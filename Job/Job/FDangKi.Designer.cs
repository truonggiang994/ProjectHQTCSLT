using static Guna.UI2.WinForms.Suite.Descriptions;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Printing;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Job
{
    partial class FDangKi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FDangKi));
            this.panelDangKi = new System.Windows.Forms.Panel();
            this.pictureBoxDaiDien = new Guna.UI2.WinForms.Guna2PictureBox();
            this.buttonDangKi = new Guna.UI2.WinForms.Guna2Button();
            this.textBoxNhapLaiMK = new Guna.UI2.WinForms.Guna2TextBox();
            this.buttonBack = new Guna.UI2.WinForms.Guna2ImageButton();
            this.textBoxMK = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxTaiKhoan = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelDangKi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDaiDien)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDangKi
            // 
            this.panelDangKi.Controls.Add(this.guna2TextBox1);
            this.panelDangKi.Controls.Add(this.pictureBoxDaiDien);
            this.panelDangKi.Controls.Add(this.buttonDangKi);
            this.panelDangKi.Controls.Add(this.textBoxNhapLaiMK);
            this.panelDangKi.Controls.Add(this.buttonBack);
            this.panelDangKi.Controls.Add(this.textBoxMK);
            this.panelDangKi.Controls.Add(this.textBoxTaiKhoan);
            this.panelDangKi.Location = new System.Drawing.Point(5, 1);
            this.panelDangKi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDangKi.Name = "panelDangKi";
            this.panelDangKi.Size = new System.Drawing.Size(575, 354);
            this.panelDangKi.TabIndex = 18;
            // 
            // pictureBoxDaiDien
            // 
            this.pictureBoxDaiDien.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDaiDien.Image")));
            this.pictureBoxDaiDien.ImageRotate = 0F;
            this.pictureBoxDaiDien.Location = new System.Drawing.Point(15, 25);
            this.pictureBoxDaiDien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxDaiDien.Name = "pictureBoxDaiDien";
            this.pictureBoxDaiDien.Size = new System.Drawing.Size(187, 172);
            this.pictureBoxDaiDien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDaiDien.TabIndex = 24;
            this.pictureBoxDaiDien.TabStop = false;
            // 
            // buttonDangKi
            // 
            this.buttonDangKi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonDangKi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonDangKi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonDangKi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonDangKi.FillColor = System.Drawing.Color.DarkGray;
            this.buttonDangKi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDangKi.ForeColor = System.Drawing.Color.White;
            this.buttonDangKi.Location = new System.Drawing.Point(305, 306);
            this.buttonDangKi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDangKi.Name = "buttonDangKi";
            this.buttonDangKi.Size = new System.Drawing.Size(149, 37);
            this.buttonDangKi.TabIndex = 22;
            this.buttonDangKi.Text = "Đăng kí";
            // 
            // textBoxNhapLaiMK
            // 
            this.textBoxNhapLaiMK.Animated = true;
            this.textBoxNhapLaiMK.BorderColor = System.Drawing.Color.Teal;
            this.textBoxNhapLaiMK.BorderRadius = 7;
            this.textBoxNhapLaiMK.BorderThickness = 3;
            this.textBoxNhapLaiMK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxNhapLaiMK.DefaultText = "";
            this.textBoxNhapLaiMK.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxNhapLaiMK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxNhapLaiMK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxNhapLaiMK.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxNhapLaiMK.FillColor = System.Drawing.SystemColors.Control;
            this.textBoxNhapLaiMK.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxNhapLaiMK.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.textBoxNhapLaiMK.ForeColor = System.Drawing.Color.Maroon;
            this.textBoxNhapLaiMK.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxNhapLaiMK.IconLeft = ((System.Drawing.Image)(resources.GetObject("textBoxNhapLaiMK.IconLeft")));
            this.textBoxNhapLaiMK.IconLeftSize = new System.Drawing.Size(22, 22);
            this.textBoxNhapLaiMK.IconRightSize = new System.Drawing.Size(22, 22);
            this.textBoxNhapLaiMK.Location = new System.Drawing.Point(208, 122);
            this.textBoxNhapLaiMK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNhapLaiMK.Name = "textBoxNhapLaiMK";
            this.textBoxNhapLaiMK.PasswordChar = '*';
            this.textBoxNhapLaiMK.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.textBoxNhapLaiMK.PlaceholderText = "Nhập lại mật khẩu";
            this.textBoxNhapLaiMK.SelectedText = "";
            this.textBoxNhapLaiMK.Size = new System.Drawing.Size(349, 37);
            this.textBoxNhapLaiMK.TabIndex = 21;
            // 
            // buttonBack
            // 
            this.buttonBack.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.buttonBack.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.buttonBack.Image = ((System.Drawing.Image)(resources.GetObject("buttonBack.Image")));
            this.buttonBack.ImageOffset = new System.Drawing.Point(0, 0);
            this.buttonBack.ImageRotate = 0F;
            this.buttonBack.ImageSize = new System.Drawing.Size(25, 25);
            this.buttonBack.Location = new System.Drawing.Point(525, 310);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.buttonBack.Size = new System.Drawing.Size(33, 33);
            this.buttonBack.TabIndex = 11;
            // 
            // textBoxMK
            // 
            this.textBoxMK.Animated = true;
            this.textBoxMK.BorderColor = System.Drawing.Color.Teal;
            this.textBoxMK.BorderRadius = 7;
            this.textBoxMK.BorderThickness = 3;
            this.textBoxMK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxMK.DefaultText = "";
            this.textBoxMK.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxMK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxMK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxMK.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxMK.FillColor = System.Drawing.SystemColors.Control;
            this.textBoxMK.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxMK.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.textBoxMK.ForeColor = System.Drawing.Color.Maroon;
            this.textBoxMK.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxMK.IconLeft = ((System.Drawing.Image)(resources.GetObject("textBoxMK.IconLeft")));
            this.textBoxMK.IconLeftSize = new System.Drawing.Size(22, 22);
            this.textBoxMK.IconRightSize = new System.Drawing.Size(22, 22);
            this.textBoxMK.Location = new System.Drawing.Point(208, 78);
            this.textBoxMK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxMK.Name = "textBoxMK";
            this.textBoxMK.PasswordChar = '*';
            this.textBoxMK.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.textBoxMK.PlaceholderText = "Mật khẩu";
            this.textBoxMK.SelectedText = "";
            this.textBoxMK.Size = new System.Drawing.Size(349, 37);
            this.textBoxMK.TabIndex = 19;
            // 
            // textBoxTaiKhoan
            // 
            this.textBoxTaiKhoan.Animated = true;
            this.textBoxTaiKhoan.BorderColor = System.Drawing.Color.Teal;
            this.textBoxTaiKhoan.BorderRadius = 7;
            this.textBoxTaiKhoan.BorderThickness = 3;
            this.textBoxTaiKhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxTaiKhoan.DefaultText = "";
            this.textBoxTaiKhoan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxTaiKhoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxTaiKhoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxTaiKhoan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxTaiKhoan.FillColor = System.Drawing.SystemColors.Control;
            this.textBoxTaiKhoan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.textBoxTaiKhoan.ForeColor = System.Drawing.Color.Maroon;
            this.textBoxTaiKhoan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxTaiKhoan.IconLeft = ((System.Drawing.Image)(resources.GetObject("textBoxTaiKhoan.IconLeft")));
            this.textBoxTaiKhoan.IconLeftSize = new System.Drawing.Size(22, 22);
            this.textBoxTaiKhoan.IconRight = ((System.Drawing.Image)(resources.GetObject("textBoxTaiKhoan.IconRight")));
            this.textBoxTaiKhoan.Location = new System.Drawing.Point(208, 32);
            this.textBoxTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxTaiKhoan.Name = "textBoxTaiKhoan";
            this.textBoxTaiKhoan.PasswordChar = '\0';
            this.textBoxTaiKhoan.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.textBoxTaiKhoan.PlaceholderText = "Tài khoản";
            this.textBoxTaiKhoan.SelectedText = "";
            this.textBoxTaiKhoan.Size = new System.Drawing.Size(349, 37);
            this.textBoxTaiKhoan.TabIndex = 18;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Animated = true;
            this.guna2TextBox1.BorderColor = System.Drawing.Color.Teal;
            this.guna2TextBox1.BorderRadius = 7;
            this.guna2TextBox1.BorderThickness = 3;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FillColor = System.Drawing.SystemColors.Control;
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.guna2TextBox1.ForeColor = System.Drawing.Color.Maroon;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.IconLeft = ((System.Drawing.Image)(resources.GetObject("guna2TextBox1.IconLeft")));
            this.guna2TextBox1.IconLeftSize = new System.Drawing.Size(22, 22);
            this.guna2TextBox1.IconRightSize = new System.Drawing.Size(22, 22);
            this.guna2TextBox1.Location = new System.Drawing.Point(208, 183);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '*';
            this.guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.guna2TextBox1.PlaceholderText = "Nhập lại mật khẩu";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(349, 37);
            this.guna2TextBox1.TabIndex = 25;
            // 
            // FDangKi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 357);
            this.ControlBox = false;
            this.Controls.Add(this.panelDangKi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(6, 1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FDangKi";
            this.Text = "FDangKi";
            this.panelDangKi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDaiDien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelDangKi;
        private Guna.UI2.WinForms.Guna2TextBox textBoxMK;
        private Guna.UI2.WinForms.Guna2TextBox textBoxTaiKhoan;
        private Guna.UI2.WinForms.Guna2ImageButton buttonBack;
        private Guna.UI2.WinForms.Guna2Button buttonDangKi;
        private Guna.UI2.WinForms.Guna2TextBox textBoxNhapLaiMK;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxDaiDien;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
    }
}