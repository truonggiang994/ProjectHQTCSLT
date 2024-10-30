using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;

namespace Job
{
    public partial class FLichSuDangViec : Form
    {
        public FLichSuDangViec()
        {
            
            InitializeComponent();
            LoadDuyetBaiDangControls();

        }

        private void LoadDuyetBaiDangControls()
        {

            using (SqlConnection connection = new SqlConnection("Data Source=BQH;Initial Catalog=Job;Persist Security Info=True;User ID=Giang;Password=123456789"))
            {
                SqlCommand command = new SqlCommand("sp_GetPostJobByEmployerUsername", connection);
                command.CommandType = CommandType.StoredProcedure;
                string user = "hoan4703";
                command.Parameters.Add(new SqlParameter("@EmployerUsername",user ));

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {

                        string NganhNghe = reader.GetString(reader.GetOrdinal("JobVacancy")).ToString();
                        string NgayDang = reader.GetDateTime(reader.GetOrdinal("CreatedDate")).ToString("dd/MM/yyyy");
                        string MucLuongToiThieu = reader.GetDecimal(reader.GetOrdinal("SalaryMin")).ToString();
                        string MucLuongToiDa = reader.GetDecimal(reader.GetOrdinal("SalaryMax")).ToString();
                        string TrangThai = reader.GetString(reader.GetOrdinal("Status")).ToString();

                        UserControlDangTin userControlDangTin = new UserControlDangTin(NganhNghe, NgayDang, MucLuongToiThieu, MucLuongToiDa, TrangThai);
                        flowLayout.Controls.Add(userControlDangTin);

                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
