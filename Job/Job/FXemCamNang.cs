using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Job
{
    public partial class FXemCamNang : Form
    {
        private UserControlCamNang myUserControl;
        public FXemCamNang()
        {
            InitializeComponent();
            TaiDuLieu();
        }

        private void TaiDuLieu()
        {
            foreach (CamNang camNang in DuLieuCV.camNangs)
            {
                UserControlCamNang userControl = new UserControlCamNang(camNang);
                flowLayoutPanelChinh.Controls.Add(userControl);
            }
        }
    }
}
