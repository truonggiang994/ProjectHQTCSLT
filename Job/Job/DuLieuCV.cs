using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Job
{
    static public class DuLieuCV
    {
        static public CV CV { get; private set; }
        public static List<ThongTinViecLam> ThongTinViecLams;
        public static List<DangTin> lichSuNopHoSo;
        public static List<ViecLamYeuThich> viecLamYeuThichs;
        public static List<CV> cVs;
        public static List<LichSuUngTuyen> lichSuUngTuyens;
        public static List<UngTuyen> thongTinUngTuyens;
        public static List<CamNang> camNangs;
        public static List<PhongVan> phongVans;
        public static List <DanhGia> danhGias;
        public static CVDAO CVDAO { get; private set; }
        public static ThongTinViecLamDAO ThongTinViecLamDAO { get; private set; }
        public static ViecLamYeuThichDAO ViecLamYeuThichDAO { get; private set; }
        public static LichSuUngTuyenDAO LichSuUngTuyenDAO { get; private set; }
        public static DangTinDao DangTinDao { get; private set; }
        public static UngTuyenDAO UngTuyenDAO { get; private set; }
        public static CamNangDAO CamNangDAO { get; private set; }
        public static PhongVanDAO PhongVanDAO { get; private set; }
        public static DanhGiaDAO DanhGiaDAO { get; private set; }

        static DuLieuCV()
        {
            CV = new CV();
            CVDAO = new CVDAO();
            ThongTinViecLams = new List<ThongTinViecLam>();
            lichSuNopHoSo = new List<DangTin>();
            ThongTinViecLamDAO = new ThongTinViecLamDAO();
            ViecLamYeuThichDAO = new ViecLamYeuThichDAO();
            cVs = new List<CV> ();
            DangTinDao = new DangTinDao();
            LichSuUngTuyenDAO = new LichSuUngTuyenDAO();
            viecLamYeuThichs = new List<ViecLamYeuThich>();
            lichSuUngTuyens = new List<LichSuUngTuyen> ();
            thongTinUngTuyens = new List<UngTuyen>();
            UngTuyenDAO = new UngTuyenDAO();
            camNangs = new List<CamNang> ();
            CamNangDAO = new CamNangDAO();
            phongVans = new List<PhongVan> ();
            PhongVanDAO = new PhongVanDAO();
            danhGias = new List<DanhGia> ();
            DanhGiaDAO = new DanhGiaDAO();  

        }

        public static void NhanCV(string taiKhoan)//Dữ liệu nhận CV
        {
            CV = CVDAO.XemCV(taiKhoan);
        }

        public static void NhanThongTinCV()
        {
            cVs = CVDAO.NhanThongTinCV();
        }

        public static void NhanThongTinCongViec()//Dữ liệu nhận thông tin công việc để CV xem
        {
            ThongTinViecLams = ThongTinViecLamDAO.NhanThongTinViecLam();
        }

        public static void NhanThongTinYeuThich()//Dữ liệu nhận thông tin công việc yêu thích
        {
            viecLamYeuThichs = ViecLamYeuThichDAO.NhanViecLamYeuThich();
        }

        public static void NhanLichSuUngTuyen()//Dữ liệu nhận lịch sử yêu thích
        {
            lichSuUngTuyens = LichSuUngTuyenDAO.NhanLichSuUngTuyen();
        }

        public static void NhanThongTinUngTuyen()//Dữ liệu nhận thông tin công việc yêu thích
        {
            thongTinUngTuyens = UngTuyenDAO.NhanThongTinUngTuyen();
        }

        public static void NhanThongTinCamNang()
        {
            camNangs = CamNangDAO.NhanThongTinCamNang();
        }

        public static void NhanThongTinPhongVan()
        {
            phongVans = PhongVanDAO.NhanThongTinPhongVan();
        }
        public static void NhanThongTinDanhGia()
        {
            danhGias = DanhGiaDAO.NhanDanhGia();
        }

        public static void NopHoSo(string taiKhoanDangTin, int maDangTin, int maCV, DateTime ngayNop, string taiKhoanUngTuyen)// Thêm dữ liệu nộp hồ sơ
        {
            ThongTinViecLamDAO.LuuThongTinUngVien(taiKhoanDangTin, maDangTin,maCV, ngayNop, taiKhoanUngTuyen);
            ThongTinViecLam thongTinViecLam = ThongTinViecLams.Find(x => x.Id == maDangTin);
            lichSuNopHoSo.Add((DangTin)thongTinViecLam);
        }
        public static void ThemYeuThich(ViecLamYeuThich viecLamYeuThich)
        {
            ViecLamYeuThichDAO.ThemYeuThichCongViec(viecLamYeuThich);
            viecLamYeuThichs.Add(viecLamYeuThich);
        }
        public static void XoaYeuThich(ViecLamYeuThich viecLamYeuThich)
        {
            ViecLamYeuThichDAO.XoaYeuThichCongViec(viecLamYeuThich);
            viecLamYeuThichs.Remove(viecLamYeuThich);
        }
    }
}
