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
    public partial class UserControlLSUngTuyen : UserControl
    {
        private LichSuUngTuyen lichSuUngTuyen;
        private UngTuyen ungTuyen;
        private PhongVan phongVan;
        private bool co = false;
        private bool cof = false;
        public UserControlLSUngTuyen(LichSuUngTuyen lichSuUngTuyen, UngTuyen ungTuyen, PhongVan phongVan)
        {
            InitializeComponent();
            this.lichSuUngTuyen = lichSuUngTuyen;
            this.ungTuyen = ungTuyen;
            this.phongVan = phongVan;
            buttonXemPhongVan.Visible = false;
            if (ungTuyen != null)
            {
                labelTrangThai.Text = "Đã được tuyển";
            }
            if (phongVan != null)
            {
                buttonXemPhongVan.Visible = true;
            }
            TaiDuLieu();
        }
        private void TaiDuLieu()
        {
            pictureBoxAnhLogo.Image = lichSuUngTuyen.AnhLogo;
            labelChucVu.Text = lichSuUngTuyen.ChucDanh;
            labelTenCongTy.Text = lichSuUngTuyen.TenCongTy;
            labelNgayNop.Text = lichSuUngTuyen.NgayNop.ToString();

        }

        private void buttonXemCV_Click(object sender, EventArgs e)
        {
            FNguoiUngTuyen.Instance.MoFCon(new FThongTinViecLam(lichSuUngTuyen));
        }

        private void labelTrangThai_Click(object sender, EventArgs e)
        {
            if(co == false)
            {
                labelTrangThai.Text = "Đã được tuyển";
            }
        }

        private void buttonXemPhongVan_Click(object sender, EventArgs e)
        {
            if (cof == false)
            {
                buttonXemPhongVan.Visible = true;
                FNguoiUngTuyen.Instance.MoFCon(new FNhanPhongVan(phongVan, lichSuUngTuyen));
            }
        }
    }
}
