using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job
{
    public class DuLieuUngTuyenDAO
    {
        private string connectionString;

        public DuLieuUngTuyenDAO()
        {
            this.connectionString = Properties.Settings.Default.Connection;
        }

        public List<DuLieuUngTuyen> NhanDuLieuUngTuyen()
        {
            List<DuLieuUngTuyen> duLieuUngTuyens = new List<DuLieuUngTuyen>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = $"select * from DuLieuDangTin inner join CV on CV.MaCV = DuLieuDangTin.MaCV and DuLieuDangTin.TKDangTin = '{TaiKhoan.TaiKhoanDangNhap.TK}'";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    DuLieuUngTuyen duLieuUngTuyen = new DuLieuUngTuyen();
                    duLieuUngTuyen.TaiKhoan = reader["tk"].ToString();
                    duLieuUngTuyen.MaCV = (int)Convert.ToSingle(reader["MaCV"]);
                    duLieuUngTuyen.HoTen = reader["HoTen"].ToString();
                    duLieuUngTuyen.NgaySinh = Convert.ToDateTime(reader["NgaySinh"]);
                    duLieuUngTuyen.SDT = reader["SDT"].ToString();
                    duLieuUngTuyen.GioiTinh = reader["GioiTinh"].ToString();
                    duLieuUngTuyen.BangCap = reader["BangCap"].ToString();
                    duLieuUngTuyen.DiaChi = reader["DiaChi"].ToString();
                    duLieuUngTuyen.ViTriMongMuon = reader["ViTriMongMuon"].ToString();
                    duLieuUngTuyen.Gmail = reader["Gmail"].ToString();
                    duLieuUngTuyen.MucTieuNgheNghiep = reader["MucTieuNgheNghiep"].ToString();
                    duLieuUngTuyen.TenTruong = reader["TenTruong"].ToString();
                    duLieuUngTuyen.ChuyenNganh = reader["ChuyenNganh"].ToString();
                    duLieuUngTuyen.HocVanTGDau = Convert.ToDateTime(reader["HocVanTGDau"]);
                    duLieuUngTuyen.HocVanTGKet = Convert.ToDateTime(reader["HocVanTGKet"]);
                    duLieuUngTuyen.LoaiTotNghiep = reader["LoaiTotNghiep"].ToString();
                    duLieuUngTuyen.TenCongTy = reader["TenCongTy"].ToString();
                    duLieuUngTuyen.KNTGDau = Convert.ToDateTime(reader["KNTGDau"]);
                    duLieuUngTuyen.KNTGKet = Convert.ToDateTime(reader["KNTGKet"]);
                    duLieuUngTuyen.ViTriCongViec = reader["ViTriCongViec"].ToString();
                    duLieuUngTuyen.KinhNghiem = reader["KinhNghiem"].ToString();
                    duLieuUngTuyen.KiNang = reader["KiNang"].ToString();
                    duLieuUngTuyen.ChungChi = reader["ChungChi"].ToString();
                    duLieuUngTuyen.AnhDaiDien = KiemTraDauVao.ChuyenAnhSangByte((byte[])reader["AnhDaiDien"]);
                    duLieuUngTuyen.MaDangTin = (int)Convert.ToSingle(reader["MaDangTin"]);
                    duLieuUngTuyen.TKUngTuyen = reader["TKUngTuyen"].ToString();
                    duLieuUngTuyen.NgayNop = Convert.ToDateTime(reader["NgayNop"]);

                    duLieuUngTuyens.Add(duLieuUngTuyen);
                }
            }
            return duLieuUngTuyens;
        }
    }
}
