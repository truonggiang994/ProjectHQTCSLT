namespace Job
{
    partial class FViecLamYeuThich
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
            this.panelYeuThich = new Guna.UI2.WinForms.Guna2Panel();
            this.labelVLYeuThich = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelYeuThich.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelChinh
            // 
            this.flowLayoutPanelChinh.AutoScroll = true;
            this.flowLayoutPanelChinh.Location = new System.Drawing.Point(0, 60);
            this.flowLayoutPanelChinh.Name = "flowLayoutPanelChinh";
            this.flowLayoutPanelChinh.Size = new System.Drawing.Size(930, 400);
            this.flowLayoutPanelChinh.TabIndex = 0;
            // 
            // panelYeuThich
            // 
            this.panelYeuThich.BorderColor = System.Drawing.Color.DimGray;
            this.panelYeuThich.BorderRadius = 10;
            this.panelYeuThich.BorderThickness = 3;
            this.panelYeuThich.Controls.Add(this.labelVLYeuThich);
            this.panelYeuThich.Location = new System.Drawing.Point(351, 12);
            this.panelYeuThich.Name = "panelYeuThich";
            this.panelYeuThich.Size = new System.Drawing.Size(225, 35);
            this.panelYeuThich.TabIndex = 1;
            // 
            // labelVLYeuThich
            // 
            this.labelVLYeuThich.BackColor = System.Drawing.Color.Transparent;
            this.labelVLYeuThich.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVLYeuThich.Location = new System.Drawing.Point(31, 4);
            this.labelVLYeuThich.Name = "labelVLYeuThich";
            this.labelVLYeuThich.Size = new System.Drawing.Size(166, 26);
            this.labelVLYeuThich.TabIndex = 0;
            this.labelVLYeuThich.Text = "Việc làm yêu thích ";
            // 
            // FViecLamYeuThich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 460);
            this.Controls.Add(this.panelYeuThich);
            this.Controls.Add(this.flowLayoutPanelChinh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FViecLamYeuThich";
            this.Text = "FViecLamYeuThich";
            this.Load += new System.EventHandler(this.FViecLamYeuThich_Load);
            this.panelYeuThich.ResumeLayout(false);
            this.panelYeuThich.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelChinh;
        private Guna.UI2.WinForms.Guna2Panel panelYeuThich;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelVLYeuThich;
    }
}