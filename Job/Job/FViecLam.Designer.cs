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
            this.panelChinh = new Guna.UI2.WinForms.Guna2Panel();
            this.panelChinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelChinh
            // 
            this.flowLayoutPanelChinh.AllowDrop = true;
            this.flowLayoutPanelChinh.AutoScroll = true;
            this.flowLayoutPanelChinh.Location = new System.Drawing.Point(0, 4);
            this.flowLayoutPanelChinh.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanelChinh.Name = "flowLayoutPanelChinh";
            this.flowLayoutPanelChinh.Size = new System.Drawing.Size(1240, 543);
            this.flowLayoutPanelChinh.TabIndex = 2;
            // 
            // panelChinh
            // 
            this.panelChinh.Controls.Add(this.flowLayoutPanelChinh);
            this.panelChinh.Location = new System.Drawing.Point(0, 0);
            this.panelChinh.Margin = new System.Windows.Forms.Padding(4);
            this.panelChinh.Name = "panelChinh";
            this.panelChinh.Size = new System.Drawing.Size(1240, 524);
            this.panelChinh.TabIndex = 3;
            // 
            // FViecLam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 558);
            this.Controls.Add(this.panelChinh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FViecLam";
            this.Text = "FViecLam";
            this.panelChinh.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelChinh;
        private Guna.UI2.WinForms.Guna2Panel panelChinh;
    }
}