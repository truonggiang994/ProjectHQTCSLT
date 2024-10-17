using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Job
{
    public class PhongVanDAO
    {
        private string connectionString;
        //private PhongVan phongVan;
        public PhongVanDAO()
        {
            this.connectionString = Properties.Settings.Default.Connection;
        }

        public void ThemPhongVan(PhongVan phongVan)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO PhongVan (TKUngTuyen, MaCV, MaDangTin, TKDangTin, NguoiPhongVan, SDT, NgayPhongVan, DiaChiPhongVan, HoTen) " +
                               "VALUES (@TKUngTuyen, @MaCV, @MaDangTin, @TKDangTin, @NguoiPhongVan, @SDT, @NgayPhongVan, @DiaChiPhongVan, @HoTen)";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@TKUngTuyen", phongVan.TKUngTuyen);
                command.Parameters.AddWithValue("@MaCV", phongVan.MaCV);
                command.Parameters.AddWithValue("@MaDangTin", phongVan.MaDangTin);
                command.Parameters.AddWithValue("@TKDangTin", phongVan.TKDangTin);
                command.Parameters.AddWithValue("@NguoiPhongVan", phongVan.NguoiPhongVan);
                command.Parameters.AddWithValue("@SDT", phongVan.SDT);
                command.Parameters.AddWithValue("@NgayPhongVan", phongVan.NgayPhongVan) ;
                command.Parameters.AddWithValue("@DiaChiPhongVan", phongVan.DiaChiPhongVan);
                command.Parameters.AddWithValue("@HoTen", phongVan.HoTen);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public List<PhongVan> NhanThongTinPhongVan()
        {
            List<PhongVan> phongVans = new List<PhongVan>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = $"select * from PhongVan";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    PhongVan phongVan = new PhongVan();
                    phongVan.TKUngTuyen = reader["TKUngTuyen"].ToString();
                    phongVan.MaCV = (int)Convert.ToSingle(reader["MaCV"]);
                    phongVan.MaDangTin = (int)Convert.ToSingle(reader["MaDangTin"]);
                    phongVan.TKDangTin = reader["TKDangTin"].ToString();
                    phongVan.NguoiPhongVan = reader["NguoiPhongVan"].ToString();
                    phongVan.SDT = reader["SDT"].ToString();
                    phongVan.NgayPhongVan = Convert.ToDateTime(reader["NgayPhongVan"]);
                    phongVan.DiaChiPhongVan = reader["DiaChiPhongVan"].ToString();
                    phongVan.HoTen = reader["HoTen"].ToString();

                    phongVans.Add(phongVan);
                }
            }
            return phongVans;
        }
    }
}
