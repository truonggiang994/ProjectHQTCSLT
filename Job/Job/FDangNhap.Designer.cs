using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using static Guna.UI2.WinForms.Suite.Descriptions;
using System.Drawing.Printing;

namespace Job
{
    partial class FDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FDangNhap));
            this.linkLabelQuenMK = new System.Windows.Forms.LinkLabel();
            this.linkLabelDangki = new System.Windows.Forms.LinkLabel();
            this.buttonDangNhap = new System.Windows.Forms.Button();
            this.panelDangNhap = new System.Windows.Forms.Panel();
            this.radioButtonEmployer = new Guna.UI2.WinForms.Guna2RadioButton();
            this.radioButtonCandidate = new Guna.UI2.WinForms.Guna2RadioButton();
            this.textBoxMK = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoTaiKhoan = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBoxDangNhap = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.radioButtonAdmin = new Guna.UI2.WinForms.Guna2RadioButton();
            this.panelDangNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDangNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabelQuenMK
            // 
            this.linkLabelQuenMK.AutoSize = true;
            this.linkLabelQuenMK.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelQuenMK.Location = new System.Drawing.Point(254, 119);
            this.linkLabelQuenMK.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabelQuenMK.Name = "linkLabelQuenMK";
            this.linkLabelQuenMK.Size = new System.Drawing.Size(103, 16);
            this.linkLabelQuenMK.TabIndex = 7;
            this.linkLabelQuenMK.TabStop = true;
            this.linkLabelQuenMK.Text = "Quên mật khẩu ?";
            // 
            // linkLabelDangki
            // 
            this.linkLabelDangki.AutoSize = true;
            this.linkLabelDangki.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelDangki.Location = new System.Drawing.Point(352, 119);
            this.linkLabelDangki.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabelDangki.Name = "linkLabelDangki";
            this.linkLabelDangki.Size = new System.Drawing.Size(56, 16);
            this.linkLabelDangki.TabIndex = 8;
            this.linkLabelDangki.TabStop = true;
            this.linkLabelDangki.Text = "Đăng kí ";
            this.linkLabelDangki.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelDangki_LinkClicked);
            // 
            // buttonDangNhap
            // 
            this.buttonDangNhap.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonDangNhap.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDangNhap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDangNhap.Location = new System.Drawing.Point(286, 86);
            this.buttonDangNhap.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDangNhap.Name = "buttonDangNhap";
            this.buttonDangNhap.Size = new System.Drawing.Size(91, 31);
            this.buttonDangNhap.TabIndex = 9;
            this.buttonDangNhap.Text = "Đăng nhập";
            this.buttonDangNhap.UseVisualStyleBackColor = false;
            this.buttonDangNhap.Click += new System.EventHandler(this.buttonDangNhap_Click);
            // 
            // panelDangNhap
            // 
            this.panelDangNhap.Controls.Add(this.radioButtonAdmin);
            this.panelDangNhap.Controls.Add(this.radioButtonEmployer);
            this.panelDangNhap.Controls.Add(this.radioButtonCandidate);
            this.panelDangNhap.Controls.Add(this.textBoxMK);
            this.panelDangNhap.Controls.Add(this.textBoTaiKhoan);
            this.panelDangNhap.Controls.Add(this.pictureBoxDangNhap);
            this.panelDangNhap.Controls.Add(this.buttonDangNhap);
            this.panelDangNhap.Controls.Add(this.linkLabelDangki);
            this.panelDangNhap.Controls.Add(this.linkLabelQuenMK);
            this.panelDangNhap.Location = new System.Drawing.Point(4, 1);
            this.panelDangNhap.Margin = new System.Windows.Forms.Padding(2);
            this.panelDangNhap.Name = "panelDangNhap";
            this.panelDangNhap.Size = new System.Drawing.Size(410, 155);
            this.panelDangNhap.TabIndex = 1;
            // 
            // radioButtonEmployer
            // 
            this.radioButtonEmployer.AutoSize = true;
            this.radioButtonEmployer.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioButtonEmployer.CheckedState.BorderThickness = 0;
            this.radioButtonEmployer.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioButtonEmployer.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radioButtonEmployer.CheckedState.InnerOffset = -4;
            this.radioButtonEmployer.Location = new System.Drawing.Point(144, 110);
            this.radioButtonEmployer.Name = "radioButtonEmployer";
            this.radioButtonEmployer.Size = new System.Drawing.Size(101, 17);
            this.radioButtonEmployer.TabIndex = 15;
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
            this.radioButtonCandidate.Location = new System.Drawing.Point(144, 86);
            this.radioButtonCandidate.Name = "radioButtonCandidate";
            this.radioButtonCandidate.Size = new System.Drawing.Size(68, 17);
            this.radioButtonCandidate.TabIndex = 14;
            this.radioButtonCandidate.Text = "Ứng viên";
            this.radioButtonCandidate.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonCandidate.UncheckedState.BorderThickness = 2;
            this.radioButtonCandidate.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radioButtonCandidate.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // textBoxMK
            // 
            this.textBoxMK.Animated = true;
            this.textBoxMK.BorderColor = System.Drawing.Color.Teal;
            this.textBoxMK.BorderRadius = 7;
            this.textBoxMK.BorderThickness = 2;
            this.textBoxMK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxMK.DefaultText = "";
            this.textBoxMK.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxMK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxMK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxMK.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxMK.FillColor = System.Drawing.SystemColors.Control;
            this.textBoxMK.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxMK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMK.ForeColor = System.Drawing.Color.Maroon;
            this.textBoxMK.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxMK.IconLeft = ((System.Drawing.Image)(resources.GetObject("textBoxMK.IconLeft")));
            this.textBoxMK.IconLeftSize = new System.Drawing.Size(22, 22);
            this.textBoxMK.IconRightSize = new System.Drawing.Size(22, 22);
            this.textBoxMK.Location = new System.Drawing.Point(142, 56);
            this.textBoxMK.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxMK.Name = "textBoxMK";
            this.textBoxMK.PasswordChar = '*';
            this.textBoxMK.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.textBoxMK.PlaceholderText = "Mật khẩu";
            this.textBoxMK.SelectedText = "";
            this.textBoxMK.Size = new System.Drawing.Size(262, 28);
            this.textBoxMK.TabIndex = 13;
            // 
            // textBoTaiKhoan
            // 
            this.textBoTaiKhoan.Animated = true;
            this.textBoTaiKhoan.BorderColor = System.Drawing.Color.Teal;
            this.textBoTaiKhoan.BorderRadius = 7;
            this.textBoTaiKhoan.BorderThickness = 2;
            this.textBoTaiKhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoTaiKhoan.DefaultText = "";
            this.textBoTaiKhoan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoTaiKhoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoTaiKhoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoTaiKhoan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoTaiKhoan.FillColor = System.Drawing.SystemColors.Control;
            this.textBoTaiKhoan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoTaiKhoan.ForeColor = System.Drawing.Color.Maroon;
            this.textBoTaiKhoan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoTaiKhoan.IconLeft = ((System.Drawing.Image)(resources.GetObject("textBoTaiKhoan.IconLeft")));
            this.textBoTaiKhoan.IconLeftSize = new System.Drawing.Size(22, 22);
            this.textBoTaiKhoan.IconRight = ((System.Drawing.Image)(resources.GetObject("textBoTaiKhoan.IconRight")));
            this.textBoTaiKhoan.Location = new System.Drawing.Point(142, 21);
            this.textBoTaiKhoan.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoTaiKhoan.Name = "textBoTaiKhoan";
            this.textBoTaiKhoan.PasswordChar = '\0';
            this.textBoTaiKhoan.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.textBoTaiKhoan.PlaceholderText = "Tài khoản";
            this.textBoTaiKhoan.SelectedText = "";
            this.textBoTaiKhoan.Size = new System.Drawing.Size(262, 28);
            this.textBoTaiKhoan.TabIndex = 12;
            // 
            // pictureBoxDangNhap
            // 
            this.pictureBoxDangNhap.FillColor = System.Drawing.Color.Transparent;
            this.pictureBoxDangNhap.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDangNhap.Image")));
            this.pictureBoxDangNhap.ImageRotate = 0F;
            this.pictureBoxDangNhap.Location = new System.Drawing.Point(4, 9);
            this.pictureBoxDangNhap.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxDangNhap.Name = "pictureBoxDangNhap";
            this.pictureBoxDangNhap.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pictureBoxDangNhap.Size = new System.Drawing.Size(134, 124);
            this.pictureBoxDangNhap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDangNhap.TabIndex = 10;
            this.pictureBoxDangNhap.TabStop = false;
            // 
            // radioButtonAdmin
            // 
            this.radioButtonAdmin.AutoSize = true;
            this.radioButtonAdmin.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioButtonAdmin.CheckedState.BorderThickness = 0;
            this.radioButtonAdmin.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioButtonAdmin.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radioButtonAdmin.CheckedState.InnerOffset = -4;
            this.radioButtonAdmin.Location = new System.Drawing.Point(144, 133);
            this.radioButtonAdmin.Name = "radioButtonAdmin";
            this.radioButtonAdmin.Size = new System.Drawing.Size(54, 17);
            this.radioButtonAdmin.TabIndex = 16;
            this.radioButtonAdmin.Text = "Admin";
            this.radioButtonAdmin.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonAdmin.UncheckedState.BorderThickness = 2;
            this.radioButtonAdmin.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radioButtonAdmin.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // FDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 160);
            this.Controls.Add(this.panelDangNhap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FDangNhap";
            this.Text = "FDangNhap";
            this.panelDangNhap.ResumeLayout(false);
            this.panelDangNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDangNhap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private LinkLabel linkLabelQuenMK;
        private LinkLabel linkLabelDangki;
        private Button buttonDangNhap;
        private Panel panelDangNhap;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureBoxDangNhap;
        private Guna.UI2.WinForms.Guna2TextBox textBoTaiKhoan;
        private Guna.UI2.WinForms.Guna2TextBox textBoxMK;
        private Guna.UI2.WinForms.Guna2RadioButton radioButtonCandidate;
        private Guna.UI2.WinForms.Guna2RadioButton radioButtonEmployer;
        private Guna.UI2.WinForms.Guna2RadioButton radioButtonAdmin;
    }
}