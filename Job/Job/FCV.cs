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
        int ID = -1;

        public FCV()
        {
            InitializeComponent();
            LoadLocations();
        }

        public void LoadCV(int ID)//CV đã có sẵn
        {
            this.ID = ID;   
            string connectionString = Settings.Default.Connection; // Chuỗi kết nối
            DataTable cvTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Gọi hàm GetCVByUsername
                    using (SqlCommand command = new SqlCommand("SELECT * FROM GetCVByUsername(@Username, @ID)", connection))
                    {
                        command.Parameters.AddWithValue("@Username", Data.username); // Thêm tham số Username
                        command.Parameters.AddWithValue("@ID", ID); // Thêm tham số ID

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(cvTable); // Điền dữ liệu vào DataTable
                        }
                    }

                    // Lặp qua các hàng trong DataTable để tạo UserControl cho từng CV
                    foreach (DataRow row in cvTable.Rows)
                    {
                        // Lấy dữ liệu từ các trường thông tin
                        richTextBoxMucTieuNgheNghiep.Text = row["CareerGoals"].ToString();
                        richTextBoxKinhNghiem.Text = row["Experience"].ToString();
                        richTextBoxHocVan.Text = row["Education"].ToString();
                        richTextBoxKiNang.Text = row["Skills"].ToString();
                        richTextBoxChungChi.Text = row["Certificates"].ToString();
                        richTextBoxSoThich.Text = row["Hobbies"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi lấy dữ liệu CV: " + ex.Message);
                }
            }
        }

        private void buttonLuu_Click(object sender, EventArgs e)//Tạo CV
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

            // Tạo kết nối tới cơ sở dữ liệu và gọi thủ tục UpdateCV
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Mở kết nối
                    connection.Open();

                    // Tạo một SqlCommand để gọi thủ tục UpdateCV
                    using (SqlCommand command = new SqlCommand("InsertOrUpdateCV", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@ID", ID);
                        command.Parameters.AddWithValue("@CandidateUsername", Data.username);
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

                    // Chuyển đến Form Danh Sách CV nhưng hiển thị nó trong cùng một Panel
                    FXemCV fXemCV = new FXemCV(); // Tạo instance của form danh sách CV

                    // Lấy Panel chứa form hiện tại (ví dụ: panelMain là panel cha của form hiện tại)
                    Panel parentPanel = (Panel)Parent; // Giả sử form hiện tại đang được nhúng vào một panel

                    // Xóa các form con khác bên trong panel
                    parentPanel.Controls.Clear();

                    // Thiết lập form fXemCV để nhúng vào panel
                    fXemCV.TopLevel = false;
                    fXemCV.FormBorderStyle = FormBorderStyle.None;
                    fXemCV.Dock = DockStyle.Fill;

                    // Thêm form danh sách CV vào panel
                    parentPanel.Controls.Add(fXemCV);
                    fXemCV.Show(); // Hiển thị form danh sách CV
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                }
            }
        }

        private void FCV_Load(object sender, EventArgs e)
        {
            if (ID == -1)
            {
                buttonLuu.Text = "Tạo CV";
            }
            else
            {
                buttonLuu.Text = "Lưu CV";
            }    
            string connectionString = Settings.Default.Connection; // Chuỗi kết nối đến SQL Server
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Gọi hàm trả về bảng trong SQL
                string query = "SELECT * FROM GetCandidateDetailsByUsername(@Username)"; // Gọi hàm trả về bảng

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", Data.username); // Thêm tham số cho hàm

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