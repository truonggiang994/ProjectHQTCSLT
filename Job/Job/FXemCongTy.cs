using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace Job
{
    public partial class FXemCongTy : Form
    {
        private int ID;

        public FXemCongTy(int ID)
        {
            this.ID = ID;
            InitializeComponent();
            CompanyInfo();
            CompanyAddresses();
            CompanyImages();
            userControlTextCTGmail.Enabled = false;
            userControlTextCTMaSoThue.Enabled = false;
            userControlTextNganh.Enabled = false;
            userControlTextSDT.Enabled = false;
            userControlTextTenCongTy.Enabled = false;
            userControlTextWebsite.Enabled = false;
            dateTimePickerNgayThanhLap.Enabled = false;
            comboBoxQuyMoNhanSu.Enabled = false;
            richTextBoxMoTa.Enabled = false;
        }

     
        private void CompanyInfo()
        {
            string connectionString = Properties.Settings.Default.ConnectionAdmin; // Thay bằng chuỗi kết nối của bạn

            // Câu lệnh SQL để gọi hàm GetCompanyInfo
            string query = "SELECT * FROM dbo.fn_GetCompanyInfo(@ID)";

            using (SqlConnection connection = DbConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", ID);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // Gán dữ liệu vào các thành phần giao diện
                    userControlTextTenCongTy.text = reader["Name"].ToString();
                    userControlTextNganh.text = reader["Industry"].ToString();
                    userControlTextWebsite.text = reader["Description"].ToString();
                    userControlTextSDT.text = reader["TaxCode"].ToString();
                    userControlTextCTGmail.text = reader["Email"].ToString();
                    userControlTextCTMaSoThue.text = reader["TaxCode"].ToString();
                    userControlTextWebsite.text = reader["Website"].ToString();
                    string scale = reader["Scale"].ToString();

                    int index = comboBoxQuyMoNhanSu.Items.IndexOf(scale + " ");
                    comboBoxQuyMoNhanSu.SelectedIndex = index; // Chọn mục nếu có
                    richTextBoxMoTa.Text = reader["Description"].ToString();
                    dateTimePickerNgayThanhLap.Value = Convert.ToDateTime(reader["CreatedDate"]);
                }

                reader.Close();
            }
        }

        public void CompanyAddresses()
        {
            try
            {
                flowLayoutPanelDiaChi.Controls.Clear();
                // Tạo một danh sách để lưu các địa chỉ của công ty
                List<string> addressList = new List<string>();

                using (SqlConnection conn = DbConnection.GetConnection())
                {
                    conn.Open();

                    // Tạo lệnh SQL để gọi hàm GetCompanyAddresses
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.fn_GetCompanyAddresses(@CompanyID)", conn))
                    {
                        cmd.Parameters.Add(new SqlParameter("@CompanyID", SqlDbType.Int)).Value = ID;

                        // Thực hiện lệnh và đọc dữ liệu
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string province = reader["Province"].ToString();
                                string district = reader["District"].ToString();
                                string street = reader["Street"].ToString();

                                // Thêm địa chỉ vào danh sách
                                addressList.Add($"{street}, {district}, {province}");

                                // Tạo một UserControlDCCT mới và gán giá trị cho nó
                                UserControlDCCTView userControlDCCT = new UserControlDCCTView();

                                userControlDCCT.comboBoxTinhThanh.Text = province;
                                userControlDCCT.comboBoxQuanHuyen.Items.Add(district);
                                userControlDCCT.comboBoxQuanHuyen.Text = district;
                                userControlDCCT.userControlTextDiaChi.text = street; // Sửa từ district thành street
                               
                                // Thêm vào FlowLayoutPanel
                                flowLayoutPanelDiaChi.Controls.Add(userControlDCCT);
                            }
                        }
                    }
                }

                // Hiển thị danh sách địa chỉ
                if (addressList.Count == 0)
                {
                    MessageBox.Show("Không có địa chỉ nào cho công ty này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy danh sách địa chỉ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CompanyImages()
        {
            using (SqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                // Tạo lệnh SQL để gọi hàm GetCompanyImages
                using (SqlCommand cmd = new SqlCommand("SELECT Image FROM dbo.fn_GetCompanyImages(@CompanyID)", conn))
                {
                    cmd.Parameters.Add(new SqlParameter("@CompanyID", SqlDbType.Int)).Value = ID;

                    // Thực hiện lệnh và đọc dữ liệu
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        flowLayoutPanelAnh.Controls.Clear();
                        while (reader.Read())
                        {
                            // Lấy hình ảnh và thêm vào danh sách
                            byte[] imageBytes = (byte[])reader["Image"];

                            UserControlACTView userControlACT = new UserControlACTView();

                            userControlACT.pictureBoxAnh.Image = ConvertByteArrayToImage(imageBytes);

                            flowLayoutPanelAnh.Controls.Add(userControlACT);
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

       

        private void labelThongTinCongTy_Click(object sender, EventArgs e)
        {

        }

        private void labelTTCaNhan_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanelAnh_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBoxNgayThanhLap_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePickerNgayThanhLap_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void richTextBoxMoTa_TextChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanelDiaChi_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxQuyMoNhanSu_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxQuyMoNhanSu_Enter(object sender, EventArgs e)
        {

        }

        private void comboBoxQuyMoNhanSu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void userControlTextTenCongTy_Load(object sender, EventArgs e)
        {

        }

        private void userControlTextCTGmail_Load(object sender, EventArgs e)
        {

        }

        private void userControlTextCTMaSoThue_Load(object sender, EventArgs e)
        {

        }

        private void userControlTextSDT_Load(object sender, EventArgs e)
        {

        }

        private void userControlTextWebsite_Load(object sender, EventArgs e)
        {

        }

        private void userControlTextNganh_Load(object sender, EventArgs e)
        {

        }
    }
}
