using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Job
{
    public class DanhGia
    {
        public int MaDanhGia {  get; set; }
        public float SoSao {  get; set; }
        public string TKDanhGia { get; set; }
        public string TKCongTy {  get; set; }

        public Image Anh { get; set; }
        public string NoiDung { get; set; }

        public DanhGia() { }

        public DanhGia(int maDanhGia, float soSao, string tKDanhGia, string tKCongTy, Image anh, string noiDung)
        {
            MaDanhGia = maDanhGia;
            SoSao = soSao;
            TKDanhGia = tKDanhGia;
            TKCongTy = tKCongTy;
            Anh = anh;
            NoiDung = noiDung;
        }
    }
}
