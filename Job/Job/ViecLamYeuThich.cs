using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job
{
    public class ViecLamYeuThich
    {
        public string TaiKhoan { get; private set; }
        public int ID {  get; private set; }
        public ViecLamYeuThich  (string taiKhoan, int iD)
        {
            TaiKhoan = taiKhoan;
            ID = iD;
        }

    }
}
