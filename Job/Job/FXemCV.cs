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
    public partial class FXemCV : Form
    {
        private CV cv;
        public FXemCV(CV cv)
        {
            InitializeComponent();
            this.cv = cv;
        }
        private void TaiDuLieu(CV cv)
        {
            if (cv == null)
            {
                FNguoiUngTuyen.Instance.MoFCon(new FThongBao("Bạn chưa nhập CV, vui lòng nhập CV trước!", "Tạo CV", new FCV()));
            }
            else
            {
                pictureBoxAnhDaiDien.Image = cv.AnhDaiDien;
                labelHoTen.Text = cv.HoTen;
                labelViTriMongMuon.Text = cv.ViTriMongMuon;
            }
        }

        private void buttonXemCV_Click(object sender, EventArgs e)
        {
            FNguoiUngTuyen.Instance.MoFCon(new FCVGuide(cv));
        }

        private void FXemCV_Load(object sender, EventArgs e)
        {
            TaiDuLieu(cv);
        }

        private void buttonSuaCV_Click(object sender, EventArgs e)
        {
            FNguoiUngTuyen.Instance.MoFCon(new FSuaCV(cv));
        }

        private void buttonXoaCV_Click(object sender, EventArgs e)
        {

        }
    }
}
