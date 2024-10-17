namespace Job
{
    partial class UserControlCamNang
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
            this.btnXemchitiet = new System.Windows.Forms.Button();
            this.labelNoiDung = new System.Windows.Forms.Label();
            this.labelTieuDe = new System.Windows.Forms.Label();
            this.pictureBoxCamNang = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCamNang)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXemchitiet
            // 
            this.btnXemchitiet.BackColor = System.Drawing.Color.DarkGray;
            this.btnXemchitiet.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemchitiet.ForeColor = System.Drawing.Color.Transparent;
            this.btnXemchitiet.Location = new System.Drawing.Point(140, 321);
            this.btnXemchitiet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXemchitiet.Name = "btnXemchitiet";
            this.btnXemchitiet.Size = new System.Drawing.Size(158, 40);
            this.btnXemchitiet.TabIndex = 3;
            this.btnXemchitiet.Text = "Xem chi tiết";
            this.btnXemchitiet.UseVisualStyleBackColor = false;
            this.btnXemchitiet.Click += new System.EventHandler(this.btnXemchitiet_Click);
            // 
            // labelNoiDung
            // 
            this.labelNoiDung.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoiDung.ForeColor = System.Drawing.Color.Black;
            this.labelNoiDung.Location = new System.Drawing.Point(3, 245);
            this.labelNoiDung.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNoiDung.Name = "labelNoiDung";
            this.labelNoiDung.Size = new System.Drawing.Size(445, 65);
            this.labelNoiDung.TabIndex = 5;
            this.labelNoiDung.Text = "Hoạt động ngoại khóa trong CV đóng vai trò quan trọng trong việc thể hiện bản thâ" +
    "n và gia tăng cơ hội xin việc thành công cho sinh viên mới ra trường, chưa có nh" +
    "iều...\r\n";
            // 
            // labelTieuDe
            // 
            this.labelTieuDe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTieuDe.ForeColor = System.Drawing.Color.Black;
            this.labelTieuDe.Location = new System.Drawing.Point(2, 217);
            this.labelTieuDe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTieuDe.Name = "labelTieuDe";
            this.labelTieuDe.Size = new System.Drawing.Size(446, 31);
            this.labelTieuDe.TabIndex = 4;
            this.labelTieuDe.Text = "Cách ghi hoạt động ngoại khóa đúng chuẩn trong CV\r\n\r\n";
            // 
            // pictureBoxCamNang
            // 
            this.pictureBoxCamNang.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxCamNang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxCamNang.Name = "pictureBoxCamNang";
            this.pictureBoxCamNang.Size = new System.Drawing.Size(448, 205);
            this.pictureBoxCamNang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCamNang.TabIndex = 0;
            this.pictureBoxCamNang.TabStop = false;
            // 
            // UserControlCamNang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelNoiDung);
            this.Controls.Add(this.labelTieuDe);
            this.Controls.Add(this.btnXemchitiet);
            this.Controls.Add(this.pictureBoxCamNang);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UserControlCamNang";
            this.Size = new System.Drawing.Size(450, 362);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCamNang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCamNang;
        private System.Windows.Forms.Button btnXemchitiet;
        public System.Windows.Forms.Label labelNoiDung;
        public System.Windows.Forms.Label labelTieuDe;
    }
}
