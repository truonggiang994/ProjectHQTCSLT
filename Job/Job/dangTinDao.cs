using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Job
{
    public class DangTinDao
    {
        private string connectionString;

        public DangTinDao()
        {
            this.connectionString = Properties.Settings.Default.Connection;

        }

        public void ThemDangTin(DangTin dangTin)
        {
            string query = "INSERT INTO DangTin (TK, ChucDanh, NganhNghe, HinhThucLV, BangCap, KinhNghiem, DoTuoiToiThieu, DoTuoiToiDa, YeuCauGioiTinh, HanNopHoSo, TinhThanh, QuanHuyen, SoNha, MucluongToiThieu, MucLuongToiDa, KiNang, MoTaCV, YeuCauCV, QuyenLoi) VALUES (@TK, @ChucDanh, @NganhNghe, @HinhThucLV, @BangCap, @KinhNghiem, @DoTuoiToiThieu, @DoTuoiToiDa, @YeuCauGioiTinh, @HanNopHoSo, @TinhThanh, @QuanHuyen, @SoNha, @MucluongToiThieu, @MucLuongToiDa, @KiNang, @MoTaCV, @YeuCauCV, @QuyenLoi)";
            DuaVoSQL(dangTin, query);
        }

        private void DuaVoSQL(DangTin dangTin, string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@TK", dangTin.TaiKhoan);
                command.Parameters.AddWithValue("@ChucDanh", dangTin.ChucDanh);
                command.Parameters.AddWithValue("@NganhNghe", dangTin.NganhNghe);
                command.Parameters.AddWithValue("@HinhThucLV", dangTin.HinhThucLV);
                command.Parameters.AddWithValue("@BangCap", dangTin.BangCap);
                command.Parameters.AddWithValue("@KinhNghiem", dangTin.KinhNghiem);
                command.Parameters.AddWithValue("@DoTuoiToiThieu", dangTin.DoTuoiToiThieu);
                command.Parameters.AddWithValue("@DoTuoiToiDa", dangTin.DoTuoiToiDa);
                command.Parameters.AddWithValue("@YeuCauGioiTinh", dangTin.YeuCauGioiTinh);
                command.Parameters.AddWithValue("@HanNopHoSo", dangTin.HanNopHoSo);
                command.Parameters.AddWithValue("@TinhThanh", dangTin.TinhThanh);
                command.Parameters.AddWithValue("@QuanHuyen", dangTin.QuanHuyen);
                command.Parameters.AddWithValue("@SoNha", dangTin.SoNha);
                command.Parameters.AddWithValue("@MucluongToiThieu", dangTin.MucluongToiThieu);
                command.Parameters.AddWithValue("@MucLuongToiDa", dangTin.MucLuongToiDa);
                command.Parameters.AddWithValue("@KiNang", dangTin.KiNang);
                command.Parameters.AddWithValue("@MoTaCV", dangTin.MoTaCV);
                command.Parameters.AddWithValue("@YeuCauCV", dangTin.YeuCauCV);
                command.Parameters.AddWithValue("@QuyenLoi", dangTin.QuyenLoi);
                connection.Open();
                command.ExecuteNonQuery();

            }
        }

        public void SuaDangTin(DangTin dangTin)
        {
            string query = "UPDATE DangTin SET ChucDanh = @ChucDanh, NganhNghe = @NganhNghe, HinhThucLV = @HinhThucLV, BangCap = @BangCap, KinhNghiem = @KinhNghiem, DoTuoiToiThieu = @DoTuoiToiThieu, DoTuoiToiDa = @DoTuoiToiDa, YeuCauGioiTinh = @YeuCauGioiTinh, HanNopHoSo = @HanNopHoSo, TinhThanh = @TinhThanh, QuanHuyen = @QuanHuyen, SoNha = @SoNha, MucluongToiThieu = @MucluongToiThieu, MucLuongToiDa = @MucLuongToiDa, KiNang = @KiNang, MoTaCV = @MoTaCV, YeuCauCV = @YeuCauCV, QuyenLoi = @QuyenLoi WHERE Id = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@ChucDanh", dangTin.ChucDanh);
                command.Parameters.AddWithValue("@NganhNghe", dangTin.NganhNghe);
                command.Parameters.AddWithValue("@HinhThucLV", dangTin.HinhThucLV);
                command.Parameters.AddWithValue("@BangCap", dangTin.BangCap);
                command.Parameters.AddWithValue("@KinhNghiem", dangTin.KinhNghiem);
                command.Parameters.AddWithValue("@DoTuoiToiThieu", dangTin.DoTuoiToiThieu);
                command.Parameters.AddWithValue("@DoTuoiToiDa", dangTin.DoTuoiToiDa);
                command.Parameters.AddWithValue("@YeuCauGioiTinh", dangTin.YeuCauGioiTinh);
                command.Parameters.AddWithValue("@HanNopHoSo", dangTin.HanNopHoSo);
                command.Parameters.AddWithValue("@TinhThanh", dangTin.TinhThanh);
                command.Parameters.AddWithValue("@QuanHuyen", dangTin.QuanHuyen);
                command.Parameters.AddWithValue("@SoNha", dangTin.SoNha);
                command.Parameters.AddWithValue("@MucluongToiThieu", dangTin.MucluongToiThieu);
                command.Parameters.AddWithValue("@MucLuongToiDa", dangTin.MucLuongToiDa);
                command.Parameters.AddWithValue("@KiNang", dangTin.KiNang);
                command.Parameters.AddWithValue("@MoTaCV", dangTin.MoTaCV);
                command.Parameters.AddWithValue("@YeuCauCV", dangTin.YeuCauCV);
                command.Parameters.AddWithValue("@QuyenLoi", dangTin.QuyenLoi);
                command.Parameters.AddWithValue("@Id", dangTin.Id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
