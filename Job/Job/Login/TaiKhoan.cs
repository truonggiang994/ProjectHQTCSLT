using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job
{
    internal class TaiKhoan
    {
        public string TK { get; private set; }
        public string MatKhau { get; private set; }
        internal static TaiKhoan TaiKhoanDangNhap { get;  set; }
        public TaiKhoan(string tK, string matKhau)
        {
            TK = tK;
            MatKhau = matKhau;
           
        }
    }
}
