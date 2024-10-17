using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Job
{
    
    public partial class FViecLam : Form
    {
        public FViecLam()
        {
            InitializeComponent();
            TaiDuLieu(DuLieuCV.ThongTinViecLams);
        }

        private void TaiDuLieu(List<ThongTinViecLam> thongTinViecLams)
        {
            foreach (ThongTinViecLam congViec in thongTinViecLams)
            {
                ViecLamYeuThich viecLamYeuThich = DuLieuCV.viecLamYeuThichs.Find(x => x.TaiKhoan == TaiKhoan.TaiKhoanDangNhap.TK && x.ID == congViec.Id);
                UserControlViecLam userControl = new UserControlViecLam(congViec, viecLamYeuThich);
                flowLayoutPanelChinh.Controls.Add(userControl);
            }
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            string nganhNghe = comboBoxNganh.SelectedItem?.ToString();
            string tinhThanh = comboBoxTinhThanh.SelectedItem?.ToString();
            string luong = comboBoxLuong.SelectedItem?.ToString();
            string loaiSapXep = comboBoxLuotYeuThich.SelectedItem?.ToString();
            TaiDuLieuDaLoc(nganhNghe, tinhThanh, luong, loaiSapXep);
        }
        private void TaiDuLieuDaLoc(string nganhNghe, string tinhThanh, string luong, string loaiSapXep)
        {
            List<ThongTinViecLam> danhSachDaLoc = new List<ThongTinViecLam>();

            foreach (ThongTinViecLam congViec in DuLieuCV.ThongTinViecLams)
            {
                if (nganhNghe != null && nganhNghe != "Tất cả" && congViec.NganhNghe != nganhNghe)
                    continue;

                if (tinhThanh != null && tinhThanh != "Tất cả" && congViec.TinhThanh != tinhThanh)
                    continue;

                if (luong != null && luong != "Tất cả")
                {
                    string[] range = luong.Split(' ');
                    float luongToiThieu = float.Parse(range[1]);
                    float luongToiDa = float.MaxValue;

                    if (range[0] == "Dưới")
                    {
                        if (range[2] == "triệu")
                        {
                            luongToiDa = luongToiThieu;
                            luongToiThieu = 0;
                        }
                    }
                    else if (range[0] == "Trên")
                    {
                        if (range[2] == "triệu")
                            luongToiDa = luongToiThieu;
                    }

                    if (congViec.MucLuongToiDa < luongToiThieu || congViec.MucluongToiThieu > luongToiDa)
                        continue;
                }
                    danhSachDaLoc.Add(congViec);
                if (loaiSapXep == "Từ ít - nhiều")
                {
                    danhSachDaLoc.Sort((x, y) => x.LuotYeuThich.CompareTo(y.LuotYeuThich));
                }
                else if (loaiSapXep == "Từ nhiều - ít")
                {
                    danhSachDaLoc.Sort((x, y) => y.LuotYeuThich.CompareTo(x.LuotYeuThich));
                }
            }

            flowLayoutPanelChinh.Controls.Clear();

            TaiDuLieu(danhSachDaLoc);
        }
    }
}
