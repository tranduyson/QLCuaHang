using System;
using System.Data;
using System.Data.SqlClient;
using DTO.Report;
using QLCuaHang.DTO;

namespace QLCuaHang.DAL
{
    public class BaoCaoChiTietDonHangDAL
    {
        public List<BaoCaoChiTietDonHangDTO> LayChiTietDonHang(string maDonHang = null)
        {
            List<BaoCaoChiTietDonHangDTO> list = new List<BaoCaoChiTietDonHangDTO>();

            string query = @"
                              SELECT ct.MaDH, ct.MaSP, sp.TenSP, ct.SoLuong, ct.DonGia, ct.ThanhTien,
                               dh.NgayDH, kh.TenKH, kh.SDT AS SDTKhachHang, nv.HoTen AS TenNhanVien
                                FROM ChiTietDonHang ct
                                 JOIN SanPham sp ON ct.MaSP = sp.MaSP
                                   JOIN DonHang dh ON ct.MaDH = dh.MaDH
                                 left JOIN KhachHang kh ON dh.MaKH = kh.MaKH
                                 left JOIN NhanVien nv ON dh.MaNV = nv.MaNV
                                WHERE (@MaDonHang IS NULL OR ct.MaDH = @MaDonHang)
                                ORDER BY ct.MaDH";

            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@MaDonHang", string.IsNullOrEmpty(maDonHang) ? (object)DBNull.Value : maDonHang)
            };

            DataTable data = DataProvider.Instance.ExecuteQueryReport(query, parameters);

            foreach (DataRow row in data.Rows)
            {
                BaoCaoChiTietDonHangDTO chiTiet = new BaoCaoChiTietDonHangDTO
                {
                    MaDH = row["MaDH"].ToString(),
                    MaSP = row["MaSP"].ToString(),
                    TenSP = row["TenSP"].ToString(),
                    SoLuong = row["SoLuong"] != DBNull.Value ? Convert.ToInt32(row["SoLuong"]) : 0,
                    DonGia = row["DonGia"] != DBNull.Value ? Convert.ToDecimal(row["DonGia"]) : 0,
                    ThanhTien = row["ThanhTien"] != DBNull.Value ? Convert.ToDecimal(row["ThanhTien"]) : 0,
                    NgayDH = row["NgayDH"] != DBNull.Value ? Convert.ToDateTime(row["NgayDH"]) : DateTime.MinValue,
                    TenKH = row["TenKH"].ToString(),
                    SDTKhachHang = row["SDTKhachHang"].ToString(),
                    TenNhanVien = row["TenNhanVien"].ToString()
                };

                list.Add(chiTiet);
            }

            return list;
        }

    }
}