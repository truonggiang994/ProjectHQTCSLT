using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Job
{
    public partial class FDangKi : Form
    {
        public FDangKi()
        {
            InitializeComponent();
        }

        private void buttonDangKi_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = DbConnection.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SELECT dbo.sp_CheckAccountExistence(@Username)", connection))
                    {
                        command.Parameters.AddWithValue("@Username", textBoxAccount.Text);

                        int result = (int)command.ExecuteScalar();
                        if (result == 1)
                        {
                            MessageBox.Show("Tài khoản đã tồn tại");
                        }
                        else
                        {
                            if (radioButtonCandidate.Checked)
                            {
                                using (SqlCommand commandAdd = new SqlCommand("sp_AddAccount", connection))
                                {
                                    commandAdd.CommandType = CommandType.StoredProcedure;

                                    // Thêm các tham số
                                    commandAdd.Parameters.AddWithValue("@Username", textBoxAccount.Text);
                                    commandAdd.Parameters.AddWithValue("@Password", textBoxPassword.Text);
                                    commandAdd.Parameters.AddWithValue("@Email", textBoxEmail.Text);
                                    commandAdd.Parameters.AddWithValue("@Phone", textBoxPhone.Text);

                                    // Thực thi stored procedure
                                    commandAdd.ExecuteNonQuery();
                                }
                                using (SqlCommand commandAdd = new SqlCommand("sp_AddCandidate", connection))
                                {
                                    commandAdd.CommandType = CommandType.StoredProcedure;
                                    commandAdd.Parameters.AddWithValue("@Username", textBoxAccount.Text);
                                    commandAdd.ExecuteNonQuery();
                                }
                                MessageBox.Show("Tạo tài khoản ứng viên thành công");
                                FDangNhap fDangNhap = new FDangNhap();
                                this.Hide();
                                fDangNhap.Show();
                            }
                            else if (radioButtonEmployer.Checked)
                            {
                                using (SqlCommand commandAdd = new SqlCommand("sp_AddAccount", connection))
                                {
                                    commandAdd.CommandType = CommandType.StoredProcedure;
                                    commandAdd.Parameters.AddWithValue("@Username", textBoxAccount.Text);
                                    commandAdd.Parameters.AddWithValue("@Password", textBoxPassword.Text);
                                    commandAdd.Parameters.AddWithValue("@Email", textBoxEmail.Text);
                                    commandAdd.Parameters.AddWithValue("@Phone", textBoxPhone.Text);
                                    commandAdd.ExecuteNonQuery();
                                }
                                using (SqlCommand commandAdd = new SqlCommand("sp_AddEmployer", connection))
                                {
                                    commandAdd.CommandType = CommandType.StoredProcedure;
                                    commandAdd.Parameters.AddWithValue("@Username", textBoxAccount.Text);
                                    commandAdd.ExecuteNonQuery();
                                }
                                MessageBox.Show("Tạo tài khoản nhà tuyển dụng thành công");
                                FDangNhap fDangNhap = new FDangNhap();
                                this.Hide();
                                fDangNhap.Show();
                            }
                            else
                            {
                                MessageBox.Show("Vui lòng chọn chức vụ");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }
    }
}