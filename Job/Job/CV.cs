using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Job
{
    public class CV
    {
        public string TaiKhoan { get;  set; }
        public int MaCV { get; set; }
        public Image AnhDaiDien {  get;  set; }
        public string HoTen { get;  set; }
        public DateTime NgaySinh {  get;  set; }
        public string SDT {  get;  set; }
        public string GioiTinh {  get;  set; }
        public string BangCap {  get;  set; }
        public string DiaChi {  get;  set; }
        public string ViTriMongMuon { get;  set; }
        public string Gmail {get;  set; }
        public string MucTieuNgheNghiep {  get;  set; }
        public string TenTruong {  get;  set; }
        public string ChuyenNganh {  get;  set; }
        public DateTime HocVanTGDau {  get;  set; }
        public DateTime HocVanTGKet { get;  set; }
        public string LoaiTotNghiep { get;  set; }
        public string TenCongTy {  get;  set; }
        public DateTime KNTGDau { get;  set; }
        public DateTime KNTGKet { get;  set; }
        public string ViTriCongViec {  get;  set; }
        public string KinhNghiem {  get;  set; }
        public string KiNang {  get;  set; }
        public string ChungChi {  get;  set; }
        public CV() { }
        public CV(string taiKhoan, string hoTen, DateTime ngaySinh, string sDT, string gioiTinh, string bangCap, string diaChi, string viTriMongMuon, string gmail, string mucTieuNgheNghiep, string tenTruong, string chuyenNganh, DateTime hocVanTGDau, DateTime hocVanTGKet, string loaiTotNghiep, string tenCongTy, DateTime kNTGDau, DateTime kNTGKet, string viTriCongViec, string kinhNghiem, string kiNang, string chungChi, Image anhDaiDien)
        {
            TaiKhoan = taiKhoan;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            SDT = sDT;
            GioiTinh = gioiTinh;
            BangCap = bangCap;
            DiaChi = diaChi;
            ViTriMongMuon = viTriMongMuon;
            Gmail = gmail;
            MucTieuNgheNghiep = mucTieuNgheNghiep;
            TenTruong = tenTruong;
            ChuyenNganh = chuyenNganh;
            HocVanTGDau = hocVanTGDau;
            HocVanTGKet = hocVanTGKet;
            LoaiTotNghiep = loaiTotNghiep;
            TenCongTy = tenCongTy;
            KNTGDau = kNTGDau;
            KNTGKet = kNTGKet;
            ViTriCongViec = viTriCongViec;
            KinhNghiem = kinhNghiem;
            KiNang = kiNang;
            ChungChi = chungChi;
            AnhDaiDien = anhDaiDien;
        }

        public CV(string hoTen, DateTime ngaySinh, string sDT, string gioiTinh, string bangCap, string diaChi, string viTriMongMuon, string gmail, string mucTieuNgheNghiep, string tenTruong, string chuyenNganh, DateTime hocVanTGDau, DateTime hocVanTGKet, string loaiTotNghiep, string tenCongTy, DateTime kNTGDau, DateTime kNTGKet, string viTriCongViec, string kinhNghiem, string kiNang, string chungChi, Image anhDaiDien)
        {
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            SDT = sDT;
            GioiTinh = gioiTinh;
            BangCap = bangCap;
            DiaChi = diaChi;
            ViTriMongMuon = viTriMongMuon;
            Gmail = gmail;
            MucTieuNgheNghiep = mucTieuNgheNghiep;
            TenTruong = tenTruong;
            ChuyenNganh = chuyenNganh;
            HocVanTGDau = hocVanTGDau;
            HocVanTGKet = hocVanTGKet;
            LoaiTotNghiep = loaiTotNghiep;
            TenCongTy = tenCongTy;
            KNTGDau = kNTGDau;
            KNTGKet = kNTGKet;
            ViTriCongViec = viTriCongViec;
            KinhNghiem = kinhNghiem;
            KiNang = kiNang;
            ChungChi = chungChi;
            AnhDaiDien = anhDaiDien;
        }
    }
}
