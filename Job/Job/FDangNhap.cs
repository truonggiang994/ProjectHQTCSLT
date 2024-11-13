using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Job
{
    public partial class FDangNhap : Form
    {
        public FDangNhap()
        {
            InitializeComponent();
        }
        private void buttonDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=BQH;Initial Catalog=Job;Persist Security Info=True;User ID=Giang;Password=123456789"))
                {
                    connection.Open();

                    string role = "";
                    if (radioButtonCandidate.Checked)
                        role = "Candidate";
                    else if (radioButtonEmployer.Checked)
                        role = "Employer";
                    else if (radioButtonAdmin.Checked)
                        role = "Admin";
                    else
                    {
                        MessageBox.Show("Chọn chức vụ");
                        return;
                    }

                    using (SqlCommand command = new SqlCommand("SELECT dbo.sp_CheckLoginAccount(@Username, @Password, @Role)", connection))
                    {
                        command.Parameters.AddWithValue("@Username", textBoTaiKhoan.Text);
                        command.Parameters.AddWithValue("@Password", textBoxMK.Text);
                        command.Parameters.AddWithValue("@Role", role);

                        int result = (int)command.ExecuteScalar();

                        if (result == 1)
                        {
                            Data.username = textBoTaiKhoan.Text;

                            if (role == "Candidate")
                            {
                                FNguoiUngTuyen fNguoiUngTuyen = new FNguoiUngTuyen();
                                this.Hide();
                                fNguoiUngTuyen.Show();
                            }
                            else if (role == "Employer")
                            {
                                FNhaTuyenDung fNhaTuyenDung = new FNhaTuyenDung();
                                this.Hide();
                                fNhaTuyenDung.Show();
                            }
                            else if (role == "Admin")
                            {
                                FQuanLy fQuanLy = new FQuanLy();
                                this.Hide();
                                fQuanLy.Show();
                            }
                        }
                        else if (result == 0)
                        {
                            MessageBox.Show("Tài khoản không tồn tại!");
                        }
                        else if (result == -1)
                        {
                            MessageBox.Show("Mật khẩu không đúng!");
                        }
                        else if (result == -2)
                        {
                            using (SqlCommand commandLock = new SqlCommand("SELECT dbo.sp_GetLockReason(@LockUsername)", connection))
                            {
                                commandLock.Parameters.AddWithValue("@LockUsername", textBoTaiKhoan.Text);
                                var resultLock = commandLock.ExecuteScalar();
                                if (resultLock != null && resultLock != DBNull.Value)
                                {
                                    MessageBox.Show("Tài khoản bị khóa: " + resultLock.ToString());
                                }
                                else
                                {
                                    MessageBox.Show("Tài khoản bị khóa nhưng không có lý do");
                                }
                            }
                        }
                        else if (result == -3)
                        {
                            MessageBox.Show("Chức vụ không hợp lệ!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void linkLabelDangki_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FDangKi fDangKi = new FDangKi();
            this.Hide();
            fDangKi.Show();
        }
    }
}