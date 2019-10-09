using Microsoft.Win32;
using System;
using System.Security.Principal;
using System.Threading;
using System.Windows.Forms;

namespace Turnos
{
    public partial class Principal_OLD : Form
    {
        public int horaIncialTurno = 0;
        // Constante que determina la hora inicial de reserva

        public int mininutosHoraIncialTurno = 0;
        // Constante que determina los minutos de la hora inicial de reserva

        public int horaFinalTurno = 0;
        // Constante que determina la hora final de reserva

        public int minutosParaFinDeTurno = 0;
        // Constante que determina los minutos que faltan para alcanzar la hora de fin de turno

        // Este booleano sirve para indicar si el usuario a accedido al tur
        public bool esEquipoHabilitado = false;

        // Constante que determina el momento en que la sesión de usuario será bloqueada
        private const int BLOQUEAR = 0;

        // Constante que determina el momento en que la sesión de usuario será desbloqueada
        private const int DESBLOQUEAR = 10;

        // Constante que determina el momento en que aparecerá el mensaje de cierre de sesión.
        private const int MENSAJE = 55;

        // Constante en la cual se recargará el archivo plano de turnos Siguientes.
        private const int EXTRAER = 59;

        private const string msgIntro = "Bienvenid@ al sistema de Turnos para el uso de los servicios de cómputo " + "del sistema de Bibliotecas de la Universidad de Antioquia. Este sistema le " + "permitirá acceder a internet y a las bases de datos bibliográficas que el " + "Sistema de Bibliotecas tiene para usted.";

        private const string msgCLoseSession = "Señor usuario, su turno terminará en 5 min; " + "por favor cierre las cuentas en el navegador y guarde todos los datos importantes. GRACIAS!!!";

        private RegistryKey policies;

        //GenericPrincipal user = (GenericPrincipal)Thread.CurrentPrincipal;

        private delegate void MakeVisibleDelegate(bool flag);

        private delegate void CloseSessionMsgDelegate(bool flag);

        WebServices servicios = new WebServices();

        HotKeys hk = new HotKeys();

        MessageBoxButtons buttons = MessageBoxButtons.YesNo;

        MessageBoxIcon infoIcon = MessageBoxIcon.Information;


        // Constructor de Clase, se encarga de situar la ventana a lo ancho y alto de la pantalla,
        // inicializando todos los componentes necesarios.
        public Principal_OLD()
        {
            // Llamada necesaria para el diseñador.
            InitializeComponent();

            // Agregue cualquier inicialización después de la llamada a InitializeComponent().
            /*this.Width = Screen.AllScreens[0].Bounds.Width;
            this.Height = Screen.AllScreens[0].Bounds.Height;
            /*this.TopMost = true;*/
            tbIntro.SelectionAlignment = HorizontalAlignment.Center;

            //lockTaskManager(true);
            //makeVisible(true);

            var t = new Thread(new ThreadStart(service));
            t.Start();
        }

        // Permite bloquear la aparación del administrador de tareas
        public void lockTaskManager(bool flag)
        {
            if (!IsAdministrator())
            {
                return;
            }

            policies = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", true);
            if (policies == null)
            {
                Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
            }

            policies = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", true);

            if (flag)
                policies.SetValue("DisableTaskMgr", 1);
            else
                policies.DeleteValue("DisableTaskMgr");
            policies.Close();
        }

        public static bool IsAdministrator()
        {
            var identity = WindowsIdentity.GetCurrent();
            var principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        //Permite hacer visible la ventana del formulario desde un hilo diferente
        public void makeVisible(bool flag)
        {
            try
            {
                if (this.InvokeRequired)
                {
                    MakeVisibleDelegate d = new MakeVisibleDelegate(makeVisible);
                    this.Invoke(d, new object[] { flag });
                }
                else
                {
                    this.Visible = flag;
                    //lockTaskManager(flag);
                }

                if (flag)
                {
                    closeSessionMsg(true);
                    hk.HookStart();
                }
                else
                {
                    hk.HookStop();
                }

                TextBoxUser.Text = "";
                TextBoxPass.Text = "";
                LabelUsuario.Visible = true;
                LabelContraseña.Visible = true;
                TextBoxUser.Visible = true;
                TextBoxPass.Visible = true;
                BotonValidarUsuario.Visible = true;
                LabelIngreseNombreYPass.Visible = true;
            }

            catch (Exception ex)
            {
            }
        }

        //Método que será ejecutado desde un nuevo hilo y servirá como un servicio de windows
        public void service()
        {
            int inactive = 60000;

            do
            {
                switch (DateTime.Now.Minute)
                {
                    case BLOQUEAR:
                        {
                            Console.WriteLine("Momento en que la aplicación bloquea la sesión");
                            esEquipoHabilitado = false;
                            makeVisible(true);
                            //TextBoxInfo.Text = "";
                            inactive = 60000 * (DESBLOQUEAR);
                            break;
                        }

                    case DESBLOQUEAR:
                        {
                            Console.WriteLine("Momento en que la aplicación desbloquea la sesión para cualquier usuario");
                            servicios.liberarReserva();
                            inactive = 60000 * (MENSAJE - DESBLOQUEAR);
                            break;
                        }

                    case EXTRAER:
                        {
                            Console.WriteLine("Momento en que la aplicación Extrae los turnos siguientes");
                            inactive = 60000;
                            break;
                        }

                    case MENSAJE:
                        {
                            Console.WriteLine("Momento en que la aplicación avisa al usuario el cierre de la sesión");
                            inactive = 60000 * (EXTRAER - MENSAJE);
                            if (esEquipoHabilitado) { }
                            //closeSessionMsg();
                            break;
                        }
                }

                Console.WriteLine(DateTime.Now.Minute);
                Thread.Sleep(inactive);
            } while (true);
        }

        // Permite mostrar el mensaje de cierre de sesión
        private void closeSessionMsg(bool flag = false)
        {
            if (this.InvokeRequired)
            {
                CloseSessionMsgDelegate d = new CloseSessionMsgDelegate(closeSessionMsg);
                this.Invoke(d, new object[] { flag });
            }
            else
            {
                if (flag)
                {
                    tbIntro.Text = msgIntro;
                    btnCloseSession.Visible = false;

                    TextBoxUser.Text = "";
                    TextBoxPass.Text = "";
                    LabelUsuario.Visible = true;
                    LabelContraseña.Visible = true;
                    TextBoxUser.Visible = true;
                    TextBoxPass.Visible = true;
                    BotonValidarUsuario.Visible = true;
                    LabelIngreseNombreYPass.Visible = true;
                }
                else
                {
                    tbIntro.Text = msgCLoseSession;
                    tbIntro.Visible = true;
                    btnCloseSession.Visible = true;
                    TextBoxUser.Text = "";
                    TextBoxPass.Text = "";
                    LabelUsuario.Visible = false;
                    LabelContraseña.Visible = false;
                    TextBoxUser.Visible = false;
                    TextBoxPass.Visible = false;
                    BotonValidarUsuario.Visible = false;
                    LabelIngreseNombreYPass.Visible = false;
                }

                tbIntro.SelectionAlignment = HorizontalAlignment.Center;
                this.Visible = true;
            }
        }

        // Controla el evento de cerrado de ventada evitando que este ocurra cuando se presiona
        // la combinación de teclas ALT + F4
        private void Turnos_Closing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            e.Cancel = true;
            lockTaskManager(false);
            makeVisible(false);
            hk.HookStop();
        }

        // Ejecuta el evento cuando la ventana está cargada
        private void frmMain_Load(System.Object sender, System.EventArgs e)
        {
            hk.HookStart();
        }

        // Evento Click sobre el boton del mensaje de cierre de sesión 
        private void btnCloseSession_Click(System.Object sender, System.EventArgs e)
        {
            makeVisible(false);
        }

        private void BotonValidarUsuario_Click(object sender, EventArgs e)
        {
            if (TextBoxPass.Text == "turnosUGT")
                makeVisible(false);
            else if (servicios.validarTurnoUsuario(TextBoxUser.Text))
            //else if (true)
            {
                if (servicios.validarUsuario(TextBoxUser.Text, TextBoxPass.Text))
                {
                    var horaInicioReserva = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    var horaFinReserva = DateTime.Now.AddHours(1).ToString("yyyy-MM-dd HH:00:00");
                    string horasReserva = "[{\"horaInicioReserva\":\"" + horaInicioReserva + "\",\"horaFinReserva\":\"" + horaFinReserva + "\"}]";

                    servicios.registrarReserva(TextBoxUser.Text, horasReserva);
                    servicios.registrarUsoReserva(TextBoxUser.Text);
                    esEquipoHabilitado = true;
                    makeVisible(false);
                }
                else
                {
                    TextBoxInfo.Text = "Bienvenid@ " + TextBoxUser.Text + ", por favor digite correctamente su nombre de usuario y contraseña";
                    TextBoxInfo.SelectionAlignment = HorizontalAlignment.Center;
                    Timer1.Enabled = true;
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
                }
                else
                {
                    // No [No hacer nada, cerrar dialogo]
                }
                TextBoxInfo.Text = "Señor usuario, usted no tiene reservado este equipo, recuerde que para usar el equipo de computo debe realizar la reserva previa a través de http://tiresias.udea.edu.co/turnos";
                TextBoxInfo.SelectionAlignment = HorizontalAlignment.Center;
                Timer1.Enabled = true;
            }
        }

        private void Timer1_Tick(System.Object sender, System.EventArgs e)
        {
        }
    }
}
