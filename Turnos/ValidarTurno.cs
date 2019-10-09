using System;
using System.Drawing;
using System.Windows.Forms;

namespace Turnos
{
    public partial class ValidarTurno : UserControl
    {
        WebServices servicios = new WebServices();

        //Configuración básica para los mensajes emergentes
        private readonly MessageBoxButtons buttons = MessageBoxButtons.YesNo;
        private readonly MessageBoxIcon infoIcon = MessageBoxIcon.Information;

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
            else if (true) //Para Pruebas
            {
                if (servicios.validarUsuario(textBoxUser.Text, textBoxPass.Text))
                {
                    //servicios.registrarUsoReserva(textBoxUser.Text);
                    Principal.Instance.esEquipoHabilitado = true;
                    Principal.Instance.makeVisible(false);
                }
                else
                {
                    //TextBoxInfo.Text = "Bienvenid@ " + TextBoxUser.Text + ", por favor digite correctamente su nombre de usuario y contraseña";
                    //TextBoxInfo.SelectionAlignment = HorizontalAlignment.Center;
                }
            }
            else
            {
                string message = "Señor usuario, usted no tiene reservado este equipo, recuerde que para usar el equipo de computo debe realizar la reserva previa a través de http://tiresias.udea.edu.co/turnos";
                string title = "¿Reservar?";
                DialogResult result = MessageBox.Show(message, title, buttons, infoIcon);
                if (result == DialogResult.Yes)
                {
                    // Yes [Mandarlo a Form 2]
                    //var horaInicioReserva = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    //var horaFinReserva = DateTime.Now.AddHours(1).ToString("yyyy-MM-dd HH:00:00");
                    //string horasReserva = "[{\"horaInicioReserva\":\"" + horaInicioReserva + "\",\"horaFinReserva\":\"" + horaFinReserva + "\"}]";

                    //servicios.registrarReserva(textBoxUser.Text, horasReserva);
                }
                else
                {
                    // No [No hacer nada, cerrar dialogo]
                }
                //TextBoxInfo.Text = "Señor usuario, usted no tiene reservado este equipo, recuerde que para usar el equipo de computo debe realizar la reserva previa a través de http://tiresias.udea.edu.co/turnos";
                //TextBoxInfo.SelectionAlignment = HorizontalAlignment.Center;
            }
        }
    }
}
