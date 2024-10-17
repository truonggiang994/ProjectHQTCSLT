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
    public partial class FXemCongTy : Form
    {
        private ThongTinViecLam thongTinViecLam;
        private DanhGia danhGia;
        public FXemCongTy(string taiKhoan, ThongTinViecLam thongTinViecLam)
        {
            InitializeComponent();
            this.thongTinViecLam = thongTinViecLam;
            danhGia = new DanhGia();
            XemThongTinCongTy(taiKhoan);
            TaiDuLieu(taiKhoan);
        }
        private void XemThongTinCongTy(string taiKhoan)
        {
            if (DuLieuCongTy.CongTy != null)
            {
                labelTenCongTy.Text = DuLieuCongTy.CongTy.TenCongTy;
                labelSDT.Text = "Số điện thoại: " + DuLieuCongTy.CongTy.SDT;
                labelQuyMo.Text = "Quy mô: " + DuLieuCongTy.CongTy.QuyMoNhanSu;
                labelDiaDiem.Text = DuLieuCongTy.CongTy.DiaDiem;
                labelDiaChi.Text = "Địa chị: " + DuLieuCongTy.CongTy.DiaChi + DuLieuCongTy.CongTy.DiaDiem;
                pictureBoxLogo.Image = DuLieuCongTy.CongTy.LoGo;
                labelGmail.Text = "Gmail: " + DuLieuCongTy.CongTy.Gmail;
                pictureBoxAnhBia.Image = DuLieuCongTy.CongTy.AnhBia;
            }
        }
        private void TaiDuLieu(string taiKhoan)
        {
            foreach (ThongTinViecLam congViec in DuLieuCV.ThongTinViecLams)
            {
                if (congViec.TaiKhoan == taiKhoan)
                {
                    ViecLamYeuThich viecLamYeuThich = DuLieuCV.viecLamYeuThichs.Find(x => x.TaiKhoan == TaiKhoan.TaiKhoanDangNhap.TK && x.ID == congViec.Id);
                    UserControlViecLam userControl = new UserControlViecLam(congViec, viecLamYeuThich);
                    flowLayoutPanelChinh.Controls.Add(userControl);
                }
            }
        }

        private void buttonDanhGia_Click(object sender, EventArgs e)
        {
            FNguoiUngTuyen.Instance.MoFCon(new FNhapDanhGia(thongTinViecLam, danhGia));
        }

        private void buttonXemDanhGia_Click(object sender, EventArgs e)
        {
            FNguoiUngTuyen.Instance.MoFCon(new FXemDanhGia(thongTinViecLam));
        }
    }
}
