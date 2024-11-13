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
        int cVID;
        int applicationSubmitID;
        string viTri;
        string tenCongTy;
        string Fullname;
        string trangThai;
        public UserControlDaNop(int ID, int applicationSubmitID, string FullName, int CVID, string trangThai)
        {
            iD = ID;
            cVID = CVID;
            this.applicationSubmitID = applicationSubmitID;
            Fullname = FullName;
            this.trangThai = trangThai;
            InitializeComponent();
            TaiDuLieu(iD);
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
                        labelTrangThai.Text = trangThai;
                        viTri = reader.GetString(reader.GetOrdinal("JobVacancy")).ToString();
                        tenCongTy = reader.GetString(reader.GetOrdinal("Name")).ToString();
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }

                // Kiểm tra nếu applicationSubmitID không tồn tại thì ẩn nút
                if (!CheckApplicationSubmitIDExists(applicationSubmitID))
                {
                    buttonXemPhongVan.Visible = false;
                }
            }

        }


        private bool CheckApplicationSubmitIDExists(int applicationSubmitID)
        {
            bool exists = false;
            string query = "SELECT COUNT(1) FROM Interview WHERE ApplicationSubmitID = @ApplicationSubmitID";

            using (SqlConnection connection = DbConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ApplicationSubmitID", applicationSubmitID);

                connection.Open();
                exists = (int)command.ExecuteScalar() > 0;
            }

            return exists;
        }

        private void buttonXemDangTin_Click(object sender, EventArgs e)
        {

            FNguoiUngTuyen.Ins.LoadForm(new FThongTinViecLam(iD));
        }

        private void buttonXemPhongVan_Click(object sender, EventArgs e)
        {
            FNguoiUngTuyen.Ins.LoadForm(new FNhanPhongVan(applicationSubmitID, viTri, tenCongTy));
        }

        private void buttonCV_Click(object sender, EventArgs e)
        {
            FCVGuide fCVGuide = new FCVGuide();
            fCVGuide.CVGuide(cVID, Data.username);
            FNguoiUngTuyen.Ins.LoadForm(fCVGuide);
        }
    }
}