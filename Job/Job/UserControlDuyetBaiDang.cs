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
                        guna2ComboBox1.Text = "Pending";
                        
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

                    // 1. Cập nhật bảng PostJob
                    SqlCommand updatePostJobCommand = new SqlCommand("UPDATE PostJob SET Status = @Status WHERE ID = @ID", connection, transaction);
                    updatePostJobCommand.Parameters.Add(new SqlParameter("@Status", newStatus));
                    updatePostJobCommand.Parameters.Add(new SqlParameter("@ID", iD));
                    updatePostJobCommand.ExecuteNonQuery();

                    // 2. Thêm bản ghi vào bảng ApprovalHistory
                    SqlCommand insertHistoryCommand = new SqlCommand("INSERT INTO ApprovalHistory (AdminUsername, PostJobID, Status) VALUES (@AdminUsername, @PostJobID, @Status)", connection, transaction);
                    insertHistoryCommand.Parameters.Add(new SqlParameter("@AdminUsername", "adminGiang")); 
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
