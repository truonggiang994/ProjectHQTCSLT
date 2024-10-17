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
    public partial class FXemDanhGia : Form
    {
        private ThongTinViecLam thongTinViecLam;
        private DanhGia danhGia;
        public FXemDanhGia(ThongTinViecLam thongTinViecLam)
        {
            InitializeComponent();
            danhGia = new DanhGia();
            this.thongTinViecLam = thongTinViecLam;
        }
        private void TaiDuLieu(ThongTinViecLam thongTinViecLam)
        {
            float tongSao = 0;
            int dem = 0;
            labelTenCongTy.Text = thongTinViecLam.TenCongTy;
            foreach (DanhGia danhGia in DuLieuCV.danhGias)
            {
                if (danhGia.TKCongTy == thongTinViecLam.TaiKhoan)
                {
                    UserControlDanhGia userControl = new UserControlDanhGia(danhGia);
                    tongSao = tongSao + danhGia.SoSao;
                    dem++;
                    flowLayoutPanelChinh.Controls.Add(userControl);
                }
            }
            if (dem > 0)
            {
                float SaoTB = tongSao / dem;
                labelSoSao.Text = SaoTB.ToString() + " sao";
                ratingStarSoSaoTB.Value = Convert.ToInt32(Math.Round(SaoTB));
            }
            else
            {
                FNguoiUngTuyen.Instance.MoFCon(new FThongBao("Công ty này chưa có lượt đánh giá nào, đánh giá công ty này ngay!", "Đánh giá", new FNhapDanhGia(thongTinViecLam, danhGia)));
            }
        }

        private void flowLayoutPanelChinh_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void FXemDanhGia_Load(object sender, EventArgs e)
        {
            TaiDuLieu(thongTinViecLam);
        }
    }
}
