namespace Job
{
    partial class FTopViecLam
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
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.flowLayoutPanelCVYT = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(312, 24);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(351, 26);
            this.guna2HtmlLabel1.TabIndex = 2;
            this.guna2HtmlLabel1.Text = "Top 5 các việc làm được\r\n yêu thích nhất ";
            // 
            // flowLayoutPanelCVYT
            // 
            this.flowLayoutPanelCVYT.AutoScroll = true;
            this.flowLayoutPanelCVYT.Location = new System.Drawing.Point(1, 55);
            this.flowLayoutPanelCVYT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanelCVYT.Name = "flowLayoutPanelCVYT";
            this.flowLayoutPanelCVYT.Size = new System.Drawing.Size(930, 434);
            this.flowLayoutPanelCVYT.TabIndex = 3;
            // 
            // FTopViecLam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 489);
            this.Controls.Add(this.flowLayoutPanelCVYT);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FTopViecLam";
            this.Text = "FTopViecLam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCVYT;
    }
}