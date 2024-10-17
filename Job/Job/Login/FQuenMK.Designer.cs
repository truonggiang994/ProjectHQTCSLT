using System.Drawing;
using System.Windows.Forms;

namespace Job.Login
{
    partial class FQuenMK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FQuenMK));
            this.pictureBoxQuenMK = new System.Windows.Forms.PictureBox();
            this.pictureBoxTaiKhoan = new System.Windows.Forms.PictureBox();
            this.buttonTim = new System.Windows.Forms.Button();
            this.panelMK = new System.Windows.Forms.Panel();
            this.textBoxMatKhau = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBoxMK = new System.Windows.Forms.PictureBox();
            this.panelTaiKhoan = new System.Windows.Forms.Panel();
            this.textBoxTaiKhoan = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelNhapMK = new System.Windows.Forms.Panel();
            this.textBoxNhapLaiMK = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBoxNhapLaiMK = new System.Windows.Forms.PictureBox();
            this.buttonBack = new Guna.UI2.WinForms.Guna2ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuenMK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTaiKhoan)).BeginInit();
            this.panelMK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMK)).BeginInit();
            this.panelTaiKhoan.SuspendLayout();
            this.panelNhapMK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNhapLaiMK)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxQuenMK
            // 
            this.pictureBoxQuenMK.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxQuenMK.Image")));
            this.pictureBoxQuenMK.Location = new System.Drawing.Point(9, 8);
            this.pictureBoxQuenMK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxQuenMK.Name = "pictureBoxQuenMK";
            this.pictureBoxQuenMK.Size = new System.Drawing.Size(164, 146);
            this.pictureBoxQuenMK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxQuenMK.TabIndex = 0;
            this.pictureBoxQuenMK.TabStop = false;
            // 
            // pictureBoxTaiKhoan
            // 
            this.pictureBoxTaiKhoan.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTaiKhoan.Image")));
            this.pictureBoxTaiKhoan.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxTaiKhoan.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pictureBoxTaiKhoan.Name = "pictureBoxTaiKhoan";
            this.pictureBoxTaiKhoan.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxTaiKhoan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTaiKhoan.TabIndex = 23;
            this.pictureBoxTaiKhoan.TabStop = false;
            // 
            // buttonTim
            // 
            this.buttonTim.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonTim.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTim.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonTim.Image = ((System.Drawing.Image)(resources.GetObject("buttonTim.Image")));
            this.buttonTim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTim.Location = new System.Drawing.Point(248, 115);
            this.buttonTim.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonTim.Name = "buttonTim";
            this.buttonTim.Size = new System.Drawing.Size(106, 31);
            this.buttonTim.TabIndex = 22;
            this.buttonTim.Text = "     Tìm kiếm";
            this.buttonTim.UseVisualStyleBackColor = false;
            this.buttonTim.Click += new System.EventHandler(this.buttonTim_Click);
            // 
            // panelMK
            // 
            this.panelMK.Controls.Add(this.textBoxMatKhau);
            this.panelMK.Controls.Add(this.pictureBoxMK);
            this.panelMK.Location = new System.Drawing.Point(178, 46);
            this.panelMK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelMK.Name = "panelMK";
            this.panelMK.Size = new System.Drawing.Size(249, 25);
            this.panelMK.TabIndex = 27;
            // 
            // textBoxMatKhau
            // 
            this.textBoxMatKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxMatKhau.DefaultText = "";
            this.textBoxMatKhau.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxMatKhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxMatKhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxMatKhau.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxMatKhau.FillColor = System.Drawing.SystemColors.Control;
            this.textBoxMatKhau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxMatKhau.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.textBoxMatKhau.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxMatKhau.Location = new System.Drawing.Point(25, 0);
            this.textBoxMatKhau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxMatKhau.Name = "textBoxMatKhau";
            this.textBoxMatKhau.PasswordChar = '\0';
            this.textBoxMatKhau.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.textBoxMatKhau.PlaceholderText = "Mật khẩu mới ";
            this.textBoxMatKhau.SelectedText = "";
            this.textBoxMatKhau.Size = new System.Drawing.Size(224, 25);
            this.textBoxMatKhau.TabIndex = 22;
            // 
            // pictureBoxMK
            // 
            this.pictureBoxMK.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMK.Image")));
            this.pictureBoxMK.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxMK.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pictureBoxMK.Name = "pictureBoxMK";
            this.pictureBoxMK.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxMK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMK.TabIndex = 21;
            this.pictureBoxMK.TabStop = false;
            // 
            // panelTaiKhoan
            // 
            this.panelTaiKhoan.Controls.Add(this.textBoxTaiKhoan);
            this.panelTaiKhoan.Controls.Add(this.pictureBoxTaiKhoan);
            this.panelTaiKhoan.Location = new System.Drawing.Point(178, 16);
            this.panelTaiKhoan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelTaiKhoan.Name = "panelTaiKhoan";
            this.panelTaiKhoan.Size = new System.Drawing.Size(249, 25);
            this.panelTaiKhoan.TabIndex = 28;
            // 
            // textBoxTaiKhoan
            // 
            this.textBoxTaiKhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxTaiKhoan.DefaultText = "";
            this.textBoxTaiKhoan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxTaiKhoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxTaiKhoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxTaiKhoan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxTaiKhoan.FillColor = System.Drawing.SystemColors.Control;
            this.textBoxTaiKhoan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTaiKhoan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxTaiKhoan.Location = new System.Drawing.Point(25, 0);
            this.textBoxTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxTaiKhoan.Name = "textBoxTaiKhoan";
            this.textBoxTaiKhoan.PasswordChar = '\0';
            this.textBoxTaiKhoan.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.textBoxTaiKhoan.PlaceholderText = "Nhập tên tài khoản của bạn";
            this.textBoxTaiKhoan.SelectedText = "";
            this.textBoxTaiKhoan.Size = new System.Drawing.Size(224, 25);
            this.textBoxTaiKhoan.TabIndex = 22;
            // 
            // panelNhapMK
            // 
            this.panelNhapMK.Controls.Add(this.textBoxNhapLaiMK);
            this.panelNhapMK.Controls.Add(this.pictureBoxNhapLaiMK);
            this.panelNhapMK.Location = new System.Drawing.Point(178, 79);
            this.panelNhapMK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelNhapMK.Name = "panelNhapMK";
            this.panelNhapMK.Size = new System.Drawing.Size(249, 25);
            this.panelNhapMK.TabIndex = 29;
            // 
            // textBoxNhapLaiMK
            // 
            this.textBoxNhapLaiMK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxNhapLaiMK.DefaultText = "";
            this.textBoxNhapLaiMK.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxNhapLaiMK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxNhapLaiMK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxNhapLaiMK.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxNhapLaiMK.FillColor = System.Drawing.SystemColors.Control;
            this.textBoxNhapLaiMK.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxNhapLaiMK.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.textBoxNhapLaiMK.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxNhapLaiMK.Location = new System.Drawing.Point(25, 0);
            this.textBoxNhapLaiMK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNhapLaiMK.Name = "textBoxNhapLaiMK";
            this.textBoxNhapLaiMK.PasswordChar = '\0';
            this.textBoxNhapLaiMK.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.textBoxNhapLaiMK.PlaceholderText = "Nhập lại mật khẩu mới ";
            this.textBoxNhapLaiMK.SelectedText = "";
            this.textBoxNhapLaiMK.Size = new System.Drawing.Size(224, 25);
            this.textBoxNhapLaiMK.TabIndex = 22;
            // 
            // pictureBoxNhapLaiMK
            // 
            this.pictureBoxNhapLaiMK.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxNhapLaiMK.Image")));
            this.pictureBoxNhapLaiMK.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxNhapLaiMK.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pictureBoxNhapLaiMK.Name = "pictureBoxNhapLaiMK";
            this.pictureBoxNhapLaiMK.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxNhapLaiMK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxNhapLaiMK.TabIndex = 21;
            this.pictureBoxNhapLaiMK.TabStop = false;
            // 
            // buttonBack
            // 
            this.buttonBack.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.buttonBack.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.buttonBack.Image = ((System.Drawing.Image)(resources.GetObject("buttonBack.Image")));
            this.buttonBack.ImageOffset = new System.Drawing.Point(0, 0);
            this.buttonBack.ImageRotate = 0F;
            this.buttonBack.ImageSize = new System.Drawing.Size(25, 25);
            this.buttonBack.Location = new System.Drawing.Point(381, 121);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.buttonBack.Size = new System.Drawing.Size(25, 25);
            this.buttonBack.TabIndex = 30;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // FQuenMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 161);
            this.ControlBox = false;
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.panelNhapMK);
            this.Controls.Add(this.panelTaiKhoan);
            this.Controls.Add(this.panelMK);
            this.Controls.Add(this.buttonTim);
            this.Controls.Add(this.pictureBoxQuenMK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FQuenMK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FQuenMK";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuenMK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTaiKhoan)).EndInit();
            this.panelMK.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMK)).EndInit();
            this.panelTaiKhoan.ResumeLayout(false);
            this.panelNhapMK.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNhapLaiMK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBoxQuenMK;
        private PictureBox pictureBoxTaiKhoan;
        private Button buttonTim;
        private Panel panelMK;
        private PictureBox pictureBoxMK;
        private Guna.UI2.WinForms.Guna2TextBox textBoxMatKhau;
        private Panel panelTaiKhoan;
        private Guna.UI2.WinForms.Guna2TextBox textBoxTaiKhoan;
        private Panel panelNhapMK;
        private Guna.UI2.WinForms.Guna2TextBox textBoxNhapLaiMK;
        private PictureBox pictureBoxNhapLaiMK;
        private Guna.UI2.WinForms.Guna2ImageButton buttonBack;
    }
}