using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Job
{
    public static class KiemTraDauVao
    {
        public static bool KiemTra(string taiKhoan, string matKhau)
        {
            if (string.IsNullOrEmpty(taiKhoan))
            {
                MessageBox.Show("Vui lòng nhập tài khoản!", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            else if (string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            else if (taiKhoan.Length < 7)
            {
                MessageBox.Show("Tài khoản phải có ít nhất 7 kí tự.", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            else if (matKhau.Length < 7)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 7 kí tự.", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            else if (!Regex.IsMatch(matKhau, @"\d") || !Regex.IsMatch(matKhau, "[a-zA-Z]"))
            {
                MessageBox.Show("Mật khẩu phải có kí tự chữ và số.", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }

        public static bool KiemTraControlsRong(List<(Guna2HtmlLabel label, ComboBox comboBox)> capLabelComboBox, List<(Guna2HtmlLabel label, RichTextBox richTextBox)> capRichTextBoxLabel)
        {
            foreach (var cap in capLabelComboBox)
            {
                if (cap.comboBox.SelectedItem == null)
                {
                    MessageBox.Show($"Vui lòng chọn {cap.label.Text}!");
                    cap.label.Visible = false;
                    cap.comboBox.Focus();
                    return false;
                }
            }

            foreach (var cap in capRichTextBoxLabel)
            {
                if (string.IsNullOrWhiteSpace(cap.richTextBox.Text))
                {
                    MessageBox.Show($"Vui lòng nhập {cap.label.Text}!");
                    cap.label.Visible = false;
                    cap.richTextBox.Focus();
                    return false;
                }
            }
            return true;
        }

        public static bool KiemTraTextBoxRong(params Guna2TextBox[] textBoxes)
        {
            foreach (var textBox in textBoxes)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    MessageBox.Show($"Vui lòng nhập {textBox.Name.Replace("textBox","")}!");
                    textBox.Focus();
                    return false;
                }
            }
            return true;
        }

        public static bool KiemTraComboBoxRong(params ComboBox[] comboBoxes)
        {
            foreach (var comboBox in comboBoxes)
            {
                if (string.IsNullOrWhiteSpace(comboBox.Text))
                {
                    MessageBox.Show($"Vui lòng nhập {comboBox.Name.Replace("textBox", "")}!");
                    comboBox.Focus();
                    return false;
                }
            }
            return true;
        }

        public static bool KiemTraSDT(string sdt)
        {
            // Kiểm tra xem số điện thoại có bắt đầu từ số 0 không
            if (!sdt.StartsWith("0"))
            {
                MessageBox.Show("Số điện thoại phải bắt đầu từ số 0.", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            // Kiểm tra xem số điện thoại có đủ 10 kí tự số không
            if (sdt.Length != 10 || !sdt.All(char.IsDigit))
            {
                MessageBox.Show("Số điện thoại phải có đủ 10 chữ số.", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }

        public static bool KiemTraGmail(string gmail)
        {
            // Kiểm tra xem gmail có hợp lệ không
            if (!Regex.IsMatch(gmail, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                MessageBox.Show("Gmail không hợp lệ.", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }

        public static Image ChuyenAnhSangByte(byte[] imageData)
        {
            if (imageData == null || imageData.Length == 0)
                return null;

            using (MemoryStream ms = new MemoryStream(imageData))
            {
                return Image.FromStream(ms);
            }
        }
        public static byte[] ChuyenByteSanhAnh(Image image)
        {
            if (image == null)
                return null;

            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }
    }
}
