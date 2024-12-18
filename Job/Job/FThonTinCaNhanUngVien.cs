﻿using Job.Properties;
using Newtonsoft.Json;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Job
{
    public partial class FThonTinCaNhanUngVien : Form
    {
        public FThonTinCaNhanUngVien()
        {
            InitializeComponent();
            LoadLocations();
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = DbConnection.GetConnection())
            {
                connection.Open();

                // Gọi stored procedure UpdateCandidateInfo
                using (SqlCommand cmd = new SqlCommand("sp_UpdateCandidateInfo", connection))
                {
                    // Chỉ định kiểu của command là Stored Procedure
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Thêm các tham số từ các control trên form
                    cmd.Parameters.AddWithValue("@Username", Data.username);
                    cmd.Parameters.AddWithValue("@Email", textBoxGmail.Text);
                    cmd.Parameters.AddWithValue("@Phone", textboxSDT.Text);
                    cmd.Parameters.AddWithValue("@Password", guna2TextBoxPassword.Text);
                    cmd.Parameters.AddWithValue("@FullName", textBoxHoTen.Text);
                    cmd.Parameters.AddWithValue("@BirthDate", dateTimePickerNgaySinh.Value);
                    cmd.Parameters.AddWithValue("@Gender", comboBoxGioiTinh.SelectedIndex == 1); // Nam: 0, Nữ: 1
                    cmd.Parameters.AddWithValue("@Province", comboBoxTinhThanh.Text);
                    cmd.Parameters.AddWithValue("@District", comboBoxQuanHuyen.Text);
                    cmd.Parameters.AddWithValue("@Street", textBoxSoNha.Text);

                    // Xử lý ảnh đại diện
                    try
                    {
                        byte[] avatar = GetAvatarBytes(pictureBoxAnhDaiDien.Image);
                        cmd.Parameters.AddWithValue("@Avatar", avatar);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi lưu ảnh: " + ex.Message);
                        return; // Ngừng thực hiện nếu có lỗi
                    }

                    // Thực thi stored procedure
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thông tin đã được lưu thành công.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi lưu thông tin: " + ex.Message);
                    }
                }
            }
        }

        private byte[] GetAvatarBytes(Image image)
        {
            if (image == null) return null;

            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }


        private void FThonTinCaNhanUngVien_Load(object sender, EventArgs e)
        {
            string connectionString = Settings.Default.ConnectionAdmin; // Chuỗi kết nối đến SQL Server
            using (SqlConnection connection = DbConnection.GetConnection())
            {
                // Gọi hàm trả về bảng trong SQL
                string query = "SELECT * FROM fn_GetCandidateDetailsByUsername(@Username)"; // Gọi hàm trả về bảng

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

        private void buttonTaiAnh_Click(object sender, EventArgs e)
        {
            // Khởi tạo OpenFileDialog
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                // Chỉ cho phép chọn file ảnh
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                // Nếu người dùng chọn ảnh
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Gán đường dẫn của ảnh vào PictureBox
                    pictureBoxAnhDaiDien.Image = Image.FromFile(ofd.FileName);
                }
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
