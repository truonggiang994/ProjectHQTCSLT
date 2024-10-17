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

namespace Job.Login
{
    public partial class FQuenMK : Form
    {
        TaiKhoanDao taiKhoanDao;
        bool isChangingPassword = false; // Biến đánh dấu xem có phải đổi mật khẩu không

        public FQuenMK()
        {
            InitializeComponent();
            taiKhoanDao = new TaiKhoanDao();
            panelMK.Visible = false;
            panelNhapMK.Visible = false;
        }

        private void buttonTim_Click(object sender, EventArgs e)
        {
            string taiKhoan = textBoxTaiKhoan.Text;

            if (!isChangingPassword) // Nếu không phải đổi mật khẩu
            {
                if (taiKhoanDao.KiemTraTaiKhoanTonTai(taiKhoan))
                {
                    MessageBox.Show("Tài khoản tồn tại. Vui lòng nhập mật khẩu mới.");
                    panelMK.Visible = true;
                    panelNhapMK.Visible = true;
                    buttonTim.Text = "Tạo mật khẩu";
                    buttonTim.Image = null;
                    isChangingPassword = true; // Đánh dấu là đang đổi mật khẩu
                }
                else
                {
                    MessageBox.Show("Tài khoản không tồn tại. Vui lòng kiểm tra lại!");
                }
            }
            else 
            {
                string matKhauMoi = textBoxMatKhau.Text;
                string nhapLaiMatKhau = textBoxNhapLaiMK.Text;
                if (KiemTraDauVao.KiemTra(taiKhoan, matKhauMoi))
                {
                    // Thực hiện đổi mật khẩu
                    if (taiKhoanDao.DoiMatKhau(taiKhoan, matKhauMoi))
                    {
                        MessageBox.Show("Mật khẩu mới đã được tạo thành công!");
                        FDangNhap fDangNhap = new FDangNhap();
                        this.Hide();
                        fDangNhap.Show();
                    }
                    else
                    {
                        MessageBox.Show("Đổi mật khẩu thất bại. Vui lòng thử lại!");
                    }
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
