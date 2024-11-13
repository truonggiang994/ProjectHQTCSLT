using Guna.UI2.WinForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Job
{
    public partial class FLichSuKhoaTaiKhoan : Form
    {
        public FLichSuKhoaTaiKhoan()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=BQH;Initial Catalog=Job;Persist Security Info=True;User ID=Giang;Password=123456789"))
                {
                    connection.Open();

                    // Sử dụng SELECT để gọi view thay vì function
                    string query = "SELECT * FROM dbo.sp_GetLockAccountHistory"; // Không có dấu ngoặc tròn

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridView.DataSource = dataTable;

                        dataGridView.AutoGenerateColumns = true;
                        dataGridView.ColumnHeadersHeight = 40; // Chiều cao tiêu đề cột là 40 pixel

                        for (int i = 0; i < dataTable.Columns.Count; i++)
                        {
                            string columnName = dataTable.Columns[i].ColumnName;
                            dataGridView.Columns[i].HeaderText = columnName;
                        }

                        // Ngăn không cho người dùng tương tác với hàng
                        dataGridView.ReadOnly = true;
                        dataGridView.AllowUserToAddRows = false;
                        dataGridView.AllowUserToDeleteRows = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void dataGridViewLSKhoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Xử lý sự kiện khi nhấp vào ô trong DataGridView (nếu cần)
        }
    }
}
