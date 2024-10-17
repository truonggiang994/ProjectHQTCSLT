using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Job
{
    public partial class UserControlViecLam : UserControl
    {
        private bool isFavorite = false;
        private ThongTinViecLam thongTinViecLam;
        private ViecLamYeuThich viecLamYeuThich;

        public UserControlViecLam(ThongTinViecLam thongTinThongTin, ViecLamYeuThich viecLamYeuThich)
        {
            InitializeComponent();
            this.thongTinViecLam = thongTinThongTin;
            this.viecLamYeuThich = viecLamYeuThich;
            if(viecLamYeuThich != null )
            {
                AnhChuaTim();
            }
            TaiDuLieu();
        }
        private void TaiDuLieu()
        {
            if (thongTinViecLam != null)
            {
                labelTenCongTy.Text = thongTinViecLam.TenCongTy;
                labelChucVu.Text = thongTinViecLam.ChucDanh;
                labelDiaChi.Text = thongTinViecLam.TinhThanh;
                labelTienLuong.Text = $"{thongTinViecLam.MucluongToiThieu} - {thongTinViecLam.MucLuongToiDa} triệu";
                pictureBoxLogo.Image = thongTinViecLam.AnhLogo;
                labelLuotYeuThich.Text = $"Lượt yêu thích: {thongTinViecLam.LuotYeuThich}";
            }
        }

        private void buttonXemChiTiet_Click(object sender, EventArgs e)
        {
            FThongTinViecLam fThongTinViecLam = new FThongTinViecLam(thongTinViecLam);
            FNguoiUngTuyen.Instance.MoFCon(fThongTinViecLam);
        }

        private void buttonYeuThich_Click(object sender, EventArgs e)
        {
            if (isFavorite == false)
            {
                viecLamYeuThich = new ViecLamYeuThich(TaiKhoan.TaiKhoanDangNhap.TK, thongTinViecLam.Id);
                AnhChuaTim();
                DuLieuCV.ThemYeuThich(viecLamYeuThich);
                MessageBox.Show("Đã thêm vô danh sách yêu thích");
            }
            else
            {
                AnhDaTim();
                DuLieuCV.XoaYeuThich(viecLamYeuThich);
                MessageBox.Show("Đã xóa khỏi danh sách yêu thích");
            }
        }

        public void AnhChuaTim()
        {
            buttonYeuThich.Image = Properties.Resources.heart__1_;
            isFavorite = true;
        }
        public void AnhDaTim()
        {
            buttonYeuThich.Image = Properties.Resources.heart;
            isFavorite = false;
        }
    }
}