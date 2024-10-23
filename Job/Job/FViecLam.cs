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
            using (SqlConnection connection = new SqlConnection("Data Source=BQH;Initial Catalog=Job;Persist Security Info=True;User ID=Giang;Password=123456789"))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("sp_GetAllJobPostings", connection))
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
    }
}
