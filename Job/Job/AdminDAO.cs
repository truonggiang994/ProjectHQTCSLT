using System;
using System.Data.SqlClient;

namespace Job
{
    public class AdminDAO
    {
        private MY_DB dbConnection;

        public AdminDAO()
        {
            dbConnection = new MY_DB();
        }

        // Hàm kiểm tra xem người dùng có phải là quản lý hay không
        public bool IsManager(string username)
        {
            bool isManager = false;

            try
            {
                dbConnection.OpenConnection();
                string query = "SELECT ManagerUsername FROM Admin WHERE Username = @Username";
                SqlCommand cmd = new SqlCommand(query, dbConnection.GetConnection());
                cmd.Parameters.AddWithValue("@Username", username);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    if (reader["ManagerUsername"] == DBNull.Value)
                    {
                        isManager = true; // Quản lý
                    }
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
            finally
            {
                dbConnection.CloseConnection();
            }

            return isManager;
        }
    }
}
