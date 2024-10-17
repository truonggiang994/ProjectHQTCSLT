using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Job
{
    public partial class FNhapCamNang : Form
    {
        public FNhapCamNang()
        {
            InitializeComponent();
        }
        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Lấy thông tin từ các điều khiển trên form
                string tieuDe = guna2TextBox9NhapTieuDe.Text;
                string noiDung = guna2TextBox10NhapNoiDung.Text;
                string label1 = guna2TextBox9TieuDe1.Text;
                string richTextBox1 = richTextBoxNoiDung1.Text;
                string label2 = guna2TextBox10TieuDe2.Text;
                string richTextBox2 = richTextBoxNoiDung2.Text;
                string label3 = guna2TextBox11TieuDe3.Text;
                string richTextBox3 = richTextBoxNoiDung3.Text;
                string label4 = guna2TextBox12TieuDe4.Text;
                string richTextBox4 = richTextBoxNoiDung4.Text;
                string label5 = guna2TextBox9TieuDe5.Text;
                string richTextBox5 = richTextBox1NoiDung5.Text;
                string label6 = guna2TextBox9TieuDe6.Text;
                string richTextBox6 = richTextBoxNoiDung6.Text;
                Image anh = pictureBoxLoGo.Image;
                // Kiểm tra xem các giá trị không rỗng
                if (string.IsNullOrEmpty(tieuDe) || string.IsNullOrEmpty(noiDung) || string.IsNullOrEmpty(label1))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                CamNang camNang = new CamNang(anh,tieuDe, noiDung, label1, richTextBox1, label2, richTextBox2, label3, richTextBox3, label4, richTextBox4, label5, richTextBox5, label6, richTextBox6);

                // Gọi đối tượng DAO để thêm dữ liệu vào cơ sở dữ liệu
                CamNangDAO camNangDao = new CamNangDAO();
                camNangDao.ThemDangTin(camNang);

                MessageBox.Show("Thông tin đã được lưu thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi lưu thông tin: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBoxLoGo.Image = Image.FromFile(ofd.FileName);
            }
        }
    }
}
