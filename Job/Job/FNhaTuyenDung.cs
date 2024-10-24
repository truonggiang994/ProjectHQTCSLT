using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Job
{
    public partial class FNhaTuyenDung : Form
    {
        public FNhaTuyenDung()
        {
            InitializeComponent();
        }


        // Hàm LoadForm chung để hiển thị các Form vào panel
        public void LoadForm(Form form)
        {
            // Xóa tất cả các control hiện tại trong panelMain
            panelMain.Controls.Clear();

            // Thiết lập không có viền cho Form khi nhúng vào panel
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill; // Điều chỉnh form vừa với panel

            // Thêm Form vào panelMain
            panelMain.Controls.Add(form);
            panelMain.Tag = form;

            // Hiển thị form
            form.Show();
        }


        private void buttonTT_Click(object sender, EventArgs e)
        {
            LoadForm(new FThongTinCongTy());
        }
    }
}
