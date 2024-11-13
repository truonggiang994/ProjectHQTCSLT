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
    public partial class FThongTinViecLam : Form
    {
        private int ID;
        private int companyID;
        public FThongTinViecLam(int ID)
        {
            InitializeComponent();
            TaiDuLieu(ID);
            this.ID = ID;
            companyID = GetIDCompany();
        }
        private int GetIDCompany()
        {
            using (SqlConnection connection = DbConnection.GetConnection())
            {
                int companyID = 0; // Khai báo biến ngoài try-catch để có thể trả về ngoài vòng lặp
                try
                {
                    connection.Open();

                    // Tạo câu lệnh SQL để gọi function
                    string query = "SELECT dbo.fn_GetCompanybyPostJobID(@PostJobID)";  // Gọi function

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@PostJobID", ID); // Thêm tham số cho function

                        // Sử dụng ExecuteScalar để lấy giá trị trả về từ function
                        object result = cmd.ExecuteScalar();

                        if (result != DBNull.Value)  // Kiểm tra xem kết quả có phải là DBNull không
                        {
                            companyID = Convert.ToInt32(result); // Lưu giá trị vào biến
                        }
                        else
                        {
                            Console.WriteLine("Không tìm thấy CompanyID cho PostJobID " + ID);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
                }

                return companyID;  // Trả về companyID sau khi đã lấy xong
            }
        }

        private void TaiDuLieu(int ID)
        {
            using (SqlConnection connection = DbConnection.GetConnection())
            {

                SqlCommand command = new SqlCommand("SELECT * FROM dbo.fn_GetJobPostingById(@ID)", connection);

                // Thêm tham số cho hàm
                command.Parameters.Add(new SqlParameter("@ID", ID));

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        labelMucLuong.Text = $"{reader.GetDecimal(reader.GetOrdinal("SalaryMin"))} - {reader.GetDecimal(reader.GetOrdinal("SalaryMax"))} triệu";
                        labelName.Text = reader.GetString(reader.GetOrdinal("Name")).ToString();
                        userControlLabelViTri.LabelText = reader.GetString(reader.GetOrdinal("JobVacancy")).ToString();
                        userControlLabelSkill.LabelText = reader.GetString(reader.GetOrdinal("Skill")).ToString();
                        userControlLabelWorkForm.LabelText = reader.GetString(reader.GetOrdinal("WorkForm")).ToString();
                        userControlLabelKinhNghiem.LabelText = reader.GetString(reader.GetOrdinal("Experience")).ToString();
                        labelMoTaCongViec.Text = reader.GetString(reader.GetOrdinal("Description")).ToString();
                        labelQuyenLoi.Text = reader.GetString(reader.GetOrdinal("Benefits")).ToString();
                        labelDiaDiemLamViec.Text = reader.GetString(reader.GetOrdinal("Street")).ToString();
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void buttonBack_Click_1(object sender, EventArgs e)
        {
            Dispose();
        }

        private void buttonNopHoSo_Click(object sender, EventArgs e)
        {
            FChonCV fChon = new FChonCV(ID);
            fChon.ShowDialog();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FXemCongTy fXemCongTy = new FXemCongTy(companyID);
            fXemCongTy.ShowDialog();

        }
    }
}
