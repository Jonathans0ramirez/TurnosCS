using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turnos
{
    public partial class ReservarTurno : UserControl
    {
        string fechaHoy = string.Empty;

        WebServices servicios = new WebServices();

        ConfManager confManager = new ConfManager();

        public delegate void RellenarHorasParaReservaDelegate();

        static ReservarTurno _instance;
        
        int contadorHora = 1;

        int contadorBotonesReserva = 0;

        //int numeroMaximoReservasDia = 0;

        int numeroMaximoReservasUsuario = 0;

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
            principalLbl.Visible = false;
            paneAcciones.Visible = false;
            flPanelHoras.Visible = false;
            backgroundWorkerHorasBtns.RunWorkerAsync();
        }


        private async void backgroundWorkerHorasBtns_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            Principal.Instance.BeginInvoke((Action)delegate ()
            {
                Principal.Instance.actualizarImgEstado(global::Turnos.Properties.Resources.Double_Ring_1s_64px);
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
                                            //btn.BackColor = System.Drawing.Color.FromArgb(0, 149, 121);
                                            btn.BackColor = Color.FromArgb(0, 114, 151);
                                            btn.FlatStyle = FlatStyle.Flat;
                                            btn.ForeColor = SystemColors.Control;
                                            btn.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
                                            if (item == 1)
                                            {
                                                btn.Enabled = false;
                                                btn.BackColor = Color.FromArgb(245, 51, 63);
                                                btn.ForeColor = SystemColors.Control;
                                            }
                                            btn.Size = new Size(97, 30);
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
                principalLbl.Text = confManager.ReadSetting("Usuario") + " reserva eliginedo las horas de acuerdo a tu disponibilidad.";
                principalLbl.Visible = true;
                paneAcciones.Visible = true;
                flPanelHoras.Visible = true;
                contadorHora = 1;
            });
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
            Principal.Instance.actualizarImgEstado(global::Turnos.Properties.Resources.Double_Ring_1s_64px);
            if (contadorBotonesReserva == 0)
            {                
                Principal.Instance.BeginInvoke((Action)delegate ()
                {
                    Principal.Instance.actualizarImgEstado(global::Turnos.Properties.Resources.icons8_reservation_100__1_);
                    Principal.Instance.timerReserva.Stop();
                });
                CustomDialog.ShowMessage("Por favor deja de ser tan bobo, gracias " + Emoji.Smiley, "No seleccionaste nada");
                flPanelHoras.Controls.Clear();
                principalLbl.Visible = false;
                paneAcciones.Visible = false;
                flPanelHoras.Visible = false;
                backgroundWorkerHorasBtns.RunWorkerAsync();
            }
            else
            {
            contadorBotonesReserva = 0;
            backgroundWorkerReservar.RunWorkerAsync();
            }
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            volverAVistaValidarTurno();
        }

        private void reservarBtns_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button.BackColor == Color.DarkGreen)
            {
                button.BackColor = Color.FromArgb(0, 114, 151);
                contadorBotonesReserva--;
            }
            else if (button.BackColor == Color.FromArgb(0, 114, 151) && contadorBotonesReserva < numeroMaximoReservasUsuario)
            {
                button.BackColor = Color.DarkGreen;
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
                if (button.BackColor.Equals(Color.DarkGreen))
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
                CustomDialog.ShowMessage("La reserva no fue creada, ya que usted excedió el número máximo de reservas por día", "Reserva no creada " + Emoji.Worried);
            }
            else if (resultadoCrearReserva.Contains("\"La Reserva fue creada exitosamente.\""))
            {
                volverAVistaValidarTurno();
                CustomDialog.ShowMessage("Bienvenid@", "Reserva creada exitosamente " + Emoji.Smile);
            }
            else if (resultadoCrearReserva.Contains("\"Reserva no creada"))
            {
                DialogResult result = CustomDialog.ShowMessage("Otro usuario acaba de reservar el mismo equipo, lo invitamos a reservar en otro horario. ¿Desea actualizar la lista con los horarios disponibles para este equipo?", "Reserva no creada " + Emoji.Confused, MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    this.BeginInvoke((Action)delegate ()
                    {
                        flPanelHoras.Controls.Clear();
                        principalLbl.Visible = false;
                        paneAcciones.Visible = false;
                        flPanelHoras.Visible = false;
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
                    ValidarTurno.Instance.Dock = DockStyle.Fill;
                    Principal.Instance.pnlContainer.Controls.Add(ValidarTurno.Instance);
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
                //Principal.Instance.timerReserva.Stop();
            });
        }
    }
}
