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
<<<<<<< HEAD
            this.pictureBoxDaiDien = new Guna.UI2.WinForms.Guna2PictureBox();
            this.buttonDangKi = new Guna.UI2.WinForms.Guna2Button();
            this.textBoxNhapLaiMK = new Guna.UI2.WinForms.Guna2TextBox();
            this.buttonBack = new Guna.UI2.WinForms.Guna2ImageButton();
            this.textBoxMK = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxTaiKhoan = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
=======
            this.radioButtonEmployer = new Guna.UI2.WinForms.Guna2RadioButton();
            this.radioButtonCandidate = new Guna.UI2.WinForms.Guna2RadioButton();
            this.textBoxPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBoxDaiDien = new Guna.UI2.WinForms.Guna2PictureBox();
            this.buttonDangKi = new Guna.UI2.WinForms.Guna2Button();
            this.textBoxReEnterPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.buttonBack = new Guna.UI2.WinForms.Guna2ImageButton();
            this.textBoxPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxAccount = new Guna.UI2.WinForms.Guna2TextBox();
>>>>>>> 8c09ce6e5d69f7524384847dbe0e3a3d2daa3bfe
            this.panelDangKi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDaiDien)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDangKi
            // 
<<<<<<< HEAD
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
=======
            this.panelDangKi.Controls.Add(this.radioButtonEmployer);
            this.panelDangKi.Controls.Add(this.radioButtonCandidate);
            this.panelDangKi.Controls.Add(this.textBoxPhone);
            this.panelDangKi.Controls.Add(this.textBoxEmail);
            this.panelDangKi.Controls.Add(this.pictureBoxDaiDien);
            this.panelDangKi.Controls.Add(this.buttonDangKi);
            this.panelDangKi.Controls.Add(this.textBoxReEnterPassword);
            this.panelDangKi.Controls.Add(this.buttonBack);
            this.panelDangKi.Controls.Add(this.textBoxPassword);
            this.panelDangKi.Controls.Add(this.textBoxAccount);
            this.panelDangKi.Location = new System.Drawing.Point(4, 1);
            this.panelDangKi.Margin = new System.Windows.Forms.Padding(2);
            this.panelDangKi.Name = "panelDangKi";
            this.panelDangKi.Size = new System.Drawing.Size(431, 288);
            this.panelDangKi.TabIndex = 18;
            // 
            // radioButtonEmployer
            // 
            this.radioButtonEmployer.AutoSize = true;
            this.radioButtonEmployer.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioButtonEmployer.CheckedState.BorderThickness = 0;
            this.radioButtonEmployer.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioButtonEmployer.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radioButtonEmployer.CheckedState.InnerOffset = -4;
            this.radioButtonEmployer.Location = new System.Drawing.Point(230, 207);
            this.radioButtonEmployer.Name = "radioButtonEmployer";
            this.radioButtonEmployer.Size = new System.Drawing.Size(101, 17);
            this.radioButtonEmployer.TabIndex = 28;
            this.radioButtonEmployer.Text = "Nhà tuyển dụng";
            this.radioButtonEmployer.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonEmployer.UncheckedState.BorderThickness = 2;
            this.radioButtonEmployer.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radioButtonEmployer.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // radioButtonCandidate
            // 
            this.radioButtonCandidate.AutoSize = true;
            this.radioButtonCandidate.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioButtonCandidate.CheckedState.BorderThickness = 0;
            this.radioButtonCandidate.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioButtonCandidate.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radioButtonCandidate.CheckedState.InnerOffset = -4;
            this.radioButtonCandidate.Location = new System.Drawing.Point(156, 207);
            this.radioButtonCandidate.Name = "radioButtonCandidate";
            this.radioButtonCandidate.Size = new System.Drawing.Size(68, 17);
            this.radioButtonCandidate.TabIndex = 27;
            this.radioButtonCandidate.Text = "Ứng viên";
            this.radioButtonCandidate.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonCandidate.UncheckedState.BorderThickness = 2;
            this.radioButtonCandidate.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radioButtonCandidate.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Animated = true;
            this.textBoxPhone.BorderColor = System.Drawing.Color.Teal;
            this.textBoxPhone.BorderRadius = 7;
            this.textBoxPhone.BorderThickness = 3;
            this.textBoxPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPhone.DefaultText = "";
            this.textBoxPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxPhone.FillColor = System.Drawing.SystemColors.Control;
            this.textBoxPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxPhone.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.textBoxPhone.ForeColor = System.Drawing.Color.Maroon;
            this.textBoxPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxPhone.IconLeft = ((System.Drawing.Image)(resources.GetObject("textBoxPhone.IconLeft")));
            this.textBoxPhone.IconLeftSize = new System.Drawing.Size(22, 22);
            this.textBoxPhone.IconRightSize = new System.Drawing.Size(22, 22);
            this.textBoxPhone.Location = new System.Drawing.Point(156, 171);
            this.textBoxPhone.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.PasswordChar = '\0';
            this.textBoxPhone.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.textBoxPhone.PlaceholderText = "Số điện thoại";
            this.textBoxPhone.SelectedText = "";
            this.textBoxPhone.Size = new System.Drawing.Size(262, 30);
            this.textBoxPhone.TabIndex = 26;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Animated = true;
            this.textBoxEmail.BorderColor = System.Drawing.Color.Teal;
            this.textBoxEmail.BorderRadius = 7;
            this.textBoxEmail.BorderThickness = 3;
            this.textBoxEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxEmail.DefaultText = "";
            this.textBoxEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxEmail.FillColor = System.Drawing.SystemColors.Control;
            this.textBoxEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxEmail.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.textBoxEmail.ForeColor = System.Drawing.Color.Maroon;
            this.textBoxEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxEmail.IconLeft = ((System.Drawing.Image)(resources.GetObject("textBoxEmail.IconLeft")));
            this.textBoxEmail.IconLeftSize = new System.Drawing.Size(22, 22);
            this.textBoxEmail.IconRightSize = new System.Drawing.Size(22, 22);
            this.textBoxEmail.Location = new System.Drawing.Point(156, 135);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.PasswordChar = '\0';
            this.textBoxEmail.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.textBoxEmail.PlaceholderText = "Email";
            this.textBoxEmail.SelectedText = "";
            this.textBoxEmail.Size = new System.Drawing.Size(262, 30);
            this.textBoxEmail.TabIndex = 25;
            // 
>>>>>>> 8c09ce6e5d69f7524384847dbe0e3a3d2daa3bfe
            // pictureBoxDaiDien
            // 
            this.pictureBoxDaiDien.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDaiDien.Image")));
            this.pictureBoxDaiDien.ImageRotate = 0F;
<<<<<<< HEAD
            this.pictureBoxDaiDien.Location = new System.Drawing.Point(15, 25);
            this.pictureBoxDaiDien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxDaiDien.Name = "pictureBoxDaiDien";
            this.pictureBoxDaiDien.Size = new System.Drawing.Size(187, 172);
=======
            this.pictureBoxDaiDien.Location = new System.Drawing.Point(11, 20);
            this.pictureBoxDaiDien.Name = "pictureBoxDaiDien";
            this.pictureBoxDaiDien.Size = new System.Drawing.Size(140, 140);
>>>>>>> 8c09ce6e5d69f7524384847dbe0e3a3d2daa3bfe
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
<<<<<<< HEAD
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
=======
            this.buttonDangKi.Location = new System.Drawing.Point(229, 249);
            this.buttonDangKi.Name = "buttonDangKi";
            this.buttonDangKi.Size = new System.Drawing.Size(112, 30);
            this.buttonDangKi.TabIndex = 22;
            this.buttonDangKi.Text = "Đăng kí";
            this.buttonDangKi.Click += new System.EventHandler(this.buttonDangKi_Click);
            // 
            // textBoxReEnterPassword
            // 
            this.textBoxReEnterPassword.Animated = true;
            this.textBoxReEnterPassword.BorderColor = System.Drawing.Color.Teal;
            this.textBoxReEnterPassword.BorderRadius = 7;
            this.textBoxReEnterPassword.BorderThickness = 3;
            this.textBoxReEnterPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxReEnterPassword.DefaultText = "";
            this.textBoxReEnterPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxReEnterPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxReEnterPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxReEnterPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxReEnterPassword.FillColor = System.Drawing.SystemColors.Control;
            this.textBoxReEnterPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxReEnterPassword.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.textBoxReEnterPassword.ForeColor = System.Drawing.Color.Maroon;
            this.textBoxReEnterPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxReEnterPassword.IconLeft = ((System.Drawing.Image)(resources.GetObject("textBoxReEnterPassword.IconLeft")));
            this.textBoxReEnterPassword.IconLeftSize = new System.Drawing.Size(22, 22);
            this.textBoxReEnterPassword.IconRightSize = new System.Drawing.Size(22, 22);
            this.textBoxReEnterPassword.Location = new System.Drawing.Point(156, 99);
            this.textBoxReEnterPassword.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxReEnterPassword.Name = "textBoxReEnterPassword";
            this.textBoxReEnterPassword.PasswordChar = '*';
            this.textBoxReEnterPassword.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.textBoxReEnterPassword.PlaceholderText = "Nhập lại mật khẩu";
            this.textBoxReEnterPassword.SelectedText = "";
            this.textBoxReEnterPassword.Size = new System.Drawing.Size(262, 30);
            this.textBoxReEnterPassword.TabIndex = 21;
>>>>>>> 8c09ce6e5d69f7524384847dbe0e3a3d2daa3bfe
            // 
            // buttonBack
            // 
            this.buttonBack.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.buttonBack.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.buttonBack.Image = ((System.Drawing.Image)(resources.GetObject("buttonBack.Image")));
            this.buttonBack.ImageOffset = new System.Drawing.Point(0, 0);
            this.buttonBack.ImageRotate = 0F;
            this.buttonBack.ImageSize = new System.Drawing.Size(25, 25);
<<<<<<< HEAD
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
=======
            this.buttonBack.Location = new System.Drawing.Point(394, 252);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.buttonBack.Size = new System.Drawing.Size(25, 27);
            this.buttonBack.TabIndex = 11;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Animated = true;
            this.textBoxPassword.BorderColor = System.Drawing.Color.Teal;
            this.textBoxPassword.BorderRadius = 7;
            this.textBoxPassword.BorderThickness = 3;
            this.textBoxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPassword.DefaultText = "";
            this.textBoxPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxPassword.FillColor = System.Drawing.SystemColors.Control;
            this.textBoxPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxPassword.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.textBoxPassword.ForeColor = System.Drawing.Color.Maroon;
            this.textBoxPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxPassword.IconLeft = ((System.Drawing.Image)(resources.GetObject("textBoxPassword.IconLeft")));
            this.textBoxPassword.IconLeftSize = new System.Drawing.Size(22, 22);
            this.textBoxPassword.IconRightSize = new System.Drawing.Size(22, 22);
            this.textBoxPassword.Location = new System.Drawing.Point(156, 63);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.textBoxPassword.PlaceholderText = "Mật khẩu";
            this.textBoxPassword.SelectedText = "";
            this.textBoxPassword.Size = new System.Drawing.Size(262, 30);
            this.textBoxPassword.TabIndex = 19;
            // 
            // textBoxAccount
            // 
            this.textBoxAccount.Animated = true;
            this.textBoxAccount.BorderColor = System.Drawing.Color.Teal;
            this.textBoxAccount.BorderRadius = 7;
            this.textBoxAccount.BorderThickness = 3;
            this.textBoxAccount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxAccount.DefaultText = "";
            this.textBoxAccount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxAccount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxAccount.FillColor = System.Drawing.SystemColors.Control;
            this.textBoxAccount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxAccount.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.textBoxAccount.ForeColor = System.Drawing.Color.Maroon;
            this.textBoxAccount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxAccount.IconLeft = ((System.Drawing.Image)(resources.GetObject("textBoxAccount.IconLeft")));
            this.textBoxAccount.IconLeftSize = new System.Drawing.Size(22, 22);
            this.textBoxAccount.IconRight = ((System.Drawing.Image)(resources.GetObject("textBoxAccount.IconRight")));
            this.textBoxAccount.Location = new System.Drawing.Point(156, 26);
            this.textBoxAccount.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxAccount.Name = "textBoxAccount";
            this.textBoxAccount.PasswordChar = '\0';
            this.textBoxAccount.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.textBoxAccount.PlaceholderText = "Tài khoản";
            this.textBoxAccount.SelectedText = "";
            this.textBoxAccount.Size = new System.Drawing.Size(262, 30);
            this.textBoxAccount.TabIndex = 18;
            // 
            // FDangKi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 290);
>>>>>>> 8c09ce6e5d69f7524384847dbe0e3a3d2daa3bfe
            this.ControlBox = false;
            this.Controls.Add(this.panelDangKi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(6, 1);
<<<<<<< HEAD
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FDangKi";
            this.Text = "FDangKi";
            this.panelDangKi.ResumeLayout(false);
=======
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FDangKi";
            this.Text = "FDangKi";
            this.panelDangKi.ResumeLayout(false);
            this.panelDangKi.PerformLayout();
>>>>>>> 8c09ce6e5d69f7524384847dbe0e3a3d2daa3bfe
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDaiDien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelDangKi;
<<<<<<< HEAD
        private Guna.UI2.WinForms.Guna2TextBox textBoxMK;
        private Guna.UI2.WinForms.Guna2TextBox textBoxTaiKhoan;
        private Guna.UI2.WinForms.Guna2ImageButton buttonBack;
        private Guna.UI2.WinForms.Guna2Button buttonDangKi;
        private Guna.UI2.WinForms.Guna2TextBox textBoxNhapLaiMK;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxDaiDien;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
=======
        private Guna.UI2.WinForms.Guna2TextBox textBoxPassword;
        private Guna.UI2.WinForms.Guna2TextBox textBoxAccount;
        private Guna.UI2.WinForms.Guna2ImageButton buttonBack;
        private Guna.UI2.WinForms.Guna2Button buttonDangKi;
        private Guna.UI2.WinForms.Guna2TextBox textBoxReEnterPassword;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxDaiDien;
        private Guna.UI2.WinForms.Guna2TextBox textBoxEmail;
        private Guna.UI2.WinForms.Guna2TextBox textBoxPhone;
        private Guna.UI2.WinForms.Guna2RadioButton radioButtonEmployer;
        private Guna.UI2.WinForms.Guna2RadioButton radioButtonCandidate;
>>>>>>> 8c09ce6e5d69f7524384847dbe0e3a3d2daa3bfe
    }
}