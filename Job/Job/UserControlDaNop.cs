using Guna.UI2.WinForms;
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
    public partial class UserControlDaNop : UserControl
    {
        private int iD;
        string usernameCandidate;
        int applicationSubmitID;
        string viTri;
        string tenCongTy;
        public UserControlDaNop(int ID, int applicationSubmitID, string usernameCandidate)
        {
            this.iD = ID;
            this.usernameCandidate = usernameCandidate;
            this.applicationSubmitID = applicationSubmitID;
            InitializeComponent();
            TaiDuLieu(iD);
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

                        labelTenCongTy.Text = reader.GetString(reader.GetOrdinal("Name")).ToString();
                        labelChucVu.Text = reader.GetString(reader.GetOrdinal("JobVacancy")).ToString();
                        labelTrangThai.Text = reader.GetString(reader.GetOrdinal("Status")).ToString();
                        viTri = reader.GetString(reader.GetOrdinal("JobVacancy")).ToString();
                        tenCongTy = reader.GetString(reader.GetOrdinal("Name")).ToString();
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

            FNguoiUngTuyen.Ins.LoadForm(new FThongTinViecLam(iD));
        }

        private void buttonXemPhongVan_Click(object sender, EventArgs e)
        {
            FNguoiUngTuyen.Ins.LoadForm(new FNhanPhongVan(applicationSubmitID, usernameCandidate, viTri, tenCongTy));
        }
    }
}
