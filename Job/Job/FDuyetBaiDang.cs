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

namespace Job
{
    public partial class FDuyetBaiDang : Form
    {
        public static FDuyetBaiDang Ins;
        
        public FDuyetBaiDang()
        {
            Ins = this;
            InitializeComponent();
            LoadDuyetBaiDangControls();
        }

        private void FDuyetBaiDang_Load(object sender, EventArgs e)
        {
            LoadDuyetBaiDangControls();
        }

        public void LoadDuyetBaiDangControls()
        {
            flowLayoutPanel1.Controls.Clear();  // Xóa các control trước đó (nếu có)

            using (SqlConnection connection = DbConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand("SELECT ID FROM PostJob WHERE Status = N'Pending'", connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int postId = reader.GetInt32(0);  // Lấy ID của PostJob

                        // Tạo một instance của UserControlDuyetBaiDang
                        UserControlDuyetbaiDang control = new UserControlDuyetbaiDang(postId);

                        // Thêm control vào flowLayoutPanel
                        flowLayoutPanel1.Controls.Add(control);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
