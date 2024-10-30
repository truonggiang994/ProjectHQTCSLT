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
    public partial class FHenPhongVan : Form
    {
        //private PhongVanDAO phongVanDAO;
        //private DuLieuUngTuyen duLieuUngTuyen;
        //private PhongVan phongVan;
        //private bool co = false;
        public FHenPhongVan()
        {
            //    this.duLieuUngTuyen = duLieuUngTuyen;
            //    this.phongVan = phongVan;
            //    phongVanDAO = new PhongVanDAO();
            InitializeComponent();
            //    if (phongVan != null)
            //    {
            //        buttonGuiThongTin.Text = "Đã gửi";
            //        buttonGuiThongTin.Enabled = false;
            //    }
            //    TaiDuLieuUI();
        }
        //private void buttonBack_Click(object sender, EventArgs e)
        //{
        //    Dispose();
        //}
        //private void TaiDuLieuUI()
        //{
        //    if (duLieuUngTuyen != null)
        //    {
        //        labelHoTen.Text = "Họ và tên: " + duLieuUngTuyen.HoTen;
        //        labelGioiTinh.Text = "Giới tính: " + duLieuUngTuyen.GioiTinh;
        //        labelNgaySinh.Text = "Ngày sinh: " + duLieuUngTuyen.NgaySinh.ToString("dd/MM/yyyy");
        //        labelBangCap.Text = "Trình độ: " + duLieuUngTuyen.BangCap;
        //        pictureBoxAnhDaiDien.Image = duLieuUngTuyen.AnhDaiDien;
        //        foreach (LicSuDangTin licSuDangTin in DuLieuCongTy.licSuDangTins)
        //        {
        //            if (licSuDangTin.Id == duLieuUngTuyen.MaDangTin)
        //                labelChucVu.Text = "Ứng tuyển vô: " + licSuDangTin.ChucDanh;
        //        }
        //    }
        //    if (phongVan != null)
        //    {
        //        textBoxHoTen.Text = phongVan.NguoiPhongVan;
        //        textBoxSDT.Text = phongVan.SDT;
        //        dateTimePickerNgayPhongVan.Text = phongVan.NgayPhongVan.ToString();
        //        textBoxDiaChi.Text = phongVan.DiaChiPhongVan;
        //    }
        //}
        //private void buttonGuiThongTin_Click(object sender, EventArgs e)
        //{
        //    if (co == false)
        //    {
        //        buttonGuiThongTin.Text = "Đã gửi";
        //        buttonGuiThongTin.Enabled = false;
        //        string tkUngTuyen = duLieuUngTuyen.TKUngTuyen;
        //        int maCV = duLieuUngTuyen.MaCV;
        //        int maDangTin = duLieuUngTuyen.MaDangTin;
        //        string tKDangTin = TaiKhoan.TaiKhoanDangNhap.TK;
        //        string nguoiPhongVan = textBoxHoTen.Text;
        //        string sDT = textBoxSDT.Text;
        //        DateTime ngayPhongVan = dateTimePickerNgayPhongVan.Value;
        //        string diaChiPhongVan = textBoxDiaChi.Text;
        //        string hoTen = duLieuUngTuyen.HoTen;

        //        PhongVan phongVanMoi = new PhongVan(tkUngTuyen, maCV, maDangTin, tKDangTin, nguoiPhongVan, sDT, ngayPhongVan, diaChiPhongVan, hoTen);
        //        phongVanDAO.ThemPhongVan(phongVanMoi);
        //        MessageBox.Show("Đã thông tin hẹn phỏng vấn  thành công!", "Thông báo");
        //    }
        //}
    }
    }
