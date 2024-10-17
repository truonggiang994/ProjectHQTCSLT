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
    public partial class FSuaDangTin : Form
    {
        private DangTin dangTin;
        private int id;
         public FSuaDangTin(DangTin dangTin)
        {
            this.dangTin = dangTin;
            InitializeComponent();
            TaiDuLieu();
        }

        private void TaiDuLieu()
        {
            textBoxChucDanh.Text = dangTin.ChucDanh;
            comboBoxNganhNghe.Text = dangTin.NganhNghe;
            comboBoxHinhThucLV.Text = dangTin.HinhThucLV;
            comBoBoxBangNap.Text = dangTin.BangCap;
            comboBoxKinhNghiem.Text = dangTin.KinhNghiem;
            textBoxTuoiToiTieu.Text = dangTin.DoTuoiToiThieu.ToString();
            textBoxTuoiToiDa.Text = dangTin.DoTuoiToiThieu.ToString();
            comboBoxGioiTinh.Text = dangTin.YeuCauGioiTinh;
            dateTimePickerHanNopHoSo.Value = DateTime.Parse(dangTin.HanNopHoSo.ToString());
            comboBoxTinhThanh.Text = dangTin.TinhThanh;
            textBoxQuanHuyen.Text = dangTin.QuanHuyen;
            textBoxSoNha.Text = dangTin.SoNha;
            textBoxLuongToiThieu.Text = dangTin.MucluongToiThieu.ToString();
            textBoxLuongToiDa.Text = dangTin.MucLuongToiDa.ToString();
            textBoxKiNang.Text = dangTin.KiNang;
            textBoxMoTaCongViec.Text = dangTin.MoTaCV;
            textBoxYeuCauCongViec.Text = dangTin.YeuCauCV;
            textBoxQuyenLoi.Text = dangTin.QuyenLoi;
            id = dangTin.Id;

        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
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
            DangTin dangTin = new DangTin(id, taiKhoan, chucDanh, nganhNghe, hinhThucLV, bangCap, kinhNghiem, yeuCauGioiTinh, hanNopHoSo, tinhThanh, quanHuyen, soNha, kiNang, moTaCV, yeuCauCV, quyenLoi, mucLuongToiThieu, mucLuongToiDa, doTuoiToiThieu, doTuoiToiDa);
            DangTinDao dangTinDao = new DangTinDao();
            dangTinDao.SuaDangTin(dangTin);

            MessageBox.Show("Đã cập nhật thông tin thành công!");
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
