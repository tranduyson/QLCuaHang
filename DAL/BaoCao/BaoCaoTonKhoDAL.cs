using System;
using System.Data;
using System.Data.SqlClient;

namespace QLCuaHang.DAL
{
    public class BaoCaoTonKhoDAL
    {
        public DataTable LayTonKho()
        {
            string query = @"
                SELECT sp.MaSP, sp.TenSP, sp.DonVi, sp.GiaBan, sp.GiaNhap,
                       sp.TonKho, 
                       sp.GiaNhap * sp.TonKho AS GiaTriTonKho,
                       CASE
                           WHEN sp.TonKho = 0 THEN N'Hết hàng'
                           WHEN sp.TonKho < 10 THEN N'Sắp hết'
                           ELSE N'Còn hàng'
                       END AS TrangThai
                FROM SanPham sp
                ORDER BY sp.TonKho ASC";

            return DataProvider.Instance.ExecuteQueryWithParameters(query);
        }
    }
}