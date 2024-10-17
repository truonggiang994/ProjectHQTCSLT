using Guna.UI2.WinForms;
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
    public partial class FSuaCV : Form
    {
        private CV cv;
        public FSuaCV(CV cv)
        {
            InitializeComponent();
            this.cv = cv;
            TaiDuLieu(cv);
        }
        public void TaiDuLieu(CV cv)
        {
            pictureBoxAnhDaiDien.Image = cv.AnhDaiDien;
            textBoxHoTen.Text = cv.HoTen;
            dateTimePickerNgaySinh.Text = cv.NgaySinh.ToString("dd/MM/yyyy");
            textboxSDT.Text = cv.SDT;
            comboBoxGioiTinh.Text = cv.GioiTinh;
            comboBoxBangCap.Text = cv.BangCap;
            textBoxDiaChi.Text = cv.DiaChi;
            textBoxViTriMongMuon.Text = cv.ViTriMongMuon;
            textBoxGmail.Text = cv.Gmail;
            richTextBoxMucTieuNgheNghiep.Text = cv.MucTieuNgheNghiep;
            textBoxTruong.Text = cv.TenTruong;
            textBoxChuyenNganh.Text = cv.ChuyenNganh;
            dateTimePickerHocVanTGDau.Text = cv.HocVanTGDau.ToString();
            dateTimePickerHocVanTGKet.Text =  cv.HocVanTGKet.ToString();
            comboBoxLoaiTotNghiep.Text = cv.LoaiTotNghiep;
            textBoxTenCongTy.Text = cv.TenCongTy;
            dateTimePickerKNTGDau.Text = cv.KNTGDau.ToString();
            dateTimePickerHocVanTGKet.Text = cv.KNTGKet.ToString();
            textBoxViTriCongViec.Text = cv.ViTriCongViec;
            richTextBoxKinhNghiem.Text = cv.KinhNghiem;
            richTextBoxKiNang.Text = cv.KiNang;
            richTextBoxChungChi.Text = cv.ChungChi;
            chinhDateTimePicker(dateTimePickerHocVanTGDau);
            chinhDateTimePicker(dateTimePickerHocVanTGKet);
            chinhDateTimePicker(dateTimePickerKNTGDau);
            chinhDateTimePicker(dateTimePickerKNTGKet);
        }
        private void chinhDateTimePicker(Guna2DateTimePicker dateTimePicker)
        {
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "MM/yyyy";
            dateTimePicker.ShowUpDown = true;
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (!KiemTraDauVao.KiemTraTextBoxRong(textBoxHoTen, textboxSDT, textBoxDiaChi, textBoxViTriMongMuon, textBoxGmail, textBoxTruong, textBoxChuyenNganh, textBoxTenCongTy, textBoxViTriCongViec))
                    return;
                if (DateTime.Now.Subtract(TimeSpan.FromDays(365 * 18)) < dateTimePickerNgaySinh.Value)
                {
                    MessageBox.Show("Bạn phải đủ 18 tuổi để tiếp tục!");
                    return;
                }
                if (!KiemTraDauVao.KiemTraSDT(textboxSDT.Text))
                    return;
                if (!KiemTraDauVao.KiemTraGmail(textBoxGmail.Text))
                    return;
                string taiKhoan = TaiKhoan.TaiKhoanDangNhap.TK;
                string hoTen = textBoxHoTen.Text;
                DateTime ngaySinh = dateTimePickerNgaySinh.Value;
                string sdt = textboxSDT.Text;
                string gioiTinh = comboBoxGioiTinh.SelectedItem.ToString();
                string bangCap = comboBoxBangCap.SelectedItem.ToString();
                string diaChi = textBoxDiaChi.Text;
                string viTriMongMuon = textBoxViTriMongMuon.Text;
                string gmail = textBoxGmail.Text;
                string mucTieuNgheNghiep = richTextBoxMucTieuNgheNghiep.Text;
                string tenTruong = textBoxTruong.Text;
                string chuyenNganh = textBoxChuyenNganh.Text;
                DateTime hocVanTGDau = dateTimePickerHocVanTGDau.Value;
                DateTime hocVanTGKet = dateTimePickerHocVanTGKet.Value;
                string loaiTotNghiep = comboBoxLoaiTotNghiep.SelectedItem.ToString();
                string tenCongTy = textBoxTenCongTy.Text;
                DateTime kNTGDau = dateTimePickerKNTGDau.Value;
                DateTime kNTGKet = dateTimePickerKNTGKet.Value;
                string viTriCongViec = textBoxViTriCongViec.Text;
                string kinhNghiem = richTextBoxKinhNghiem.Text;
                string kiNang = richTextBoxKiNang.Text;
                string chungChi = richTextBoxChungChi.Text;
                Image anhDaiDien = pictureBoxAnhDaiDien.Image;

                CV cvMoi = new CV(taiKhoan, hoTen, ngaySinh, sdt, gioiTinh, bangCap, diaChi, viTriMongMuon, gmail, mucTieuNgheNghiep, tenTruong, chuyenNganh, hocVanTGDau, hocVanTGKet, loaiTotNghiep, tenCongTy, kNTGDau, kNTGKet, viTriCongViec, kinhNghiem, kiNang, chungChi, anhDaiDien);

                CVDAO cvDAO = new CVDAO();
                cvDAO.SuaCV(cvMoi);

                MessageBox.Show("Đã sửa CV thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi lưu thông tin: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonTaiAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBoxAnhDaiDien.Image = Image.FromFile(ofd.FileName);
            }
        }
    }
}
