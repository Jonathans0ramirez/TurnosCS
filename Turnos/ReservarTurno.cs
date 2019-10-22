using Newtonsoft.Json.Linq;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Turnos
{
    public partial class ReservarTurno : UserControl
    {
        int spaceControl = 1;

        string fechaHoy = DateTime.Now.ToString("yyyy-MM-dd ");

        WebServices servicios = new WebServices();

        public ReservarTurno()
        {
            InitializeComponent();
            rellenarHorasParaReserva();
        }

        public void rellenarHorasParaReserva()
        {
            string horaInicioReserva = servicios.obtenerHoraReserva("PISO2-PC16", 0);
            string horaFinReserva = servicios.obtenerHoraReserva("PISO2-PC16", 1);

            string CurDate = DateTime.Now.Hour.ToString();

            if (Int32.Parse(horaInicioReserva) < Int32.Parse(CurDate))
            {
                horaInicioReserva = CurDate;
            }

            int contador = 1;

            string fechaInicioPC;
            string fechaFinPC;
            string Reservas = servicios.consultarReservasEquipo("PISO2-PC16");
            JArray jsonArray = JArray.Parse(Reservas);
            var jsonObjects = jsonArray.OfType<JObject>().ToList();
            int objetos = jsonObjects.Count();

            while (Int32.Parse(horaFinReserva) >= Int32.Parse(horaInicioReserva))
            {
                if (objetos != 0)
                {
                    foreach (JToken signInName in jsonObjects)
                    {
                        fechaInicioPC = (string)signInName.SelectToken("fechaInicio");
                        fechaInicioPC = fechaInicioPC.Substring(11, 2);
                        fechaFinPC = (string)signInName.SelectToken("fechaFin");
                        fechaFinPC = fechaFinPC.Substring(11, 2);

                        if (Int32.Parse(fechaInicioPC) > Int32.Parse(CurDate))
                        {
                            while (Int32.Parse(fechaInicioPC) > Int32.Parse(CurDate))
                            {
                                Button btn = new Button();
                                flPanelHoras.Controls.Add(btn);
                                btn.BackColor = System.Drawing.Color.FromArgb(0, 105, 92);
                                btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                                btn.ForeColor = System.Drawing.SystemColors.Control;
                                btn.Size = new System.Drawing.Size(97, 30);
                                string auxHour = string.Empty;
                                if ((DateTime.Now.Hour + contador) == 24)
                                {
                                    auxHour = "00";
                                }
                                else
                                {
                                    auxHour = (DateTime.Now.Hour + contador).ToString();
                                }
                                btn.Text = CurDate + ":00 - " + auxHour + ":00";
                                btn.UseVisualStyleBackColor = false;
                                btn.Click += new System.EventHandler(this.reservarBtns_Click);

                                CurDate = (DateTime.Now.Hour + contador).ToString();
                                contador++;
                            }
                        }
                        if (fechaInicioPC.Equals(CurDate))
                        {
                            Button btn = new Button();
                            flPanelHoras.Controls.Add(btn);
                            btn.BackColor = System.Drawing.Color.FromArgb(0, 105, 92);
                            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                            btn.ForeColor = System.Drawing.SystemColors.Control;
                            btn.Size = new System.Drawing.Size(97, 30);
                            string auxHour = string.Empty;
                            if ((DateTime.Now.Hour + contador) == 24)
                            {
                                auxHour = "00";
                            }
                            else
                            {
                                auxHour = (DateTime.Now.Hour + contador).ToString();
                            }
                            btn.Text = CurDate + ":00 - " + auxHour + ":00";
                            btn.UseVisualStyleBackColor = false;
                            btn.Enabled = false;
                            btn.Click += new System.EventHandler(this.reservarBtns_Click);
                            CurDate = (DateTime.Now.Hour + contador).ToString();
                            contador++;
                        }
                        objetos--;
                    }
                }
                else if (Int32.Parse(CurDate) < 24)
                {
                    Button btn = new Button();
                    flPanelHoras.Controls.Add(btn);
                    btn.BackColor = System.Drawing.Color.FromArgb(0, 105, 92);
                    btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    btn.ForeColor = System.Drawing.SystemColors.Control;
                    btn.Size = new System.Drawing.Size(97, 30);
                    string auxHour = string.Empty;
                    if ((DateTime.Now.Hour + contador) == 24)
                    {
                        auxHour = "00";
                    }
                    else
                    {
                        auxHour = (DateTime.Now.Hour + contador).ToString();
                    }
                    btn.Text = CurDate + ":00 - " + auxHour + ":00";
                    btn.UseVisualStyleBackColor = false;
                    btn.Click += new System.EventHandler(this.reservarBtns_Click);

                    CurDate = (DateTime.Now.Hour + contador).ToString();
                    contador++;
                }
                int aux = Int32.Parse(horaFinReserva);
                aux--;
                horaFinReserva = aux.ToString();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
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
            //servicios.registrarReserva(TextBoxUser.Text, jsonHorario);
        }

        private void reservarBtns_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button.BackColor == Color.DarkGreen)
            {
                button.BackColor = Color.FromArgb(0, 105, 92);
            }
            else
            {
                button.BackColor = Color.DarkGreen;
            }
            string name = button.Text;
        }
    }
}
