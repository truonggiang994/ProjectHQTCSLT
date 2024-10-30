using Job.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Job
{
    public partial class FCVGuide : Form
    {
        int ID;
        string username;
        public FCVGuide()
        {
            InitializeComponent();
        }

        public void CVGuide(int ID, string username)
        {
            this.ID = ID;
            this.username = username;
            string connectionString = "Data Source=BQH;Initial Catalog=Job;Persist Security Info=True;User ID=Giang;Password=123456789";
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
                            labelHoTen.Text = reader["FullName"].ToString();
                            labelGmail.Text = "Email: " + reader["Email"].ToString();
                            labelNgaySinh.Text = "Ngày sinh: " + Convert.ToDateTime(reader["BirthDate"]).ToString("dd/MM/yyyy");
                            labelDiaChi.Text = "Địa chỉ: " + $"{reader["Province"].ToString()}, {reader["District"].ToString()}, {reader["Street"].ToString()}";
                            labelSDT.Text = "Số điện thoại: " + reader["Phone"].ToString();

                            // Giới tính
                            if (Convert.ToBoolean(reader["Gender"]))
                            {
                                labelGioiTinh.Text = "Giới tính: Nam";
                            }
                            else
                            {
                                labelGioiTinh.Text = "Giới tính: Nữ";
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

            DataTable cvTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Gọi hàm GetCVByUsername
                    using (SqlCommand command = new SqlCommand("SELECT * FROM GetCVByUsername(@Username, @ID)", connection))
                    {
                        command.Parameters.AddWithValue("@Username", username); // Thêm tham số Username
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
                        richTextBoxMucTieuNN.Text = row["CareerGoals"].ToString();
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

        public Image ConvertByteArrayToImage(byte[] imageBytes)
        {
            if (imageBytes == null || imageBytes.Length == 0)
                return null; // Trả về null nếu mảng byte rỗng hoặc null

            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                return Image.FromStream(ms); // Chuyển đổi mảng byte thành hình ảnh
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
