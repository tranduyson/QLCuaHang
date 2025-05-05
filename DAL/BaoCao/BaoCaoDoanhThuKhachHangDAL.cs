using System;
using System.Data;
using System.Data.SqlClient;

namespace QLCuaHang.DAL
{
    public class BaoCaoDoanhThuKhachHangDAL
    {
        public DataTable LayDoanhThuTheoKhachHang(DateTime? tuNgay = null, DateTime? denNgay = null)
        {
            string query = @"
                SELECT kh.MaKH, kh.TenKH, kh.SDT, kh.DiaChi, kh.Email,
                       COUNT(dh.MaDH) AS SoDonHang,
                       SUM(dh.TongTien) AS TongDoanhThu
                FROM KhachHang kh
                LEFT JOIN DonHang dh ON kh.MaKH = dh.MaKH
                WHERE (@TuNgay IS NULL OR dh.NgayDH >= @TuNgay) 
                  AND (@DenNgay IS NULL OR dh.NgayDH <= @DenNgay)
                GROUP BY kh.MaKH, kh.TenKH, kh.SDT, kh.DiaChi, kh.Email
                ORDER BY TongDoanhThu DESC";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@TuNgay", tuNgay ?? (object)DBNull.Value),
                new SqlParameter("@DenNgay", denNgay ?? (object)DBNull.Value)
            };

            return DataProvider.Instance.ExecuteQueryWithParameters(query, parameters);
        }
    }
}