using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job
{
    public class CamNang
    {
        public Image Anh {  get; set; }
        public string TieuDe { get; set; }
        public string NoiDung { get; set; }
        public string Label1 { get; set; }
        public string RichTextBox1 { get; set; }
        public string Label2 { get; set; }
        public string RichTextBox2 { get; set; }

        public string Label3 { get; set; }
        public string RichTextBox3 { get; set; }
        public string Label4 { get; set; }
        public string RichTextBox4 { get; set; }

        public string Label5 { get; set; }
        public string RichTextBox5 { get; set; }
        public string Label6 { get; set; }
        public string RichTextBox6 { get; set; }
        public CamNang() { }
        public CamNang(Image anh, string tieuDe, string noiDung, string label1, string richTextBox1, string label2, string richTextBox2, string label3, string richTextBox3, string label4, string richTextBox4, string label5, string richTextBox5, string label6, string richTextBox6)
        {
            Anh = anh;
            TieuDe = tieuDe;
            NoiDung = noiDung;
            Label1 = label1;
            RichTextBox1 = richTextBox1;
            Label2 = label2;
            RichTextBox2 = richTextBox2;
            Label3 = label3;
            RichTextBox3 = richTextBox3;
            Label4 = label4;
            RichTextBox4 = richTextBox4;
            Label5 = label5;
            RichTextBox5 = richTextBox5;
            Label6 = label6;
            RichTextBox6 = richTextBox6;
        }
    }
}
