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
    public partial class FQuanLy : Form
    {
        static public FQuanLy Instance { get; private set; }
        public FQuanLy()
        {
            InitializeComponent();
            Instance = this;
        }
        public void MoFCon(Form fCon)
        {
            fCon.TopLevel = false;
            fCon.Size = panelChinh.Size;
            fCon.Location = new Point(0, 0);
            fCon.Tag = this;
            panelChinh.Controls.Add(fCon);
            fCon.BringToFront();
            fCon.Show();
        }

        private void buttonDuyetBaiDang_Click(object sender, EventArgs e)
        {
            MoFCon(new FDuyetBaiDang());
        }

        private void buttonKhoaTaiKhoan_Click(object sender, EventArgs e)
        {
            MoFCon(new FKhoaTaiKhoan());
        }

        private void buttonLSDuyetBaiDang_Click(object sender, EventArgs e)
        {
            MoFCon(new FlichSuDuyetBaiDang());
        }

        private void buttonLSKoaTaiKhoan_Click(object sender, EventArgs e)
        {
            MoFCon(new FLichSuKhoaTaiKhoan());
        }
        private void panelChinh_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
