using Job;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job
{
    public class CVDAO
    {
        private string connectionString;
        public CVDAO()
        {
            this.connectionString = Properties.Settings.Default.Connection;
        }
        public void ThemCV(CV cv)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO CV (tk, HoTen, NgaySinh, SDT, GioiTinh, BangCap, DiaChi, ViTriMongMuon, Gmail, MucTieuNgheNghiep, TenTruong, ChuyenNganh, HocVanTGDau, HocVanTGKet, LoaiTotNghiep, TenCongTy, KNTGDau, KNTGKet, ViTriCongViec, KinhNghiem, KiNang, ChungChi, AnhDaiDien)
                                 VALUES (@tk, @HoTen, @NgaySinh, @SDT, @GioiTinh, @BangCap, @DiaChi, @ViTriMongMuon, @Gmail, @MucTieuNgheNghiep, @TenTruong, @ChuyenNganh, @HocVanTGDau, @HocVanTGKet, @LoaiTotNghiep, @TenCongTy, @KNTGDau, @KNTGKet, @ViTriCongViec, @KinhNghiem, @KiNang, @ChungChi, @AnhDaiDien)";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@tk", cv.TaiKhoan);
                command.Parameters.AddWithValue("@HoTen", cv.HoTen);
                command.Parameters.AddWithValue("@NgaySinh", cv.NgaySinh);
                command.Parameters.AddWithValue("@SDT", cv.SDT);
                command.Parameters.AddWithValue("@GioiTinh", cv.GioiTinh);
                command.Parameters.AddWithValue("@BangCap", cv.BangCap);
                command.Parameters.AddWithValue("@DiaChi", cv.DiaChi);
                command.Parameters.AddWithValue("@ViTriMongMuon", cv.ViTriMongMuon);
                command.Parameters.AddWithValue("@Gmail", cv.Gmail);
                command.Parameters.AddWithValue("@MucTieuNgheNghiep", cv.MucTieuNgheNghiep);
                command.Parameters.AddWithValue("@TenTruong", cv.TenTruong);
                command.Parameters.AddWithValue("@ChuyenNganh", cv.ChuyenNganh);
                command.Parameters.AddWithValue("@HocVanTGDau", cv.HocVanTGDau);
                command.Parameters.AddWithValue("@HocVanTGKet", cv.HocVanTGKet);
                command.Parameters.AddWithValue("@LoaiTotNghiep", cv.LoaiTotNghiep);
                command.Parameters.AddWithValue("@TenCongTy", cv.TenCongTy);
                command.Parameters.AddWithValue("@KNTGDau", cv.KNTGDau);
                command.Parameters.AddWithValue("@KNTGKet", cv.KNTGKet);
                command.Parameters.AddWithValue("@ViTriCongViec", cv.ViTriCongViec);
                command.Parameters.AddWithValue("@KinhNghiem", cv.KinhNghiem);
                command.Parameters.AddWithValue("@KiNang", cv.KiNang);
                command.Parameters.AddWithValue("@ChungChi", cv.ChungChi);
                command.Parameters.AddWithValue(@"AnhDaiDien", KiemTraDauVao.ChuyenByteSanhAnh(cv.AnhDaiDien));
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public CV XemCV(string taiKhoan)
        {
            CV cv = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM CV WHERE tk = @tk";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@tk", taiKhoan);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Image anhDaiDien = KiemTraDauVao.ChuyenAnhSangByte((byte[])reader["AnhDaiDien"]);
                    string hoTen = reader["HoTen"].ToString();
                    string ngaySinh = reader["NgaySinh"].ToString();
                    string sDT = reader["SDT"].ToString();
                    string gioiTinh = reader["GioiTinh"].ToString();
                    string bangCap = reader["BangCap"].ToString();
                    string diaChi = reader["ViTriMongMuon"].ToString();
                    string viTriMongMuon = reader["ViTriMongMuon"].ToString();
                    string gmail = reader["Gmail"].ToString();
                    string mucTieuNgheNghiep = reader["MucTieuNgheNghiep"].ToString();
                    string tenTruong = reader["TenTruong"].ToString();
                    string chuyenNganh = reader["ChuyenNganh"].ToString();
                    string hocVanTGDau = reader["HocVanTGDau"].ToString();
                    string hocVanTGKet = reader["HOcVanTGKet"].ToString();
                    string loaiTotNghiep = reader["LoaiTotNghiep"].ToString();
                    string tenCongTy = reader["TenCongTy"].ToString();
                    string kNTGdau = reader["KNTGDau"].ToString();
                    string kNTGKet = reader["KNTGKet"].ToString();
                    string viTriCongViec = reader["ViTriCongViec"].ToString();
                    string kinhNghiem = reader["KinhNghiem"].ToString();
                    string kiNang = reader["KiNang"].ToString();
                    string chungChi = reader["ChungChi"].ToString();


                    cv = new CV(hoTen, DateTime.Parse(ngaySinh), sDT, gioiTinh, bangCap, diaChi, viTriMongMuon, gmail, mucTieuNgheNghiep, tenTruong, chuyenNganh, DateTime.Parse(hocVanTGDau), DateTime.Parse(hocVanTGKet), loaiTotNghiep, tenCongTy, DateTime.Parse(kNTGdau), DateTime.Parse(kNTGKet), viTriCongViec, kinhNghiem, kiNang, chungChi, anhDaiDien);
                }
                return cv;
            }
        }
        public void SuaCV(CV cv)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"UPDATE CV SET HoTen = @HoTen, NgaySinh = @NgaySinh, SDT = @SDT, GioiTinh = @GioiTinh, BangCap = @BangCap, DiaChi = @DiaChi, ViTriMongMuon = @ViTriMongMuon, Gmail = @Gmail, MucTieuNgheNghiep = @MucTieuNgheNghiep, TenTruong = @TenTruong, ChuyenNganh = @ChuyenNganh, HocVanTGDau = @HocVanTGDau, HocVanTGKet = @HocVanTGKet, LoaiTotNghiep = @LoaiTotNghiep, TenCongTy = @TenCongTy, KNTGDau = @KNTGDau, KNTGKet = @KNTGKet, ViTriCongViec = @ViTriCongViec, KinhNghiem = @KinhNghiem, KiNang = @KiNang, ChungChi = @ChungChi, AnhDaiDien = @AnhDaiDien WHERE tk = @tk";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@HoTen", cv.HoTen);
                command.Parameters.AddWithValue("@NgaySinh", cv.NgaySinh);
                command.Parameters.AddWithValue("@SDT", cv.SDT);
                command.Parameters.AddWithValue("@GioiTinh", cv.GioiTinh);
                command.Parameters.AddWithValue("@BangCap", cv.BangCap);
                command.Parameters.AddWithValue("@DiaChi", cv.DiaChi);
                command.Parameters.AddWithValue("@ViTriMongMuon", cv.ViTriMongMuon);
                command.Parameters.AddWithValue("@Gmail", cv.Gmail);
                command.Parameters.AddWithValue("@MucTieuNgheNghiep", cv.MucTieuNgheNghiep);
                command.Parameters.AddWithValue("@TenTruong", cv.TenTruong);
                command.Parameters.AddWithValue("@ChuyenNganh", cv.ChuyenNganh);
                command.Parameters.AddWithValue("@HocVanTGDau", cv.HocVanTGDau);
                command.Parameters.AddWithValue("@HocVanTGKet", cv.HocVanTGKet);
                command.Parameters.AddWithValue("@LoaiTotNghiep", cv.LoaiTotNghiep);
                command.Parameters.AddWithValue("@TenCongTy", cv.TenCongTy);
                command.Parameters.AddWithValue("@KNTGDau", cv.KNTGDau);
                command.Parameters.AddWithValue("@KNTGKet", cv.KNTGKet);
                command.Parameters.AddWithValue("@ViTriCongViec", cv.ViTriCongViec);
                command.Parameters.AddWithValue("@KinhNghiem", cv.KinhNghiem);
                command.Parameters.AddWithValue("@KiNang", cv.KiNang);
                command.Parameters.AddWithValue("@ChungChi", cv.ChungChi);
                command.Parameters.AddWithValue("@AnhDaiDien", KiemTraDauVao.ChuyenByteSanhAnh(cv.AnhDaiDien));
                command.Parameters.AddWithValue("@tk", cv.TaiKhoan);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public List<CV> NhanThongTinCV()
        {
            List<CV> cVs = new List<CV>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = $"select * from CV";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    CV cv = new CV();
                    cv.TaiKhoan = reader["tk"].ToString();
                    cv.MaCV = (int)Convert.ToSingle(reader["MaCV"]);
                    cv.HoTen = reader["HoTen"].ToString();
                    cv.NgaySinh = Convert.ToDateTime(reader["NgaySinh"]);
                    cv.SDT = reader["SDT"].ToString();
                    cv.GioiTinh = reader["GioiTinh"].ToString();
                    cv.BangCap = reader["BangCap"].ToString();
                    cv.DiaChi = reader["DiaChi"].ToString();
                    cv.ViTriMongMuon = reader["ViTriMongMuon"].ToString();
                    cv.Gmail = reader["Gmail"].ToString();
                    cv.MucTieuNgheNghiep = reader["MucTieuNgheNghiep"].ToString();
                    cv.TenTruong = reader["TenTruong"].ToString();
                    cv.ChuyenNganh = reader["ChuyenNganh"].ToString();
                    cv.HocVanTGDau = Convert.ToDateTime(reader["HocVanTGDau"]);
                    cv.HocVanTGKet = Convert.ToDateTime(reader["HocVanTGKet"]);
                    cv.LoaiTotNghiep = reader["LoaiTotNghiep"].ToString();
                    cv.TenCongTy = reader["TenCongTy"].ToString();
                    cv.KNTGDau = Convert.ToDateTime(reader["KNTGDau"]);
                    cv.KNTGKet = Convert.ToDateTime(reader["KNTGKet"]);
                    cv.ViTriCongViec = reader["ViTriCongViec"].ToString();
                    cv.KinhNghiem = reader["KinhNghiem"].ToString();
                    cv.KiNang = reader["KiNang"].ToString();
                    cv.ChungChi = reader["ChungChi"].ToString();
                    cv.AnhDaiDien = KiemTraDauVao.ChuyenAnhSangByte((byte[])reader["AnhDaiDien"]);

                    cVs.Add(cv);
                }
            }
            return cVs;
        }
    }
}
