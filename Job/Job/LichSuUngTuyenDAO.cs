using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job
{
    public class LichSuUngTuyenDAO
    {
        private string connectionString;

        public LichSuUngTuyenDAO()
        {
            this.connectionString = Properties.Settings.Default.Connection;
        }

        public List<LichSuUngTuyen> NhanLichSuUngTuyen()
        {
            List<LichSuUngTuyen> lichSuUngTuyens = new List<LichSuUngTuyen>();
            string taiKhoan = TaiKhoan.TaiKhoanDangNhap.TK;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = $"SELECT * FROM (SELECT CongTy.tk, TenCongTy, MaSoThue, SDT, QuyMo, ChucDanh, NganhNghe, HinhThucLV, BangCap, KinhNghiem, YeuCauGioiTinh, HanNopHoSo, TinhThanh, QuanHuyen, SoNha, MucluongToiThieu, MucLuongToiDa, DoTuoiToiThieu, DoTuoiToiDa, KiNang, MoTaCV, YeuCauCV, QuyenLoi, AnhLogo, id FROM CongTy INNER JOIN DangTin ON CongTy.tk = DangTin.tk) AS lichSuUngTuyen INNER JOIN DuLieuDangTin ON DuLieuDangTin.MaDangTin = lichSuUngTuyen.id and DuLieuDangTin.TKUngTuyen = '{taiKhoan}'";

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {

                    LichSuUngTuyen lichSuUngTuyen = new LichSuUngTuyen();
                    lichSuUngTuyen.TaiKhoan = reader["tk"].ToString();
                    lichSuUngTuyen.TenCongTy = reader["TenCongTy"].ToString();
                    lichSuUngTuyen.TenCongTy = reader["TenCongTy"].ToString();
                    lichSuUngTuyen.MaSoThue = reader["MaSoThue"].ToString();
                    lichSuUngTuyen.SDT = reader["SDT"].ToString();
                    lichSuUngTuyen.QuyMo = reader["QuyMo"].ToString();
                    lichSuUngTuyen.ChucDanh = reader["ChucDanh"].ToString();
                    lichSuUngTuyen.NganhNghe = reader["NganhNghe"].ToString();
                    lichSuUngTuyen.HinhThucLV = reader["HinhThucLV"].ToString();
                    lichSuUngTuyen.BangCap = reader["BangCap"].ToString();
                    lichSuUngTuyen.KinhNghiem = reader["KinhNghiem"].ToString();
                    lichSuUngTuyen.YeuCauGioiTinh = reader["YeuCauGioiTinh"].ToString();
                    lichSuUngTuyen.HanNopHoSo = Convert.ToDateTime(reader["HanNopHoSo"]);
                    lichSuUngTuyen.TinhThanh = reader["TinhThanh"].ToString();
                    lichSuUngTuyen.QuanHuyen = reader["QuanHuyen"].ToString();
                    lichSuUngTuyen.SoNha = reader["SoNha"].ToString();
                    lichSuUngTuyen.MucluongToiThieu = Convert.ToSingle(reader["MucluongToiThieu"]);
                    lichSuUngTuyen.MucLuongToiDa = Convert.ToSingle(reader["MucLuongToiDa"]);
                    lichSuUngTuyen.DoTuoiToiThieu = (int)Convert.ToSingle(reader["DoTuoiToiThieu"]);
                    lichSuUngTuyen.DoTuoiToiDa = (int)Convert.ToSingle(reader["DoTuoiToiDa"]);
                    lichSuUngTuyen.KiNang = reader["KiNang"].ToString();
                    lichSuUngTuyen.MoTaCV = reader["MoTaCV"].ToString();
                    lichSuUngTuyen.YeuCauCV = reader["YeuCauCV"].ToString();
                    lichSuUngTuyen.QuyenLoi = reader["QuyenLoi"].ToString();
                    lichSuUngTuyen.AnhLogo = KiemTraDauVao.ChuyenAnhSangByte((byte[])reader["AnhLogo"]);
                    lichSuUngTuyen.TKUngTuyen = reader["TKUngTuyen"].ToString();
                    lichSuUngTuyen.MaDangTin = (int)Convert.ToSingle(reader["MaDangTin"]);
                    lichSuUngTuyen.NgayNop = Convert.ToDateTime(reader["NgayNop"]);
                    lichSuUngTuyens.Add(lichSuUngTuyen);
                }
            }
            return lichSuUngTuyens;
        }
    }
}
