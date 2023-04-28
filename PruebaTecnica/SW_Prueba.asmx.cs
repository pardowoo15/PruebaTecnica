using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Services;

namespace PruebaTecnica
{
    /// <summary>
    /// Descripción breve de SW_Prueba
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class SW_Prueba : System.Web.Services.WebService
    {

        Conect conect = new Conect();

        [WebMethod]
        public string GetConect()
        {
            try { 
                SqlConnection c = conect.conexion();
                c.Open();
                var test = c.State.ToString();
                c.Close();
                return test;
            }
            catch  (Exception e)
            {
                return e.Message;
            }
           
        }
    
        [WebMethod]
        public string CreateEmpl(string Nombres, string Apellidos, string Direccion, string Email, int IdGenero, int IdCiudad)
        {
            var response = new Response();
            if(string.IsNullOrEmpty(Nombres) || string.IsNullOrEmpty(Apellidos) || string.IsNullOrEmpty(Direccion) || string.IsNullOrEmpty(Email) || IdGenero <= 0 || IdCiudad <= 0)
            {
                response.exitValue = null;
                response.exitError = -4;
                response.exitMensaje = $"Todos lo valores son obligatorios";
                return JsonConvert.SerializeObject(response);
            }
            if (!IsValidEmail(Email))
            {
                response.exitValue = null;
                response.exitError = -2;
                response.exitMensaje = $"El Email = {Email} no es un Email valido";
                return JsonConvert.SerializeObject(response);

            }
            string QueryString = $"INSERT INTO EMPLEADO VALUES('{Nombres}', '{Apellidos}', '{Direccion}','{Email}',{IdGenero},{IdCiudad}) SELECT SCOPE_IDENTITY() AS ID; ";
            var c = conect.conexion();
            try
            {


                SqlCommand command = new SqlCommand(QueryString, c);
                c.Open();
                SqlDataReader reader = command.ExecuteReader();
                var results = new List<string>();
                while (reader.Read())
                {
                    var row = new Dictionary<string, object>();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        row[reader.GetName(i)] = reader[i];
                    }
                    results.Add(row.FirstOrDefault().Value.ToString());
                }
                reader.Close();
                c.Close();
                
                if (results.Count == 0)
                {
                    response.exitValue = results.FirstOrDefault();
                    response.exitError = -1;
                    response.exitMensaje = $"No se pudo crear el empleado ";
                    return JsonConvert.SerializeObject(response); 
                }
                var emp = GetEmpl(int.Parse(results.FirstOrDefault()));
                var pattern = @"\b(\d+)\.0\b"; // patrón para buscar números enteros seguidos de ".0"
                var replacement = "$1"; // reemplazo por el número entero sin ".0"
                emp = Regex.Replace(emp, pattern, replacement);


                return emp; 
            }
            catch (Exception e)
            {
                c.Close();
                response.exitValue = null; 
                response.exitError = 500;
                response.exitMensaje = e.Message;

                return JsonConvert.SerializeObject(response);
            }
           
        }
        [WebMethod]
        public string GetAllEmpl ()
        {
            var settings = new JsonSerializerSettings
            {
                FloatFormatHandling = FloatFormatHandling.String
            };
            var response = new Response();

            string QueryString = $"SELECT * FROM EMPLEADO";
            var c = conect.conexion();
            try
            {


                SqlCommand command = new SqlCommand(QueryString, c);
                c.Open();
                SqlDataReader reader = command.ExecuteReader();
                var results = new List<Dictionary<string, object>>();
                while (reader.Read())
                {
                    var row = new Dictionary<string, object>();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        row[reader.GetName(i)] = reader[i];
                    }
                    results.Add(row);
                }
                reader.Close();
                c.Close();
                string json = JsonConvert.SerializeObject(results, settings);
                var pattern = @"\b(\d+)\.0\b"; // patrón para buscar números enteros seguidos de ".0"
                var replacement = "$1"; // reemplazo por el número entero sin ".0"
                json = Regex.Replace(json, pattern, replacement);
                if (results.Count == 0)
                {
                    response.exitValue = json;
                    response.exitError = -1;
                    response.exitMensaje = $"No existen Empleados registrados";
                    return JsonConvert.SerializeObject(response); ;
                }
                response.exitValue = json;
                response.exitError = 0;
                response.exitMensaje = null;

                return JsonConvert.SerializeObject(response); ;
            }
            catch (Exception e)
            {
                c.Close();
                response.exitValue = null;
                response.exitError = 500;
                response.exitMensaje = e.Message;

                return JsonConvert.SerializeObject(response);
            }
        }
        [WebMethod]
        public string GetEmpl(int id)
        {
            var response = new Response();

            string QueryString = $"SELECT * FROM EMPLEADO where IdEmpleado = {id}";
            var c = conect.conexion();
            try
            {


                SqlCommand command = new SqlCommand(QueryString, c);
                c.Open();
                SqlDataReader reader = command.ExecuteReader();
                var results = new List<Dictionary<string, object>>();
                while (reader.Read())
                {
                    var row = new Dictionary<string, object>();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        row[reader.GetName(i)] = reader[i];
                    }
                    results.Add(row);
                }
                reader.Close();
                c.Close();
                string json = JsonConvert.SerializeObject(results);
                if (results.Count == 0) {
                    response.exitValue = json;
                    response.exitError = -1;
                    response.exitMensaje = $"No existe Empleado con el id = {id}";
                    return JsonConvert.SerializeObject(response); ;
                }
                response.exitValue = json;
                response.exitError = 0;
                response.exitMensaje = null;

                return JsonConvert.SerializeObject(response); 
            }
            catch (Exception e)
            {
                c.Close();
                response.exitValue = null;
                response.exitError = 500;
                response.exitMensaje = e.Message;

                return JsonConvert.SerializeObject(response);
            }
        }
        [WebMethod]
        public string GetVinc(int id)
        {
            var response = new Response();

            string QueryString = $"SELECT * FROM VINCULACION where IdVinculacion = {id}";
            var c = conect.conexion();
            try
            {


                SqlCommand command = new SqlCommand(QueryString, c);
                c.Open();
                SqlDataReader reader = command.ExecuteReader();
                var results = new List<Dictionary<string, object>>();
                while (reader.Read())
                {
                    var row = new Dictionary<string, object>();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        row[reader.GetName(i)] = reader[i];
                    }
                    results.Add(row);
                }
                reader.Close();
                c.Close();
                string json = JsonConvert.SerializeObject(results);
                if (results.Count == 0)
                {
                    response.exitValue = json;
                    response.exitError = -1;
                    response.exitMensaje = $"No existe Vinculacion con el id = {id}";
                    return JsonConvert.SerializeObject(response); ;
                }
                response.exitValue = json;
                response.exitError = 0;
                response.exitMensaje = null;

                return JsonConvert.SerializeObject(response);
            }
            catch (Exception e)
            {
                c.Close();
                response.exitValue = null;
                response.exitError = 500;
                response.exitMensaje = e.Message;

                return JsonConvert.SerializeObject(response);
            }
        }
        [WebMethod]
     
        public string CreateVinc(int IdEmpleado,string FechaIngreso,int IdCargo, string FechaRetiro, string FechaRegistro)
        {
            var response = new Response();
            if (IdEmpleado <= 0 || string.IsNullOrEmpty(FechaIngreso) || IdCargo<= 0 || string.IsNullOrEmpty(FechaRetiro) || string.IsNullOrEmpty(FechaRegistro))

            {
                response.exitValue = null;
                response.exitError = -4;
                response.exitMensaje = $"Todos lo valores son obligatorios";
                return JsonConvert.SerializeObject(response);
            }
            string QueryString = $"INSERT INTO VINCULACION VALUES({IdEmpleado}, '{FechaIngreso}', {IdCargo},'{FechaRetiro}','{FechaRegistro}') SELECT SCOPE_IDENTITY() AS ID; ";
            var c = conect.conexion();
            try
            {
                //Validamos si existe un empleado con ese id
              
                var empl= GetEmpl(IdEmpleado);               
                Response jsonEmpl = JsonConvert.DeserializeObject<Response>(empl);
                
               if(jsonEmpl.exitError!=0) 
               {
                    response.exitValue = null;
                    response.exitError = -3;
                    response.exitMensaje = $"No Existe ningun empleado con el id = {IdEmpleado} ";
                    return JsonConvert.SerializeObject(response);

               }

                SqlCommand command = new SqlCommand(QueryString, c);
                c.Open();
                SqlDataReader reader = command.ExecuteReader();
                var results = new List<string>();
                while (reader.Read())
                {
                    var row = new Dictionary<string, object>();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        row[reader.GetName(i)] = reader[i];
                    }
                    results.Add(row.FirstOrDefault().Value.ToString());
                }
                reader.Close();
                c.Close();
                string json = JsonConvert.SerializeObject(results);
                if (results.Count == 0)
                {
                    response.exitValue = json;
                    response.exitError = -1;
                    response.exitMensaje = $"No se pudo crear la vinculacion ";
                    return JsonConvert.SerializeObject(response);
                }
                var emp = GetVinc(int.Parse(results.FirstOrDefault()));
                var pattern = @"\b(\d+)\.0\b"; // patrón para buscar números enteros seguidos de ".0"
                var replacement = "$1"; // reemplazo por el número entero sin ".0"
                emp = Regex.Replace(emp, pattern, replacement);


                return emp;

                
            }
            catch (Exception e)
            {
                c.Close();
                response.exitValue = null;
                response.exitError = 500;
                response.exitMensaje = e.Message;

                return JsonConvert.SerializeObject(response);
            }
          
        }
        [WebMethod]
        public string GetAllVinc()
        {
            var response = new Response();

            string QueryString = $"SELECT * FROM VINCULACION";
            var c = conect.conexion();
            try
            {


                SqlCommand command = new SqlCommand(QueryString, c);
                c.Open();
                SqlDataReader reader = command.ExecuteReader();
                var results = new List<Dictionary<string, object>>();
                while (reader.Read())
                {
                    var row = new Dictionary<string, object>();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        row[reader.GetName(i)] = reader[i];
                    }
                    results.Add(row);
                }
                reader.Close();
                c.Close();
                string json = JsonConvert.SerializeObject(results);
                if (results.Count == 0)
                {
                    response.exitValue = json;
                    response.exitError = -1;
                    response.exitMensaje = $"No existen Vinculaciones registradas";
                    return JsonConvert.SerializeObject(response); ;
                }
                var pattern = @"\b(\d+)\.0\b"; // patrón para buscar números enteros seguidos de ".0"
                var replacement = "$1"; // reemplazo por el número entero sin ".0"
                json = Regex.Replace(json, pattern, replacement);
                response.exitValue = json;
                response.exitError = 0;
                response.exitMensaje = null;

                return JsonConvert.SerializeObject(response); ;
            }
            catch (Exception e)
            {
                c.Close();
                response.exitValue = null;
                response.exitError = 500;
                response.exitMensaje = e.Message;

                return JsonConvert.SerializeObject(response);
            }
        }
        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
                return false;

            // Expresión regular para validar el formato de un email
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            // Se compila la expresión regular
            Regex regex = new Regex(pattern);

            // Se verifica si el email cumple con el formato de la expresión regular
            return regex.IsMatch(email);
        }
    }
}
