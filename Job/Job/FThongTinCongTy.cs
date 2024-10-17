using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Job
{
    public partial class FThongTinCongTy : Form
    {
        private CongTyDao congTyDao;
        public FThongTinCongTy()
        {
            InitializeComponent();
            congTyDao = new CongTyDao();
        }

        private void buttonFileGiayPhep_Click(object sender, EventArgs e)
        {
            ThayDoiAnh(pictureBoxGiayPhep);
        }

        private void buttonThayDoiAnh_Click(object sender, EventArgs e)
        {
            ThayDoiAnh(pictureBoxLoGo);
        }

        private void ThayDoiAnh(PictureBox pictureBox)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void buttonCapNhat_Click(object sender, EventArgs e)
        {
            if (!KiemTraDauVao.KiemTraComboBoxRong(comboBoxDiaDiem, comboBoxQuyMoNhanSu))
                return;
            string taiKhoan = TaiKhoan.TaiKhoanDangNhap.TK;
            string tenCongTy = userControlTextTenCongTy.text;
            string maSoThue = userControlTextCTMaSoThue.text;
            string sdt = userControlTextSDT.text;
            string diaChi = userControlTextDiaChi.text;
            string diaDiem = comboBoxDiaDiem.Text;
            string quyMo = comboBoxQuyMoNhanSu.Text;
            Image logo = pictureBoxLoGo.Image;
            Image giayPhep = pictureBoxGiayPhep.Image;
            string nguoiDungDau = userControlNguoiDungDau.text;
            string gmail = userControlTextCTGmail.text;
            Image anhBia = pictureBoxAnhBia.Image;
            // Tạo đối tượng CongTy
            CongTy congTy = new CongTy(taiKhoan, tenCongTy, maSoThue, sdt, quyMo, diaDiem, diaChi, logo, giayPhep, nguoiDungDau, gmail, anhBia);

            // Thêm vào cơ sở dữ liệu
            congTyDao.ThemCongTy(congTy);

            MessageBox.Show("Đã cập nhật thông tin công ty thành công!");
        }

        private void XemThongTinCongTy()
        {
            if (DuLieuCongTy.CongTy != null)
            {
                userControlTextTenCongTy.text = DuLieuCongTy.CongTy.TenCongTy;
                userControlNguoiDungDau.text = DuLieuCongTy.CongTy.MaSoThue;
                userControlTextSDT.text = DuLieuCongTy.CongTy.SDT;
                comboBoxQuyMoNhanSu.SelectedItem = DuLieuCongTy.CongTy.QuyMoNhanSu;
                comboBoxDiaDiem.Text = DuLieuCongTy.CongTy.DiaDiem;
                userControlTextDiaChi.text = DuLieuCongTy.CongTy.DiaChi;
                pictureBoxLoGo.Image = DuLieuCongTy.CongTy.LoGo;
                pictureBoxGiayPhep.Image = DuLieuCongTy.CongTy.GiayPhepKinhDoanh;
                userControlNguoiDungDau.text = DuLieuCongTy.CongTy.NguoiDungDau;
                userControlTextCTGmail.text = DuLieuCongTy.CongTy.Gmail;
                pictureBoxAnhBia.Image = DuLieuCongTy.CongTy.AnhBia;
            }
        }

        private void FThongTinCongTy_Load(object sender, EventArgs e)
        {
            XemThongTinCongTy();
        }

        private void buttonAnhBia_Click(object sender, EventArgs e)
        {
            ThayDoiAnh(pictureBoxAnhBia);
        }
    }
}
