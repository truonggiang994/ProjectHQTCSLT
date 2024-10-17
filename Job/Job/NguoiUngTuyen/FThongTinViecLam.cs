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
    public partial class FThongTinViecLam : Form
    {
        private ThongTinViecLam thongTinViecLam;
        private CV cv;
        private int maCV;

        public FThongTinViecLam(ThongTinViecLam thongTinViecLam)
        {
            InitializeComponent();
            this.thongTinViecLam = thongTinViecLam;
            DuLieuCongTy.NhanCongTy(thongTinViecLam.TaiKhoan);
            cv = new CV();
            TaiDuLieu();
            TaiDuLieuViecLamTuongTu(thongTinViecLam.NganhNghe, thongTinViecLam.Id);
        }

        private void TaiDuLieu()
        {
            if (thongTinViecLam != null)
            {
                labelTenCongTy.Text = thongTinViecLam.TenCongTy;
                labelChucVu.Text = thongTinViecLam.ChucDanh;
                labelDiaChi.Text = thongTinViecLam.TinhThanh;
                labelMucLuong.Text = $"{thongTinViecLam.MucluongToiThieu.ToString()} - {thongTinViecLam.MucLuongToiDa.ToString()} triệu";
                pictureBoxCongTy.Image = thongTinViecLam.AnhLogo;
                labelHanNopHoSo.Text = thongTinViecLam.HanNopHoSo.ToString("dd/MM/yyyy");
                userControlLabelTTNganhNghe.LabelText = thongTinViecLam.NganhNghe;
                userControlLabelTTBangCap.LabelText = thongTinViecLam.BangCap;
                userControlLabelTTDoTuoi.LabelText = $"{thongTinViecLam.DoTuoiToiThieu.ToString()} - {thongTinViecLam.DoTuoiToiDa.ToString()} tuổi";
                userControlLabelTTHinhThucLV.LabelText = thongTinViecLam.HinhThucLV;
                userControlLabelTTKN.LabelText = thongTinViecLam.KinhNghiem;
                labelMoTaCongViec.Text = thongTinViecLam.MoTaCV;
                labelYeuCauCongViec.Text = thongTinViecLam.YeuCauCV;
                labelQuyenLoi.Text = thongTinViecLam.QuyenLoi;
                labelDiaDiemLamViec.Text = thongTinViecLam.SoNha + ", " + thongTinViecLam.TinhThanh;
            }
            foreach (CV cv in DuLieuCV.cVs)
            {
                if (cv != null && cv.TaiKhoan.Trim() == TaiKhoan.TaiKhoanDangNhap.TK)
                {
                    maCV = cv.MaCV;
                }
            }
        }
        private void TaiDuLieuViecLamTuongTu(string nganhNghe, int id)
        {
            List<ThongTinViecLam> danhSachDaLoc = new List<ThongTinViecLam>();

            foreach (ThongTinViecLam congViec in DuLieuCV.ThongTinViecLams)
            {
                if (congViec.NganhNghe != nganhNghe && congViec.Id != id)
                    continue;
                danhSachDaLoc.Add(congViec);
            }
            
            foreach (ThongTinViecLam congViec in danhSachDaLoc)
            {
                ViecLamYeuThich viecLamYeuThich = DuLieuCV.viecLamYeuThichs.Find(x => x.TaiKhoan == TaiKhoan.TaiKhoanDangNhap.TK && x.ID == congViec.Id);
                UserControlViecLam userControl = new UserControlViecLam(congViec, viecLamYeuThich);
                flowLayoutPanel1.Controls.Add(userControl);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void buttonNopHoSo_Click(object sender, EventArgs e)
        {
            DuLieuCV.NopHoSo(thongTinViecLam.TaiKhoan, thongTinViecLam.Id, maCV, DateTime.Now, TaiKhoan.TaiKhoanDangNhap.TK);
        }

        private void labelTenCongTy_Click_1(object sender, EventArgs e)
        {
            FNguoiUngTuyen.Instance.MoFCon(new FXemCongTy(thongTinViecLam.TaiKhoan, thongTinViecLam));
        }
    }
}
