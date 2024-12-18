﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        public UserControlUngVien(int ID, int CVID, int PostJobID, string hoTen, string gioiTinh, string ngaySinh, Image anhDaiDien, string viTri, string trangthai, string UsernameCandidate)
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

            labelChucVu.Text = "Ứng tuyển vô: " + viTri;
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
            if (!co)
            {
                using (SqlConnection connection = DbConnection.GetConnection())
                {
                    using (SqlCommand command = new SqlCommand("sp_UpdateApplicationStatus", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ApplicationSubmitID", iD);

                        try
                        {
                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                // Cập nhật thành công, thay đổi trạng thái nút và hiển thị thông báo
                                buttonTuyen.Text = "Đã tuyển";
                                buttonTuyen.Enabled = false;
                                co = true;
                                MessageBox.Show("Ứng viên đã được tuyển thành công!");
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy ứng viên hoặc cập nhật thất bại.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi: " + ex.Message);
                        }
                    }
                }
            }
        }
        private void buttonPhuongVan_Click(object sender, EventArgs e)
        {
            FNhaTuyenDung.Instance.MoFCon(new FHenPhongVan(iD, PostJobID, UsernameCandidate, hoTen, viTri, ngaySinh, gioiTinh));
        }
    }
}

