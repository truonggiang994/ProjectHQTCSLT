﻿using System;
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
    public partial class FThongBaoNhaUngTuyen : Form
    {
        private Form form;
        public FThongBaoNhaUngTuyen(string noiDung, string tenButton, Form form)
        {
            InitializeComponent();
            this.form = form;
            TaiDuLieu(noiDung, tenButton);
        }
        
        

        private void TaiDuLieu(string noiDung, string tenButton)
        {
            labelNoiDung.Text = noiDung;
            buttonMoForm.Text = tenButton;
        }

        private void buttonMoForm_Click(object sender, EventArgs e)
        {
            FNhaTuyenDung.Instance.MoFCon(form);
        }
    }
}
