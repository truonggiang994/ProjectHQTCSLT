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
using System.Windows.Forms;

namespace Job
{
    public partial class UserControlCVItem : UserControl
    {
        int ID;
        public UserControlCVItem()
        {
            InitializeComponent();
        }

        // Phương thức để cập nhật thông tin CV
        public void UpdateCVInfo(int maCV, string careerGoals, string experience, string education, string skills, string certificates, string hobbies)
        {
            // Gộp toàn bộ thông tin CV
            string cvSummary = $"Mục tiêu nghề nghiệp:\n{careerGoals}\n" +
                               $"___________________________________________________________________________________________\n\n" +
                               $"Kinh nghiệm:\n{experience}\n" +
                               $"___________________________________________________________________________________________\n\n" +
                               $"Học vấn:\n{education}\n" +
                               $"___________________________________________________________________________________________\n\n" +
                               $"Kỹ năng:\n{skills}\n" +
                               $"___________________________________________________________________________________________\n\n" +
                               $"Chứng chỉ:\n{certificates}" +
                               $"___________________________________________________________________________________________\n\n" +
                               $"Sở thích:\n{hobbies}";

            guna2HtmlMaCV.Text = "Mã CV: " + maCV;
            ID = maCV;
            // Đặt nội dung cho richTextBoxTomTatCV
            richTextBoxTomTatCV.Text = cvSummary;
        }

        private void buttonXemCV_Click(object sender, EventArgs e)
        {
            FCVGuide fCV = new FCVGuide();

            fCV.CVGuide(ID,Data.username);
            FNguoiUngTuyen.Ins.LoadForm(fCV);
        }

        private void buttonXoaCV_Click(object sender, EventArgs e)
        {
            string connectionString = Settings.Default.ConnectionAdmin; // Chuỗi kết nối

            using (SqlConnection connection = DbConnection.GetConnection())
            {
                try
                {
                    connection.Open();

                    // Gọi thủ tục DeleteCVByID
                    using (SqlCommand command = new SqlCommand("DeleteCVByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ID", ID); // Thêm tham số ID

                        int rowsAffected = command.ExecuteNonQuery(); // Thực thi lệnh xóa

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Xóa CV thành công!");

                            // Xóa chính UserControl hiện tại
                            Parent.Controls.Remove(this); // Xóa UserControl khỏi Parent
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy CV với ID đã cho.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi xóa CV: " + ex.Message);
                }
            }
        }

        private void guna2ButtonSua_Click(object sender, EventArgs e)
        {
            FCV fCV = new FCV();

            fCV.LoadCV(ID);
            FNguoiUngTuyen.Ins.LoadForm(fCV);
        }
    }
}
