using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job
{
    public class UngTuyen
    {
        public string TKDangTin { get; private set; }
        public int MaCV { get; private set; }
        public int ID {  get; private set; }
        public string TKUngTuyen { get; private set; }
        public DateTime NgayNop { get; private set; }
        public UngTuyen() { }
        public UngTuyen(string tKDangTin, int maCV, int iD, string tKUngTuyen)
        {
            TKDangTin = tKDangTin;
            MaCV = maCV;
            ID = iD;
            TKUngTuyen = tKUngTuyen;
        }

        public UngTuyen(string tKDangTin, int maCV, int iD, string tKUngTuyen, DateTime ngayNop)
        {
            TKDangTin = tKDangTin;
            MaCV = maCV;
            ID = iD;
            TKUngTuyen = tKUngTuyen;
            NgayNop = ngayNop;
        }
    }
}
