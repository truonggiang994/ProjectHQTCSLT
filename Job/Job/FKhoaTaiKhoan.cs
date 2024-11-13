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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Job
{
    public partial class FKhoaTaiKhoan : Form
    {
        public FKhoaTaiKhoan()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                using (SqlConnection connection = DbConnection.GetConnection())
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SELECT * FROM vw_ListAccountLock", connection))
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

            buttonLock.Hide();
            buttonUnlock.Hide();
            htmlLabelReason.Hide();
            textBoxReason.Hide();
        }


        private void dataGridView_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy hàng dữ liệu được chọn
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];

                // Gán dữ liệu vào các TextBox
                textBoxName.Text = row.Cells["Tên tài khoản"].Value.ToString(); // Cột tên tài khoản
                textBoxPosition.Text = row.Cells["Chức vụ"].Value.ToString(); // Cột chức vụ
                textBoxStatus.Text = row.Cells["Trạng thái"].Value.ToString(); // Cột trạng thái
                if(textBoxStatus.Text == "Active")
                {
                    buttonLock.Show();
                    buttonUnlock.Hide();
                    htmlLabelReason.Show();
                    textBoxReason.Show();
                }
                else
                {
                    buttonLock.Hide();
                    buttonUnlock.Show();
                    htmlLabelReason.Hide();
                    textBoxReason.Hide();
                }
            }
        }

        private void buttonLock_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = DbConnection.GetConnection())
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("sp_LockAccount", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Username", textBoxName.Text); // Tên tài khoản cần khóa
                        command.Parameters.AddWithValue("@AdminUsername", Data.username.ToString()); // Tên admin thực hiện khóa
                        command.Parameters.AddWithValue("@Reason", textBoxReason.Text); // Lý do khóa

                        command.ExecuteNonQuery(); // Thực thi câu lệnh
                    }
                }
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void buttonUnlock_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = DbConnection.GetConnection())
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("sp_LockAccount", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Username", textBoxName.Text); // Tên tài khoản cần khóa
                        command.Parameters.AddWithValue("@AdminUsername", Data.username.ToString()); // Tên admin thực hiện khóa
                        command.Parameters.AddWithValue("@Reason", textBoxReason.Text); // Lý do khóa

                        command.ExecuteNonQuery(); // Thực thi câu lệnh
                    }
                }
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi tải dữ liệu: " + ex.Message);
            }
        }
    }
}
