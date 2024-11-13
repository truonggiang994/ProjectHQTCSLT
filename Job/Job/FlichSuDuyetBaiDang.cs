using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Job
{
    public partial class FlichSuDuyetBaiDang : Form
    {
        public FlichSuDuyetBaiDang()
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

                    // Sử dụng view thay vì function
                    string query = "SELECT * FROM dbo.vw_GetApprovalHistory";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridView.DataSource = dataTable;

                        dataGridView.AutoGenerateColumns = true;
                        dataGridView.ColumnHeadersHeight = 40;

                        for (int i = 0; i < dataTable.Columns.Count; i++)
                        {
                            string columnName = dataTable.Columns[i].ColumnName;
                            dataGridView.Columns[i].HeaderText = columnName;
                        }

                        // Thiết lập DataGridView chỉ đọc
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

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
