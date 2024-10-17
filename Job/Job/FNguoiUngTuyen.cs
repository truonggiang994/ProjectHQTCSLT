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
    public partial class FNguoiUngTuyen : Form
    {
        static public FNguoiUngTuyen Instance { get; private set; }

        public FNguoiUngTuyen()
        {
            Instance = this;
            DuLieuCV.NhanCV(TaiKhoan.TaiKhoanDangNhap.TK);
            DuLieuCV.NhanThongTinCV();
            DuLieuCV.NhanThongTinUngTuyen();
            DuLieuCV.NhanThongTinCongViec();
            DuLieuCV.NhanThongTinYeuThich();
            DuLieuCV.NhanLichSuUngTuyen();
            DuLieuCV.NhanThongTinPhongVan();
            DuLieuCV.NhanThongTinDanhGia();
            DuLieuCV.NhanThongTinCamNang();
            InitializeComponent();
            labelUser.Text = TaiKhoan.TaiKhoanDangNhap.TK;
        }

        
        public void MoFCon(Form fCon)
        {
            fCon.TopLevel = false;
            fCon.Size = panel.Size;
            fCon.Location = new Point(0, 0);
            fCon.Tag = this;
            panel.Controls.Add(fCon);
            fCon.BringToFront();
            fCon.Show();
        }
        
        private void buttonTrangChu_Click(object sender, EventArgs e)
        {
            MoFCon(new FTrangChu());
        }
        
        private void buttonCoHoiVL_Click(object sender, EventArgs e)
        {
            MoFCon(new FViecLam());
        }

        private void buttonCV_Click(object sender, EventArgs e)
        {
            MoFCon(new FCV());
        }

        
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FNhaTuyenDung fNhaTuyenDung = new FNhaTuyenDung();
            this.Hide();
            fNhaTuyenDung.Show();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            FDangNhap dn = new FDangNhap();
            this.Hide();
            dn.Show();
        }

        private void buttonVLDaUngTuyen_Click(object sender, EventArgs e)
        {
            FLichSuUngTuyen fLichSuUngTuyen = new FLichSuUngTuyen();
            MoFCon(fLichSuUngTuyen);
        }

        private void buttonXemCV_Click(object sender, EventArgs e)
        {
            
            MoFCon(new FXemCV(DuLieuCV.CV));
        }

        private void buttonVLYeuThich_Click(object sender, EventArgs e)
        {
            FViecLamYeuThich fViecLamYeuThich = new FViecLamYeuThich();
            MoFCon(fViecLamYeuThich);
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            MoFCon(new FTrangChu());
        }
    }
}
