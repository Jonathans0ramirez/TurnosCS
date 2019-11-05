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
            //Principal.Instance.makeVisible(false);
            else if (false) //Para Pruebas
            //else if (servicios.validarTurnoUsuario(textBoxUser.Text))
            {
                if (servicios.validarUsuario(textBoxUser.Text, textBoxPass.Text))
                {
                    confManager.AddUpdateAppSettings("Usuario", textBoxUser.Text);
                    //confManager.ReadSetting("Usuario");     //VERIFICAR SI LA RESPUESTA ES NULA [NULL]
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
                    //string message = "Señor usuario, usted no tiene reservado este equipo, recuerde que para usar el equipo de computo debe realizar la reserva previa a través de http://tiresias.udea.edu.co/turnos";
                    string message = "Señor usuario, usted no tiene reservado este equipo. ¿Desea realizar la reserva de este equipo?";
                    string title = "¿Reservar?";
                    //DialogResult result = MessageBox.Show(message, title, buttons, infoIcon);
                    DialogResult result = CustomDialog.ShowMessage(message, title, MessageBoxButtons.YesNo);
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
                            ValidarTurno.Instance.Dispose();
                            ValidarTurno.Instance = null;
                        }
                    }
                    else
                    {
                        // Limpia los campos usuario y contraseña del UserControl
                        textBoxUser.Text = string.Empty;
                        textBoxPass.Text = string.Empty;
                        textBoxUser.Focus();
                    }
                }
                else
                {
                    string message = "Bienvenid@ " + textBoxUser.Text.ToUpper() + ", por favor digite correctamente su nombre de usuario y contraseña";
                    string title = "¡Error al autenticar!";
                    //MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CustomDialog.ShowMessage(message, title);
                    textBoxPass.Text = string.Empty;
                    textBoxPass.Focus();
                }
            }
        }
    }
}
