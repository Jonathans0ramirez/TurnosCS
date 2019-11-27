using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turnos
{
    public partial class ReservarTurno : UserControl
    {
        private string fechaHoy = string.Empty;

        WebServices servicios = new WebServices();

        ConfManager confManager = new ConfManager();

        public delegate void RellenarHorasParaReservaDelegate();

        static ReservarTurno _instance;

        private int tiempoRestante = 59;
        
        private int contadorHora = 1;

        private int contadorBotonesReserva = 0;

        //private int numeroMaximoReservasDia = 0;

        private int numeroMaximoReservasUsuario = 0;

        private Color colorSeleccionadoBtn = Color.FromArgb(127, 179, 22);

        private Color colorDisponibleBtn = Color.FromArgb(31, 106, 57);

        public static ReservarTurno Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ReservarTurno();
                }
                return _instance;
            }
            set
            {
                _instance = value;
            }
        }

        public ReservarTurno()
        {
            InitializeComponent();
            centrarPanelesContainers();

            flPanelHoras.Controls.Clear();
            containerlPrincipal.Visible = false;
            paneAcciones.Visible = false;
            containerHoras.Visible = false;
            panelLoad.Visible = true;

            backgroundWorkerHorasBtns.RunWorkerAsync();
        }

        private async void backgroundWorkerHorasBtns_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            Principal.Instance.BeginInvoke((Action)delegate ()
            {
                Principal.Instance.actualizarImgEstado(global::Turnos.Properties.Resources.Spinner_1s_64px);
            });
            await pintarBotones();
            //Hacer llamado al reloj que finalizará instancia si es necesario
            Principal.Instance.BeginInvoke((Action)delegate ()
            {
                Principal.Instance.timerReserva.Start();
            });
        }

        private async Task pintarBotones()
        {
            string CurDate = DateTime.Now.Hour.ToString();
            await Task.Run(() =>
            {
                List<int> hab = rellenarListaHoras();
                foreach (var item in hab)
                {
                    if (!flPanelHoras.IsDisposed)
                    {
                        flPanelHoras.BeginInvoke((Action)delegate ()
                        {
                            if (!flPanelHoras.IsDisposed)
                            {
                                Button btn = new Button();
                                flPanelHoras.Controls.Add(btn);
                                if (!btn.IsDisposed)
                                {
                                    btn.BeginInvoke((Action)delegate ()
                                    {
                                        if (!btn.IsDisposed)
                                        {
                                            btn.BackColor = colorDisponibleBtn;   //Color de Horario disponible
                                            btn.FlatStyle = FlatStyle.Flat;
                                            btn.ForeColor = SystemColors.ControlLight;
                                            btn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
                                            if (item == 1)
                                            {
                                                btn.Enabled = false;
                                                btn.BackColor = Color.FromArgb(236, 43, 68);    //Color de Horario ocuopado
                                            }
                                            btn.Size = new Size(115, 35);
                                            string auxHour = string.Empty;
                                            if ((DateTime.Now.Hour + contadorHora) == 24)
                                            {
                                                auxHour = "00";
                                            }
                                            else
                                            {
                                                auxHour = (DateTime.Now.Hour + contadorHora).ToString();
                                            }
                                            if (CurDate.Length == 1)
                                            {
                                                CurDate = String.Concat("0", CurDate);
                                            }
                                            if (auxHour.Length == 1)
                                            {
                                                auxHour = String.Concat("0", auxHour);
                                            }
                                            btn.Text = CurDate + ":00 - " + auxHour + ":00";
                                            btn.UseVisualStyleBackColor = false;
                                            btn.Click += new EventHandler(this.reservarBtns_Click);
                                            CurDate = (DateTime.Now.Hour + contadorHora).ToString();
                                            
                                            contadorHora++;
                                        }
                                    });
                                }
                            }
                        });
                    }
                }
            });
            Principal.Instance.BeginInvoke((Action)delegate ()
            {
                Principal.Instance.actualizarImgEstado(global::Turnos.Properties.Resources.icons8_reservation_100__1_);
            });
            this.BeginInvoke((Action)delegate ()
            {
                principalLbl.Text = confManager.ReadSetting("Usuario");

                flPanelHoras.Enabled = true;
                panelLoad.Visible = false;
                containerlPrincipal.Visible = true;
                tiempoRestanteReserva.Start();
                paneAcciones.Enabled = true;
                paneAcciones.Visible = true;
                containerHoras.Visible = true;
                contadorHora = 1;
            });
        }

        public void centrarPanelesContainers()
        {
            /*CENTRAR HORAS CONTAINER*/
            int x, y;
            x = (this.Width / 2) - (containerHoras.Width / 2);
            containerHoras.Location = new Point(x, containerHoras.Location.Y);

            /*CENTRAR PANEL HORAS*/
            x = (containerHoras.Width / 2) - (flPanelHoras.Width / 2);
            y = (containerHoras.Height / 2) - (flPanelHoras.Height / 2);
            flPanelHoras.Location = new Point(x, y);

            /*CENTRAR PRINCIPAL CONTAINER - LABELS - PICTUREBOX*/
            x = (this.Width / 2) - (containerlPrincipal.Width / 2);
            containerlPrincipal.Location = new Point(x, containerlPrincipal.Location.Y);

            x = (containerlPrincipal.Width / 2) - (principalLbl.Width / 2);
            principalLbl.Location = new Point(x, principalLbl.Location.Y);
            
            x = (containerlPrincipal.Width / 2) - (descripcionLbl.Width / 2);
            descripcionLbl.Location = new Point(x, descripcionLbl.Location.Y);

            x = (containerlPrincipal.Width / 2) - (tiempoRestanteLbl.Width / 2);
            tiempoRestanteLbl.Location = new Point(x, tiempoRestanteLbl.Location.Y);

            x = (containerlPrincipal.Width / 2) - (pictureBoxLogo.Width / 2);
            pictureBoxLogo.Location = new Point(x, pictureBoxLogo.Location.Y);

            /*CENTRAR LOAD*/
            x = (this.Width / 2) - (panelLoad.Width / 2);
            y = (this.Height / 2) - (panelLoad.Height / 2);
            panelLoad.Location = new Point(x, y);
        }

        private List<int> rellenarListaHoras()
        {
            //numeroMaximoReservasDia = Int32.Parse(servicios.obtenerMaxReservasEquipo("PISO3-PC20"));
            numeroMaximoReservasUsuario = Int32.Parse(servicios.obtenerMaxReservasUsuario(confManager.ReadSetting("Usuario"), DateTime.Now.ToString("yyyy-MM-dd")));
            List<int> retorno = new List<int>();
            string horaInicioReserva = servicios.obtenerHoraReserva("PISO3-PC20", 0);
            string horaFinReserva = servicios.obtenerHoraReserva("PISO3-PC20", 1);

            string CurDate = DateTime.Now.Hour.ToString();

            if (Int32.Parse(horaInicioReserva) < Int32.Parse(CurDate))
            {
                horaInicioReserva = CurDate;
            }

            string fechaInicioPC;
            string Reservas = servicios.consultarReservasEquipo("PISO3-PC20");
            JArray jsonArray = JArray.Parse(Reservas);
            var jsonObjects = jsonArray.OfType<JObject>().ToList();
            int objetos = jsonObjects.Count();

            while (Int32.Parse(horaFinReserva) > Int32.Parse(horaInicioReserva))
            {
                if (objetos != 0)
                {
                    foreach (JToken signInName in jsonObjects)
                    {
                        fechaInicioPC = (string)signInName.SelectToken("horaInicio");
                        fechaInicioPC = fechaInicioPC.Substring(11, 2);
                        while (!fechaInicioPC.Equals(horaInicioReserva) && Int32.Parse(horaInicioReserva) < Int32.Parse(horaFinReserva))
                        {
                            retorno.Add(0);
                            horaInicioReserva = (Int32.Parse(horaInicioReserva) + 1).ToString();
                        }
                        if (fechaInicioPC.Equals(horaInicioReserva))
                        {
                            retorno.Add(1);
                            horaInicioReserva = (Int32.Parse(horaInicioReserva) + 1).ToString();
                        }
                        objetos--;
                    }
                }
                else
                {
                    retorno.Add(0);
                    horaInicioReserva = (Int32.Parse(horaInicioReserva) + 1).ToString();
                }
            }
            return retorno;
        }

        private void ReservarBtn_Click(object sender, EventArgs e)
        {
            Principal.Instance.actualizarImgEstado(global::Turnos.Properties.Resources.Spinner_1s_64px);
            if (contadorBotonesReserva == 0)
            {                
                Principal.Instance.BeginInvoke((Action)delegate ()
                {
                    Principal.Instance.actualizarImgEstado(global::Turnos.Properties.Resources.icons8_reservation_100__1_);
                    Principal.Instance.timerReserva.Stop();
                });
                CustomDialog.ShowMessage("Por favor deja de ser tan bobo, gracias " + Emoji.Smiley, "No seleccionaste nada", MessageBoxButtons.OK, global::Turnos.Properties.Resources.ErrorImg);

                flPanelHoras.Controls.Clear();
                containerlPrincipal.Visible = false;
                paneAcciones.Visible = false;
                containerHoras.Visible = false;
                panelLoad.Visible = true;
                backgroundWorkerHorasBtns.RunWorkerAsync();
            }
            else
            {
                contadorBotonesReserva = 0;
                flPanelHoras.Enabled = false;
                paneAcciones.Enabled = false;
                backgroundWorkerReservar.RunWorkerAsync();
            }
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            Principal.Instance.BeginInvoke((Action)delegate ()
            {
                Principal.Instance.timerReserva.Stop();
            });
            volverAVistaValidarTurno();
        }

        private void reservarBtns_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button.BackColor == colorSeleccionadoBtn)   //Color de horario seleccionado
            {
                button.BackColor = colorDisponibleBtn;    //Color de horario disponible
                contadorBotonesReserva--;
            }
            else if (button.BackColor == colorDisponibleBtn /*[Color de horario disponible]*/ && contadorBotonesReserva < numeroMaximoReservasUsuario)
            {
                button.BackColor = colorSeleccionadoBtn;    //Color de horario seleccionado
                contadorBotonesReserva++;
            }
            string name = button.Text;
        }

        private void ReservarTurno_Load(object sender, EventArgs e)
        {
            int x;
            x = (this.Width / 2) - (paneAcciones.Width / 2);
            paneAcciones.Location = new Point(x, paneAcciones.Location.Y);
            fechaHoy = DateTime.Now.ToString("yyyy-MM-dd ");
        }

        private void backgroundWorkerReservar_DoWork(object sender, DoWorkEventArgs e)
        {
            Principal.Instance.BeginInvoke((Action)delegate ()
            {
                Principal.Instance.timerReserva.Stop();
            });
            string jsonHorario = string.Empty;
            bool moreThanOne = false;
            foreach (var button in flPanelHoras.Controls.OfType<Button>())
            {
                if (button.BackColor.Equals(colorSeleccionadoBtn))
                {
                    if (moreThanOne)
                    {
                        jsonHorario = String.Concat(jsonHorario, ",");
                    }

                            jsonHorario = String.Concat(jsonHorario, "{\"horaInicioReserva\": \"" + fechaHoy + button.Text.Substring(0, 5) + ":00\", \"horaFinReserva\": \"" + fechaHoy + button.Text.Substring(8, 5) + ":00\"}");
                    moreThanOne = true;
                }
            }
            string resultadoCrearReserva = servicios.registrarReserva(confManager.ReadSetting("Usuario"), jsonHorario);
            Principal.Instance.BeginInvoke((Action)delegate ()
            {
                Principal.Instance.actualizarImgEstado(global::Turnos.Properties.Resources.icons8_reservation_100__1_);
            });

            if (resultadoCrearReserva.Contains("\"La reserva No fue creada"))
            {
                volverAVistaValidarTurno();
                CustomDialog.ShowMessage("La reserva no fue creada, excediste el número máximo de reservas por día.", "Reserva no creada", MessageBoxButtons.OK, global::Turnos.Properties.Resources.NoCreadaImg);
            }
            else if (resultadoCrearReserva.Contains("\"La Reserva fue creada exitosamente.\""))
            {
                volverAVistaValidarTurno();
                CustomDialog.ShowMessage("Recuerda hacer un uso efectivo de este equipo.", "Reserva creada", MessageBoxButtons.OK, global::Turnos.Properties.Resources.CreadaImg);
            }
            else if (resultadoCrearReserva.Contains("\"Reserva no creada"))
            {
                DialogResult result = CustomDialog.ShowMessage("Otro usuario acaba de reservar el mismo equipo, lo invitamos a reservar en otro horario. ¿Desea actualizar la lista con los horarios disponibles para este equipo?", "Reserva no creada " + Emoji.Confused, MessageBoxButtons.YesNo, global::Turnos.Properties.Resources.NoCreadaImg);
                if (result == DialogResult.Yes)
                {
                    this.BeginInvoke((Action)delegate ()
                    {
                        flPanelHoras.Controls.Clear();
                        containerlPrincipal.Visible = false;
                        paneAcciones.Visible = false;
                        containerHoras.Visible = false;
                        panelLoad.Visible = true;
                        backgroundWorkerHorasBtns.RunWorkerAsync();
                    });
                }
                else
                {
                    volverAVistaValidarTurno();
                }
            }
        }

        private void volverAVistaValidarTurno()
        {
            confManager.RemoveSetting("Usuario");
            Principal.Instance.BeginInvoke((Action)delegate ()
            {
                if (!Principal.Instance.pnlContainer.Controls.Contains(ValidarTurno.Instance))
                {
                    Principal.Instance.pnlContainer.Controls.Add(ValidarTurno.Instance);
                    ValidarTurno.Instance.Dock = DockStyle.Fill;
                    ValidarTurno.Instance.centrarPaneles();
                }
                ValidarTurno.Instance.BringToFront();
                if (Principal.Instance.pnlContainer.Controls.Contains(ReservarTurno.Instance))
                {
                    Principal.Instance.pnlContainer.Controls.Remove(ReservarTurno.Instance);
                    ReservarTurno.Instance.BeginInvoke((Action)delegate ()
                    {
                        ReservarTurno.Instance.Dispose();
                        ReservarTurno.Instance = null;
                    });
                }           
                Principal.Instance.actualizarImgEstado(global::Turnos.Properties.Resources.icons8_instagram_check_mark_100);
            });
        }

        private void tiempoRestanteReserva_Tick(object sender, EventArgs e)
        {
            fadeTiempoRestanteTransition.HideSync(tiempoRestanteLbl);
            if (tiempoRestante > 0)
            {
                tiempoRestanteLbl.Text = "Tienes " + tiempoRestante + " segundos para realizar tu reserva";
                int x = (containerlPrincipal.Width / 2) - (tiempoRestanteLbl.Width / 2);
                tiempoRestanteLbl.Location = new Point(x, tiempoRestanteLbl.Location.Y);
                tiempoRestante--;
            }
            else
            {
                tiempoRestante = 59;
                tiempoRestanteLbl.Text = "Tu tiempo para reservar se ha agotado";
                int x = (containerlPrincipal.Width / 2) - (tiempoRestanteLbl.Width / 2);
                tiempoRestanteLbl.Location = new Point(x, tiempoRestanteLbl.Location.Y);
                tiempoRestanteReserva.Stop();
            }
            fadeTiempoRestanteTransition.ShowSync(tiempoRestanteLbl);
        }
    }
}
