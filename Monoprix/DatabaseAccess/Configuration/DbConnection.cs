using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monoprix.DatabaseAccess.Configuration
{
 public   class DbConnection
    {
        private static string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\firas\\source\\repos\\Monoprix\\Monoprix\\MonoprixDatabase.mdf;Integrated Security=True";
        //Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nouha\source\repos\Monoprix\Monoprix\MonoprixDatabase.mdf;Integrated Security=True
        public static SqlConnection connection = null;


        public static void InitDb()
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
        }

        public static bool IsConnected()
        {
            if (connection != null)
            {
                return true;
            }
            return false;
        }
    }
}
