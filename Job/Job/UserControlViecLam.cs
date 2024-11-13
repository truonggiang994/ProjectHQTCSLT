
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Job
{
    public partial class UserControlViecLam : UserControl
    {
        private int IDPostJob;
        public UserControlViecLam(int ID, string tenCongTy, string diaChi, string tienLuong, string chucVu)
        {
            InitializeComponent();
            this.IDPostJob = ID;
            labelTenCongTy.Text = tenCongTy;
            labelChucVu.Text = chucVu;
            labelDiaChi.Text = diaChi;
            labelTienLuong.Text = tienLuong;
        }

        private void buttonXemChiTiet_Click(object sender, EventArgs e)
        {
            FThongTinViecLam fThongTinViecLam = new FThongTinViecLam(IDPostJob);

            FNguoiUngTuyen.Ins.LoadForm(fThongTinViecLam);
        }   
    }
}
