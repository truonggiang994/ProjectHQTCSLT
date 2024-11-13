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
    public partial class FHenPhongVan : Form
    {
        private string usernameCandidate;
        private int PostJobID;
        private string viTri;
        private int ID;
        private string ngaySinh;
        private string gioiTinh;
        public FHenPhongVan(int ID, int PostJobID, string usernameCandidate, string hoTen, string viTri, string ngaySinh, string gioiTinh)
        {
            InitializeComponent();
            this.ID = ID;
            this.usernameCandidate = usernameCandidate;
            this.PostJobID = PostJobID;
            this.viTri = viTri;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;

            UserControlDCCT userControlDCCT = new UserControlDCCT();
            userControlDCCT.buttonXoa.Size = new Size(0, 0);
            panel1.Controls.Add(userControlDCCT);
            labelHoTen.Text = "Họ và tên: " + hoTen;
            labelGioiTinh.Text = "Giới tính: " + gioiTinh;
            labelNgaySinh.Text = "Ngày sinh: " + ngaySinh;
            labelChucVu.Text = "Ứng tuyển vô: " + viTri;
            TaiDuLieuUI();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void TaiDuLieuUI()
        {
            using (SqlConnection connection = DbConnection.GetConnection())
            {
                string query = "SELECT * FROM dbo.fn_GetInterviewByApplicationSubmitID(@ID)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", ID);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Nếu có dữ liệu, gán dữ liệu vào các điều khiển
                            textBoxHoTen.Text = reader["InterviewerName"].ToString();
                            textBoxSDT.Text = reader["Phone"].ToString();
                            dateTimePickerNgayPhongVan.Value = Convert.ToDateTime(reader["InterviewDate"]);
                            textBoxGmail.Text = reader["Email"].ToString();
                            richTextBox.Text = reader["Note"].ToString();
                            labelChucVu.Text = "Ứng tuyển vô: " + viTri;
                            buttonGuiThongTin.Text = "Đã gửi";
                            buttonGuiThongTin.Enabled = false;
                        }
                        else
                        {
                            buttonGuiThongTin.Enabled = true;
                        }
                    }
                }
            }
        }

        private int InsertAddress()
        {
            if (panel1.Controls.Count > 0 && panel1.Controls[0] is UserControlDCCT control)
            {
                control.buttonXoa.Size = new Size(0, 0);
                string tinhThanh = control.comboBoxTinhThanh.Text;
                string quanHuyen = control.comboBoxQuanHuyen.Text;
                string diaChi = control.userControlTextDiaChi.text;

                try
                {
                    using (SqlConnection conn = DbConnection.GetConnection())
                    {
                        conn.Open();

                        using (SqlCommand cmd = new SqlCommand("sp_InsertAddess", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.Add(new SqlParameter("@Province", SqlDbType.NVarChar)).Value = tinhThanh;
                            cmd.Parameters.Add(new SqlParameter("@District", SqlDbType.NVarChar)).Value = quanHuyen;
                            cmd.Parameters.Add(new SqlParameter("@Street", SqlDbType.NVarChar)).Value = diaChi;

                            // Lấy ID của địa chỉ mới được chèn
                            int newID = Convert.ToInt32(cmd.ExecuteScalar());
                            return newID;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cập nhật địa chỉ thất bại. Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Không có địa chỉ nào để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return -1; // Trả về -1 nếu không thành công
        }

        private void LuuThongTinPhongVan(int applicationSubmitID, string email, string phone, int addressID,
                                 string interviewerName, DateTime interviewDate, DateTime acceptDate, string note)
        {
            using (SqlConnection connection = DbConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("sp_InsertInterview", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ApplicationSubmitID", applicationSubmitID);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Phone", phone);
                    command.Parameters.AddWithValue("@AddressID", addressID);
                    command.Parameters.AddWithValue("@InterviewerName", interviewerName);
                    command.Parameters.AddWithValue("@InterviewDate", interviewDate);
                    command.Parameters.AddWithValue("@AcceptDate", acceptDate);
                    command.Parameters.AddWithValue("@Note", note);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Thông tin đã được lưu thành công!", "Thông báo");
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message, "Thông báo lỗi");
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        public void UpdateAddressAndSaveInterview()
        {
            // Lấy IDAddress sau khi chèn địa chỉ mới
            int IDAddress = InsertAddress();

            if (IDAddress == -1)
            {
                MessageBox.Show("Thêm địa chỉ thất bại, vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Gọi lưu thông tin phỏng vấn
            int iD = ID;
            string email = textBoxGmail.Text;
            string sDT = textBoxSDT.Text;
            string hoTen = textBoxHoTen.Text;
            DateTime ngayGui = DateTime.Now;
            DateTime ngayPhongVan = dateTimePickerNgayPhongVan.Value;
            string note = richTextBox.Text;

            LuuThongTinPhongVan(iD, email, sDT, IDAddress, hoTen, ngayPhongVan, ngayGui, note);
            MessageBox.Show("Đã lưu thông tin hẹn phỏng vấn thành công!", "Thông báo");
        }

        private void buttonGuiThongTin_Click(object sender, EventArgs e)
        {
            buttonGuiThongTin.Text = "Đã gửi";
            buttonGuiThongTin.Enabled = false;
            UpdateAddressAndSaveInterview();
        }

        private void FHenPhongVan_Load(object sender, EventArgs e)
        {

        }
    }
}
