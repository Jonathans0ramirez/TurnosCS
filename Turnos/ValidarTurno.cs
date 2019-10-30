using System;
using System.Drawing;
using System.Windows.Forms;

namespace Turnos
{
    public partial class ValidarTurno : UserControl
    {
        WebServices servicios = new WebServices();

        ConfManager confManager = new ConfManager();

        //Configuración básica para los mensajes emergentes
        private readonly MessageBoxButtons buttons = MessageBoxButtons.YesNo;
        private readonly MessageBoxIcon infoIcon = MessageBoxIcon.Information;

        static ValidarTurno _instance;

        public static ValidarTurno Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ValidarTurno();
                }
                return _instance;
            }
            set
            {
                _instance = value;
            }
        }

        public ValidarTurno()
        {
            InitializeComponent();
            Show();
            int x, y;
            x = (panelValidar.Width / 2) - (panelValidar_2.Width / 2);
            y = (panelValidar.Height / 2) - (panelValidar_2.Height / 2);
            panelValidar_2.Location = new Point(x, y);
        }


        private void ValidarBtn_Click(object sender, EventArgs e)
        {
            if (textBoxPass.Text == "turnosUGT") { }
            //makeVisible(false);
            //else if (servicios.validarTurnoUsuario(textBoxUser.Text))
            else if (false) //Para Pruebas
            {
                if (servicios.validarUsuario(textBoxUser.Text, textBoxPass.Text))
                {
                    confManager.AddUpdateAppSettings("Usuario", textBoxUser.Text);
                    confManager.ReadSetting("Usuario");     //VERIFICAR SI LA RESPUESTA ES NULA [NULL]
                    //servicios.registrarUsoReserva(textBoxUser.Text);
                    Principal.Instance.esEquipoHabilitado = true;
                    Principal.Instance.makeVisible(false);
                }
                else
                {
                    string message = "Bienvenid@ " + textBoxUser.Text + ", por favor digite correctamente su nombre de usuario y contraseña";
                    string title = "¡Error al autenticar!";
                    MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (servicios.validarUsuario(textBoxUser.Text, textBoxPass.Text))
                {
                    string message = "Señor usuario, usted no tiene reservado este equipo, recuerde que para usar el equipo de computo debe realizar la reserva previa a través de http://tiresias.udea.edu.co/turnos";
                    string title = "¿Reservar?";
                    DialogResult result = MessageBox.Show(message, title, buttons, infoIcon);
                    if (result == DialogResult.Yes)
                    {
                        confManager.AddUpdateAppSettings("Usuario", textBoxUser.Text);
                        // Se manda al UserControl ReservarTurno.cs para que el usuario realice su reserva
                        if (!Principal.Instance.pnlContainer.Controls.Contains(ReservarTurno.Instance))
                        {
                            ReservarTurno.Instance.Dock = DockStyle.Fill;
                            Principal.Instance.pnlContainer.Controls.Add(ReservarTurno.Instance);
                        }
                        ReservarTurno.Instance.BringToFront();
                        if (Principal.Instance.pnlContainer.Controls.Contains(ValidarTurno.Instance))
                        {
                            Principal.Instance.pnlContainer.Controls.Remove(ValidarTurno.Instance);
                            ValidarTurno.Instance = null;
                        }


                        //var horaInicioReserva = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        //var horaFinReserva = DateTime.Now.AddHours(1).ToString("yyyy-MM-dd HH:00:00");
                        //string horasReserva = "[{\"horaInicioReserva\":\"" + horaInicioReserva + "\",\"horaFinReserva\":\"" + horaFinReserva + "\"}]";

                        //servicios.registrarReserva(textBoxUser.Text, horasReserva);
                    }
                    else
                    {
                        // Limpia los campos usuario y contraseña del UserControl
                        textBoxUser.Text = string.Empty;
                        textBoxPass.Text = string.Empty;
                    }
                }
                else
                {
                    string message = "Bienvenid@ " + textBoxUser.Text + ", por favor digite correctamente su nombre de usuario y contraseña";
                    string title = "¡Error al autenticar!";
                    MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //TextBoxInfo.Text = "Bienvenid@ " + TextBoxUser.Text + ", por favor digite correctamente su nombre de usuario y contraseña";
                    //TextBoxInfo.SelectionAlignment = HorizontalAlignment.Center;
                }
                //TextBoxInfo.Text = "Señor usuario, usted no tiene reservado este equipo, recuerde que para usar el equipo de computo debe realizar la reserva previa a través de http://tiresias.udea.edu.co/turnos";
                //TextBoxInfo.SelectionAlignment = HorizontalAlignment.Center;
            }
        }
    }
}
