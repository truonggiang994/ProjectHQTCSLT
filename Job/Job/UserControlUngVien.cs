using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Job
{
    public partial class UserControlUngVien : UserControl
    {
        private int iD;
        private int CVID;
        private int PostJobID;
        private string UsernameCandidate;
        private bool co = false;
        string viTri;
        string ngaySinh;
        string hoTen;
        string gioiTinh;
        public UserControlUngVien(int ID,int CVID, int PostJobID, string hoTen, string gioiTinh, string ngaySinh, Image anhDaiDien, string viTri, string trangthai, string UsernameCandidate)
        {
            InitializeComponent();
            this.iD = ID;
            this.CVID = CVID;
            this.PostJobID = PostJobID;
            this.UsernameCandidate = UsernameCandidate;
            this.viTri = viTri;
            this.ngaySinh = ngaySinh;
            this.hoTen = hoTen;
            this.gioiTinh = gioiTinh;
            labelHoTen.Text = "Họ và tên: " + hoTen;
            labelGioiTinh.Text = "Giới tính: " + gioiTinh;
            labelNgaySinh.Text = "Ngày sinh: " + ngaySinh;
            pictureBoxAnhDaiDien.Image = anhDaiDien;

            labelChucVu.Text = "Ứng tuyển vô: " +viTri;
            if (trangthai == "Accepted")
            {
                buttonTuyen.Text = "Đã tuyển";
                buttonTuyen.Enabled = false;
                co = true;
            }

        }

        public Image ConvertByteArrayToImage(byte[] imageBytes)
        {
            if (imageBytes == null || imageBytes.Length == 0)
                return null; // Trả về null nếu mảng byte rỗng hoặc null

            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                return Image.FromStream(ms); // Chuyển đổi mảng byte thành hình ảnh
            }
        }

        private void buttonXemChiTiet_Click(object sender, EventArgs e)
        {
            FCVGuide fCVGuide = new FCVGuide();
            fCVGuide.CVGuide(CVID, UsernameCandidate);
            FNhaTuyenDung.Instance.MoFCon(fCVGuide);
        }
        private void buttonTuyen_Click(object sender, EventArgs e)
        {
            if (co == false)
            {
                buttonTuyen.Text = "Đã tuyển";
                buttonTuyen.Enabled = false;
                MessageBox.Show("Đã thêm vô danh sách yêu thích");
            }
        }
        private void buttonPhuongVan_Click(object sender, EventArgs e)
        {
            FNhaTuyenDung.Instance.MoFCon(new FHenPhongVan(iD, PostJobID, UsernameCandidate, hoTen, viTri, ngaySinh, gioiTinh));
        }
    }
}
