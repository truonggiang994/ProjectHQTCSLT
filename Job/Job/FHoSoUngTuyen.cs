using Job.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Job
{
    public partial class FHoSoUngTuyen : Form
    {

        public FHoSoUngTuyen()
        {
            InitializeComponent();
            LoadData(); 
        }
        public void LoadData()
        {
            string connectionString = "Data Source=BQH;Initial Catalog=Job;Persist Security Info=True;User ID=Giang;Password=123456789";
            string query = "SELECT * FROM fn_GetApplicationSummaries(@Username)"; // Khai báo câu truy vấn

            using (SqlConnection connection = DbConnection.GetConnection())
            {
                connection.Open(); // Mở kết nối

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", Data.username); // Thêm tham số cho hàm

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int ID = reader.GetInt32(reader.GetOrdinal("ApplicationID")); // Sửa tên cột
                            string trangThai = reader.GetString(reader.GetOrdinal("Status")); // Sửa tên cột
                            int CVID = reader.GetInt32(reader.GetOrdinal("CVID"));
                            int PostJobID = reader.GetInt32(reader.GetOrdinal("PostJobID"));
                            string FullName = reader.GetString(reader.GetOrdinal("FullName")).ToString();
                            string BirthDate = Convert.ToDateTime(reader["BirthDate"]).ToString("dd/MM/yyyy");
                            string Gender = Convert.ToBoolean(reader["Gender"]) ? "Nam" : "Nữ";
                            string JobVacancy = reader.GetString(reader.GetOrdinal("JobVacancy")).ToString();
                            string UsernameCandidate = reader.GetString(reader.GetOrdinal("Username")).ToString();
                            Image anhDaiDien = null; // Khai báo ảnh

                            if (reader["Avatar"] != DBNull.Value)
                            {
                                byte[] img = (byte[])reader["Avatar"];
                                anhDaiDien = ConvertByteArrayToImage(img); // Sử dụng hàm chuyển đổi byte[] thành hình ảnh
                            }

                            // Chuyển 'anhDaiDien' cho UserControlUngVien
                            UserControlUngVien userControl = new UserControlUngVien(ID, CVID, PostJobID, FullName, Gender, BirthDate, anhDaiDien, JobVacancy, trangThai, UsernameCandidate);
                            flowLayoutPanelChinh.Controls.Add(userControl);
                        }
                    }
                }
            }
        }
        public Image ConvertByteArrayToImage(byte[] imageBytes)
        {
            if (imageBytes == null || imageBytes.Length == 0)
                return null; // Trả về null nếu mảng byte rỗng hoặc null

            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                return Image.FromStream(ms); // Chuyển đổi mảng byte thành hình ảnh
            }
        }
    }
}
