namespace Job
{
    partial class UserControlACT
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonXoa = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ButtonTaiAnh = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBoxAnh = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonXoa
            // 
            this.buttonXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonXoa.FillColor = System.Drawing.Color.DarkGray;
            this.buttonXoa.FocusedColor = System.Drawing.SystemColors.Control;
            this.buttonXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoa.ForeColor = System.Drawing.Color.White;
            this.buttonXoa.Location = new System.Drawing.Point(34, 277);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(80, 30);
            this.buttonXoa.TabIndex = 19;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.guna2ButtonTaiAnh);
            this.guna2Panel1.Controls.Add(this.pictureBoxAnh);
            this.guna2Panel1.Controls.Add(this.buttonXoa);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(288, 310);
            this.guna2Panel1.TabIndex = 20;
            // 
            // guna2ButtonTaiAnh
            // 
            this.guna2ButtonTaiAnh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonTaiAnh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonTaiAnh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonTaiAnh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonTaiAnh.FillColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonTaiAnh.FocusedColor = System.Drawing.SystemColors.Control;
            this.guna2ButtonTaiAnh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ButtonTaiAnh.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonTaiAnh.Location = new System.Drawing.Point(170, 277);
            this.guna2ButtonTaiAnh.Name = "guna2ButtonTaiAnh";
            this.guna2ButtonTaiAnh.Size = new System.Drawing.Size(80, 30);
            this.guna2ButtonTaiAnh.TabIndex = 20;
            this.guna2ButtonTaiAnh.Text = "Tải ảnh";
            this.guna2ButtonTaiAnh.Click += new System.EventHandler(this.guna2ButtonTaiAnh_Click);
            // 
            // pictureBoxAnh
            // 
            this.pictureBoxAnh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxAnh.FillColor = System.Drawing.Color.Transparent;
            this.pictureBoxAnh.ImageRotate = 0F;
            this.pictureBoxAnh.InitialImage = null;
            this.pictureBoxAnh.Location = new System.Drawing.Point(11, 6);
            this.pictureBoxAnh.Name = "pictureBoxAnh";
            this.pictureBoxAnh.Size = new System.Drawing.Size(265, 265);
            this.pictureBoxAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAnh.TabIndex = 18;
            this.pictureBoxAnh.TabStop = false;
            // 
            // UserControlACT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "UserControlACT";
            this.Size = new System.Drawing.Size(290, 310);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2PictureBox pictureBoxAnh;
        private Guna.UI2.WinForms.Guna2Button buttonXoa;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonTaiAnh;
    }
}