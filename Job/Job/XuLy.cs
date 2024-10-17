using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Job
{
    public static class XuLy
    {
        public static void KiemSoatControls(List<(Guna2HtmlLabel label, ComboBox comboBox)> comboBoxPairs, List<(Guna2HtmlLabel label, RichTextBox richTextBox)> richTextBoxPairs)
        {
            foreach (var pair in comboBoxPairs)
            {
                pair.label.Click += (sender, e) => XuLyComboBox(pair.label, pair.comboBox);
                pair.comboBox.Leave += (sender, e) => XuLyLeave(pair.comboBox, pair.label);
                pair.comboBox.Click += (sender, e) => XuLyClick(pair.label);
            }

            foreach (var pair in richTextBoxPairs)
            {
                pair.label.Click += (sender, e) => XuLyRichTextBox(pair.label, pair.richTextBox);
                pair.richTextBox.Leave += (sender, e) => XuLyLeave(pair.richTextBox, pair.label);
                pair.richTextBox.Click += (sender, e) => XuLyClick(pair.label);
            }
        }

        private static void XuLyComboBox(Guna2HtmlLabel label, ComboBox comboBox)
        {
            label.Visible = false;
            comboBox.Visible = true;
            comboBox.DroppedDown = true;
        }

        private static void XuLyLeave(Control control, Guna2HtmlLabel label)
        {
            if (control is ComboBox comboBox)
            {
                if (comboBox.SelectedItem == null)
                {
                    label.Visible = true;
                }
            }
            else if (control is RichTextBox richTextBox)
            {
                if (string.IsNullOrWhiteSpace(richTextBox.Text))
                {
                    label.Visible = true;
                }
            }
        }

        private static void XuLyClick(Guna2HtmlLabel label)
        {
            label.Visible = false;
        }

        private static void XuLyRichTextBox(Guna2HtmlLabel label, RichTextBox richTextBox)
        {
            label.Visible = false;
            richTextBox.Visible = true;
            richTextBox.Focus();
        }
    }
}
