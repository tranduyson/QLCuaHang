using System;
using System.Data;
using System.Data.SqlClient;

namespace QLCuaHang.DAL
{
    public class BaoCaoChiTietDonHangDAL
    {
        public DataTable LayChiTietDonHang(string maDonHang = null)
        {
            string query = @"
                SELECT ct.MaDH, ct.MaSP, sp.TenSP, ct.SoLuong, ct.DonGia, ct.ThanhTien,
                       dh.NgayDH, kh.TenKH, kh.SDT AS SDTKhachHang, nv.HoTen AS TenNhanVien
                FROM ChiTietDonHang ct
                INNER JOIN SanPham sp ON ct.MaSP = sp.MaSP
                INNER JOIN DonHang dh ON ct.MaDH = dh.MaDH
                INNER JOIN KhachHang kh ON dh.MaKH = kh.MaKH
                INNER JOIN NhanVien nv ON dh.MaNV = nv.MaNV
                WHERE (@MaDonHang IS NULL OR ct.MaDH = @MaDonHang)
                ORDER BY ct.MaDH";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaDonHang", maDonHang ?? (object)DBNull.Value)
            };

            return DataProvider.Instance.ExecuteQueryWithParameters(query, parameters);
        }
    }
}