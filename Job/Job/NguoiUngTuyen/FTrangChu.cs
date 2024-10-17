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
    public partial class FTrangChu : Form
    {
        public FTrangChu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FNguoiUngTuyen.Instance.MoFCon(new FXemCamNang());
        }

        private void buttonTaoCV_Click(object sender, EventArgs e)
        {
            FNguoiUngTuyen.Instance.MoFCon(new FCV());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FNguoiUngTuyen.Instance.MoFCon(new FViecLam());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FNguoiUngTuyen.Instance.MoFCon(new FTopViecLam());
        }
    }
}
