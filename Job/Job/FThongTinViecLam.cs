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
            using (SqlConnection connection = new SqlConnection("Data Source=BQH;Initial Catalog=Job;Persist Security Info=True;User ID=Giang;Password=123456789"))
            {
                try
                {
                    connection.Open();

                    // Tạo lệnh để gọi hàm SQL
                    using (SqlCommand cmd = new SqlCommand("dbo.GetCompanybyPostJobID", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure; // Đảm bảo rằng lệnh là một stored procedure
                        cmd.Parameters.AddWithValue("@PostJobID", ID); // Thêm tham số cho hàm

                        // Sử dụng ExecuteScalar để lấy giá trị trả về từ hàm
                      int  companyID = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
                }
            }

            return companyID;
        }
    
        private void TaiDuLieu(int ID)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=BQH;Initial Catalog=Job;Persist Security Info=True;User ID=Giang;Password=123456789"))
            {
                SqlCommand command = new SqlCommand("sp_GetJobPostingById", connection);
                command.CommandType = CommandType.StoredProcedure;
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
