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
    public partial class UserControlDuyetbaiDang : UserControl
    {
        private int iD;

        public UserControlDuyetbaiDang(int ID)
        {
            InitializeComponent();
            iD = ID;
            TaiDuLieu(ID);
        }

        private void TaiDuLieu(int ID)
        {
            using (SqlConnection connection = DbConnection.GetConnection())
            {
                // Sử dụng câu lệnh SELECT để gọi hàm fn_GetJobPostingById
                SqlCommand command = new SqlCommand("SELECT * FROM dbo.fn_GetJobPostingById(@ID)", connection);

                // Thêm tham số cho hàm
                command.Parameters.Add(new SqlParameter("@ID", ID));

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        labelTenCongTy.Text = reader.GetString(reader.GetOrdinal("Name")).ToString();
                        labelChucVu.Text = reader.GetString(reader.GetOrdinal("JobVacancy")).ToString();
                        guna2ComboBox1.Text = "Pending";
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }


        private void buttonXemDangTin_Click(object sender, EventArgs e)
        {

            FQuanLy.Instance.MoFCon(new FThongTinViecLam(iD));
        }

        private void buttonDuyet_Click(object sender, EventArgs e)
        {
            // Lấy giá trị Status từ comboBox
            string newStatus = guna2ComboBox1.SelectedItem.ToString();

            // Kiểm tra xem giá trị trong comboBox có hợp lệ không
            if (newStatus != "Approved" && newStatus != "Rejected")
            {
                MessageBox.Show("Vui lòng chọn trạng thái hợp lệ.");
                return;
            }

            using (SqlConnection connection = DbConnection.GetConnection())
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("sp_UpdateJobPostingStatusAndHistory", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    // Thêm tham số
                    command.Parameters.Add(new SqlParameter("@AdminUsername", Data.username));
                    command.Parameters.Add(new SqlParameter("@PostJobID", iD));
                    command.Parameters.Add(new SqlParameter("@Status", newStatus));

                    // Thực thi stored procedure
                    command.ExecuteNonQuery();

                    MessageBox.Show("Cập nhật trạng thái và thêm lịch sử duyệt thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
    }
}
