namespace Job
{
    partial class UserControlComboBox
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
            this.comboBoxGioiTinh = new Guna.UI2.WinForms.Guna2ComboBox();
            this.labelGioiTnh = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // comboBoxGioiTinh
            // 
            this.comboBoxGioiTinh.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxGioiTinh.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.comboBoxGioiTinh.BorderRadius = 4;
            this.comboBoxGioiTinh.BorderThickness = 2;
            this.comboBoxGioiTinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGioiTinh.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxGioiTinh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxGioiTinh.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.comboBoxGioiTinh.ForeColor = System.Drawing.Color.Black;
            this.comboBoxGioiTinh.ItemHeight = 24;
            this.comboBoxGioiTinh.Location = new System.Drawing.Point(2, 25);
            this.comboBoxGioiTinh.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxGioiTinh.Name = "comboBoxGioiTinh";
            this.comboBoxGioiTinh.Size = new System.Drawing.Size(279, 30);
            this.comboBoxGioiTinh.TabIndex = 40;
            // 
            // labelGioiTnh
            // 
            this.labelGioiTnh.BackColor = System.Drawing.Color.Transparent;
            this.labelGioiTnh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGioiTnh.Location = new System.Drawing.Point(11, 3);
            this.labelGioiTnh.Margin = new System.Windows.Forms.Padding(2);
            this.labelGioiTnh.Name = "labelGioiTnh";
            this.labelGioiTnh.Size = new System.Drawing.Size(114, 21);
            this.labelGioiTnh.TabIndex = 39;
            this.labelGioiTnh.Text = "Yêu cầu giới tính ";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.DarkGray;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(11, 29);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(36, 21);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Chọn";
            // 
            // UserControlComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.comboBoxGioiTinh);
            this.Controls.Add(this.labelGioiTnh);
            this.Name = "UserControlComboBox";
            this.Size = new System.Drawing.Size(284, 58);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox comboBoxGioiTinh;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelGioiTnh;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}
