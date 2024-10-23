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
    public partial class FNguoiUngTuyen : Form
    {
        public FNguoiUngTuyen()
        {
            InitializeComponent();
        }

        private void buttonCV_Click(object sender, EventArgs e)
        {
            // Xóa tất cả các control hiện tại trong panelMain
            panelMain.Controls.Clear();

            // Tạo instance của FormCV
            FCV fCV = new FCV();

            // Thiết lập không có viền cho Form khi nhúng vào panel
            fCV.TopLevel = false;
            fCV.FormBorderStyle = FormBorderStyle.None;
            fCV.Dock = DockStyle.Fill; // Điều chỉnh form vừa với panel

            // Thêm FormCV vào panelMain
            panelMain.Controls.Add(fCV);
            panelMain.Tag = fCV;

            // Hiển thị fCV
            fCV.Show();
        }

    }
}
