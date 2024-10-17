using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job
{
    public class DangTin
    {
        public CongTy CongTyDaDang { get; private set; }
        public List<CV> ListCVDaNop {  get; private set; }  
        public int Id { get;  set; }
        public string TaiKhoan { get; set; }
        public string ChucDanh { get; set; }
        public string NganhNghe { get; set; }
        public string HinhThucLV { get;  set; }
        public string BangCap { get;  set; }
        public string KinhNghiem { get;  set; }
        public string YeuCauGioiTinh { get;  set; }
        public DateTime HanNopHoSo { get;  set; }
        public string TinhThanh { get;  set; }
        public string QuanHuyen { get;  set; }
        public string SoNha { get;  set; }
        public string KiNang { get;  set; }
        public string MoTaCV { get;  set; }
        public string YeuCauCV { get;  set; }
        public string QuyenLoi {  get;  set; }
        public float MucluongToiThieu { get;  set; }
        public float MucLuongToiDa { get;  set; }
        public int DoTuoiToiThieu { get;  set; }
        public int DoTuoiToiDa { get;  set; }
        public DangTin() { }
        public DangTin(string taiKhoan, string chucDanh, string nganhNghe, string hinhThucLV, string bangCap, string kinhNghiem, string yeuCauGioiTinh, DateTime hanNopHoSo, string tinhThanh, string quanHuyen, string soNha, string kiNang, string moTaCV, string yeucaucv, string quyenloi, float mucluongToiThieu, float mucLuongToiDa, int doTuoiToiThieu, int doTuoiToiDa)
        {
            TaiKhoan = taiKhoan;
            ChucDanh = chucDanh;
            NganhNghe = nganhNghe;
            HinhThucLV = hinhThucLV;
            BangCap = bangCap;
            KinhNghiem = kinhNghiem;
            YeuCauGioiTinh = yeuCauGioiTinh;
            HanNopHoSo = hanNopHoSo;
            TinhThanh = tinhThanh;
            QuanHuyen = quanHuyen;
            SoNha = soNha;
            KiNang = kiNang;
            MoTaCV = moTaCV;
            YeuCauCV = yeucaucv;
            QuyenLoi = quyenloi;
            MucluongToiThieu = mucluongToiThieu;
            MucLuongToiDa = mucLuongToiDa;
            DoTuoiToiThieu = doTuoiToiThieu;
            DoTuoiToiDa = doTuoiToiDa;
        }

        public DangTin(int id, string taiKhoan, string chucDanh, string nganhNghe, string hinhThucLV, string bangCap, string kinhNghiem, string yeuCauGioiTinh, DateTime hanNopHoSo, string tinhThanh, string quanHuyen, string soNha, string kiNang, string moTaCV, string yeuCauCV, string quyenLoi, float mucluongToiThieu, float mucLuongToiDa, int doTuoiToiThieu, int doTuoiToiDa)
        {
            Id = id;
            TaiKhoan = taiKhoan;
            ChucDanh = chucDanh;
            NganhNghe = nganhNghe;
            HinhThucLV = hinhThucLV;
            BangCap = bangCap;
            KinhNghiem = kinhNghiem;
            YeuCauGioiTinh = yeuCauGioiTinh;
            HanNopHoSo = hanNopHoSo;
            TinhThanh = tinhThanh;
            QuanHuyen = quanHuyen;
            SoNha = soNha;
            KiNang = kiNang;
            MoTaCV = moTaCV;
            YeuCauCV = yeuCauCV;
            QuyenLoi = quyenLoi;
            MucluongToiThieu = mucluongToiThieu;
            MucLuongToiDa = mucLuongToiDa;
            DoTuoiToiThieu = doTuoiToiThieu;
            DoTuoiToiDa = doTuoiToiDa;
        }
    }
}
