using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job
{
    public class ViecLamYeuThichDAO
    {
        private string connectionString;
        public ViecLamYeuThichDAO()
        {
            this.connectionString = Properties.Settings.Default.Connection;
        }

        public void ThemYeuThichCongViec(ViecLamYeuThich viecLamYeuThich)
        {
            string updateQuery = "INSERT INTO DuLieuYeuThich (tk, id) VALUES (@TaiKhoan, @ID)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                {
                    updateCommand.Parameters.AddWithValue("@TaiKhoan", viecLamYeuThich.TaiKhoan);
                    updateCommand.Parameters.AddWithValue("@ID", viecLamYeuThich.ID);
                    connection.Open();
                    updateCommand.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        public void XoaYeuThichCongViec(ViecLamYeuThich viecLamYeuThich)
        {
            string taiKhoan = TaiKhoan.TaiKhoanDangNhap.TK;
            string deleteQuery = "DELETE FROM DuLieuYeuThich WHERE tk = @TaiKhoan AND id = @ID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection))
                {
                    deleteCommand.Parameters.AddWithValue("@TaiKhoan", viecLamYeuThich.TaiKhoan);
                    deleteCommand.Parameters.AddWithValue("@ID", viecLamYeuThich.ID);
                    connection.Open();
                    deleteCommand.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        public List<ViecLamYeuThich> NhanViecLamYeuThich()
        {
            List<ViecLamYeuThich> viecLamYeuThichs = new List<ViecLamYeuThich>();
            string taiKhoan = TaiKhoan.TaiKhoanDangNhap.TK;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = $"select * from DuLieuYeuThich where tk = '{TaiKhoan.TaiKhoanDangNhap.TK}'";

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    
                    ViecLamYeuThich viecLamYeuThich = new ViecLamYeuThich(reader["tk"].ToString().Trim(), (int)Convert.ToSingle(reader["Id"]));
                    viecLamYeuThichs.Add(viecLamYeuThich);
                }
            }
            return viecLamYeuThichs;
        }
    }
}
