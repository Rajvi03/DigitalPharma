using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace DigitalPharma.App_Code
{
    public class DAtabaseConfig1
    {
        public DAtabaseConfig1()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["DigitalPharmaConnectionString"].ConnectionString;
    }
}