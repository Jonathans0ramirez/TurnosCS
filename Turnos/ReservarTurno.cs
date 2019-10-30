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
        int spaceControl = 1;

        string fechaHoy = DateTime.Now.ToString("yyyy-MM-dd ");

        WebServices servicios = new WebServices();

        ConfManager confManager = new ConfManager();

        public delegate void RellenarHorasParaReservaDelegate();

        static ReservarTurno _instance;
        
        int contadorHora = 1;

        int contadorBotonesReserva = 0;

        int numeroMaximoReservasDia = 0;

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
            backgroundWorker1.RunWorkerAsync();
        }


        private async void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            Principal.Instance.BeginInvoke((Action)delegate ()
            {
                //Principal.Instance.pictureStatus.Visible = true;
                Principal.Instance.actualizarImgEstado(global::Turnos.Properties.Resources.Double_Ring_1s_64px__1_);
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
                                            btn.BackColor = System.Drawing.Color.FromArgb(0, 105, 92);
                                            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                                            btn.ForeColor = System.Drawing.SystemColors.Control;
                                            if (item == 1)
                                            {
                                                btn.Enabled = false;
                                            }
                                            btn.Size = new System.Drawing.Size(97, 30);
                                            string auxHour = string.Empty;
                                            if ((DateTime.Now.Hour + contadorHora) == 24)
                                            {
                                                auxHour = "00";
                                            }
                                            else
                                            {
                                                auxHour = (DateTime.Now.Hour + contadorHora).ToString();
                                            }
                                            btn.Text = CurDate + ":00 - " + auxHour + ":00";
                                            btn.UseVisualStyleBackColor = false;
                                            btn.Click += new System.EventHandler(this.reservarBtns_Click);
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
                //Principal.Instance.pictureStatus.Visible = false;
                Principal.Instance.actualizarImgEstado(global::Turnos.Properties.Resources.icons8_reservation_100__1_);
            });
            this.BeginInvoke((Action)delegate ()
            {
                principalLbl.Text = confManager.ReadSetting("Usuario");
                principalLbl.Visible = true;
                paneAcciones.Visible = true;
            });
        }

        private List<int> rellenarListaHoras()
        {
            numeroMaximoReservasDia = Int32.Parse(servicios.obtenerMaxReservasEquipo("PISO3-PC20"));
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
            string jsonHorario = string.Empty;
            bool moreThanOne = false;
            foreach (var button in flPanelHoras.Controls.OfType<Button>())
            {
                if (button.BackColor.Equals(Color.DarkGreen))
                {
                    TextBox t1 = new TextBox();
                    this.Controls.Add(t1);
                    t1.Top = spaceControl * 25;
                    t1.Left = 100;
                    t1.Text = button.Text;
                    spaceControl++;

                    if (moreThanOne)
                    {
                        jsonHorario = String.Concat(jsonHorario, ",");
                    }

                    jsonHorario = String.Concat(jsonHorario, "{\"horaInicioReserva\": \"" + fechaHoy + button.Text.Substring(0, 5) + ":00\", \"horaFinReserva\": " + fechaHoy + button.Text.Substring(8, 5) + ":00\"}");
                    moreThanOne = true;
                }
            }
            //servicios.registrarReserva(confManager.ReadSetting("Usuario"), jsonHorario);
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            confManager.RemoveSetting("Usuario");
            if (!Principal.Instance.pnlContainer.Controls.Contains(ValidarTurno.Instance))
            {
                ValidarTurno.Instance.Dock = DockStyle.Fill;
                Principal.Instance.pnlContainer.Controls.Add(ValidarTurno.Instance);
            }
            ValidarTurno.Instance.BringToFront();
            if (Principal.Instance.pnlContainer.Controls.Contains(ReservarTurno.Instance))
            {
                Principal.Instance.pnlContainer.Controls.Remove(ReservarTurno.Instance);
                ReservarTurno.Instance = null;
            }
            Principal.Instance.BeginInvoke((Action)delegate ()
            {
                Principal.Instance.actualizarImgEstado(global::Turnos.Properties.Resources.icons8_instagram_check_mark_100);
                Principal.Instance.timerReserva.Stop();
            });
        }

        private void reservarBtns_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button.BackColor == Color.DarkGreen)
            {
                button.BackColor = Color.FromArgb(0, 105, 92);
                contadorBotonesReserva--;
            }
            else if (button.BackColor == Color.FromArgb(0, 105, 92) && contadorBotonesReserva < numeroMaximoReservasDia)
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
        }
    }
}
