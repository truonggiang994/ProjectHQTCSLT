using Job.Login;
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
                    using (SqlCommand command = new SqlCommand("SELECT dbo.sp_CheckAccount(@Username, @Password)", connection))
                    {
                        // Chỉ truyền đúng 2 tham số
                        command.Parameters.AddWithValue("@Username", textBoTaiKhoan.Text);
                        command.Parameters.AddWithValue("@Password", textBoxMK.Text);

                        int result = (int)command.ExecuteScalar();

                        if (result == 1)
                        {
                            if (radioButtonCandidate.Checked)
                            {
                                using (SqlCommand commandCandidate = new SqlCommand("SELECT dbo.sp_CheckAccountCandidate(@Username)", connection))
                                {
                                    commandCandidate.Parameters.AddWithValue("@Username", textBoTaiKhoan.Text);
                                    int resultCandidate = (int)commandCandidate.ExecuteScalar();
                                    if (resultCandidate == 1)
                                    {
                                        Data.username = textBoTaiKhoan.Text;
                                        FNguoiUngTuyen fNguoiUngTuyen = new FNguoiUngTuyen();
                                        this.Hide();
                                        fNguoiUngTuyen.Show();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Bạn không phải ứng viên");
                                    }
                                }
                            }
                            else if (radioButtonEmployer.Checked)
                            {
                                using (SqlCommand commandEmployer = new SqlCommand("SELECT dbo.sp_CheckAccountEmployer(@Username)", connection))
                                {
                                    commandEmployer.Parameters.AddWithValue("@Username", textBoTaiKhoan.Text);
                                    int resultEmployer = (int)commandEmployer.ExecuteScalar();
                                    if (resultEmployer == 1)
                                    {
                                        Data.username = textBoTaiKhoan.Text;
                                        FNhaTuyenDung fNhaTuyenDung = new FNhaTuyenDung();
                                        this.Hide();
                                        fNhaTuyenDung.Show();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Bạn không phải nhà ứng tuyển");
                                    }
                                }
                            }
                            else if (radioButtonAdmin.Checked)
                            {
                                using (SqlCommand commandEmployer = new SqlCommand("SELECT dbo.sp_CheckAccountAdmin(@Username)", connection))
                                {
                                    commandEmployer.Parameters.AddWithValue("@Username", textBoTaiKhoan.Text);
                                    int resultEmployer = (int)commandEmployer.ExecuteScalar();
                                    if (resultEmployer == 1)
                                    {
                                        Data.username = textBoTaiKhoan.Text;
                                        FQuanLy fQuanLy = new FQuanLy();
                                        this.Hide();
                                        fQuanLy.Show();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Bạn không phải quản lý");
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Chọn chứ vụ");
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