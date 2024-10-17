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
    public partial class FViecLamYeuThich : Form
    {
        public FViecLamYeuThich()
        {
            InitializeComponent();
        }
        private void TaiDuLieu()
        {
            foreach (ThongTinViecLam congViec in DuLieuCV.ThongTinViecLams)
            {

                ViecLamYeuThich viecLamYeuThich = DuLieuCV.viecLamYeuThichs.Find(x => x.TaiKhoan == TaiKhoan.TaiKhoanDangNhap.TK && x.ID == congViec.Id);
                if (viecLamYeuThich != null)
                {
                    UserControlViecLam userControl = new UserControlViecLam(congViec, viecLamYeuThich);
                    flowLayoutPanelChinh.Controls.Add(userControl);
                      
                }
            }
            if (flowLayoutPanelChinh.Controls.Count == 0)
            {
                FNguoiUngTuyen.Instance.MoFCon(new FThongBao("Bạn chưa yêu thích việc làm nào, vui lòng nhấn yêu thích việc làm trước!", "Việc làm", new FViecLam()));
            }  
        }

        private void FViecLamYeuThich_Load(object sender, EventArgs e)
        {
            TaiDuLieu();
        }
    }
}
