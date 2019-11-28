using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Security.Principal;
using System.Threading;
using System.Windows.Forms;

namespace Turnos
{
    public partial class Principal : Form
    {
        static Principal _obj;

        public static Principal Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Principal();
                }
                return _obj;
            }
        }

        public Panel pnlContainer
        {
            get { return panelContainer; }
            set { panelContainer = value; }
        }

        public PictureBox pictureStatus
        {
            get { return ReservationLoadCheckingImg; }
            set { ReservationLoadCheckingImg = value; }
        }

        public System.Windows.Forms.Timer timerReserva
        {
            get { return timerAnimation; }
            set { timerAnimation = value; }
        }

        public int horaIncialTurno = 0;
        // Constante que determina la hora inicial de reserva

        public int mininutosHoraIncialTurno = 0;
        // Constante que determina los minutos de la hora inicial de reserva

        public int horaFinalTurno = 0;
        // Constante que determina la hora final de reserva

        public int minutosParaFinDeTurno = 0;
        // Constante que determina los minutos que faltan para alcanzar la hora de fin de turno

        // Este booleano sirve para indicar si el usuario a accedido al turno
        public bool esEquipoHabilitado = false;

        // Este booleano sirve para indicar si el equipo está en jornada 130 Horas.
        public bool estaEn130Horas = false;

        // Constante que determina el momento en que la sesión de usuario será bloqueada
        private const int BLOQUEAR = 0;

        // Constante que determina el momento en que la sesión de usuario será desbloqueada
        private const int DESBLOQUEAR = 10;

        // Constante que determina el momento en que aparecerá el mensaje de cierre de sesión.
        private const int MENSAJE = 55;

        // Constante en la cual se recargará el archivo plano de turnos Siguientes.
        private const int EXTRAER = 59;

        private RegistryKey policiesCU;

        WebServices servicios = new WebServices();

        HotKeys hk = new HotKeys();

        ConfManager confManager = new ConfManager();

        public delegate void MakeVisibleDelegate(bool flag);

        public Principal()
        {
            InitializeComponent();
            //Show();

            //lockTaskManager(true);
            //makeVisible(true);
        }

        public void lockTaskManager(bool flag)
        {
            if (!IsAdministrator())
            {
                return;
            }

            policiesCU = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", true);
            if (policiesCU == null)
            {
                Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
            }

            policiesCU = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", true);

            if (flag)
            {
                policiesCU.SetValue("DisableLockWorkstation", 1);
                policiesCU.SetValue("DisableChangePassword", 1);
                policiesCU.SetValue("DisableTaskMgr", 1);
            }
            else
            {
                policiesCU.DeleteValue("DisableLockWorkstation");
                policiesCU.DeleteValue("DisableChangePassword");
                policiesCU.DeleteValue("DisableTaskMgr");
            }
            policiesCU.Close();
        }

        public static bool IsAdministrator()
        {
            var identity = WindowsIdentity.GetCurrent();
            var principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

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
                    hk.HookStart();
                }
                else
                {
                    hk.HookStop();
                }
            }

            catch (Exception)
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
                            if (esEquipoHabilitado)
                            {
                                if (servicios.validarTurnoUsuario(confManager.ReadSetting("Usuario")))
                                {
                                    servicios.registrarUsoReserva(confManager.ReadSetting("Usuario"));
                                    CustomDialog.ShowMessage("Continúa trabajando sin problemas por una hora más.", "Te queda una hora", MessageBoxButtons.OK, global::Turnos.Properties.Resources.HoraLeftImg);
                                }
                                else
                                {
                                    confManager.RemoveSetting("Usuario");

                                    /*Cierra todas las aplicaciones y procesos abiertos.*/
                                    Process[] processes = Process.GetProcesses();
                                    foreach (Process p in processes)
                                    {
                                        if (!String.IsNullOrEmpty(p.MainWindowTitle) && !p.MainWindowTitle.Contains("Turnos"))
                                        {
                                            p.Kill();
                                        }
                                    }


                                    esEquipoHabilitado = false;
                                    makeVisible(true);
                                }
                                inactive = 60000;
                            }
                            break;
                        }

                    case DESBLOQUEAR:
                        {
                            Console.WriteLine("Momento en que la aplicación desbloquea la sesión para cualquier usuario");
                            servicios.liberarReserva();
                            inactive = 60000 * (MENSAJE - DESBLOQUEAR);
                            break;
                        }

                    case MENSAJE:
                        {
                            Console.WriteLine("Momento en que la aplicación avisa al usuario el cierre de la sesión");
                            inactive = 60000 * (EXTRAER - MENSAJE);
                            if (esEquipoHabilitado) {
                                CustomDialog.ShowMessage("Tu turno terminará en 5 minutos; " + "Asegúrate de guardar todos los datos importantes. Al finalizar cerraremos todo por ti. ¡GRACIAS!", "Te quedan 5 minutos", MessageBoxButtons.OK, global::Turnos.Properties.Resources._5MinLeftImg);
                            }
                            break;
                        }
                }

                Console.WriteLine(DateTime.Now.Minute);
                Thread.Sleep(inactive);
            } while (true);
        }

        // Controla el evento de cerrado de ventada evitando que este ocurra cuando se presiona
        // la combinación de teclas ALT + F4
        private void Turnos_Closing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            if (!estaEn130Horas)
            {
                e.Cancel = true;
                //lockTaskManager(false);
                //makeVisible(false);
                //hk.HookStop();
            }
            else
            {
                Application.Exit();
            }
        }

        // Ejecuta el evento cuando la ventana está cargada
        private void frmMain_Load(System.Object sender, System.EventArgs e)
        {
            //hk.HookStart();
            _obj = this;

            int y;
            y = (headerPanel.Height / 2) - (ReservationLoadCheckingImg.Height / 2);
            ReservationLoadCheckingImg.Location = new Point(ReservationLoadCheckingImg.Location.X, y);

            panelContainer.Controls.Add(ValidarTurno.Instance);
            ValidarTurno.Instance.Dock = DockStyle.Fill;
            ValidarTurno.Instance.centrarPaneles();

            /*AQUÍ DEBE IR LA LLAMADA AL SERVICIO QUE VERIFICARÁ SI EL EQUIPO ESTÁ EN 130 HORAS*/
            bw130Horas.RunWorkerAsync();
        }


        /*ANIMACIONES Y CONTROLES*/

        private void TimerAnimation_Tick(object sender, EventArgs e)
        {
            actualizarImgEstado(global::Turnos.Properties.Resources.Login_Icon);
            if (!panelContainer.Controls.Contains(ValidarTurno.Instance))
            {
                panelContainer.Controls.Add(ValidarTurno.Instance);
                ValidarTurno.Instance.Dock = DockStyle.Fill;
                ValidarTurno.Instance.centrarPaneles();
            }
            ValidarTurno.Instance.BringToFront();
            if (panelContainer.Controls.Contains(ReservarTurno.Instance))
            {
                panelContainer.Controls.Remove(ReservarTurno.Instance);
                ReservarTurno.Instance.Dispose();
                ReservarTurno.Instance = null;
            }
            timerAnimation.Stop();
        }

        public void actualizarImgEstado(Image picturePath)
        {
            this.Refresh();
            Thread.Sleep(10);
            logoStatusTransition.HideSync(ReservationLoadCheckingImg);
            ReservationLoadCheckingImg.Image = picturePath;
            logoStatusTransition.ShowSync(ReservationLoadCheckingImg);

        }

        private void bw130Horas_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (servicios.validar130Horas(System.Net.Dns.GetHostName()))
            {
                estaEn130Horas = true;
                BeginInvoke((Action)delegate ()
                {
                    Close();
                });
            }
            else
            {
                var t = new Thread(new ThreadStart(service));
                t.Start();
            }
        }
    }
}
