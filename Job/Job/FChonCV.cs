using Guna.UI2.AnimatorNS;
using Job.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Job
{
    public partial class FChonCV : Form
    {

        private int ID;
        public FChonCV(int ID)
        {
            this.ID = ID;
            InitializeComponent();
            LoadF();
        }

        private void FXemCV_Load(object sender, EventArgs e)
        {
            LoadF();
        }

        public void LoadF()
        {
            string connectionString = Settings.Default.ConnectionAdmin; // Chuỗi kết nối
            DataTable cvTable = new DataTable();

            using (SqlConnection connection = DbConnection.GetConnection())
            {
                try
                {
                    connection.Open();

                    // Gọi hàm GetCVByUsername
                    using (SqlCommand command = new SqlCommand("SELECT * FROM GetCVByUsername(@Username, @ID)", connection))
                    {
                        command.Parameters.AddWithValue("@Username", Data.username); // Thêm tham số Username
                        command.Parameters.AddWithValue("@ID", DBNull.Value); // Thêm tham số ID

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(cvTable); // Điền dữ liệu vào DataTable
                        }
                    }

                    // Xóa các control cũ trong flowLayoutPanel trước khi thêm mới
                    flowLayoutPanelChinh.Controls.Clear();

                    // Lặp qua các hàng trong DataTable để tạo UserControl cho từng CV
                    foreach (DataRow row in cvTable.Rows)
                    {
                        // Tạo một UserControl mới
                        UserControlCV cvControl = new UserControlCV(ID);

                        // Cập nhật thông tin CV vào UserControl
                        cvControl.UpdateCVInfo(
                            int.Parse(row["ID"].ToString()),                  // Mã CV
                            row["CareerGoals"].ToString(),         // Mục tiêu nghề nghiệp
                            row["Experience"].ToString(),          // Kinh nghiệm
                            row["Education"].ToString(),           // Học vấn
                            row["Skills"].ToString(),              // Kỹ năng
                            row["Certificates"].ToString(),        // Chứng chỉ
                            row["Hobbies"].ToString()              // Sở thích
                        );

                        // Thêm UserControl vào flowLayoutPanel
                        flowLayoutPanelChinh.Controls.Add(cvControl);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi lấy dữ liệu CV: " + ex.Message);
                }
            }
        }
}
}
