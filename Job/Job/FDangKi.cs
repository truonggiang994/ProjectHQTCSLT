using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


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
            if (radioButtonCandidate.Checked || radioButtonEmployer.Checked)
            {
                try
                {
                    using (SqlConnection connection = DbConnection.GetConnection())
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand("SELECT dbo.fn_CheckAccountExistence(@Username)", connection))
                        {
                            command.Parameters.AddWithValue("@Username", textBoxAccount.Text);

                            int result = (int)command.ExecuteScalar();
                            if (result == 1)
                            {
                                MessageBox.Show("Tài khoản đã tồn tại");
                            }
                            else
                            {
                                string role = radioButtonCandidate.Checked ? "Candidate" : radioButtonEmployer.Checked ? "Employer" : null;

                                if (role != null)
                                {
                                    using (SqlCommand commandAdd = new SqlCommand("sp_AddAccount", connection))
                                    {
                                        commandAdd.CommandType = CommandType.StoredProcedure;

                                        // Thêm các tham số
                                        commandAdd.Parameters.AddWithValue("@Username", textBoxAccount.Text);
                                        commandAdd.Parameters.AddWithValue("@Password", textBoxPassword.Text);
                                        commandAdd.Parameters.AddWithValue("@Email", textBoxEmail.Text);
                                        commandAdd.Parameters.AddWithValue("@Phone", textBoxPhone.Text);
                                        commandAdd.Parameters.AddWithValue("@Role", role);

                                        // Thực thi stored procedure
                                        int addResult = (int)commandAdd.ExecuteScalar();
                                        if (addResult == 1)
                                        {
                                            MessageBox.Show($"Tạo tài khoản {role.ToLower()} thành công");
                                            FDangNhap fDangNhap = new FDangNhap();
                                            this.Hide();
                                            fDangNhap.Show();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Đã xảy ra lỗi khi thêm tài khoản.");
                                        }
                                    }
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
            else
            {
                MessageBox.Show("Vui lòng chọn chức vụ");
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FDangNhap fDangKi = new FDangNhap();
            Hide();
            fDangKi.Show();
        }

        private void radioButtonEmployer_CheckedChanged(object sender, EventArgs e)
        {
            Data.role = ERoleLogin.employ;
        }

        private void radioButtonCandidate_CheckedChanged(object sender, EventArgs e)
        {
            Data.role = ERoleLogin.cadidate;
        }
    }
}

