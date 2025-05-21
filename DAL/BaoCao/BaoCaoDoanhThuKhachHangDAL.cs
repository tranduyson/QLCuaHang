using System;
using System.Data;
using System.Data.SqlClient;
using DTO.Report;

namespace QLCuaHang.DAL
{
    public class BaoCaoDoanhThuKhachHangDAL
    {
        public DataTable LayDoanhThuTheoKhachHang(string tuNgay = null, string denNgay = null)
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
                new SqlParameter("@TuNgay", string.IsNullOrEmpty(tuNgay) ? (object)DBNull.Value : DateTime.Parse(tuNgay)),
                new SqlParameter("@DenNgay", string.IsNullOrEmpty(denNgay) ? (object)DBNull.Value : DateTime.Parse(denNgay))
            };

            return DataProvider.Instance.ExecuteQueryWithParameters(query, parameters);
        }

        public List<DoanhThuKhachHangDTO> LayDoanhThuKhachHangDTOs(string tuNgay = null, string denNgay = null)
        {
            DataTable dt = LayDoanhThuTheoKhachHang(tuNgay, denNgay);

            List<DoanhThuKhachHangDTO> result = new List<DoanhThuKhachHangDTO>();

            foreach (DataRow row in dt.Rows)
            {
                result.Add(new DoanhThuKhachHangDTO
                {
                    MaKH = row["MaKH"].ToString(),
                    TenKH = row["TenKH"].ToString(),
                    SDT = row["SDT"].ToString(),
                    DiaChi = row["DiaChi"].ToString(),
                    Email = row["Email"].ToString(),
                    SoDonHang = row["SoDonHang"] != DBNull.Value ? Convert.ToInt32(row["SoDonHang"]) : 0,
                    TongDoanhThu = row["TongDoanhThu"] != DBNull.Value ? Convert.ToDecimal(row["TongDoanhThu"]) : 0
                });
            }

            return result;
        }

    }
}