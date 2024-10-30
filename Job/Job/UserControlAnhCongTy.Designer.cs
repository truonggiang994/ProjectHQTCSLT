namespace Job
{
    partial class UserControlAnhCongTy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlAnhCongTy));
            this.buttonAnhBia = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBoxAnhBia = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnhBia)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAnhBia
            // 
            this.buttonAnhBia.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonAnhBia.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonAnhBia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonAnhBia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonAnhBia.FillColor = System.Drawing.Color.DarkGray;
            this.buttonAnhBia.FocusedColor = System.Drawing.SystemColors.Control;
            this.buttonAnhBia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnhBia.ForeColor = System.Drawing.Color.White;
            this.buttonAnhBia.Location = new System.Drawing.Point(39, 145);
            this.buttonAnhBia.Name = "buttonAnhBia";
            this.buttonAnhBia.Size = new System.Drawing.Size(80, 30);
            this.buttonAnhBia.TabIndex = 19;
            this.buttonAnhBia.Text = "Xóa";
            // 
            // pictureBoxAnhBia
            // 
            this.pictureBoxAnhBia.FillColor = System.Drawing.SystemColors.Control;
            this.pictureBoxAnhBia.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAnhBia.Image")));
            this.pictureBoxAnhBia.ImageRotate = 0F;
            this.pictureBoxAnhBia.Location = new System.Drawing.Point(13, 3);
            this.pictureBoxAnhBia.Name = "pictureBoxAnhBia";
            this.pictureBoxAnhBia.Size = new System.Drawing.Size(140, 140);
            this.pictureBoxAnhBia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAnhBia.TabIndex = 18;
            this.pictureBoxAnhBia.TabStop = false;
            // 
            // UserControlAnhCongTy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBoxAnhBia);
            this.Controls.Add(this.buttonAnhBia);
            this.Name = "UserControlAnhCongTy";
            this.Size = new System.Drawing.Size(165, 180);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnhBia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxAnhBia;
        private Guna.UI2.WinForms.Guna2Button buttonAnhBia;
    }
}
