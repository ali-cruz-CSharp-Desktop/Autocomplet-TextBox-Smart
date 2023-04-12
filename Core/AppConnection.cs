using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutocompletTextBox_Smart.Core
{
    public class AppConnection
    {
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["LocalHostHome"].ConnectionString;
        }
    }
}
