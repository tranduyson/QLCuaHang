using System;
using System.Data;
using System.Data.SqlClient;
using DTO.Report;

namespace QLCuaHang.DAL
{
    public class BaoCaoTonKhoDAL
    {
        public DataTable LayTonKhoDataTable(string tenSanPham = null)
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
                WHERE (@TenSanPham IS NULL OR sp.TenSP LIKE '%' + @TenSanPham + '%')
                ORDER BY sp.TonKho ASC";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@TenSanPham", string.IsNullOrEmpty(tenSanPham) ? (object)DBNull.Value : tenSanPham)
            };

            return DataProvider.Instance.ExecuteQueryWithParameters(query, parameters);
        }

        public List<BaoCaoTonKhoDTO> LayBaoCaoTonKhoDTOs(string tenSanPham = null)
        {
            DataTable dt = LayTonKhoDataTable(tenSanPham);
            List<BaoCaoTonKhoDTO> result = new List<BaoCaoTonKhoDTO>();

            foreach (DataRow row in dt.Rows)
            {
                result.Add(new BaoCaoTonKhoDTO
                {
                    MaSP = row["MaSP"].ToString(),
                    TenSP = row["TenSP"].ToString(),
                    DonVi = row["DonVi"].ToString(),
                    GiaBan = row["GiaBan"] != DBNull.Value ? Convert.ToDecimal(row["GiaBan"]) : 0,
                    GiaNhap = row["GiaNhap"] != DBNull.Value ? Convert.ToDecimal(row["GiaNhap"]) : 0,
                    TonKho = row["TonKho"] != DBNull.Value ? Convert.ToInt32(row["TonKho"]) : 0,
                    GiaTriTonKho = row["GiaTriTonKho"] != DBNull.Value ? Convert.ToDecimal(row["GiaTriTonKho"]) : 0,
                    TrangThai = row["TrangThai"].ToString()
                });
            }

            return result;
        }
    }
}
