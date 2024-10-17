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
    public partial class FCV : Form
    {
        private CV cv;
        private List<(Guna2HtmlLabel label, ComboBox comboBox)> capLabelComboBox = new List<(Guna2HtmlLabel label, ComboBox comboBox)>();
        private List<(Guna2HtmlLabel label, RichTextBox richTextBox)> capRichTextBoxLabel = new List<(Guna2HtmlLabel label, RichTextBox richTextBox)>();

        public FCV()
        {
            InitializeComponent();
            BatTatControls();
            chinhDateTimePicker(dateTimePickerHocVanTGDau);
            chinhDateTimePicker(dateTimePickerHocVanTGKet);
            chinhDateTimePicker(dateTimePickerKNTGDau);
            chinhDateTimePicker(dateTimePickerKNTGKet);
        }
        private void BatTatControls()
        {
            capLabelComboBox.Add((labelChonBangCap, comboBoxBangCap));
            capLabelComboBox.Add((labelChonGioiTinh, comboBoxGioiTinh));
            capLabelComboBox.Add((labelChonLoaiTotNghiep, comboBoxLoaiTotNghiep));

            capRichTextBoxLabel.Add((labelChonMucTieuNN, richTextBoxMucTieuNgheNghiep));
            capRichTextBoxLabel.Add((labelChonKinhNghiem, richTextBoxKinhNghiem));
            capRichTextBoxLabel.Add((labelChonChungChi, richTextBoxChungChi));
            capRichTextBoxLabel.Add((labelChonKiNang, richTextBoxKiNang));

            XuLy.KiemSoatControls(capLabelComboBox, capRichTextBoxLabel);

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
                if (!KiemTraDauVao.KiemTraControlsRong(capLabelComboBox, capRichTextBoxLabel))
                    return;

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
                
                CV cv = new CV(taiKhoan, hoTen, ngaySinh, sdt, gioiTinh, bangCap, diaChi, viTriMongMuon, gmail, mucTieuNgheNghiep, tenTruong, chuyenNganh, hocVanTGDau, hocVanTGKet, loaiTotNghiep, tenCongTy, kNTGDau, kNTGKet, viTriCongViec, kinhNghiem, kiNang, chungChi, anhDaiDien);

                CVDAO cvDAO = new CVDAO();
                cvDAO.ThemCV(cv);

                MessageBox.Show("Thông tin đã được lưu thành công!");
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

        private void FCV_Load(object sender, EventArgs e)
        {
            if(DuLieuCV.CV != null)
            {
                FNguoiUngTuyen.Instance.MoFCon(new FThongBao("Bạn đã tạo CV trước đó!", "Xem CV", new FXemCV(DuLieuCV.CV)));
            }
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}