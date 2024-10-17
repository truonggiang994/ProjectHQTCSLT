using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace Job
{
    public class CongTyDao
    {
        private string connectionString; 

        public CongTyDao()
        {
            this.connectionString = Properties.Settings.Default.Connection;
        }

        public void ThemCongTy(CongTy congTy)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO CongTy (tk, AnhLogo, AnhGiayPhep, TenCongTy, MaSoThue, SDT, QuyMo, DiaDiem, DiaChi, NguoiDungDau, Gmail, AnhBia) " +
                               "VALUES (@tk, @AnhLogo, @AnhGiayPhep, @TenCongTy, @MaSoThue, @SDT, @QuyMo, @DiaDiem, @DiaChi, @NguoiDungDau, @Gmail, @AnhBia)";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@tk", congTy.TaiKhoan);
                command.Parameters.AddWithValue("@AnhLogo", KiemTraDauVao.ChuyenByteSanhAnh(congTy.LoGo));
                command.Parameters.AddWithValue("@AnhGiayPhep", KiemTraDauVao.ChuyenByteSanhAnh(congTy.GiayPhepKinhDoanh));
                command.Parameters.AddWithValue("@TenCongTy", congTy.TenCongTy);
                command.Parameters.AddWithValue("@MaSoThue", congTy.MaSoThue);
                command.Parameters.AddWithValue("@SDT", congTy.SDT);
                command.Parameters.AddWithValue("@QuyMo", congTy.QuyMoNhanSu);
                command.Parameters.AddWithValue("@DiaDiem", congTy.DiaDiem);
                command.Parameters.AddWithValue("@DiaChi", congTy.DiaChi);
                command.Parameters.AddWithValue("@NguoiDungDau", congTy.NguoiDungDau);
                command.Parameters.AddWithValue("@Gmail", congTy.Gmail);
                command.Parameters.AddWithValue("@AnhBia", KiemTraDauVao.ChuyenByteSanhAnh(congTy.AnhBia));

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public CongTy XemCongTy(string taiKhoan)
        {
            CongTy congTy = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM CongTy WHERE tk = @tk";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@tk", taiKhoan);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // Lấy dữ liệu từ cơ sở dữ liệu
                    string tenCongTy = reader["TenCongTy"].ToString();
                    string maSoThue = reader["MaSoThue"].ToString();
                    string sdt = reader["SDT"].ToString();
                    string quyMo = reader["QuyMo"].ToString();
                    string diaDiem = reader["DiaDiem"].ToString();
                    string diaChi = reader["DiaChi"].ToString();
                    Image anhLogo = KiemTraDauVao.ChuyenAnhSangByte((byte[])reader["AnhLogo"]);
                    Image anhGiayPhep = KiemTraDauVao.ChuyenAnhSangByte((byte[])reader["AnhGiayPhep"]);
                    string nguoiDungDau = reader["NguoiDungDau"].ToString();
                    string gmail = reader["Gmail"].ToString();
                    Image anhBia = KiemTraDauVao.ChuyenAnhSangByte((byte[])reader["AnhBia"]);


                    // Tạo đối tượng CongTy
                    congTy = new CongTy(taiKhoan, tenCongTy, maSoThue, sdt, quyMo, diaDiem, diaChi, anhLogo, anhGiayPhep, nguoiDungDau, gmail, anhBia);
                }
            }
            return congTy;
        }
    }
}
