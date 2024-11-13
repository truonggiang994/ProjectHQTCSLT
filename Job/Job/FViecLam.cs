using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Job
{

    public partial class FViecLam : Form
    {
        public FViecLam()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            using (SqlConnection connection = DbConnection.GetConnection())
            {
                connection.Open();

                // Câu truy vấn SQL trực tiếp từ bảng view vw_JobPostings với điều kiện status = 'Approved'
                using (SqlCommand command = new SqlCommand("SELECT * FROM vw_JobPostings WHERE status = 'Approved'", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int ID = reader.GetInt32(reader.GetOrdinal("ID"));
                            string CompanyName = reader.GetString(reader.GetOrdinal("Name")).ToString();
                            string JobVacancy = reader.GetString(reader.GetOrdinal("JobVacancy")).ToString();
                            string SalaryMax = reader.GetDecimal(reader.GetOrdinal("SalaryMax")).ToString();
                            string SalaryMin = reader.GetDecimal(reader.GetOrdinal("SalaryMin")).ToString();
                            string address = reader.GetString(reader.GetOrdinal("Street")).ToString();
                            string salary = $"{SalaryMin} - {SalaryMax} ";

                            UserControlViecLam userControl = new UserControlViecLam(ID, CompanyName, address, salary, JobVacancy);
                            flowLayoutPanelChinh.Controls.Add(userControl);
                        }
                    }
                }
            }

        }

        private void FViecLam_Load(object sender, EventArgs e)
        {

        }
    }
}