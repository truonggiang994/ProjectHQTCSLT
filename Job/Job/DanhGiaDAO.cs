using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job
{
    public class DanhGiaDAO
    {
        private string connectionString;

        public DanhGiaDAO()
        {
            this.connectionString = Properties.Settings.Default.Connection;
        }

        public void ThemDanhGia(DanhGia danhGia)
        {
            string query = "INSERT INTO DanhGia (SoSao, TKDanhGia, TKCongTy, Anh, NoiDung) VALUES (@SoSao, @TKDanhGia, @TKCongTy, @Anh, @NoiDung)";
            ;using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@SoSao", danhGia.SoSao);
                command.Parameters.AddWithValue("@TKDanhGia", danhGia.TKDanhGia);
                command.Parameters.AddWithValue("@TKCongTy", danhGia.TKCongTy);
                command.Parameters.AddWithValue("@Anh", KiemTraDauVao.ChuyenByteSanhAnh(danhGia.Anh));
                command.Parameters.AddWithValue("@NoiDung", danhGia.NoiDung);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public List<DanhGia> NhanDanhGia()
        {
            List<DanhGia> danhGias = new List<DanhGia>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM DanhGia";

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    DanhGia danhGia = new DanhGia();
                    danhGia.MaDanhGia = (int)Convert.ToSingle(reader["MaDanhGia"]);
                    danhGia.SoSao = (int)Convert.ToSingle(reader["SoSao"]);
                    danhGia.TKDanhGia = reader["TKDanhGia"].ToString();
                    danhGia.TKCongTy = reader["TKCongTy"].ToString();
                    danhGia.Anh = KiemTraDauVao.ChuyenAnhSangByte((byte[])reader["Anh"]);
                    danhGia.NoiDung = reader["NoiDung"].ToString();

                    danhGias.Add(danhGia);
                }
            }
            return danhGias;
        }
    }
}
