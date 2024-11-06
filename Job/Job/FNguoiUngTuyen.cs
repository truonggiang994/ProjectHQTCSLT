using System;
using System.Windows.Forms;

namespace Job
{
    public partial class FNguoiUngTuyen : Form
    {
        public static FNguoiUngTuyen Ins;

        public FNguoiUngTuyen()
        {
            Ins = this;
            InitializeComponent();
        }

        // Hàm LoadForm chung để hiển thị các Form vào panel
        public void LoadForm(Form form)
        {
            // Xóa tất cả các control hiện tại trong panelMain
            panelChinh.Controls.Clear();

            // Thiết lập không có viền cho Form khi nhúng vào panel
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill; // Điều chỉnh form vừa với panel

            // Thêm Form vào panelMain
            panelChinh.Controls.Add(form);
            panelChinh.Tag = form;

            // Hiển thị form
            form.Show();
        }

        private void buttonCV_Click(object sender, EventArgs e)
        {
            // Tạo instance của FormCV và gọi hàm LoadForm
            FCV fCV = new FCV();
            LoadForm(fCV);
        }

        private void buttonXemCV_Click(object sender, EventArgs e)
        {
            // Tạo instance của FXemCV và gọi hàm LoadForm
            FXemCV fCV = new FXemCV();
            LoadForm(fCV);
        }

        private void buttonCoHoiVL_Click(object sender, EventArgs e)
        {
            LoadForm(new FThonTinCaNhanUngVien());
        }

        private void buttonVLDaUngTuyen_Click(object sender, EventArgs e)
        {
            LoadForm(new FLichSuUngTuyen());
        }

        private void btnViecLam_Click(object sender, EventArgs e)
        {
            LoadForm(new FViecLam());
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            FDangNhap fDangNhap = new FDangNhap();
            this.Hide();
            fDangNhap.Show();
        }

    }
}