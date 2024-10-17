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
    public partial class UserControlLabelTT : UserControl
    {
        public string LabelText
        {
            get { return label1.Text; }
            set { label1.Text = value; }
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
        public Image PictureBoxImage
        {
            get { return PictureBox1.Image; }
            set { PictureBox1.Image = value; }
        }
        public UserControlLabelTT()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
