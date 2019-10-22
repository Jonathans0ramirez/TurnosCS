using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Turnos
{
    class WebServices
    {

        public WebServices() { }

        public string SendRequest(Uri uri, byte[] jsonDataBytes, string contentType, string method)
        {
            WebRequest req = WebRequest.Create(uri);
            req.ContentType = contentType;
            method = method.ToUpper();
            req.Method = method;

            if (!method.Equals("GET"))
            {
                req.ContentLength = jsonDataBytes.Length;
                var stream = req.GetRequestStream();
                stream.Write(jsonDataBytes, 0, jsonDataBytes.Length);
                stream.Close();
            }

            var response = req.GetResponse().GetResponseStream();

            StreamReader reader = new StreamReader(response);
            var res = reader.ReadToEnd();
            reader.Close();
            response.Close();

            return res;
        }

        public string consultarSalaPorPC(string codComputador)
        {
            try
            {
                var uri = new Uri("http://biblioteca.udea.edu.co/turnos/services/ConsultarSalaPorPC.php?codComputador=" + codComputador);
                var result_get = SendRequest(uri, null, "application/json", "GET");
                result_get = result_get.Trim();
                return result_get;
            }
            catch (Exception ex)
            {
                return "No se pudo consumir el servicio web que retorna el número de sala";
            }
        }

        public string consultarReservasEquipo(string codComputador)
        {
            try
            {
                var uri = new Uri("http://biblioteca.udea.edu.co/turnos/services/ListarReservasPorEquipo.php?equipoConsulta=" + codComputador);
                var result_get = SendRequest(uri, null, "application/json", "GET");
                result_get = result_get.Trim();
                return result_get;
            }
            catch (Exception ex)
            {
                return "No se pudo consumir el servicio web que retorna la disponibilidad del equipo";
            }
        }

        public bool registrarReserva(string usuario, string horaReserva)
        {
            try
            {
                //string codigoComputador = System.Net.Dns.GetHostName();
                string codigoComputador = "PISO2-PC45";
                string idSala = consultarSalaPorPC(codigoComputador);

                string json = "{\"codigoSala\":" + idSala + ",\"codigoComputador\":\"" + codigoComputador + "\",\"horasReserva\":" + horaReserva + ",\"usuario\":\"" + usuario + "\"}";
                var data = Encoding.UTF8.GetBytes(json);
                var uri = new Uri("http://biblioteca.udea.edu.co/turnos/services/CrearReserva.php");
                var result_post = SendRequest(uri, data, "application/json", "POST");
                result_post = result_post.Trim();
                return result_post == "{\"reservaCreada\":true}";
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se pudo consumir el servicio web que registra la reserva", ex);
                return true;
            }
        }

        public bool validarTurnoUsuario(string usuario)
        {
            try
            {
                string json = "{\"usuario\":\"" + usuario + "\",\"codComputador\":\"" + System.Net.Dns.GetHostName() + "\"}";
                var data = Encoding.UTF8.GetBytes(json);
                var uri = new Uri("http://biblioteca.udea.edu.co/turnos/services/ValidarReservaUsuario.php");
                var result_post = SendRequest(uri, data, "application/json", "POST");
                result_post = result_post.Trim();
                return result_post == "{\"existeReserva\":true}";
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se pudo consumir el servicio web que valida el turno");
                return true;
            }
        }

        public bool validarUsuario(string usuario, string clave)
        {
            try
            {
                string json = "{\"usuario\":\"" + usuario + "\",\"clave\":\"" + clave + "\"}";
                var data = Encoding.UTF8.GetBytes(json);
                var uri = new Uri("http://biblioteca.udea.edu.co/turnos/services/loguearusuario.php");
                var result_post = SendRequest(uri, data, "application/json", "POST");
                result_post = result_post.Trim();
                if (result_post == "{\"VALIDADO\":false,\"RESULTADO\":\"ERROR 002: El usuario no existe en el oid\"}")
                    return false;
                else if (result_post == "{\"VALIDADO\":false,\"RESULTADO\":\"\"}")
                    return false;
                else if (result_post == "{\"VALIDADO\":false,\"RESULTADO\":\"ERROR 003: Password incorrecto\"}")
                    return false;
                else
                    return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se pudo consumir el servicio web que valida el usuario");
                return true;
            }
        }

        public bool registrarUsoReserva(string user)
        {
            try
            {
                string json = "{\"usuario\":\"" + user + "\",\"codComputador\":\"" + System.Net.Dns.GetHostName() + "\"}";
                var data = Encoding.UTF8.GetBytes(json);
                var uri = new Uri("http://biblioteca.udea.edu.co/turnos/services/registrarUsoReserva.php");
                var result_post = SendRequest(uri, data, "application/json", "POST");
                result_post = result_post.Trim();
                return result_post == "{\"existeReserva\":true}";
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se pudo consumir el servicio web que valida el usuario");
                return true;
            }
        }

        public bool liberarReserva()
        {
            try
            {
                string json = "{\"codComputador\":\"" + System.Net.Dns.GetHostName() + "\"}";
                var data = Encoding.UTF8.GetBytes(json);
                var uri = new Uri("http://biblioteca.udea.edu.co/turnos/services/liberarReserva.php");
                var result_post = SendRequest(uri, data, "application/json", "POST");
                result_post = result_post.Trim();
                return result_post == "{\"existeReserva\":true}";
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se pudo consumir el servicio web que valida el usuario");
                return true;
            }
        }

        public string obtenerHoraReserva(string codComputador, int inicioOFin) //0 Inicio, 1 Fin
        {
            try
            {
                string horaInicio = "";
                string horaFin = "";
                string idSala = consultarSalaPorPC(codComputador);
                var uri = new Uri("http://biblioteca.udea.edu.co/turnos/services/ListarSalaPorCodigoSala.php?idSala=" + idSala);
                var result_post = SendRequest(uri, null, "application/json", "GET");
                result_post = result_post.Trim();

                JArray jsonArray = JArray.Parse(result_post);
                var jsonObjects = jsonArray.OfType<JObject>().ToList();
                CultureInfo ci = new CultureInfo("Es-Es");
                var diaSemana = ci.DateTimeFormat.GetDayName(DateTime.Now.DayOfWeek);
                foreach (JToken horarios in jsonObjects)
                {
                    switch (diaSemana)
                    {
                        case "sábado":
                            horaInicio = (string)horarios.SelectToken("horaInicioSabado");
                            horaFin = (string)horarios.SelectToken("horaFinSabado");
                            break;
                        case "domingo":
                            horaInicio = (string)horarios.SelectToken("horaInicioDomingo");
                            horaFin = (string)horarios.SelectToken("horaFinDomingo");
                            break;
                        default:
                            horaInicio = (string)horarios.SelectToken("horaInicioSemana");
                            horaFin = (string)horarios.SelectToken("horaFinSemana");
                            break;
                    }
                }
                if (inicioOFin == 0) {
                    return horaInicio;
                }
                return horaFin;
            }
            catch (Exception)
            {
                Console.WriteLine("No se pudo consumir el servicio web que retorna la hora de inicio de la sala del pc");
                return null;
            }
        }
    }
}
