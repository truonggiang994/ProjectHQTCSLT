using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job
{
    public class CongTy
    {
        public string TaiKhoan { get; private set; }
        public string TenCongTy{ get; private set; }
        public string MaSoThue {  get; private set; }
        public string SDT { get; private set; }
        public string QuyMoNhanSu { get; private set; }
        public string DiaDiem { get; private set; }
        public string DiaChi { get; private set; }
        public Image LoGo { get; private set; }
        public Image GiayPhepKinhDoanh {  get; private set; }
        public string NguoiDungDau {  get; private set; }
        public string Gmail {  get; private set; }
        public Image AnhBia { get; private set; }
        public CongTy() { }
        public CongTy(string taiKhoan, string tenCongTy, string maSoThue, string sDT, string quyMoNhanSu, string diaDiem, string diaChi, Image loGo, Image giayPhepKinhDoanh)
        {
            TaiKhoan = taiKhoan;
            TenCongTy = tenCongTy;
            MaSoThue = maSoThue;
            SDT = sDT;
            QuyMoNhanSu  = quyMoNhanSu;
            DiaDiem = diaDiem;
            DiaChi = diaChi;
            LoGo = loGo;
            GiayPhepKinhDoanh = giayPhepKinhDoanh;
        }
        public CongTy(string taiKhoan, string tenCongTy, string maSoThue, string sDT, string quyMoNhanSu, string diaDiem, string diaChi, Image loGo, Image giayPhepKinhDoanh, string nguoiDungDau, string gmail, Image anhBia)
        {
            TaiKhoan = taiKhoan;
            TenCongTy = tenCongTy;
            MaSoThue = maSoThue;
            SDT = sDT;
            QuyMoNhanSu = quyMoNhanSu;
            DiaDiem = diaDiem;
            DiaChi = diaChi;
            LoGo = loGo;
            GiayPhepKinhDoanh = giayPhepKinhDoanh;
            NguoiDungDau = nguoiDungDau;
            Gmail = gmail;
            AnhBia = anhBia;
        }
    }
}
