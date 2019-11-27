using System;
using System.Windows.Forms;

namespace Turnos
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*string ho = DateTime.Now.ToString();
             ho = DateTime.Now.Day.ToString();
             ho = DateTime.Now.Month.ToString();
             ho = DateTime.Now.Year.ToString();

             ho = DateTime.Now.Hour.ToString();
             ho = DateTime.Now.Minute.ToString();
             ho = DateTime.Now.ToString("yyyy-MM-dd ");*/

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Principal());
        }
    }
}
