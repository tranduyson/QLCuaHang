using System;
using System.Data;
using System.Data.SqlClient;
using DTO.Report;

namespace QLCuaHang.DAL
{
    public class BaoCaoDoanhThuDAL
    {
        public List<DoanhThuTheoNgayDTO> LayDoanhThuTheoNgay(string tuNgay = null, string denNgay = null)
        {
            List<DoanhThuTheoNgayDTO> list = new List<DoanhThuTheoNgayDTO>();

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
        new SqlParameter("@TuNgay", string.IsNullOrEmpty(tuNgay) ? (object)DBNull.Value : DateTime.Parse(tuNgay)),
        new SqlParameter("@DenNgay", string.IsNullOrEmpty(denNgay) ? (object)DBNull.Value : DateTime.Parse(denNgay))
            };

            DataTable data = DataProvider.Instance.ExecuteQueryReport(query, parameters);

            foreach (DataRow row in data.Rows)
            {
                DateTime ngay = row["NgayDonHang"] != DBNull.Value ? Convert.ToDateTime(row["NgayDonHang"]) : DateTime.MinValue;
                decimal doanhThu = row["DoanhThu"] != DBNull.Value ? Convert.ToDecimal(row["DoanhThu"]) : 0;

                list.Add(new DoanhThuTheoNgayDTO(ngay, doanhThu));
            }

            return list;
        }
    }
}