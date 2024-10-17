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
    public partial class FDangTin : Form
    {
        private DangTinDao dangTinDao;
        private List<(Guna2HtmlLabel label, ComboBox comboBox)> capLabelComboBox = new List<(Guna2HtmlLabel label, ComboBox comboBox)>();
        private List<(Guna2HtmlLabel label, RichTextBox richTextBox)> capLabelRichTextBox = new List<(Guna2HtmlLabel label, RichTextBox richTextBox)>();

        public FDangTin()
        {
            InitializeComponent();

            dangTinDao = new DangTinDao();
            BatTatControls();

        }
        private void KiemTra()
        {
            if(DuLieuCongTy.CongTy == null)
            {
                FNhaTuyenDung.Instance.MoFCon(new FThongBaoNhaUngTuyen("Bạn chưa nhập thông tin công ty, vui lòng nhập thông tin công ty trước!", "Nhập thông tin", new FThongTinCongTy()));
            }
        }
        private void BatTatControls()
        {
            capLabelComboBox.Add((labelChonNganhNghe, comboBoxNganhNghe));
            capLabelComboBox.Add((labelChonHinhThucLV, comboBoxHinhThucLV));
            capLabelComboBox.Add((labelChonBangCap, comBoBoxBangNap));
            capLabelComboBox.Add((labelChonGioiTinh, comboBoxGioiTinh));
            capLabelComboBox.Add((labelChonKinhNghiem, comboBoxKinhNghiem));
            capLabelComboBox.Add((labelChonTinhThanh, comboBoxTinhThanh));

            capLabelRichTextBox.Add((labelChonMoTaCV, textBoxMoTaCongViec));
            capLabelRichTextBox.Add((label1ChonYeuCauCV, textBoxYeuCauCongViec));
            capLabelRichTextBox.Add((labelChonQuyenLoi, textBoxQuyenLoi));

            XuLy.KiemSoatControls(capLabelComboBox, capLabelRichTextBox);
        }
        private void buttonDang_Click(object sender, EventArgs e)
        {
            if(!KiemTraDauVao.KiemTraControlsRong(capLabelComboBox,capLabelRichTextBox)) 
                return;
            if (!KiemTraDauVao.KiemTraTextBoxRong(textBoxChucDanh, textBoxQuanHuyen, textBoxSoNha, textBoxKiNang, textBoxLuongToiThieu, textBoxLuongToiDa, textBoxTuoiToiDa, textBoxTuoiToiTieu))
                return;
            string taiKhoan = TaiKhoan.TaiKhoanDangNhap.TK;
            string chucDanh = textBoxChucDanh.Text;
            string nganhNghe = comboBoxNganhNghe.SelectedItem.ToString();
            string hinhThucLV = comboBoxHinhThucLV.SelectedItem.ToString();
            string bangCap = comBoBoxBangNap.SelectedItem.ToString();
            string kinhNghiem = comboBoxKinhNghiem.SelectedItem.ToString();
            string yeuCauGioiTinh = comboBoxGioiTinh.SelectedItem.ToString();
            DateTime hanNopHoSo = dateTimePickerHanNopHoSo.Value;
            string tinhThanh = comboBoxTinhThanh.SelectedItem.ToString();
            string quanHuyen = textBoxQuanHuyen.Text;
            string soNha = textBoxSoNha.Text;
            string kiNang = textBoxKiNang.Text;
            string moTaCV = textBoxMoTaCongViec.Text;
            string yeuCauCV = textBoxYeuCauCongViec.Text;
            string quyenLoi = textBoxQuyenLoi.Text;
            float mucLuongToiThieu = float.Parse(textBoxLuongToiThieu.Text);
            float mucLuongToiDa = float.Parse(textBoxLuongToiDa.Text);
            int doTuoiToiThieu = int.Parse(textBoxTuoiToiTieu.Text); 
            int doTuoiToiDa = int.Parse(textBoxTuoiToiDa.Text); 

            // Tạo một đối tượng DangTin từ dữ liệu thu thập được
            DangTin dangTin = new DangTin(taiKhoan, chucDanh, nganhNghe, hinhThucLV, bangCap, kinhNghiem, yeuCauGioiTinh, hanNopHoSo, tinhThanh, quanHuyen, soNha, kiNang, moTaCV, yeuCauCV, quyenLoi, mucLuongToiThieu, mucLuongToiDa, doTuoiToiThieu, doTuoiToiDa);

            // Gọi phương thức ThemDangTin của lớp DangTinDao để lưu trữ dữ liệu vào cơ sở dữ liệu
            dangTinDao.ThemDangTin(dangTin);

            // Thông báo cho người dùng biết rằng dữ liệu đã được lưu thành công
            MessageBox.Show("Đã đăng tin thành công!");
        }

        private void FDangTin_Load(object sender, EventArgs e)
        {
            KiemTra();
        }
    }
}
