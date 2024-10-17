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
    public partial class FNhapDanhGia : Form
    {
        private ThongTinViecLam ThongTinViecLam;
        private DanhGia danhGia;
        public FNhapDanhGia(ThongTinViecLam thongTinViecLam, DanhGia danhGia)
        {
            InitializeComponent();
            this.ThongTinViecLam = thongTinViecLam;
            this.danhGia = danhGia;
            labelTenCongTy.Text = thongTinViecLam.TenCongTy;
        }

        private void btnGuiDanhGia_Click(object sender, EventArgs e)
        {
            DanhGia danhGia = new DanhGia();
            danhGia.SoSao = ratingStarSoSao.Value;
            danhGia.TKDanhGia = TaiKhoan.TaiKhoanDangNhap.TK; 
            danhGia.TKCongTy = ThongTinViecLam.TaiKhoan;
            danhGia.Anh = pictureBoxAnhDanhGia.Image; 
            danhGia.NoiDung = richTextBoxDanhGia.Text;

            DanhGiaDAO danhGiaDAO = new DanhGiaDAO();
            danhGiaDAO.ThemDanhGia(danhGia);

            MessageBox.Show("Đánh giá đã được gửi thành công!");

        }

        private void buttonThemAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBoxAnhDanhGia.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
