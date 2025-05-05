using System;
using System.Data;
using System.Data.SqlClient;

namespace QLCuaHang.DAL
{
    public class BaoCaoSanPhamBanChayDAL
    {
        public DataTable LaySanPhamBanChay(DateTime? tuNgay = null, DateTime? denNgay = null, int soLuongHienThi = 20)
        {
            string query = @"
                SELECT TOP (@SoLuongHienThi) sp.MaSP, sp.TenSP, sp.DonVi, 
                       SUM(ct.SoLuong) AS TongSoLuong,
                       SUM(ct.ThanhTien) AS TongDoanhThu,
                       sp.GiaBan, sp.TonKho
                FROM ChiTietDonHang ct
                INNER JOIN SanPham sp ON ct.MaSP = sp.MaSP
                INNER JOIN DonHang dh ON ct.MaDH = dh.MaDH
                WHERE (@TuNgay IS NULL OR dh.NgayDH >= @TuNgay) 
                  AND (@DenNgay IS NULL OR dh.NgayDH <= @DenNgay)
                GROUP BY sp.MaSP, sp.TenSP, sp.DonVi, sp.GiaBan, sp.TonKho
                ORDER BY TongSoLuong DESC";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@TuNgay", tuNgay ?? (object)DBNull.Value),
                new SqlParameter("@DenNgay", denNgay ?? (object)DBNull.Value),
                new SqlParameter("@SoLuongHienThi", soLuongHienThi)
            };

            return DataProvider.Instance.ExecuteQueryWithParameters(query, parameters);
        }
    }
}