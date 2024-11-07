using System;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Job
{
    public partial class FLichSuUngTuyen : Form
    {
        public FLichSuUngTuyen()
        {
            InitializeComponent();

        }
        private void LoadDuyetBaiDangControls()
        {
            flowLayoutPanel.Controls.Clear();  // Xóa các control trước đó (nếu có)

            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=BQH;Initial Catalog=Job;Persist Security Info=True;User ID=Giang;Password=123456789"))
                {
                    SqlCommand command = new SqlCommand("select * from ApplicationSubmit where ", connection);

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
                            flowLayoutPanel.Controls.Add(control);
                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi tải dữ liệu: " + ex.Message);
            }

        }
    }
}