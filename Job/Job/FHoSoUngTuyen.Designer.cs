namespace Job
{
    partial class FHoSoUngTuyen
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
            this.flowLayoutPanelChinh = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // flowLayoutPanelChinh
            // 
            this.flowLayoutPanelChinh.AutoScroll = true;
            this.flowLayoutPanelChinh.Location = new System.Drawing.Point(0, 50);
            this.flowLayoutPanelChinh.Name = "flowLayoutPanelChinh";
            this.flowLayoutPanelChinh.Size = new System.Drawing.Size(930, 427);
            this.flowLayoutPanelChinh.TabIndex = 0;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(349, 12);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(238, 26);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "Hồ sơ ứng viên đã nộp CV";
            // 
            // FHoSoUngTuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 476);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.flowLayoutPanelChinh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FHoSoUngTuyen";
            this.Text = "FHoSoUngTuyen";
            this.Load += new System.EventHandler(this.FHoSoUngTuyen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelChinh;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}