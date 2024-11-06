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
    public partial class FNhanPhongVan : Form
    {
        string usernameCandidate;
        int applicationSubmitID;
        string viTri;
        string tenCongTy;
        public FNhanPhongVan(int applicationSubmitID,string usernameCandidate,  string viTri, string tenCongTy)
        {
            InitializeComponent();
            this.usernameCandidate = usernameCandidate;
            this.applicationSubmitID = applicationSubmitID;
            this.viTri = viTri;
            this.tenCongTy = tenCongTy;
        }
        private void TaiDuLieuUI()
        {
            string connectionString = "Data Source=BQH;Initial Catalog=Job;Persist Security Info=True;User ID=Giang;Password=123456789";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Lệnh SQL để lấy dữ liệu từ bảng Interview
                string query = "SELECT InterviewerName, InterviewDate, AddressID, Note FROM Interview WHERE ApplicationSubmitID = @ApplicationSubmitID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ApplicationSubmitID", applicationSubmitID);
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Gán giá trị từ SQL Reader vào các control
                            labelHoTen.Text = "Họ và Tên: " + reader["InterviewerName"].ToString();
                            labelNgayPhongVan.Text = "Ngày phỏng vấn: " + Convert.ToDateTime(reader["InterviewDate"]).ToString("dd/MM/yyyy");
                            labelChucVu.Text = "Vị trí ứng tuyển: " + viTri;  // Giả định 'viTri' là biến đã được truyền vào FNhanPhongVan

                            // Thông tin địa chỉ từ bảng Address
                            int addressID = (int)reader["AddressID"];
                            string addressQuery = "SELECT Province, District, Street FROM Address WHERE ID = @AddressID";
                            using (SqlCommand addressCommand = new SqlCommand(addressQuery, connection))
                            {
                                addressCommand.Parameters.AddWithValue("@AddressID", addressID);
                                using (SqlDataReader addressReader = addressCommand.ExecuteReader())
                                {
                                    if (addressReader.Read())
                                    {
                                        labelDiaChi.Text = "Địa chỉ: " + addressReader["Street"] + ", " + addressReader["District"] + ", " + addressReader["Province"];
                                    }
                                }
                            }

                            labelThongTin.Text = "Công ty " + tenCongTy + 
                                "thông báo: Hồ sơ ứng tuyển của anh/chị đã chúng tôi tiếp nhận. Chugns tôi xin trân trọng kính mời anh/chị đến tham gia phỏng vấn." +
                                "Ghi chú: " + reader["Note"].ToString();
                            labelThongTinNguoiPhongvan.Text = "Mọi chi tiết, anh/chị vui lòng liên hệ " + reader["InterviewName"].ToString() + " qua số điện thoại: "
                                + reader["Phone"].ToString() + " hoặc email: " + reader["Email"].ToString() + " để biết thêm chi tiết. \n"
                                + "Rất mong Anh/Chị thu xếp thời gian tham gia. Trường hợp Anh/Chị không thể thu xếp được thời gian, xin vui lòng liên hệ lại chúng tôi theo số điện thoại/địa chỉ trên để xác nhận lại.\n"
                                + "\r\nTrân trọng kính chào!";
                        }
                    }
                    connection.Close();
                }
            }
        }

        private void labelHoTen_Click(object sender, EventArgs e)
        {

        }
    }

}
