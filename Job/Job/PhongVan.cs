using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Job
{
    public class PhongVan : DuLieuUngTuyen
    {


        public string TKDangTin { get; set; }
        public string NguoiPhongVan { get; set; }
        public string SDT { get; set; }
        public DateTime NgayPhongVan { get; set; }
        public string DiaChiPhongVan { get; set; }

        public PhongVan() { }
        public PhongVan(string tKUngTuyen, int maCV, int maDangTin, string tKDangTin, string nguoiPhongVan, string sDT, DateTime ngayPhongVan, string diaChiPhongVan, string hoTen)
        {
            this.TKUngTuyen = tKUngTuyen; 
            this.MaCV = maCV;
            this.MaDangTin = maDangTin;
            this.TKDangTin = tKDangTin;
            this.NguoiPhongVan = nguoiPhongVan;
            this.SDT = sDT;
            this.NgayPhongVan = ngayPhongVan;
            this.DiaChiPhongVan = diaChiPhongVan;
            this.HoTen = hoTen;
        }
    }
}
