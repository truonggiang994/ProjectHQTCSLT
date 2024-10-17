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
    public partial class FHoSoUngTuyen : Form
    {
        private int dem;
        public FHoSoUngTuyen()
        {
            InitializeComponent();
        }
        private void TaiDuLieu()
        {
            foreach (DuLieuUngTuyen duLieuUngTuyen in DuLieuCongTy.duLieuUngTuyens)
            {
                UngTuyen ungTuyen = DuLieuCongTy.ungTuyens.Find(x => x.TKDangTin == TaiKhoan.TaiKhoanDangNhap.TK && x.MaCV == duLieuUngTuyen.MaCV );
                PhongVan phongVan = DuLieuCongTy.phongVans.Find(x => x.TKDangTin.Trim() == TaiKhoan.TaiKhoanDangNhap.TK && x.MaCV == duLieuUngTuyen.MaCV && x.MaDangTin == duLieuUngTuyen.MaDangTin);
                UserControlUngVien userControl = new UserControlUngVien(duLieuUngTuyen, ungTuyen, phongVan);
                flowLayoutPanelChinh.Controls.Add(userControl);
            }
            if (flowLayoutPanelChinh.Controls.Count == 0)
            {
                FNhaTuyenDung.Instance.MoFCon(new FThongBaoNhaUngTuyen("Công ty chưa có ứng viên nào ứng tuyển!", "Đồng ý", new FDangTin()));
            }
        }

        private void FHoSoUngTuyen_Load(object sender, EventArgs e)
        {
            TaiDuLieu();
        }
    }
}
