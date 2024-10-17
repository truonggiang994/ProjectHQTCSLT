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
    public partial class FLichSuUngTuyen : Form
    {
        public FLichSuUngTuyen()
        {
            InitializeComponent();
        }
        private void TaiDuLieu()
        {
            if (DuLieuCV.lichSuUngTuyens.Count == 0)
            {
                FNguoiUngTuyen.Instance.MoFCon(new FThongBao("Bạn chưa nộp hồ sơ vào cho một công ty, vui lòng nộp hồ sơ trước!", "Tìm việc", new FViecLam()));
            }
            else
            {
                foreach (LichSuUngTuyen lichSuUngTuyen in DuLieuCV.lichSuUngTuyens)
                {
                    UngTuyen ungTuyen = DuLieuCV.thongTinUngTuyens.Find(x => x.TKUngTuyen.Trim() == TaiKhoan.TaiKhoanDangNhap.TK && x.ID == lichSuUngTuyen.MaDangTin);
                    PhongVan phongVan = DuLieuCV.phongVans.Find(x => x.TKUngTuyen.Trim() == TaiKhoan.TaiKhoanDangNhap.TK && x.MaDangTin == lichSuUngTuyen.MaDangTin);
                    UserControlLSUngTuyen userControl = new UserControlLSUngTuyen(lichSuUngTuyen, ungTuyen,phongVan);
                    flowLayoutPanelChinh.Controls.Add(userControl);
                }
            }
        }

        private void FLichSuUngTuyen_Load(object sender, EventArgs e)
        {
            TaiDuLieu();
        }
    }
}
