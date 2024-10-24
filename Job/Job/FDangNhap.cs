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
        private DatabaseConnection db;
        public FDangNhap()
        {
            InitializeComponent();
            db = new DatabaseConnection();
        }
        private void buttonDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                    db.OpenConnection();
                using (SqlCommand command = new SqlCommand("sp_CheckAccount", db.GetConnection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Chỉ truyền đúng 2 tham số
                    command.Parameters.AddWithValue("@Username", textBoTaiKhoan.Text);
                    command.Parameters.AddWithValue("@Password", textBoxMK.Text);

                    // Không cần thêm tham số OUTPUT nếu stored procedure không yêu cầu
                    object resultObj = command.ExecuteScalar(); // Thực thi và lấy kết quả

                    if (resultObj != null)
                    {
                        int result = (int)resultObj;
                        if (result == 1)
                        {
                            if (radioButtonCandidate.Checked)
                            {
                                using (SqlCommand commandCandidate = new SqlCommand("sp_CheckAccountCandidate", db.GetConnection))
                                {
                                    commandCandidate.CommandType = CommandType.StoredProcedure;
                                    commandCandidate.Parameters.AddWithValue("@Username", textBoTaiKhoan.Text);
                                    object resultObjCandidate = commandCandidate.ExecuteScalar();
                                    if (resultObjCandidate != null)
                                    {
                                        int resultCandidate = (int)resultObjCandidate;
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
                                    else
                                    {
                                        MessageBox.Show("Lỗi Candidate trả về null");
                                    }
                                }
                            }
                            else if (radioButtonEmployer.Checked)
                            {
                                using (SqlCommand commandEmployer = new SqlCommand("sp_CheckAccountEmployer", db.GetConnection))
                                {
                                    commandEmployer.CommandType = CommandType.StoredProcedure;
                                    commandEmployer.Parameters.AddWithValue("@Username", textBoTaiKhoan.Text);
                                    object resultObjEmployer = commandEmployer.ExecuteScalar();
                                    if (resultObjEmployer != null)
                                    {
                                        int resultEmployer = (int)resultObjEmployer;
                                        if (resultEmployer == 1)
                                        {
                                            Data.username = textBoTaiKhoan.Text;

                                            FNhaTuyenDung fNhaTuyenDung = new FNhaTuyenDung();
                                            this.Hide();
                                            fNhaTuyenDung.Show();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Bạn không phải nhà tuyển dụng");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Lỗi Employer trả về null");
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
                    }
                    else
                    {
                        MessageBox.Show("Đã xảy ra lỗi: Kết quả trả về là null.");
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
