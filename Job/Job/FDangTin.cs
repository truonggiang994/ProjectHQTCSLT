﻿using Guna.UI2.WinForms;
using Newtonsoft.Json;
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
using System.Data.SqlClient;

namespace Job
{
    public partial class FDangTin : Form
    {

        private List<(Guna2HtmlLabel label, ComboBox comboBox)> capLabelComboBox = new List<(Guna2HtmlLabel label, ComboBox comboBox)>();
        private List<(Guna2HtmlLabel label, RichTextBox richTextBox)> capLabelRichTextBox = new List<(Guna2HtmlLabel label, RichTextBox richTextBox)>();
        public FDangTin()
        {
            InitializeComponent();


        }
        private void buttonDang_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = DbConnection.GetConnection())
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("sp_AddPostJob", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Thêm các tham số
                        command.Parameters.AddWithValue("@EmployerUsername", Data.username);
                        command.Parameters.AddWithValue("@Description", textBoxMoTaCongViec.Text);
                        command.Parameters.AddWithValue("@Skill", textBoxKiNang.Text);
                        command.Parameters.AddWithValue("@Experience", comboBoxKinhNghiem.Text);
                        command.Parameters.AddWithValue("@SalaryMax", textBoxLuongToiDa.Text);
                        command.Parameters.AddWithValue("@SalaryMin", textBoxLuongToiThieu.Text);
                        command.Parameters.AddWithValue("@Benefits", textBoxQuyenLoi.Text);
                        command.Parameters.AddWithValue("@WorkForm", comboBoxHinhThucLV.Text);
                        command.Parameters.AddWithValue("@JobVacancy", textBoxChucDanh.Text);


                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Đăng bài viết thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Đăng bài viết thất bại, vui lòng thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Lỗi kết nối: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonHuy_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
