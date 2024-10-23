using Guna.UI2.WinForms;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Job
{
    public partial class FDangTin : Form
    {
<<<<<<< HEAD
    
        private List<(Guna2HtmlLabel label, ComboBox comboBox)> capLabelComboBox = new List<(Guna2HtmlLabel label, ComboBox comboBox)>();
        private List<(Guna2HtmlLabel label, RichTextBox richTextBox)> capLabelRichTextBox = new List<(Guna2HtmlLabel label, RichTextBox richTextBox)>();
        public FDangTin()
        {
            InitializeComponent();
          

        }
        private void buttonDang_Click(object sender, EventArgs e)
        {


            string employerUsername = "hoan4703";
            int companyId = 1;
            string jobvacancy = labelViTri.Text.Trim();
            string description = textBoxMoTaCongViec.Text.Trim();
            string skill = textBoxKiNang.Text.Trim();
            string experience = comboBoxKinhNghiem.Text.Trim();
            decimal salaryMax = decimal.Parse(textBoxLuongToiDa.Text.Trim());
            decimal salaryMin = decimal.Parse(textBoxLuongToiThieu.Text.Trim());
            string benefits = textBoxQuyenLoi.Text.Trim();
            string workForm = comboBoxHinhThucLV.Text.Trim();

            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=BQH;Initial Catalog=Job;Persist Security Info=True;User ID=Giang;Password=123456789"))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("AddPostJob", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Thêm các tham số
                        command.Parameters.AddWithValue("@EmployerUsername", employerUsername);
                        command.Parameters.AddWithValue("@CompanyID", companyId);
                        command.Parameters.AddWithValue("@Description", description);
                        command.Parameters.AddWithValue("@Skill", skill);
                        command.Parameters.AddWithValue("@Experience", experience);
                        command.Parameters.AddWithValue("@SalaryMax", salaryMax);
                        command.Parameters.AddWithValue("@SalaryMin", salaryMin);
                        command.Parameters.AddWithValue("@Benefits", benefits);
                        command.Parameters.AddWithValue("@WorkForm", workForm);
                        command.Parameters.AddWithValue("@JobVacancy", jobvacancy);


                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Đăng bài viết thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Đăng bài viết thất bại, vui lòng thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Lỗi kết nối: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonHuy_Click_1(object sender, EventArgs e)
        {
            Close();
=======
        public FDangTin()
        {
            InitializeComponent();
>>>>>>> 8c09ce6e5d69f7524384847dbe0e3a3d2daa3bfe
        }
    }
}
