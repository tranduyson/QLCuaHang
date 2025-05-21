using System;
using System.Data;
using System.Data.SqlClient;
using DTO.Report;

namespace QLCuaHang.DAL
{
    public class BaoCaoLuongNhanVienDAL
    {
        public DataTable LayLuongNhanVienDataTable(string tenNhanVien = null)
        {
            string query = @"
                SELECT nv.MaNV, nv.HoTen, nv.NgaySinh, nv.GioiTinh, nv.DiaChi, nv.SDT, nv.Email,
                       cv.MaCV, cv.TenCV, cv.HeSoLuong, nv.LuongCoBan,
                       nv.LuongCoBan * cv.HeSoLuong AS TongLuong,
                       nv.NgayVaoLam,
                       DATEDIFF(MONTH, nv.NgayVaoLam, GETDATE()) AS SoThangLamViec
                FROM NhanVien nv
                INNER JOIN ChucVu cv ON nv.MaCV = cv.MaCV
                WHERE (@TenNhanVien IS NULL OR nv.HoTen LIKE '%' + @TenNhanVien + '%')
                ORDER BY cv.TenCV, nv.HoTen";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@TenNhanVien", string.IsNullOrEmpty(tenNhanVien) ? (object)DBNull.Value : tenNhanVien)
            };

            return DataProvider.Instance.ExecuteQueryWithParameters(query, parameters);
        }

        public List<BaoCaoLuongNhanVienDTO> LayBaoCaoLuongNhanVienDTOs(string tenNhanVien = null)
        {
            DataTable dt = LayLuongNhanVienDataTable(tenNhanVien);
            List<BaoCaoLuongNhanVienDTO> result = new List<BaoCaoLuongNhanVienDTO>();

            foreach (DataRow row in dt.Rows)
            {
                result.Add(new BaoCaoLuongNhanVienDTO
                {
                    MaNV = row["MaNV"].ToString(),
                    HoTen = row["HoTen"].ToString(),
                    NgaySinh = (DateTime)(row["NgaySinh"] != DBNull.Value ? Convert.ToDateTime(row["NgaySinh"]) : (DateTime?)null),
                    GioiTinh = row["GioiTinh"].ToString(),
                    DiaChi = row["DiaChi"].ToString(),
                    SDT = row["SDT"].ToString(),
                    Email = row["Email"].ToString(),
                    MaCV = row["MaCV"].ToString(),
                    TenCV = row["TenCV"].ToString(),
                    HeSoLuong = row["HeSoLuong"] != DBNull.Value ? Convert.ToDecimal(row["HeSoLuong"]) : 0,
                    LuongCoBan = row["LuongCoBan"] != DBNull.Value ? Convert.ToDecimal(row["LuongCoBan"]) : 0,
                    TongLuong = row["TongLuong"] != DBNull.Value ? Convert.ToDecimal(row["TongLuong"]) : 0,
                    NgayVaoLam = (DateTime)(row["NgayVaoLam"] != DBNull.Value ? Convert.ToDateTime(row["NgayVaoLam"]) : (DateTime?)null),
                    SoThangLamViec = row["SoThangLamViec"] != DBNull.Value ? Convert.ToInt32(row["SoThangLamViec"]) : 0
                });
            }

            return result;
        }
    }
}
