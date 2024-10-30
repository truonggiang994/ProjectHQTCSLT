using System;
using System.Drawing;
using System.Windows.Forms;

namespace Job
{
    public partial class FLichSuUngTuyen : Form
    {
        public FLichSuUngTuyen()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            // Tạo mới DataGridView và thêm vào form
            DataGridView dataGridView = new DataGridView
            {
                Dock = DockStyle.Fill,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                AllowUserToAddRows = false,
                RowHeadersVisible = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect
            };

            // Thêm cột logo công ty
            DataGridViewImageColumn logoColumn = new DataGridViewImageColumn
            {
                HeaderText = "Logo",
                Name = "LogoColumn",
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                Width = 80
            };
            dataGridView.Columns.Add(logoColumn);

            // Thêm cột tên công ty
            DataGridViewTextBoxColumn companyNameColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Tên Công Ty",
                Name = "CompanyNameColumn",
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleLeft }
            };
            dataGridView.Columns.Add(companyNameColumn);

            // Thêm cột vị trí tuyển dụng
            DataGridViewTextBoxColumn jobPositionColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Vị Trí Tuyển Dụng",
                Name = "JobPositionColumn"
            };
            dataGridView.Columns.Add(jobPositionColumn);

            // Thêm cột trạng thái
            DataGridViewTextBoxColumn statusColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Trạng Thái",
                Name = "StatusColumn",
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }
            };
            dataGridView.Columns.Add(statusColumn);

            // Thêm cột button "Xem Chi Tiết"
            DataGridViewButtonColumn detailButtonColumn = new DataGridViewButtonColumn
            {
                HeaderText = "",
                Name = "DetailButtonColumn",
                Text = "Xem Chi Tiết",
                UseColumnTextForButtonValue = true,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter },
                Width = 120
            };
            dataGridView.Columns.Add(detailButtonColumn);

            // Thêm cột button "Xem Lịch Hẹn Phỏng Vấn"
            DataGridViewButtonColumn interviewScheduleButtonColumn = new DataGridViewButtonColumn
            {
                HeaderText = "",
                Name = "InterviewScheduleButtonColumn",
                Text = "Xem Lịch Hẹn",
                UseColumnTextForButtonValue = true,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter },
                Width = 120
            };
            dataGridView.Columns.Add(interviewScheduleButtonColumn);

            // Thêm DataGridView vào form
            this.Controls.Add(dataGridView);

            // Gán sự kiện cho các nút
            dataGridView.CellContentClick += DataGridView_CellContentClick;

            //// Thêm dữ liệu mẫu
            //var defaultImage = Properties.Resources.DefaultCompanyLogo; // Cần thay thế bằng hình ảnh mặc định
            //dataGridView.Rows.Add(defaultImage, "Công ty ABC", "Lập trình viên", "Đang xử lý");
            //dataGridView.Rows.Add(defaultImage, "Công ty XYZ", "Quản lý dự án", "Phỏng vấn");
        }

        // Xử lý sự kiện khi click vào các button trong DataGridView
        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (sender is DataGridView dgv && dgv.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                string action = dgv.Columns[e.ColumnIndex].Name;
                string companyName = dgv.Rows[e.RowIndex].Cells["CompanyNameColumn"].Value.ToString();

                if (action == "DetailButtonColumn")
                {
                    MessageBox.Show($"Xem chi tiết về công ty: {companyName}");
                }
                else if (action == "InterviewScheduleButtonColumn")
                {
                    MessageBox.Show($"Xem lịch hẹn phỏng vấn với công ty: {companyName}");
                }
            }
        }
    }
}
