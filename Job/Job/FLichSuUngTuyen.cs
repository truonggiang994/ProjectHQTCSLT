using System;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Job
{
    public partial class FLichSuUngTuyen : Form
    {
        public FLichSuUngTuyen()
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
                    using (SqlCommand command = new SqlCommand("sp_GetApplicationSubmit", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Username", Data.username.ToString());

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
                        dataGridView.ReadOnly = true; // Đặt DataGridView ở chế độ chỉ đọc
                        dataGridView.AllowUserToAddRows = false; // Không cho phép người dùng thêm hàng mới
                        dataGridView.AllowUserToDeleteRows = false; // Không cho phép người dùng xóa hàng
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi tải dữ liệu: " + ex.Message);
            }
        }
    }
}
