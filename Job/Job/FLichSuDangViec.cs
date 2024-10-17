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
    public partial class FLichSuDangViec : Form
    {
        public FLichSuDangViec()
        {
            InitializeComponent();
        }
        private void TaiDuLieu()
        {
            if (DuLieuCongTy.licSuDangTins.Count == 0)
            {
                FNhaTuyenDung.Instance.MoFCon(new FThongBaoNhaUngTuyen("Bạn chưa đăng tin nào, vui lòng tạo tin đăng trước!", "Tạo đăng tin", new FDangTin()));
                return;
            }
            else
            foreach (LicSuDangTin licSuDangTin in DuLieuCongTy.licSuDangTins)
            {
                UserControlDangTin userControl = new UserControlDangTin(licSuDangTin);
                flowLayoutPanel1.Controls.Add(userControl);
            }
        }

        private void FLichSuDangViec_Load(object sender, EventArgs e)
        {
            TaiDuLieu();
        }
    }
}
