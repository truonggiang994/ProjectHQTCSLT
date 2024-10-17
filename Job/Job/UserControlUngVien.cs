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
    public partial class UserControlUngVien : UserControl
    {
        private DuLieuUngTuyen duLieuUngTuyen;
        private UngTuyen ungTuyen;
        private DangTin dangTin;
        private PhongVan phongVan;
        private bool co  = false;
        public UserControlUngVien(DuLieuUngTuyen duLieuUngTuyen, UngTuyen ungTuyen, PhongVan phongVan)
        {
            InitializeComponent();
            this.duLieuUngTuyen = duLieuUngTuyen;
            this.ungTuyen = ungTuyen;
            this.phongVan = phongVan;
            if (ungTuyen != null)
            {
                buttonTuyen.Text = "Đã tuyển";
                buttonTuyen.Enabled = false;
            }
            TaiDuLieuUI();
            
        }
        private void TaiDuLieuUI()
        {
            if (duLieuUngTuyen != null)
            {
                labelHoTen.Text = "Họ và tên: " + duLieuUngTuyen.HoTen;
                labelGioiTinh.Text = "Giới tính: " + duLieuUngTuyen.GioiTinh;
                labelNgaySinh.Text = "Ngày sinh: " + duLieuUngTuyen.NgaySinh.ToString("dd/MM/yyyy");
                labelBangCap.Text = "Trình độ: " + duLieuUngTuyen.BangCap;
                pictureBoxAnhDaiDien.Image = duLieuUngTuyen.AnhDaiDien;
                foreach(LicSuDangTin licSuDangTin in DuLieuCongTy.licSuDangTins)
                {
                    if(licSuDangTin.Id == duLieuUngTuyen.MaDangTin)
                        labelChucVu.Text = "Ứng tuyển vô: " + licSuDangTin.ChucDanh;
                }
                
            }
        }

        private void buttonXemChiTiet_Click(object sender, EventArgs e)
        {
            FCVGuide fCVGuide = new FCVGuide(duLieuUngTuyen);
            FNhaTuyenDung.Instance.MoFCon(fCVGuide);
        }

        private void buttonTuyen_Click(object sender, EventArgs e)
        {
            if (co == false)
            {   
                ungTuyen  = new UngTuyen(TaiKhoan.TaiKhoanDangNhap.TK, duLieuUngTuyen.MaCV, duLieuUngTuyen.MaDangTin, duLieuUngTuyen.TKUngTuyen, duLieuUngTuyen.NgayNop);
                buttonTuyen.Text = "Đã tuyển";
                buttonTuyen.Enabled = false;
                DuLieuCongTy.Tuyen(ungTuyen);
                MessageBox.Show("Đã thêm vô danh sách yêu thích");
            }
        }

        private void buttonPhuongVan_Click(object sender, EventArgs e)
        {
            FNhaTuyenDung.Instance.MoFCon(new FHenPhongVan(duLieuUngTuyen, phongVan));
        }
    }
}
