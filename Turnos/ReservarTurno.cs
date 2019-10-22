using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Globalization;

namespace Turnos
{
    public partial class ReservarTurno : UserControl
    {
        string horaInicioReserva;
        string horaFinReserva;

        int spaceControl = 1;

        WebServices servicios = new WebServices();

        public ReservarTurno()
        {
            InitializeComponent();
            horaInicioReserva = servicios.obtenerHoraReserva("PC05", 0);
            horaFinReserva = servicios.obtenerHoraReserva("PC05", 0);
            string type;
            string value;
            string Reservas = servicios.consultarReservasEquipo("PC05");
            //Reservas = Reservas.Substring(1, Reservas.Length - 2);
            JArray jsonArray = JArray.Parse(Reservas);
            var jsonObjects = jsonArray.OfType<JObject>().ToList();

            foreach (JToken signInName in jsonObjects)
            {
                type = (string)signInName.SelectToken("fechaInicio");
                value = (string)signInName.SelectToken("fechaFin");
                //Console.WriteLine("{0}, {1}", type, value);
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            foreach (var button in this.Controls.OfType<Button>())
            {
                if (button.BackColor.Equals(Color.Maroon))
                {
                    label1.Text = "Sí";
                    TextBox t1 = new TextBox();
                    this.Controls.Add(t1);
                    t1.Top = spaceControl * 25;
                    t1.Left = 100;
                    spaceControl++;
                }
            }

            /*TextBox t1 = new TextBox();
            this.Controls.Add(t1);
            t1.Top = spaceControl * 25;
            t1.Left = 100;
            spaceControl++;*/

        }
    }
}
