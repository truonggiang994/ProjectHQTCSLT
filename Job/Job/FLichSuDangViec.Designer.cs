namespace Job
{
    partial class FLichSuDangViec
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
            this.lblLsdv = new System.Windows.Forms.Label();
            this.guna2PanelLsdv = new Guna.UI2.WinForms.Guna2Panel();
            this.flowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2PanelLsdv.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLsdv
            // 
            this.lblLsdv.AutoSize = true;
            this.lblLsdv.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLsdv.Location = new System.Drawing.Point(30, 10);
            this.lblLsdv.Name = "lblLsdv";
            this.lblLsdv.Size = new System.Drawing.Size(142, 21);
            this.lblLsdv.TabIndex = 0;
            this.lblLsdv.Text = "Lịch sử đăng việc";
            // 
            // guna2PanelLsdv
            // 
            this.guna2PanelLsdv.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.guna2PanelLsdv.BorderRadius = 15;
            this.guna2PanelLsdv.BorderThickness = 5;
            this.guna2PanelLsdv.Controls.Add(this.lblLsdv);
            this.guna2PanelLsdv.FillColor = System.Drawing.SystemColors.Control;
            this.guna2PanelLsdv.Location = new System.Drawing.Point(365, 0);
            this.guna2PanelLsdv.Name = "guna2PanelLsdv";
            this.guna2PanelLsdv.Size = new System.Drawing.Size(200, 40);
            this.guna2PanelLsdv.TabIndex = 2;
            // 
            // flowLayout
            // 
            this.flowLayout.AutoScroll = true;
            this.flowLayout.Location = new System.Drawing.Point(12, 46);
            this.flowLayout.Name = "flowLayout";
            this.flowLayout.Size = new System.Drawing.Size(976, 580);
            this.flowLayout.TabIndex = 8;
            this.flowLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // FLichSuDangViec
            // 
            this.ClientSize = new System.Drawing.Size(1000, 638);
            this.Controls.Add(this.flowLayout);
            this.Controls.Add(this.guna2PanelLsdv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FLichSuDangViec";
            this.guna2PanelLsdv.ResumeLayout(false);
            this.guna2PanelLsdv.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblLsdv;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelLsdv;
        private System.Windows.Forms.FlowLayoutPanel flowLayout;
    }
}
