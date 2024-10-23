using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Job
{
    public class DatabaseConnection
    {
        private SqlConnection conn;
        public DatabaseConnection()
        {
            string connectionString;
            connectionString = @"Data Source=BQH;Initial Catalog=Job;User ID= Giang;Password= 123456789";

            conn = new SqlConnection(connectionString);
        }

        public void OpenConnection()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public void CloseConnection()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public SqlConnection GetConnection
        {
            get
            {
                return conn;
            }
        }
    }
}
