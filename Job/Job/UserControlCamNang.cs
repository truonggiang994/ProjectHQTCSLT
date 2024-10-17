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
    public partial class UserControlCamNang : UserControl
    {
        private CamNang camNang;

        public UserControlCamNang(CamNang camNang)
        {
            InitializeComponent();
            this.camNang = camNang;
            UpdateUI();
        }

        private void UpdateUI()
        {
            if (camNang != null)
            {
                pictureBoxCamNang.Image = camNang.Anh;
                labelTieuDe.Text = camNang.TieuDe;
                labelNoiDung.Text = camNang.NoiDung;
            }
        }
        private void btnXemchitiet_Click(object sender, EventArgs e)
        {
            FCamNang fCamNang = new FCamNang(camNang);
            FNguoiUngTuyen.Instance.MoFCon(fCamNang);
        }
    }
}
