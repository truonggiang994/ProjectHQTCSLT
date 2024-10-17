using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job
{
    public class LichSuDangTinDAO
    {
        private string connectionString;

        public LichSuDangTinDAO()
        {
            this.connectionString = Properties.Settings.Default.Connection;
        }

        public List<LicSuDangTin> NhanLichSuDangTin()
        {
            List<LicSuDangTin> licSuDangTins = new List<LicSuDangTin>();
            string taiKhoan = TaiKhoan.TaiKhoanDangNhap.TK;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = $"select * from DangTin where DangTin.tk = '{TaiKhoan.TaiKhoanDangNhap.TK}'";

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    LicSuDangTin lichSuDangTin = new LicSuDangTin();
                    lichSuDangTin.TaiKhoan = reader["tk"].ToString();
                    lichSuDangTin.Id = (int)Convert.ToSingle(reader["Id"]);
                    lichSuDangTin.ChucDanh = reader["ChucDanh"].ToString();
                    lichSuDangTin.NganhNghe = reader["NganhNghe"].ToString();
                    lichSuDangTin.HinhThucLV = reader["HinhThucLV"].ToString();
                    lichSuDangTin.BangCap = reader["BangCap"].ToString();
                    lichSuDangTin.KinhNghiem = reader["KinhNghiem"].ToString();
                    lichSuDangTin.YeuCauGioiTinh = reader["YeuCauGioiTinh"].ToString();
                    lichSuDangTin.HanNopHoSo = Convert.ToDateTime(reader["HanNopHoSo"]);
                    lichSuDangTin.TinhThanh = reader["TinhThanh"].ToString();
                    lichSuDangTin.QuanHuyen = reader["QuanHuyen"].ToString();
                    lichSuDangTin.SoNha = reader["SoNha"].ToString();
                    lichSuDangTin.MucluongToiThieu = Convert.ToSingle(reader["MucluongToiThieu"]);
                    lichSuDangTin.MucLuongToiDa = Convert.ToSingle(reader["MucLuongToiDa"]);
                    lichSuDangTin.DoTuoiToiThieu = (int)Convert.ToSingle(reader["DoTuoiToiThieu"]);
                    lichSuDangTin.DoTuoiToiDa = (int)Convert.ToSingle(reader["DoTuoiToiDa"]);
                    lichSuDangTin.KiNang = reader["KiNang"].ToString();
                    lichSuDangTin.MoTaCV = reader["MoTaCV"].ToString();
                    lichSuDangTin.YeuCauCV = reader["YeuCauCV"].ToString();
                    lichSuDangTin.QuyenLoi = reader["QuyenLoi"].ToString();
                    lichSuDangTin.LuotDaTuyen = DemLuotDaTuyen((int)Convert.ToSingle(reader["Id"]));
                    lichSuDangTin.LuotChuaTuyen = DemLuotUngTuyen((int)Convert.ToSingle(reader["Id"])) - lichSuDangTin.LuotDaTuyen;

                    licSuDangTins.Add(lichSuDangTin);
                }
            }
            return licSuDangTins;
        }

        public int DemLuotUngTuyen(int MaDangTin)
        {
            int soLanXuatHien = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = $"SELECT COUNT(*) FROM DuLieuDangTin WHERE TKDangTin = '{TaiKhoan.TaiKhoanDangNhap.TK}' and MaDangTin = {MaDangTin}";

                SqlCommand command = new SqlCommand(query, connection);
                soLanXuatHien = (int)command.ExecuteScalar();
            }
            return soLanXuatHien;
        }
        public int DemLuotDaTuyen(int MaDangTin)
        {
            int soLanXuatHien = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = $"SELECT COUNT(*) FROM DuLieuUngTuyen WHERE TKDangTin = '{TaiKhoan.TaiKhoanDangNhap.TK}' and ID = {MaDangTin}";

                SqlCommand command = new SqlCommand(query, connection);
                soLanXuatHien = (int)command.ExecuteScalar();
            }
            return soLanXuatHien;
        }
    }
}
