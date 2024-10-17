using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Job
{
    public class UngTuyenDAO
    {
        private string connectionString;
        public UngTuyenDAO()
        {
            this.connectionString = Properties.Settings.Default.Connection;
        }

        public void Tuyen(UngTuyen ungTuyen)
        {
            string taiKhoan = TaiKhoan.TaiKhoanDangNhap.TK;
            string updateQuery = "INSERT INTO DuLieuUngTuyen (TKDangTin, MaCV, ID, TKUngTuyen, NgayNop) VALUES (@TKDangTin, @MaCV,@ID, @TKUngTuyen, @NgayNop)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                {
                    updateCommand.Parameters.AddWithValue("@TKDangTin", ungTuyen.TKDangTin);
                    updateCommand.Parameters.AddWithValue("@MaCV", ungTuyen.MaCV);
                    updateCommand.Parameters.AddWithValue("@ID", ungTuyen.ID);
                    updateCommand.Parameters.AddWithValue("@TKUngTuyen", ungTuyen.TKUngTuyen);
                    updateCommand.Parameters.AddWithValue("@NgayNop", ungTuyen.NgayNop);

                    connection.Open();
                    updateCommand.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
        public List<UngTuyen> NhanHoSoUngTuyen()
        {
            List<UngTuyen> ungTuyens = new List<UngTuyen>();
            string taiKhoan = TaiKhoan.TaiKhoanDangNhap.TK;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = $"select * from DuLieuUngTuyen where TKDangTin = '{TaiKhoan.TaiKhoanDangNhap.TK}'";

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {

                    UngTuyen ungTuyen = new UngTuyen(reader["TKDangTin"].ToString().Trim(), (int)Convert.ToSingle(reader["MaCV"]), (int)Convert.ToSingle(reader["ID"]), reader["TKUngTuyen"].ToString());
                    ungTuyens.Add(ungTuyen);
                }
            }
            return ungTuyens;
        }
        public List<UngTuyen> NhanThongTinUngTuyen()
        {
            List<UngTuyen> ungTuyens = new List<UngTuyen>();
            string taiKhoan = TaiKhoan.TaiKhoanDangNhap.TK;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = $"select * from DuLieuUngTuyen where TKUngTuyen = '{TaiKhoan.TaiKhoanDangNhap.TK}'";

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {

                    UngTuyen ungTuyen = new UngTuyen(reader["TKDangTin"].ToString().Trim(), (int)Convert.ToSingle(reader["MaCV"]), (int)Convert.ToSingle(reader["ID"]), reader["TKUngTuyen"].ToString());
                    ungTuyens.Add(ungTuyen);
                }
            }
            return ungTuyens;
        }
    }
}
