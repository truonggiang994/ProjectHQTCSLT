using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Job
{
    public partial class UserControlTextCT : UserControl
    {
        public string Placeholder
        {
            get { return textBox1.PlaceholderText; }
            set { textBox1.PlaceholderText = value;}
        }
        
        public string text
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        public string GroupBoxText
        {
            get { return groupBox1.Text; }
            set { groupBox1.Text = value; }
        }

        public Size GroupBoxSize
        {
            get { return groupBox1.Size; }
            set { groupBox1.Size = value; }
        }
        public Size textBoxSize
        {
            get { return textBox1.Size; }
            set { textBox1.Size = value; }
        }
        public Image PictureBoxImage
        {
            get { return pictureBox2.Image; }
            set { pictureBox2.Image = value; }
        }
        public bool ReadOnly
        {
            get { return textBox1.ReadOnly; }
            set { textBox1.ReadOnly = value; }
        }
        public UserControlTextCT()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
