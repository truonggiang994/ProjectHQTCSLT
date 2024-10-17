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
    public partial class FCamNang : Form
    {
        private CamNang camNang;

        public FCamNang(CamNang camNang)
        {
            this.camNang = camNang;
            InitializeComponent();
            TaiDuLieu();

        }

        private void TaiDuLieu()
        {
            labelTieuDe1.Text = camNang.Label1;
            richTextBoxNoiDung1.Text = camNang.RichTextBox1;
            labelTieuDe2.Text = camNang.Label2;
            richTextBoxNoiDung2.Text = camNang.RichTextBox2;
            labelTieuDe3.Text = camNang.Label3;
            richTextBoxNoiDung3.Text = camNang.RichTextBox3;
            labelTieuDe4.Text = camNang.Label4;
            richTextBoxNoiDung4.Text = camNang.RichTextBox4;
            labelTieuDe5.Text = camNang.Label5;
            richTextBox1NoiDung5.Text = camNang.RichTextBox5;
            labelTieuDe6.Text = camNang.Label5;
            richTextBoxNoiDung6.Text = camNang.RichTextBox4;
        }



    }
}
