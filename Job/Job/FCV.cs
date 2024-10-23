using Guna.UI2.WinForms;
using Job.Properties;
using Newtonsoft.Json;
using System;
using System.Collections;
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
    public partial class FCV : Form
    {
        string username = "hoan4701"; // Giả sử bạn đã có tên người dùng ứng viên

        public FCV()
        {
            InitializeComponent();
            LoadLocations();
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            // Chuẩn bị kết nối tới cơ sở dữ liệu
            string connectionString = Settings.Default.Connection; // Sửa lại cho phù hợp với cấu hình của bạn
            // Lấy dữ liệu từ các trường thông tin
            string careerGoals = richTextBoxMucTieuNgheNghiep.Text;
            string experience = richTextBoxKinhNghiem.Text;
            string education = richTextBoxHocVan.Text;
            string skills = richTextBoxKiNang.Text;
            string certificates = richTextBoxChungChi.Text;
            string hobbies = richTextBoxSoThich.Text;

            // Tạo kết nối tới cơ sở dữ liệu và gọi thủ tục InsertCV
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Mở kết nối
                    connection.Open();

                    // Tạo một SqlCommand để gọi thủ tục InsertCV
                    using (SqlCommand command = new SqlCommand("InsertCV", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Thêm các tham số cho thủ tục
                        command.Parameters.AddWithValue("@CandidateUsername", username);
                        command.Parameters.AddWithValue("@CareerGoals", careerGoals);
                        command.Parameters.AddWithValue("@Experience", experience);
                        command.Parameters.AddWithValue("@Education", education);
                        command.Parameters.AddWithValue("@Skills", skills);
                        command.Parameters.AddWithValue("@Certificates", certificates);
                        command.Parameters.AddWithValue("@Hobbies", hobbies);

                        // Thực thi thủ tục
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("CV đã được lưu thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                }
            }
        }

        private void FCV_Load(object sender, EventArgs e)
        {
            string connectionString = Settings.Default.Connection; // Chuỗi kết nối đến SQL Server
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Gọi hàm trả về bảng trong SQL
                string query = "SELECT * FROM GetCandidateDetailsByUsername(@Username)"; // Gọi hàm trả về bảng

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username); // Thêm tham số cho hàm

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read()) // Kiểm tra xem có dữ liệu không
                        {
                            textBoxHoTen.Text = reader["FullName"].ToString();
                            textBoxGmail.Text = reader["Email"].ToString();
                            dateTimePickerNgaySinh.Value = Convert.ToDateTime(reader["BirthDate"]);
                            comboBoxTinhThanh.Text = reader["Province"].ToString();
                            comboBoxQuanHuyen.Text = reader["District"].ToString();
                            textBoxSoNha.Text = reader["Street"].ToString();
                            textboxSDT.Text = reader["Phone"].ToString();

                            // Giới tính
                            if (Convert.ToBoolean(reader["Gender"]))
                            {
                                comboBoxGioiTinh.Text = "Nam";
                            }
                            else
                            {
                                comboBoxGioiTinh.Text = "Nữ";
                            }

                            // Đọc và hiển thị ảnh
                            if (reader["Avatar"] != DBNull.Value)
                            {
                                byte[] img = (byte[])reader["Avatar"];
                                pictureBoxAnhDaiDien.Image = ConvertByteArrayToImage(img); // Sử dụng hàm chuyển đổi byte[] thành hình ảnh
                            }
                        }
                        else
                        {
                            MessageBox.Show("No data found for the given username.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
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



        //Khu vực

        // Dictionary để chứa dữ liệu tỉnh thành và quận huyện
        private Dictionary<string, List<string>> locations = new Dictionary<string, List<string>>();

        // Hàm để đọc file JSON và lưu vào Dictionary
        private void LoadLocations()
        {
            // Kiểm tra nếu đã có dữ liệu trong locations
            if (locations.Any())
            {
                return;
            }

            // Lấy đường dẫn tới thư mục chứa file Address.json
            string resourcesFolder = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory); // D:\IT\ProjectHQTCSLT\Job\Job\bin\Debug\Resources

            string projectBasePath = resourcesFolder.Substring(0, resourcesFolder.IndexOf(@"\bin"));
            string fullPath = Path.Combine(projectBasePath, "Resources", "Address.json");

            // Đọc nội dung file JSON
            string jsonContent = File.ReadAllText(fullPath);

            // Deserialise JSON vào Dictionary
            locations = JsonConvert.DeserializeObject<Dictionary<string, List<string>>>(jsonContent);

            // Gán danh sách tỉnh thành vào comboBoxTinhThanh
            comboBoxTinhThanh.DataSource = new BindingSource(locations, null); // Sử dụng BindingSource để gán

            // Đặt tên hiển thị cho comboBoxTinhThanh
            comboBoxTinhThanh.DisplayMember = "Key"; // Hiển thị tên tỉnh thành
        }

        // Sự kiện khi người dùng chọn tỉnh thành
        private void comboBoxTinhThanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTinhThanh.SelectedItem != null)
            {
                var selectedProvince = (KeyValuePair<string, List<string>>)comboBoxTinhThanh.SelectedItem;
                comboBoxQuanHuyen.DataSource = selectedProvince.Value; // Gán danh sách quận huyện tương ứng
            }
        }

    }
}