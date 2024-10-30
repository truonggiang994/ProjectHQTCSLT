using Guna.UI2.WinForms;
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
    public partial class FLichSuKhoaTaiKhoan : Form
    {
        public FLichSuKhoaTaiKhoan()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=BQH;Initial Catalog=Job;Persist Security Info=True;User ID=Giang;Password=123456789"))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("sp_GetLockAccountHistory", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

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

        private void dataGridViewLSKhoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
