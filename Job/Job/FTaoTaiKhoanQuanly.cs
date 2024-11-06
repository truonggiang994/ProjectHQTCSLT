using Job.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;

namespace Job
{
    public partial class FTaoTaiKhoanQuanly : Form
    {
        public FTaoTaiKhoanQuanly()
        {
            InitializeComponent();
            CheckAndDisableCheckBox();
        }

        private void CheckAndDisableCheckBox()
        {
            // Kiểm tra và vô hiệu hóa các button dựa trên vai trò

            // Kích hoạt buttonTaoTaiKhoan nếu có quyền Create_Account, ngược lại vô hiệu hóa
            guna2CheckBoxTaoTaiKhoan.Enabled = FQuanLy.Instance.RoleHastSet.Contains(GetSringRole(ERole.Create_Account));

            // Kích hoạt buttonDuyetBaiDang nếu có quyền Approve_Post, ngược lại vô hiệu hóa
            guna2CheckBoxDuyetBai.Enabled = FQuanLy.Instance.RoleHastSet.Contains(GetSringRole(ERole.Approve_Post));

            // Kích hoạt buttonKhoaTaiKhoan nếu có quyền Lock_Account, ngược lại vô hiệu hóa
            guna2CheckBoxKhoaTaiKhoan.Enabled = FQuanLy.Instance.RoleHastSet.Contains(GetSringRole(ERole.Lock_Account));

            // Kích hoạt buttonLSKhoaTaiKhoan nếu có quyền Account_Lock_History, ngược lại vô hiệu hóa
            guna2CheckBoxLichSuKhoaTaiKhoan.Enabled = FQuanLy.Instance.RoleHastSet.Contains(GetSringRole(ERole.Account_Lock_History));

            // Kích hoạt buttonLSDuyetBaiDang nếu có quyền Post_Approve_Histor, ngược lại vô hiệu hóa
            guna2CheckBoxLichSuDuyetBaiDang.Enabled = FQuanLy.Instance.RoleHastSet.Contains(GetSringRole(ERole.Post_Approve_Histor));

            // Bạn có thể thực hiện tương tự với các nút khác nếu cần
        }

        public string GetSringRole(ERole role)
        {
            switch (role)
            {
                case ERole.Create_Account:
                    return "Create Account";
                case ERole.Approve_Post:
                    return "Approve Post";
                case ERole.Lock_Account:
                    return "Lock Account";
                case ERole.Account_Lock_History:
                    return "Account Lock History";
                case ERole.Post_Approve_Histor:
                    return "Post Approve History";
            }
            return "Unknown Role";
        }


        private void buttonDangKi_Click(object sender, EventArgs e)
        {
            string connectionString = Settings.Default.Connection;

            try
            {
                // Kiểm tra thông tin nhập vào, ví dụ password phải khớp
                if (textBoxPassword.Text != textBoxReEnterPassword.Text)
                {
                    MessageBox.Show("Mật khẩu không khớp!");
                    return;
                }

                // Chuẩn bị các tham số
                string username = textBoxAccount.Text;
                string password = textBoxPassword.Text;
                string email = textBoxEmail.Text;
                string phone = textBoxPhone.Text;
                string managerUsername = Data.username; // Bạn có thể lấy từ một textbox hoặc điều kiện nào đó
                DataTable rolesTable = new DataTable();
                rolesTable.Columns.Add("Role", typeof(string));

                // Thêm vai trò dựa trên trạng thái của các CheckBox
                if (guna2CheckBoxLichSuKhoaTaiKhoan.Checked)
                {
                    rolesTable.Rows.Add("Account Lock History");
                }

                if (guna2CheckBoxLichSuDuyetBaiDang.Checked)
                {
                    rolesTable.Rows.Add("Post Approve History");
                }

                if (guna2CheckBoxKhoaTaiKhoan.Checked)
                {
                    rolesTable.Rows.Add("Lock Account");
                }

                if (guna2CheckBoxDuyetBai.Checked)
                {
                    rolesTable.Rows.Add("Approve Post");
                }

                if (guna2CheckBoxTaoTaiKhoan.Checked)
                {
                    rolesTable.Rows.Add("Create Account");
                }

                // Kết nối tới SQL và gọi stored procedure
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("dbo.AddAdminWithRoles", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm các tham số cho stored procedure
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Phone", phone);
                        cmd.Parameters.AddWithValue("@ManagerUsername", managerUsername);

                        // Vai trò là kiểu dữ liệu bảng (table-valued parameter)
                        SqlParameter rolesParam = new SqlParameter("@Roles", SqlDbType.Structured);
                        rolesParam.TypeName = "dbo.RoleListType"; // Đảm bảo TypeName chính xác với kiểu trong DB
                        rolesParam.Value = rolesTable;
                        cmd.Parameters.Add(rolesParam);

                        string result = cmd.ExecuteScalar()?.ToString();
                        if (result != null && result == "1")
                        {
                            MessageBox.Show("Đăng ký admin thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Đã có lỗi xảy ra.");
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }
    }

    public enum ERole
    {
        Create_Account = 0,
        Approve_Post = 1,
        Lock_Account = 2,
        Account_Lock_History = 3,
        Post_Approve_Histor = 4
    }
}
