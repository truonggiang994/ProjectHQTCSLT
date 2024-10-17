namespace Job
{
    partial class FThongBaoNhaUngTuyen
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
            this.labelNoiDung = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.buttonMoForm = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(349, 104);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(222, 57);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Thông báo ";
            // 
            // labelNoiDung
            // 
            this.labelNoiDung.AutoSize = false;
            this.labelNoiDung.BackColor = System.Drawing.Color.Transparent;
            this.labelNoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoiDung.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelNoiDung.Location = new System.Drawing.Point(62, 182);
            this.labelNoiDung.Name = "labelNoiDung";
            this.labelNoiDung.Size = new System.Drawing.Size(795, 58);
            this.labelNoiDung.TabIndex = 1;
            this.labelNoiDung.Text = "Bạn cần tạo CV trước!";
            this.labelNoiDung.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonMoForm
            // 
            this.buttonMoForm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonMoForm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonMoForm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonMoForm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonMoForm.FillColor = System.Drawing.Color.DarkGray;
            this.buttonMoForm.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMoForm.ForeColor = System.Drawing.Color.White;
            this.buttonMoForm.Location = new System.Drawing.Point(367, 274);
            this.buttonMoForm.Name = "buttonMoForm";
            this.buttonMoForm.Size = new System.Drawing.Size(180, 45);
            this.buttonMoForm.TabIndex = 2;
            this.buttonMoForm.Text = "Tạo CV";
            this.buttonMoForm.Click += new System.EventHandler(this.buttonMoForm_Click);
            // 
            // FThongBaoNhaUngTuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 476);
            this.Controls.Add(this.buttonMoForm);
            this.Controls.Add(this.labelNoiDung);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FThongBaoNhaUngTuyen";
            this.Text = "FThongBao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelNoiDung;
        private Guna.UI2.WinForms.Guna2Button buttonMoForm;
    }
}