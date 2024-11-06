
namespace Job
{
    partial class UserControlACTView
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
            this.pictureBoxAnh = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnh)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxAnh
            // 
            this.pictureBoxAnh.FillColor = System.Drawing.Color.Transparent;
            this.pictureBoxAnh.ImageRotate = 0F;
            this.pictureBoxAnh.Location = new System.Drawing.Point(15, 7);
            this.pictureBoxAnh.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxAnh.Name = "pictureBoxAnh";
            this.pictureBoxAnh.Size = new System.Drawing.Size(353, 371);
            this.pictureBoxAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAnh.TabIndex = 18;
            this.pictureBoxAnh.TabStop = false;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.pictureBoxAnh);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Location = new System.Drawing.Point(4, 4);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(384, 382);
            this.guna2Panel1.TabIndex = 21;
            // 
            // UserControlACTView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "UserControlACTView";
            this.Size = new System.Drawing.Size(395, 394);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnh)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2PictureBox pictureBoxAnh;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}
