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
    public partial class UserControlDangTin : UserControl
    {

        public UserControlDangTin(string NganhNghe , string NgayDang , String LuongMin,string LuongMax, string Status)
            
        {
            InitializeComponent();
            labelNganhNghe.Text = NganhNghe;
            labelNgayDang.Text = NgayDang;
            labelMucLuongToiThieu.Text = LuongMin;
            labelMucLuongToiDa.Text = LuongMax;
            labelTrangThai.Text = Status;

        }
        private void TaiDuLieu()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=BQH;Initial Catalog=Job;Persist Security Info=True;User ID=Giang;Password=123456789"))
            {
                SqlCommand command = new SqlCommand("sp_GetPostJobByEmployerUsername", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@EmployerUsername", Data.username));

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {

                        labelNganhNghe.Text = reader.GetString(reader.GetOrdinal("JobVacancy")).ToString();
                        labelNgayDang.Text = reader.GetDateTime(reader.GetOrdinal("CreatedDate")).ToString("dd/MM/yyyy");
                        labelMucLuongToiThieu.Text = reader.GetDecimal(reader.GetOrdinal("SalaryMin")).ToString();
                        labelMucLuongToiDa.Text= reader.GetDecimal(reader.GetOrdinal("SalaryMax")).ToString();
                        labelTrangThai.Text = reader.GetString(reader.GetOrdinal("Status")).ToString();

                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
        private void labelTrangThaiHanNop_Click(object sender, EventArgs e)
        {

        }

        private void guna2VSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSua_Click(object sender, EventArgs e)
        {

        }
    }
}
