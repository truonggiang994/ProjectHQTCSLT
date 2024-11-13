using Job.Properties;
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
    public partial class UserControlCVItem : UserControl
    {
        int ID;
        public UserControlCVItem()
        {
            InitializeComponent();
        }

        // Phương thức để cập nhật thông tin CV
        public void UpdateCVInfo(int maCV, string careerGoals, string experience, string education, string skills, string certificates, string hobbies)
        {
            // Gộp toàn bộ thông tin CV
            string cvSummary = $"Mục tiêu nghề nghiệp:\n{careerGoals}\n" +
                               $"___________________________________________________________________________________________\n\n" +
                               $"Kinh nghiệm:\n{experience}\n" +
                               $"___________________________________________________________________________________________\n\n" +
                               $"Học vấn:\n{education}\n" +
                               $"___________________________________________________________________________________________\n\n" +
                               $"Kỹ năng:\n{skills}\n" +
                               $"___________________________________________________________________________________________\n\n" +
                               $"Chứng chỉ:\n{certificates}" +
                               $"___________________________________________________________________________________________\n\n" +
                               $"Sở thích:\n{hobbies}";

            guna2HtmlMaCV.Text = "Mã CV: " + maCV;
            ID = maCV;
            // Đặt nội dung cho richTextBoxTomTatCV
            richTextBoxTomTatCV.Text = cvSummary;
        }

        private void buttonXemCV_Click(object sender, EventArgs e)
        {
            FCVGuide fCV = new FCVGuide();

            fCV.CVGuide(ID,Data.username);
            FNguoiUngTuyen.Ins.LoadForm(fCV);
        }

        private void guna2ButtonSua_Click(object sender, EventArgs e)
        {
            FCV fCV = new FCV();

            fCV.LoadCV(ID);
            FNguoiUngTuyen.Ins.LoadForm(fCV);
        }
    }
}
