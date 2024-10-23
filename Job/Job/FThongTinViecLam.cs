using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Job
{
    public partial class FThongTinViecLam : Form
    {

        private int ID; 
        public FThongTinViecLam(int ID)
        {
            InitializeComponent();
            TaiDuLieu(ID);
            this.ID = ID;
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

        private void labelMoTaCongViec_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonNopHoSo_Click(object sender, EventArgs e)
        {

        }
    }
}
