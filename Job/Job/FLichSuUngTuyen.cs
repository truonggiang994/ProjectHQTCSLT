using System;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Job
{
    public partial class FLichSuUngTuyen : Form
    {
        public FLichSuUngTuyen()
        {
            InitializeComponent();
            LoadControls();
        }
        private void LoadControls()
        {
            flowLayoutPanel.Controls.Clear();  // Xóa các control trước đó (nếu có)

            string connectionString = "Data Source=BQH;Initial Catalog=Job;Persist Security Info=True;User ID=Giang;Password=123456789";
            string query = "SELECT * FROM GetApplicationSubmitted(@Username)"; // Khai báo câu truy vấn

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open(); // Mở kết nối

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", Data.username); // Thêm tham số cho hàm

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int applicationSubmitID = reader.GetInt32(reader.GetOrdinal("ApplicationID")); // Sửa tên cột
                            string trangThai = reader.GetString(reader.GetOrdinal("Status")); // Sửa tên cột
                            int CVID = reader.GetInt32(reader.GetOrdinal("CVID"));
                            int PostJobID = reader.GetInt32(reader.GetOrdinal("PostJobID"));
                            string FullName = reader.GetString(reader.GetOrdinal("FullName")).ToString();
                            string BirthDate = Convert.ToDateTime(reader["BirthDate"]).ToString("dd/MM/yyyy");
                            string Gender = Convert.ToBoolean(reader["Gender"]) ? "Nam" : "Nữ";
                            string JobVacancy = reader.GetString(reader.GetOrdinal("JobVacancy")).ToString();
                            string UsernameCandidate = reader.GetString(reader.GetOrdinal("Username")).ToString();
                            
                            // Chuyển 'anhDaiDien' cho UserControlUngVien
                            UserControlDaNop control = new UserControlDaNop(PostJobID, applicationSubmitID, FullName, CVID);

                            // Thêm control vào flowLayoutPanel
                            flowLayoutPanel.Controls.Add(control);
                        }
                        reader.Close();
                    }
                }
            }
        }
    }
}