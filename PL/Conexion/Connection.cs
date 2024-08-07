using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace PL.Conexion
{
    public class Connection
    {
        public static string GetConnection()
        {
            return ConfigurationManager.ConnectionStrings["ControlEsacolar"].ConnectionString.ToString();
        }
    }
}