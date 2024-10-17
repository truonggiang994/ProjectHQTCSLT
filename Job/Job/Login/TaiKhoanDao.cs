using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job
{
    internal class TaiKhoanDao
    {
        private string connectionString;

        public TaiKhoanDao()
        {
            this.connectionString = Properties.Settings.Default.Connection;
        }
        public bool DangKiTaiKhoan(string taiKhoan, string matKhau)
        {
            if (KiemTraTaiKhoanTonTai(taiKhoan))
            {
                return false;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Account ([tk], [mk]) VALUES (@TaiKhoan, @MatKhau)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TaiKhoan", taiKhoan);
                command.Parameters.AddWithValue("@MatKhau", matKhau);
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
        public bool KiemTraTaiKhoanTonTai(string taiKhoan)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Account WHERE [tk] = @TaiKhoan";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TaiKhoan", taiKhoan);
                int count = Convert.ToInt32(command.ExecuteScalar());
                return count > 0;
            }
        }

        public bool DangNhap(string taiKhoan, string matKhau)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Account WHERE [tk] = @TaiKhoan AND [mk] = @MatKhau";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TaiKhoan", taiKhoan);
                command.Parameters.AddWithValue("@MatKhau", matKhau);
                int count = Convert.ToInt32(command.ExecuteScalar());
                return count > 0;
            }
        }
        public bool DoiMatKhau(string taiKhoan, string matKhauMoi)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE Account SET [mk] = @MatKhauMoi WHERE [tk] = @TaiKhoan";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MatKhauMoi", matKhauMoi);
                command.Parameters.AddWithValue("@TaiKhoan", taiKhoan);
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
    }
}
