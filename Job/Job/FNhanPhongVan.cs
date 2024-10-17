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
    public partial class FNhanPhongVan : Form
    {
        private PhongVan phongVan;
        private LichSuUngTuyen lichSuUngTuyen;
        public FNhanPhongVan(PhongVan phongVan, LichSuUngTuyen lichSuUngTuyen)
        {
            InitializeComponent();
            this.phongVan = phongVan;
            this.lichSuUngTuyen = lichSuUngTuyen;
            TaiDuLieu();
        }

        private void TaiDuLieu()
        {
            labelHoTen.Text = $"Kính gửi:    {phongVan.HoTen}";
            labelThongTin.Text = $"    Công ty: {lichSuUngTuyen.TenCongTy} thông báo. Hồ sơ của anh chị đã đầy đủ các điều kiện và yêu cầu với vị trí ứng tuyển của công ty chúng thôi đang tuyển dụng. Chúng tôi trân trọng kính mời Anh/Chị đến tham gia buổi phỏng vấn:";
            labelChucVu.Text = $"Vị trí ứng tuyển: {lichSuUngTuyen.ChucDanh}";
            labelNgayPhongVan.Text = $"Ngày phỏng vấn: {phongVan.NgayPhongVan}";
            labelDiaChi.Text = $"Địa điểm phỏng vấn: {phongVan.DiaChiPhongVan}";
            labelThongTinNguoiPhongvan.Text = $"    Rất mong anh chị thu xếp thời gian tham gia phỏng vấn. Trường hợp Anh/Chị không thể tham gia vui lòng liên hệ {phongVan.NguoiPhongVan} qua số điện thoai: {phongVan.SDT} để xác nhận lại. Trân trọng kính chào!";
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
