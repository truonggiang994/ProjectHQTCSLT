using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Policy;
using System.Windows.Forms;

namespace Job
{
    
    public class ThongTinViecLamDAO
    {
        private CVDAO cVDAO;
        private string connectionString;
        public ThongTinViecLamDAO()
        {
            cVDAO = new CVDAO();
            this.connectionString = Properties.Settings.Default.Connection;
        }

        public List<ThongTinViecLam> NhanThongTinViecLam()
        {
            List<ThongTinViecLam> thongTinCongViecs = new List<ThongTinViecLam>();
            string taiKhoan = TaiKhoan.TaiKhoanDangNhap.TK;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "select * from CongTy inner join DangTin on CongTy.tk = DangTin.tk";
                
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ThongTinViecLam thongTinViecLam = new ThongTinViecLam();
                    thongTinViecLam.LuotYeuThich = DemLuotYeuThich((int)Convert.ToSingle(reader["Id"]));
                    thongTinViecLam.TaiKhoan = reader["tk"].ToString();
                    thongTinViecLam.Id = (int)Convert.ToSingle(reader["Id"]);
                    thongTinViecLam.TenCongTy = reader["TenCongTy"].ToString();
                    thongTinViecLam.MaSoThue = reader["MaSoThue"].ToString();
                    thongTinViecLam.SDT = reader["SDT"].ToString();
                    thongTinViecLam.QuyMo = reader["QuyMo"].ToString();
                    thongTinViecLam.ChucDanh = reader["ChucDanh"].ToString();
                    thongTinViecLam.NganhNghe = reader["NganhNghe"].ToString();
                    thongTinViecLam.HinhThucLV = reader["HinhThucLV"].ToString();
                    thongTinViecLam.BangCap = reader["BangCap"].ToString();
                    thongTinViecLam.KinhNghiem = reader["KinhNghiem"].ToString();
                    thongTinViecLam.YeuCauGioiTinh = reader["YeuCauGioiTinh"].ToString();
                    thongTinViecLam.HanNopHoSo = Convert.ToDateTime(reader["HanNopHoSo"]);
                    thongTinViecLam.TinhThanh = reader["TinhThanh"].ToString();
                    thongTinViecLam.QuanHuyen = reader["QuanHuyen"].ToString();
                    thongTinViecLam.SoNha = reader["SoNha"].ToString();
                    thongTinViecLam.MucluongToiThieu = Convert.ToSingle(reader["MucluongToiThieu"]);
                    thongTinViecLam.MucLuongToiDa = Convert.ToSingle(reader["MucLuongToiDa"]);
                    thongTinViecLam.DoTuoiToiThieu = (int)Convert.ToSingle(reader["DoTuoiToiThieu"]);
                    thongTinViecLam.DoTuoiToiDa = (int)Convert.ToSingle(reader["DoTuoiToiDa"]);
                    thongTinViecLam.KiNang = reader["KiNang"].ToString();
                    thongTinViecLam.MoTaCV = reader["MoTaCV"].ToString();
                    thongTinViecLam.YeuCauCV = reader["YeuCauCV"].ToString();
                    thongTinViecLam.QuyenLoi = reader["QuyenLoi"].ToString();
                    thongTinViecLam.AnhLogo = KiemTraDauVao.ChuyenAnhSangByte((byte[])reader["AnhLogo"]);
                    if (thongTinViecLam.HanNopHoSo > DateTime.Now)
                        thongTinCongViecs.Add(thongTinViecLam);
                }
            }
            return thongTinCongViecs;
        }
       
        public void LuuThongTinUngVien(string taiKhoanDangTin, int maDangTin, int maCV, DateTime ngayNop, string taiKhoanUngTuyen)
        {
            string checkQuery = "SELECT COUNT(*) FROM DuLieuDangTin WHERE TKDangTin = @TaiKhoanDangTin AND MaDangTin = @MaDangTin AND MaCV = @MaCV AND TKUngTuyen = @TaiKhoanUngTuyen";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@TaiKhoanDangTin", taiKhoanDangTin);
                    checkCommand.Parameters.AddWithValue("@MaDangTin", maDangTin);
                    checkCommand.Parameters.AddWithValue("@MaCV", maCV);
                    checkCommand.Parameters.AddWithValue("@TaiKhoanUngTuyen", taiKhoanUngTuyen);

                    connection.Open();

                    int existingRecords = (int)checkCommand.ExecuteScalar();

                    if (existingRecords > 0)
                    {
                        
                        MessageBox.Show("Bạn đã ứng tuyển việc làm này trước đó!");
                    }
                    else
                    {
                        string insertQuery = "INSERT INTO DuLieuDangTin (TKDangTin, MaDangTin, MaCV, NgayNop, TKUngTuyen) VALUES (@TaiKhoanDangTin, @MaDangTin, @MaCV, @NgayNop, @TaiKhoanUngTuyen)";

                        using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                        {
                            insertCommand.Parameters.AddWithValue("@TaiKhoanDangTin", taiKhoanDangTin);
                            insertCommand.Parameters.AddWithValue("@MaDangTin", maDangTin);
                            insertCommand.Parameters.AddWithValue("@MaCV", maCV);
                            insertCommand.Parameters.AddWithValue("@NgayNop", ngayNop);
                            insertCommand.Parameters.AddWithValue("@TaiKhoanUngTuyen", taiKhoanUngTuyen);

                            insertCommand.ExecuteNonQuery();
                            MessageBox.Show("Hồ sơ của bạn đã được nộp thành công!");
                        }
                    }
                }
            }
        }

        public int DemLuotYeuThich(int id)
        {
            int soLanXuatHien = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = $"SELECT COUNT(*) FROM DuLieuYeuThich WHERE id = {id}";

                SqlCommand command = new SqlCommand(query, connection);
                soLanXuatHien = (int)command.ExecuteScalar();
            }
            return soLanXuatHien;
        }
    }
}
