namespace Job
{
    partial class FXemDanhGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FXemDanhGia));
            this.label1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labelTenCongTy = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ratingStarSoSaoTB = new Guna.UI2.WinForms.Guna2RatingStar();
            this.labelSoSao = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.flowLayoutPanelChinh = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(361, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bài viết đánh giá";
            // 
            // labelTenCongTy
            // 
            this.labelTenCongTy.AutoSize = false;
            this.labelTenCongTy.BackColor = System.Drawing.Color.Transparent;
            this.labelTenCongTy.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenCongTy.ForeColor = System.Drawing.Color.Black;
            this.labelTenCongTy.Location = new System.Drawing.Point(24, 43);
            this.labelTenCongTy.Name = "labelTenCongTy";
            this.labelTenCongTy.Size = new System.Drawing.Size(712, 26);
            this.labelTenCongTy.TabIndex = 2;
            this.labelTenCongTy.Text = "Bài viết đánh giá";
            // 
            // ratingStarSoSaoTB
            // 
            this.ratingStarSoSaoTB.Location = new System.Drawing.Point(735, 57);
            this.ratingStarSoSaoTB.Name = "ratingStarSoSaoTB";
            this.ratingStarSoSaoTB.RatingColor = System.Drawing.Color.Khaki;
            this.ratingStarSoSaoTB.Size = new System.Drawing.Size(120, 28);
            this.ratingStarSoSaoTB.TabIndex = 3;
            // 
            // labelSoSao
            // 
            this.labelSoSao.BackColor = System.Drawing.Color.Transparent;
            this.labelSoSao.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoSao.ForeColor = System.Drawing.Color.Black;
            this.labelSoSao.Location = new System.Drawing.Point(861, 60);
            this.labelSoSao.Name = "labelSoSao";
            this.labelSoSao.Size = new System.Drawing.Size(49, 25);
            this.labelSoSao.TabIndex = 4;
            this.labelSoSao.Text = "4 sao";
            // 
            // flowLayoutPanelChinh
            // 
            this.flowLayoutPanelChinh.AutoScroll = true;
            this.flowLayoutPanelChinh.ForeColor = System.Drawing.Color.Black;
            this.flowLayoutPanelChinh.Location = new System.Drawing.Point(0, 89);
            this.flowLayoutPanelChinh.Name = "flowLayoutPanelChinh";
            this.flowLayoutPanelChinh.Size = new System.Drawing.Size(930, 376);
            this.flowLayoutPanelChinh.TabIndex = 5;
            this.flowLayoutPanelChinh.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanelChinh_Paint);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.guna2ImageButton1.Location = new System.Drawing.Point(885, 15);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Size = new System.Drawing.Size(25, 32);
            this.guna2ImageButton1.TabIndex = 8;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // FXemDanhGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 460);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.flowLayoutPanelChinh);
            this.Controls.Add(this.labelSoSao);
            this.Controls.Add(this.ratingStarSoSaoTB);
            this.Controls.Add(this.labelTenCongTy);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FXemDanhGia";
            this.Text = "FXemDanhGia";
            this.Load += new System.EventHandler(this.FXemDanhGia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel label1;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelTenCongTy;
        private Guna.UI2.WinForms.Guna2RatingStar ratingStarSoSaoTB;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelSoSao;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelChinh;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
    }
}