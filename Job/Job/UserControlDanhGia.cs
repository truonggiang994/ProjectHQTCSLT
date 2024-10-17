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
    public partial class UserControlDanhGia : UserControl
    {
        private DanhGia danhGia;
        public UserControlDanhGia(DanhGia danhGia)
        {
            InitializeComponent();
            this.danhGia = danhGia;
            TaiDuLieu();
        }

        private void TaiDuLieu()
        {
            if (danhGia != null)
            {
                labelTKDanhGia.Text = danhGia.TKDanhGia;
                ratingStarSoSao.Value = Convert.ToInt32(Math.Round(danhGia.SoSao));
                richTextBoxDanhGia.Text = danhGia.NoiDung;
                pictureBoxDanhGia.Image = danhGia.Anh;
            }
        }
    }
}
