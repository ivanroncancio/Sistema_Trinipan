using Sitema_Trinipan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Sitema_Trinipan
{
    internal class BasesDatos
    {
        public static SqlConnection Connection()
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=IVAN\\SQLEXPRES;Initial Catalog=Sistema_Trinipan;Integrated Security=True;Encrypt=False");
            sqlConnection.Open();
            
            return sqlConnection;

        }
    }
}
