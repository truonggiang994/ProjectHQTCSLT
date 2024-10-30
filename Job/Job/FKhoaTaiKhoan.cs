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
                using (SqlConnection connection = new SqlConnection("Data Source=BQH;Initial Catalog=Job;Persist Security Info=True;User ID=Giang;Password=123456789"))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("sp_GetListAccountLock", connection))
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
                using (SqlConnection connection = new SqlConnection("Data Source=BQH;Initial Catalog=Job;Persist Security Info=True;User ID=Giang;Password=123456789"))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("sp_AccountStatusTransition", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Username", textBoxName.Text); // Thêm tham số

                        command.ExecuteNonQuery(); // Thực thi câu lệnh

                        MessageBox.Show("Trạng thái tài khoản đã được cập nhật.");
                    }
                    using (SqlCommand command = new SqlCommand("sp_SaveLockAccountHistory", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@AdminUsername", "adminHung");
                        command.Parameters.AddWithValue("@LockUsername", textBoxName.Text);
                        command.Parameters.AddWithValue("@Reason", textBoxReason.Text);

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
                using (SqlConnection connection = new SqlConnection("Data Source=BQH;Initial Catalog=Job;Persist Security Info=True;User ID=Giang;Password=123456789"))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("sp_AccountStatusTransition", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Username", textBoxName.Text); // Thêm tham số

                        command.ExecuteNonQuery(); // Thực thi câu lệnh

                        MessageBox.Show("Trạng thái tài khoản đã được cập nhật.");
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
