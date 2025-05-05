using System;
using System.Data;
using System.Data.SqlClient;

namespace QLCuaHang.DAL
{
    public class BaoCaoDoanhThuDAL
    {
        public DataTable LayDoanhThuTheoNgay(DateTime? tuNgay = null, DateTime? denNgay = null)
        {
            string query = @"
                SELECT CONVERT(date, NgayDH) AS NgayDonHang, 
                       SUM(TongTien) AS DoanhThu 
                FROM DonHang 
                WHERE (@TuNgay IS NULL OR NgayDH >= @TuNgay) 
                  AND (@DenNgay IS NULL OR NgayDH <= @DenNgay)
                GROUP BY CONVERT(date, NgayDH)
                ORDER BY NgayDonHang";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@TuNgay", tuNgay ?? (object)DBNull.Value),
                new SqlParameter("@DenNgay", denNgay ?? (object)DBNull.Value)
            };

            return DataProvider.Instance.ExecuteQueryWithParameters(query, parameters);
        }
    }
}