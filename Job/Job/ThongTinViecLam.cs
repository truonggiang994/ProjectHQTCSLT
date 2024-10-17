using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Job
{
    public class ThongTinViecLam : DangTin
    {
        public int LuotYeuThich {  get; set; }
        public Image AnhLogo { get;  set; }
        public Image AnhGiayPhep { get;  set; }
        public string TenCongTy { get; set; }
        public string MaSoThue { get; set; }
        public string SDT { get; set; }
        public string QuyMo { get; set; }
        public ThongTinViecLam() { }
        
    }
}
