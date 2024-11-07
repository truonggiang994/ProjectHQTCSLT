using Job.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Job
{
    public partial class FQuanLy : Form
    {
        static public FQuanLy Instance { get; private set; }
        public HashSet<string> RoleHastSet { get; private set; }


        public FQuanLy()
        {
            InitializeComponent();
            Instance = this;
            RoleHastSet = GetRole();
            CheckAndDisableButton();
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

        public void MoFCon(Form fCon)
        {
            fCon.TopLevel = false;
            fCon.Size = panelChinh.Size;
            fCon.Location = new Point(0, 0);
            fCon.Tag = this;
            panelChinh.Controls.Add(fCon);
            fCon.BringToFront();
            fCon.Show();
        }

        HashSet<string> GetRole()
        {
            string connectionString = Settings.Default.Connection;
            HashSet<string> roleHashSet = new HashSet<string>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Mở kết nối
                connection.Open();

                // Câu truy vấn sử dụng hàm GetRole
                string query = "SELECT * FROM dbo.GetRole(@username)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Thêm tham số username
                    command.Parameters.AddWithValue("@username", Data.username);

                    // Thực thi và đọc dữ liệu
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            roleHashSet.Add(reader["Role"].ToString());
                        }
                    }
                }
            }
            return roleHashSet;
        }

        private void buttonDuyetBaiDang_Click(object sender, EventArgs e)
        {
            MoFCon(new FDuyetBaiDang());
        }

        private void buttonKhoaTaiKhoan_Click(object sender, EventArgs e)
        {
            MoFCon(new FKhoaTaiKhoan());
        }

        private void buttonLSDuyetBaiDang_Click(object sender, EventArgs e)
        {
            MoFCon(new FlichSuDuyetBaiDang());
        }

        private void buttonLSKoaTaiKhoan_Click(object sender, EventArgs e)
        {
            MoFCon(new FLichSuKhoaTaiKhoan());
        }

        private void buttonTaoTaiKhoan_Click(object sender, EventArgs e)
        {
            MoFCon(new FTaoTaiKhoanQuanly());   
        }

        private void buttonTT_Click(object sender, EventArgs e)
        {
            MoFCon(new FThongTinCaNhan());
        }

        private void CheckAndDisableButton()
        {
            // Kiểm tra và vô hiệu hóa các button dựa trên vai trò

            // Kích hoạt buttonTaoTaiKhoan nếu có quyền Create_Account, ngược lại vô hiệu hóa
            buttonTaoTaiKhoan.Enabled = RoleHastSet.Contains(GetSringRole(ERole.Create_Account));

            // Kích hoạt buttonDuyetBaiDang nếu có quyền Approve_Post, ngược lại vô hiệu hóa
            buttonDuyetBaiDang.Enabled = RoleHastSet.Contains(GetSringRole(ERole.Approve_Post));

            // Kích hoạt buttonKhoaTaiKhoan nếu có quyền Lock_Account, ngược lại vô hiệu hóa
            buttonKhoaTaiKhoan.Enabled = RoleHastSet.Contains(GetSringRole(ERole.Lock_Account));

            // Kích hoạt buttonLSKhoaTaiKhoan nếu có quyền Account_Lock_History, ngược lại vô hiệu hóa
            buttonLSKhoaTaiKhoan.Enabled = RoleHastSet.Contains(GetSringRole(ERole.Account_Lock_History));

            // Kích hoạt buttonLSDuyetBaiDang nếu có quyền Post_Approve_Histor, ngược lại vô hiệu hóa
            buttonLSDuyetBaiDang.Enabled = RoleHastSet.Contains(GetSringRole(ERole.Post_Approve_Histor));

            // Bạn có thể thực hiện tương tự với các nút khác nếu cần
        }
    }
}
