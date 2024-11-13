using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;

namespace Job
{
    public partial class FThongTinCongTy : Form
    {
        int ID;

        public FThongTinCongTy()
        {
            InitializeComponent();
        }

        private void FThongTinCongTy_Load(object sender, EventArgs e)
        {
            ID = GetCompanyID();
            CompanyInfo();
            CompanyAddresses();
            CompanyImages();
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

                    int index = comboBoxQuyMoNhanSu.Items.IndexOf(scale);
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
                                UserControlDCCT userControlDCCT = new UserControlDCCT();

                                userControlDCCT.comboBoxTinhThanh.Text = province;
                                userControlDCCT.comboBoxQuanHuyen.Text = district;
                                userControlDCCT.userControlTextDiaChi.text = street; // Sửa từ district thành street
                                userControlDCCT.DeleteRequested += UserControl_DeleteRequested;
                                // Thêm vào FlowLayoutPanel
                                flowLayoutPanelDiaChi.Controls.Add(userControlDCCT);
                            }
                        }
                    }
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

                            UserControlACT userControlACT = new UserControlACT();

                            userControlACT.pictureBoxAnh.Image = ConvertByteArrayToImage(imageBytes);
                            userControlACT.DeleteRequested += UserControl_DeleteRequested;

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

        private void UpdateCompanyImages()
        {
            // Tạo danh sách để lưu các hình ảnh
            List<byte[]> images = new List<byte[]>();

            // Duyệt qua từng UserControl trong flowLayoutPanelAnh
            foreach (Control control in flowLayoutPanelAnh.Controls)
            {
                if (control is UserControlACT userControlImage)
                {
                    // Lấy hình ảnh từ PictureBox
                    if (userControlImage.pictureBoxAnh.Image != null)
                    {
                        // Xác định định dạng của ảnh
                        ImageFormat format = userControlImage.pictureBoxAnh.Image.RawFormat;

                        // Chuyển đổi Image thành mảng byte với định dạng đã phát hiện
                        using (MemoryStream ms = new MemoryStream())
                        {
                            userControlImage.pictureBoxAnh.Image.Save(ms, format);
                            byte[] imageBytes = ms.ToArray();
                            images.Add(imageBytes);
                        }
                    }
                }
            }

            // Gọi hàm để thêm hình ảnh vào cơ sở dữ liệu
            InsertImages(images);
        }

        public void InsertImages(List<byte[]> images)
        {
            // Tạo DataTable để chứa danh sách hình ảnh
            DataTable imageTable = new DataTable();
            imageTable.Columns.Add("Image", typeof(byte[]));

            // Thêm từng hình ảnh vào DataTable
            foreach (var image in images)
            {
                imageTable.Rows.Add(image);
            }

            using (SqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("sp_UpdateCompanyImages", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Thêm tham số CompanyID
                    cmd.Parameters.Add(new SqlParameter("@CompanyID", SqlDbType.Int)).Value = ID;

                    // Thêm tham số cho danh sách hình ảnh
                    SqlParameter imagesParam = new SqlParameter("@Images", SqlDbType.Structured);
                    imagesParam.Value = imageTable;
                    imagesParam.TypeName = "dbo.tp_ImageListType"; // Đảm bảo tên trùng khớp với tên trong SQL Server
                    cmd.Parameters.Add(imagesParam);


                    // Thực thi thủ tục
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Cập nhật hình ảnh thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Hàm lấy CompanyID từ Username
        private int GetCompanyID()
        {
            int companyId = -1;
            string connectionString = Properties.Settings.Default.ConnectionAdmin;
            string query = "SELECT dbo.fn_GetCompanyIDByUsername(@Username) AS CompanyID";

            using (SqlConnection connection = DbConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", Data.username);

                connection.Open();
                var result = command.ExecuteScalar();

                if (result != DBNull.Value)
                {
                    companyId = Convert.ToInt32(result);
                }
            }

            return companyId;
        }

        public void UpdateCompanyAddresses()
        {
            // Bước 1: Chuẩn bị DataTable cho AddressListType
            DataTable addressTable = new DataTable();
            addressTable.Columns.Add("Province", typeof(string));
            addressTable.Columns.Add("District", typeof(string));
            addressTable.Columns.Add("Street", typeof(string));

            // Bước 2: Duyệt qua các Control trong flowLayoutPanelDiaChi để lấy thông tin
            foreach (UserControlDCCT control in flowLayoutPanelDiaChi.Controls)
            {
                string tinhThanh = control.comboBoxTinhThanh.Text;
                string quanHuyen = control.comboBoxQuanHuyen.Text;
                string diaChi = control.userControlTextDiaChi.text;


                DataRow row = addressTable.NewRow();
                row["Province"] = tinhThanh;
                row["District"] = quanHuyen;
                row["Street"] = diaChi;

                addressTable.Rows.Add(row);
            }

            // Bước 3: Kết nối với cơ sở dữ liệu và gọi thủ tục UpdateCompanyAddresses
            try
            {
                using (SqlConnection conn = DbConnection.GetConnection())
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_UpdateCompanyAddresses", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Truyền CompanyID
                        cmd.Parameters.Add(new SqlParameter("@CompanyID", SqlDbType.Int)).Value = ID;

                        // Truyền AddressListType (DataTable dưới dạng SqlParameter)
                        SqlParameter addressesParam = new SqlParameter("@Addresses", SqlDbType.Structured);
                        addressesParam.Value = addressTable;
                        addressesParam.TypeName = "dbo.tp_AddressListType"; // Đảm bảo tên trùng khớp với tên trong SQL Server
                        cmd.Parameters.Add(addressesParam);

                        // Thực thi thủ tục
                        cmd.ExecuteNonQuery();
                    }
                }

                // Thông báo thành công
                MessageBox.Show("Cập nhật địa chỉ công ty thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Thông báo thất bại
                MessageBox.Show("Cập nhật địa chỉ công ty thất bại. Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateCompanyInfo()
        {
            string name = userControlTextTenCongTy.text;
            string email = userControlTextCTGmail.text;
            string description = richTextBoxMoTa.Text;
            string taxCode = userControlTextCTMaSoThue.text;
            string scale = comboBoxQuyMoNhanSu.Text;
            string industry = userControlTextNganh.text;
            string website = userControlTextWebsite.text;
            DateTime createdDate = dateTimePickerNgayThanhLap.Value;
            string connectionString = Properties.Settings.Default.ConnectionAdmin;

            using (SqlConnection connection = DbConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("sp_UpdateCompanyInfo", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Thêm các tham số
                    command.Parameters.AddWithValue("@ID", ID);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Description", description);
                    command.Parameters.AddWithValue("@TaxCode", taxCode);
                    command.Parameters.AddWithValue("@Scale", scale);
                    command.Parameters.AddWithValue("@Industry", industry);
                    command.Parameters.AddWithValue("@Website", website);
                    command.Parameters.AddWithValue("@CreatedDate", createdDate);

                    // Mở kết nối và thực thi câu lệnh
                    connection.Open();
                    command.ExecuteNonQuery();

                    MessageBox.Show("Cập nhật thông tin công ty thành công!");
                }
            }
        }


        private void guna2ButtonThemAnh_Click(object sender, EventArgs e)
        {
            UserControlACT userControlDCCT = new UserControlACT();

            userControlDCCT.DeleteRequested += UserControl_DeleteRequested;
            flowLayoutPanelAnh.Controls.Add(userControlDCCT);
        }


        private void guna2ButtonThemDiaChi_Click(object sender, EventArgs e)
        {
            UserControlDCCT userControlDCCT = new UserControlDCCT();

            userControlDCCT.DeleteRequested += UserControl_DeleteRequested;
            flowLayoutPanelDiaChi.Controls.Add(userControlDCCT);
        }

        private void buttonCapNhat_Click(object sender, EventArgs e)
        {
            UpdateCompanyInfo();
            UpdateCompanyAddresses();
            UpdateCompanyImages();
        }

        private void UserControl_DeleteRequested(object sender, EventArgs e)
        {
            // Lấy UserControlDCCT được yêu cầu xóa
            UserControl userControlToRemove = sender as UserControlDCCT;

            if (userControlToRemove == null)
            {
                userControlToRemove = sender as UserControlACT;
                flowLayoutPanelAnh.Controls.Remove(userControlToRemove);
            }
            else
            {
                // Xóa khỏi FlowLayoutPanel
                flowLayoutPanelDiaChi.Controls.Remove(userControlToRemove);
            }
        }
    }
}