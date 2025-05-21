using System;
using System.Data;
using System.Data.SqlClient;
using DTO.Report;

namespace QLCuaHang.DAL
{
    public class BaoCaoSanPhamBanChayDAL
    {
        public DataTable LaySanPhamBanChayDataTable(string tuNgay = null, string denNgay = null, int soLuongHienThi = 20)
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
                new SqlParameter("@TuNgay", string.IsNullOrEmpty(tuNgay) ? (object)DBNull.Value : DateTime.Parse(tuNgay)),
                new SqlParameter("@DenNgay", string.IsNullOrEmpty(denNgay) ? (object)DBNull.Value : DateTime.Parse(denNgay)),
                new SqlParameter("@SoLuongHienThi", soLuongHienThi)
            };

            return DataProvider.Instance.ExecuteQueryWithParameters(query, parameters);
        }

        public List<SanPhamBanChayDTO> LaySanPhamBanChayDTOs(string tuNgay = null, string denNgay = null, int soLuongHienThi = 20)
        {
            DataTable dt = LaySanPhamBanChayDataTable(tuNgay, denNgay, soLuongHienThi);

            List<SanPhamBanChayDTO> result = new List<SanPhamBanChayDTO>();

            foreach (DataRow row in dt.Rows)
            {
                result.Add(new SanPhamBanChayDTO
                {
                    MaSP = row["MaSP"].ToString(),
                    TenSP = row["TenSP"].ToString(),
                    DonVi = row["DonVi"].ToString(),
                    TongSoLuong = row["TongSoLuong"] != DBNull.Value ? Convert.ToInt32(row["TongSoLuong"]) : 0,
                    TongDoanhThu = row["TongDoanhThu"] != DBNull.Value ? Convert.ToDecimal(row["TongDoanhThu"]) : 0,
                    GiaBan = row["GiaBan"] != DBNull.Value ? Convert.ToDecimal(row["GiaBan"]) : 0,
                    TonKho = row["TonKho"] != DBNull.Value ? Convert.ToInt32(row["TonKho"]) : 0
                });
            }

            return result;
        }
    }
}
