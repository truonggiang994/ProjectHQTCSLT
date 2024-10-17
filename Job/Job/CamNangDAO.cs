using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job
{
    public class CamNangDAO
    {
        private string connectionString;

        public CamNangDAO()
        {
            this.connectionString = Properties.Settings.Default.Connection;

        }

        public void ThemDangTin(CamNang camNang)
        {
            string query = "INSERT INTO CamNang (LoiGioiThieu, NoiDung, label1, richTextBox1, label2, richTextBox2, label3, richTextBox3, label4, richTextBox4,label5, richTextBox5,label6, richTextBox6) VALUES (@LoiGioiThieu, @NoiDung, @label1, @richTextBox1, @label2, @richTextBox2, @label3, @richTextBox3, @label4, @richTextBox4,@label5, @richTextBox5,@label6, @richTextBox6)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@AnhDaiDien", KiemTraDauVao.ChuyenByteSanhAnh(camNang.Anh));
                command.Parameters.AddWithValue("@LoiGioiThieu", camNang.TieuDe);
                command.Parameters.AddWithValue("@NoiDung", camNang.NoiDung);
                command.Parameters.AddWithValue("@label1", camNang.Label1);
                command.Parameters.AddWithValue("@richTextBox1", camNang.RichTextBox1);
                command.Parameters.AddWithValue("@label2", camNang.Label2);
                command.Parameters.AddWithValue("@richTextBox2", camNang.RichTextBox2);
                command.Parameters.AddWithValue("@label3", camNang.Label3);
                command.Parameters.AddWithValue("@richTextBox3", camNang.RichTextBox3);
                command.Parameters.AddWithValue("@label4", camNang.Label4);
                command.Parameters.AddWithValue("@richTextBox4", camNang.RichTextBox4);
                command.Parameters.AddWithValue("@label5", camNang.Label5);
                command.Parameters.AddWithValue("@richTextBox5", camNang.RichTextBox5);
                command.Parameters.AddWithValue("@label6", camNang.Label5);
                command.Parameters.AddWithValue("@richTextBox6", camNang.RichTextBox5);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public List<CamNang> NhanThongTinCamNang()
        {
            List<CamNang> camNangs = new List<CamNang>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "select * from CamNang";

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    CamNang camNang = new CamNang();
                    camNang.Anh = KiemTraDauVao.ChuyenAnhSangByte((byte[])reader["AnhDaiDien"]);
                    camNang.TieuDe = reader["LoiGioiThieu"].ToString();
                    camNang.NoiDung = reader["NoiDung"].ToString();
                    camNang.Label1 = reader["label1"].ToString();
                    camNang.RichTextBox1 = reader["richTextBox1"].ToString();
                    camNang.Label2 = reader["label2"].ToString();
                    camNang.RichTextBox2 = reader["richTextBox2"].ToString();
                    camNang.Label3 = reader["label3"].ToString();
                    camNang.RichTextBox3 = reader["richTextBox3"].ToString();
                    camNang.Label4 = reader["label4"].ToString();
                    camNang.RichTextBox4 = reader["richTextBox4"].ToString();
                    camNang.Label5 = reader["label5"].ToString();
                    camNang.RichTextBox5 = reader["richTextBox5"].ToString();
                    camNang.Label6 = reader["label6"].ToString();
                    camNang.RichTextBox6 = reader["richTextBox6"].ToString();

                    camNangs.Add(camNang);
                }
            }
            return camNangs;
        }
    }
}
