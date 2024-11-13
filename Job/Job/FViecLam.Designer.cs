namespace Job
{
    partial class FViecLam
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
            this.SuspendLayout();
            // 
            // flowLayoutPanelChinh
            // 
            this.flowLayoutPanelChinh.AllowDrop = true;
            this.flowLayoutPanelChinh.AutoScroll = true;
            this.flowLayoutPanelChinh.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanelChinh.Name = "flowLayoutPanelChinh";
            this.flowLayoutPanelChinh.Size = new System.Drawing.Size(976, 614);
            this.flowLayoutPanelChinh.TabIndex = 3;
            // 
            // FViecLam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 638);
            this.Controls.Add(this.flowLayoutPanelChinh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FViecLam";
            this.Text = "FViecLam";
            this.Load += new System.EventHandler(this.FViecLam_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelChinh;
    }
}