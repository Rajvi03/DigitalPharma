using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace DigitalPharma
{
    public class DatabaseConfig2
    {
        public DatabaseConfig2()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["DigitalPharmaConnectionString"].ConnectionString;
    }
}