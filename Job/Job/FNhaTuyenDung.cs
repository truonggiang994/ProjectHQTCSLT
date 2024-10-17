using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Job
{
    public partial class FNhaTuyenDung : Form
    {
        static public FNhaTuyenDung Instance { get; private set; }
        public FNhaTuyenDung()
        {
            Instance = this;
            DuLieuCongTy.NhanThongTinNopCV();
            DuLieuCongTy.NhanCongTy(TaiKhoan.TaiKhoanDangNhap.TK);
            DuLieuCongTy.NhanDangTin();
            DuLieuCongTy.NhanThongTinTuyen();
            DuLieuCongTy.NhanThongTinPhongVan();
            InitializeComponent();
            labelUser.Text = TaiKhoan.TaiKhoanDangNhap.TK;

        }
        
        public void MoFCon(Form fCon)
        {
            fCon.TopLevel = false;
            fCon.Size = panelChinh.Size;
            fCon.Location = new Point(0, 0);
            fCon.Tag = this;
            panelChinh.Controls.Add(fCon);
            fCon.BringToFront();
            fCon.Show();
        }
        

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            FDangNhap dn = new FDangNhap();
            this.Hide();
            dn.Show();
        }

        private void buttonNguoiUngTuyen_Click(object sender, EventArgs e)
        {
            FNguoiUngTuyen fNguoiUngTuyen = new FNguoiUngTuyen();
            this.Hide();
            fNguoiUngTuyen.Show();
        }

        private void buttonDangTin_Click(object sender, EventArgs e)
        {
            MoFCon(new FDangTin());
        }

        private void buttonTT_Click(object sender, EventArgs e)
        {
            MoFCon(new FThongTinCongTy());
        }

        private void buttonTinDaDang_Click(object sender, EventArgs e)
        {
            MoFCon(new FLichSuDangViec());
        }

        private void buttonHoSoUngTuyen_Click(object sender, EventArgs e)
        {
            MoFCon(new FHoSoUngTuyen());
        }

        private void panelChinh_Paint(object sender, PaintEventArgs e)
        {
            MoFCon(new FDangTin());
        }
    }
}
