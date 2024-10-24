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
    public partial class UserControlDuyetbaiDang : UserControl
    {
        private int iD;
        public UserControlDuyetbaiDang()
        {
            InitializeComponent();
        }
        private bool co = false;
        private bool cof = false;
        public UserControlDuyetbaiDang(int ID)
        {
            InitializeComponent();
            iD = ID;
            TaiDuLieu(ID);
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
                        guna2ComboBox1.SelectedText = reader.GetString(reader.GetOrdinal("Status")).ToString(); ;
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

            FQuanLy.Instance.MoFCon(  new FThongTinViecLam(iD));
        }
        
        private void buttonDuyet_Click(object sender, EventArgs e)
        {
            // Lấy giá trị Status từ comboBox
            string newStatus = guna2ComboBox1.SelectedItem.ToString();

            // Kiểm tra xem giá trị trong comboBox có hợp lệ không
            if (newStatus != "Approved" && newStatus != "Rejected")
            {
                MessageBox.Show("Vui lòng chọn trạng thái hợp lệ.");
                return;
            }
            using (SqlConnection connection = new SqlConnection("Data Source=BQH;Initial Catalog=Job;Persist Security Info=True;User ID=Giang;Password=123456789"))
            {
                SqlTransaction transaction = null;
                try
                {
                    connection.Open();
                    transaction = connection.BeginTransaction();

                    // 1. Gọi thủ tục cập nhật PostJob
                    SqlCommand updatePostJobCommand = new SqlCommand("usp_UpdatePostJobStatus", connection, transaction);
                    updatePostJobCommand.CommandType = CommandType.StoredProcedure;
                    updatePostJobCommand.Parameters.Add(new SqlParameter("@ID", iD));
                    updatePostJobCommand.Parameters.Add(new SqlParameter("@Status", newStatus));
                    updatePostJobCommand.ExecuteNonQuery();

                    // 2. Gọi thủ tục thêm bản ghi vào ApprovalHistory
                    SqlCommand insertHistoryCommand = new SqlCommand("usp_InsertApprovalHistory", connection, transaction);
                    insertHistoryCommand.CommandType = CommandType.StoredProcedure;
                    insertHistoryCommand.Parameters.Add(new SqlParameter("@AdminUsername", "test0")); // Thay thế 'Giang' bằng admin hiện tại
                    insertHistoryCommand.Parameters.Add(new SqlParameter("@PostJobID", iD));
                    insertHistoryCommand.Parameters.Add(new SqlParameter("@Status", newStatus));
                    insertHistoryCommand.ExecuteNonQuery();

                    // Commit transaction
                    transaction.Commit();
                    MessageBox.Show("Cập nhật trạng thái thành công!");
                }
                catch (Exception ex)
                {
                    // Nếu có lỗi, rollback transaction
                    transaction?.Rollback();
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
    }
}
