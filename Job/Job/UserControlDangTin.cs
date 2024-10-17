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
    public partial class UserControlDangTin : UserControl
    {
        private LicSuDangTin licSuDangTin;
        public UserControlDangTin(LicSuDangTin licSuDangTin)
        {
            InitializeComponent();
            this.licSuDangTin = licSuDangTin;
            TaiDuLieu();
        }

        private void TaiDuLieu()
        {
            if( licSuDangTin != null )
            {
                labelChucVu.Text = "Chức vụ: " + licSuDangTin.ChucDanh;
                labelNganhNghe.Text = "Ngành: " + licSuDangTin.NganhNghe;
                labelHanHopHoSo.Text = licSuDangTin.HanNopHoSo.ToString("dd/MM/yyyy");
                if (licSuDangTin.HanNopHoSo < DateTime.Now)
                {
                    labelTrangThaiHanNop.Text = "Hết hạn";
                }
                else
                {
                    labelTrangThaiHanNop.Text = "Còn hạn";
                }
                labelMucLuongToiThieu.Text = $"Từ {licSuDangTin.MucluongToiThieu} triệu";
                labelMucLuongToiDa.Text = $"đến {licSuDangTin.MucLuongToiDa} triệu";
                labelLuotDaTuyen.Text = "Lượt đã tuyển: " + licSuDangTin.LuotDaTuyen;
                labelLuotChuaTuyen.Text = "Lượt chưa tuyển: " + licSuDangTin.LuotChuaTuyen;
            }
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            FNhaTuyenDung.Instance.MoFCon(new FSuaDangTin(licSuDangTin));
        }
    }
}
