using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job
{
    class DuLieuCongTy
    {
        static public CongTy CongTy { get; private set; }
        public static CongTyDao CongTyDao { get; private set; }
        public static LichSuDangTinDAO LichSuDangTinDAO { get; private set; }
        public static DuLieuUngTuyenDAO DuLieuUngTuyenDAO { get; private set; }
        public static PhongVanDAO PhongVanDAO { get; private set; }
        public static UngTuyenDAO UngTuyenDAO { get; private set; }
        public static List<LicSuDangTin> licSuDangTins;
        public static List<DuLieuUngTuyen> duLieuUngTuyens;
        public static List<UngTuyen> ungTuyens;
        public static List<PhongVan> phongVans;
        static DuLieuCongTy()
        {
            CongTy = new CongTy();
            DuLieuUngTuyenDAO = new DuLieuUngTuyenDAO();
            LichSuDangTinDAO = new LichSuDangTinDAO();
            CongTyDao = new CongTyDao();
            UngTuyenDAO = new UngTuyenDAO();
            licSuDangTins = new List<LicSuDangTin>();
            duLieuUngTuyens = new List<DuLieuUngTuyen>();
            ungTuyens = new List<UngTuyen>();
            PhongVanDAO = new PhongVanDAO();
            phongVans = new List<PhongVan>();
        }

        public static void NhanCongTy(string taiKhoan)//Dữ liệu nhận công ty
        {
            CongTy = CongTyDao.XemCongTy(taiKhoan);
        }

        public static void NhanThongTinNopCV()
        {
            duLieuUngTuyens = DuLieuUngTuyenDAO.NhanDuLieuUngTuyen();
        }

        public static void NhanDangTin()
        {
           licSuDangTins = LichSuDangTinDAO.NhanLichSuDangTin();
        }
        public static void NhanThongTinPhongVan()
        {
            phongVans = PhongVanDAO.NhanThongTinPhongVan();
        }
        public static void Tuyen(UngTuyen ungTuyen)
        {
            UngTuyenDAO.Tuyen(ungTuyen);
            ungTuyens.Add(ungTuyen);
        }

        public static void NhanThongTinTuyen()//Dữ liệu nhận thông tin tuyển
        {
            ungTuyens = UngTuyenDAO.NhanHoSoUngTuyen();
        }
    }
}
