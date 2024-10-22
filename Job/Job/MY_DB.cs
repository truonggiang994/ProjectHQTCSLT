using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job
{
    public class MY_DB
    {

        private SqlConnection con;

        public MY_DB()
        {
            string connectionString;

            if (Global.IsManager())
            {
                connectionString = @"Data Source=BQH;Initial Catalog=Job;";
            }
            else
            {
                connectionString = @"Data Source=BQH;Initial Catalog=Job;User ID=" + Global.Username + ";Password=" + Global.Password;
            }

            con = new SqlConnection(connectionString);
        }
        public void OpenConnection()
        {
            try
            {
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                    Console.WriteLine("Kết nối thành công.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi kết nối: " + ex.Message);
            }
        }

        public void CloseConnection()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }

        public SqlConnection GetConnection()
        {
            return con;
        }

    }
}
