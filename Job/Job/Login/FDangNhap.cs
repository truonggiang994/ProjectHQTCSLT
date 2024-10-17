using Job.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Job
{
    public partial class FDangNhap : Form
    {
        private ThongTinViecLamDAO thongTinViecLamDao;
        private TaiKhoanDao taiKhoanDao;
        public FDangNhap()
        {
            InitializeComponent();
            taiKhoanDao = new TaiKhoanDao();
            thongTinViecLamDao = new ThongTinViecLamDAO();
            CenterToScreen();
        }
        
        private void buttonDangNhap_Click(object sender, EventArgs e)
        {
            string taiKhoan = textBoTaiKhoan.Text;
            string matKhau = textBoxMK.Text;

            if (KiemTraDauVao.KiemTra(taiKhoan, matKhau))
            {
                if (taiKhoanDao.DangNhap(taiKhoan, matKhau))
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK);
                    TaiKhoan.TaiKhoanDangNhap = new TaiKhoan(taiKhoan, matKhau);
                    FNguoiUngTuyen fNguoiUngTuyen = new FNguoiUngTuyen();
                    this.Hide();
                    fNguoiUngTuyen.Show();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!", "Thông báo", MessageBoxButtons.OK);
                }
            }
            
        }
    
        private void linkLabelDangki_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FDangKi dk = new FDangKi();
            this.Hide();
            dk.ShowDialog();
        }

        private void linkLabelQuenMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FQuenMK quenMK = new FQuenMK();
            this.Hide();
            quenMK.ShowDialog();
        }
    }
}
