using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Job
{
    public partial class FTopViecLam : Form
    {
        public FTopViecLam()
        {
            InitializeComponent();
            TaiDuLieu();
        }
        private void TaiDuLieu()
        {
            List<ThongTinViecLam> thongTinViecLams = new List<ThongTinViecLam>(DuLieuCV.ThongTinViecLams);
            thongTinViecLams.Sort((x, y) => y.LuotYeuThich.CompareTo(x.LuotYeuThich));
            thongTinViecLams = thongTinViecLams.Take(5).ToList();
            foreach (ThongTinViecLam congViec in thongTinViecLams)
            {
                ViecLamYeuThich viecLamYeuThich = DuLieuCV.viecLamYeuThichs.Find(x => x.TaiKhoan == TaiKhoan.TaiKhoanDangNhap.TK && x.ID == congViec.Id);
                UserControlViecLam userControl = new UserControlViecLam(congViec, viecLamYeuThich);
                flowLayoutPanelCVYT.Controls.Add(userControl);
            }
        }
    }
}
