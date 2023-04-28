using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PruebaTecnica
{
    public class Conect
    {
        public SqlConnection conexion()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConectPrueba"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}