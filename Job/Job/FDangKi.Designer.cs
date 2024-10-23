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
            this.panelDangKi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDaiDien)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDangKi
            // 
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
            // pictureBoxDaiDien
            // 
            this.pictureBoxDaiDien.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDaiDien.Image")));
            this.pictureBoxDaiDien.ImageRotate = 0F;
            this.pictureBoxDaiDien.Location = new System.Drawing.Point(11, 20);
            this.pictureBoxDaiDien.Name = "pictureBoxDaiDien";
            this.pictureBoxDaiDien.Size = new System.Drawing.Size(140, 140);
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
            // 
            // buttonBack
            // 
            this.buttonBack.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.buttonBack.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.buttonBack.Image = ((System.Drawing.Image)(resources.GetObject("buttonBack.Image")));
            this.buttonBack.ImageOffset = new System.Drawing.Point(0, 0);
            this.buttonBack.ImageRotate = 0F;
            this.buttonBack.ImageSize = new System.Drawing.Size(25, 25);
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
            this.ControlBox = false;
            this.Controls.Add(this.panelDangKi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(6, 1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FDangKi";
            this.Text = "FDangKi";
            this.panelDangKi.ResumeLayout(false);
            this.panelDangKi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDaiDien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelDangKi;
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
    }
}