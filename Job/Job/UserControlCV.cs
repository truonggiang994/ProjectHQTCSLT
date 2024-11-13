using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Job
{
    public partial class UserControlCV : UserControl
    {
        int ID;
        int postID;
        public UserControlCV(int postID)
        {
            this.postID = postID;
            InitializeComponent();
        }
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

        private void buttonNopCV_Click(object sender, EventArgs e)
        {
            try
            {
                // Kết nối với SQL Server
                using (SqlConnection conn = DbConnection.GetConnection())
                {
                    // Mở kết nối
                    conn.Open();

                    // Khởi tạo SqlCommand với stored procedure
                    using (SqlCommand cmd = new SqlCommand("CheckCVIDByUserName", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm tham số cho stored procedure
                        cmd.Parameters.Add(new SqlParameter("@UserName", SqlDbType.NVarChar, 100)).Value = "hoan4701";
                        cmd.Parameters.Add(new SqlParameter("@PostJobID", SqlDbType.Int)).Value = postID;
                        cmd.Parameters.Add(new SqlParameter("@CVID", SqlDbType.Int)).Value = ID;

                        // Thực thi stored procedure
                        SqlParameter outputMessage = new SqlParameter("@Message", SqlDbType.NVarChar, 255)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(outputMessage);

                        // Thực thi stored procedure
                        cmd.ExecuteNonQuery();

                        // Hiển thị thông báo từ tham số OUTPUT
                        string message = outputMessage.Value.ToString();
                        MessageBox.Show(message);


                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Lỗi SQL: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
        }
    }
    
}
