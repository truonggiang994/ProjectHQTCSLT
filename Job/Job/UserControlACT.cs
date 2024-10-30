using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Job
{
    public partial class UserControlACT : UserControl
    {
        public UserControlACT()
        {
            InitializeComponent();
        }

        public event EventHandler DeleteRequested;

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            // Gọi sự kiện DeleteRequested để thông báo cho thằng cha
            DeleteRequested?.Invoke(this, EventArgs.Empty);
        }

        private void guna2ButtonTaiAnh_Click(object sender, EventArgs e)
        {            // Khởi tạo OpenFileDialog
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                // Chỉ cho phép chọn file ảnh
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                // Nếu người dùng chọn ảnh
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Gán đường dẫn của ảnh vào PictureBox
                    pictureBoxAnh.Image = Image.FromFile(ofd.FileName);
                }
            }
        }
    }
}
