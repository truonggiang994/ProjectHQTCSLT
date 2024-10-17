    using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Job
{
    public partial class FCVGuide : Form
    {
        private CV cv;

        public FCVGuide(CV cv)
        {
            InitializeComponent();
            this.cv = cv;
        }

        private void TaiDuLieu(CV cv)
        {
            if (cv == null)
            {
                FNguoiUngTuyen.Instance.MoFCon(new FThongBao("Bạn chưa nhập CV, vui lòng nhập CV trước!", "Tạo CV", new FCV()));
            }    
            else
            {
                pictureBoxAnhDaiDien.Image = cv.AnhDaiDien;
                labelHoTen.Text = cv.HoTen;
                labelNgaySinh.Text = "Ngày sinh: " + cv.NgaySinh.ToString("dd/MM/yyyy");
                labelSDT.Text = "Số điện thoại: " + cv.SDT;
                labelGioiTinh.Text = "Giới tính: " + cv.GioiTinh;
                labelBangCap.Text = "Bằng cấp: " + cv.BangCap;
                labelDiaChi.Text = "Địa chỉ: " + cv.DiaChi;
                labelViTriMongMuon.Text = cv.ViTriMongMuon;
                labelGmail.Text = "Gmail: " + cv.Gmail;
                richTextBoxMucTieuNN.Text = cv.MucTieuNgheNghiep;
                labelTruong.Text = "Trường: " + cv.TenTruong;
                labelChuyenNganh.Text = "Ngành: " + cv.ChuyenNganh;
                labelHocVanTG.Text = cv.HocVanTGDau.ToString("MM/yyyy") + " - " + cv.HocVanTGKet.ToString("MM/yyyy");
                labelLoaiTotNghiep.Text = "Loại tốt nghiệp: " + cv.LoaiTotNghiep;
                labelTenCongTy.Text = "Công ty: " + cv.TenCongTy;
                labelKNTG.Text = cv.KNTGDau.ToString("MM/yyyy") + " - " + cv.KNTGKet.ToString("MM/yyyy");
                labelKNNganhNghe.Text = "Vị trí: " + cv.ViTriCongViec;
                richTextBoxKinhNghiem.Text = cv.KinhNghiem;
                richTextBoxKiNang.Text = cv.KiNang;
                richTextBoxChungChi.Text = cv.ChungChi;
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void FCVGuide_Load(object sender, EventArgs e)
        {
            TaiDuLieu(cv);
        }
    }
}
