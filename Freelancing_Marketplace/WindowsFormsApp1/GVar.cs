using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class GVar
    { 
        public static int user_id ;
        public static string username = "";
        public static string password = "";
        public static string role = "";
        public static string email = "";

        public static string connection_string = "Data Source=rakib\\sqlexpress;Initial Catalog=FreelanceLink; Integrated Security=True";

    }
}
