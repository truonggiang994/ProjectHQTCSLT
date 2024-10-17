using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job
{
    public class LichSuUngTuyen : ThongTinViecLam
    {
        public int MaDangTin { get; set; }
        public string TKUngTuyen { get; set; }
        public DateTime NgayNop { get; set; }
        public LichSuUngTuyen()
        {
        }
    }
}
