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
    public partial class UserControlComboBox : UserControl
    {
        private bool isLabelVisible = true;
        private List<string> items = new List<string>();
        public string comboText
        {
            get { return comboBoxGioiTinh.Text; }
            set { comboBoxGioiTinh.Text = value; }
        }
        public string labelText
        {
            get { return labelGioiTnh.Text; }
            set { labelGioiTnh.Text = value; }
        }
        public string text
        {
            get { return comboBoxGioiTinh.Text; }
            set { comboBoxGioiTinh.Text = value; }
        }
        public string labelChonText
        {
            get { return guna2HtmlLabel1.Text; }
            set { guna2HtmlLabel1.Text = value; }
        }
        public List<string> Items
        {
            get { return items; }
            set { items = value; UpdateComboBoxItems(); }
        }
        public UserControlComboBox()
        {
            InitializeComponent();
        }
        private void UpdateComboBoxItems()
        {
            comboBoxGioiTinh.Items.Clear();
            comboBoxGioiTinh.Items.AddRange(items.ToArray());
        }

        public void AddItem(string item)
        {
            items.Add(item);
            comboBoxGioiTinh.Items.Add(item);
        }

        public void RemoveItem(string item)
        {
            items.Remove(item);
            comboBoxGioiTinh.Items.Remove(item);
        }
        private void comboBoxGioiTinh_Click(object sender, EventArgs e)
        {
            if (isLabelVisible)
            {
                guna2HtmlLabel1.Hide();
                isLabelVisible = false;
            }
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {
            guna2HtmlLabel1.Visible = false;
            comboBoxGioiTinh.Show();
        }
    }
}
