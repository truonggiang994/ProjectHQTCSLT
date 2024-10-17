using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Job
{
    public partial class FDangKi : Form
    {
        private TaiKhoanDao taiKhoanDao;
        public FDangKi()
        {
            InitializeComponent();
            taiKhoanDao = new TaiKhoanDao();
            CenterToScreen();
        }

        private void buttonDangKi_Click(object sender, EventArgs e)
        {
            string taiKhoan = textBoxTaiKhoan.Text;
            string matKhau = textBoxMK.Text;
            string nhapLaiMatKhau = textBoxNhapLaiMK.Text;

            if (KiemTraDauVao.KiemTra(taiKhoan, matKhau))
            {
                if (taiKhoanDao.KiemTraTaiKhoanTonTai(taiKhoan))
                {
                    MessageBox.Show("Tài khoản đã tồn tại!", "Thông báo", MessageBoxButtons.OK);
                    return;
                }

                // Đăng kí tài khoản
                else if (taiKhoanDao.DangKiTaiKhoan(taiKhoan, matKhau))
                {
                    MessageBox.Show("Đăng kí tài khoản thành công!", "Thông báo", MessageBoxButtons.OK);
                    FDangNhap fDangNhap = new FDangNhap();
                    this.Hide();
                    fDangNhap.Show();
                }
                else
                {
                    MessageBox.Show("Đăng kí tài khoản thất bại!", "Thông báo", MessageBoxButtons.OK);
                }
            }
            
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FDangNhap fDangNhap = new FDangNhap();
            this.Hide();
            fDangNhap.Show();
        }

        
    }
}
