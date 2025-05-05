using System;
using System.Data;
using System.Data.SqlClient;

namespace QLCuaHang.DAL
{
    public class BaoCaoLuongNhanVienDAL
    {
        public DataTable LayLuongNhanVien()
        {
            string query = @"
                SELECT nv.MaNV, nv.HoTen, nv.NgaySinh, nv.GioiTinh, nv.DiaChi, nv.SDT, nv.Email,
                       cv.MaCV, cv.TenCV, cv.HeSoLuong, nv.LuongCoBan,
                       nv.LuongCoBan * cv.HeSoLuong AS TongLuong,
                       nv.NgayVaoLam, 
                       DATEDIFF(MONTH, nv.NgayVaoLam, GETDATE()) AS SoThangLamViec
                FROM NhanVien nv
                INNER JOIN ChucVu cv ON nv.MaCV = cv.MaCV
                ORDER BY cv.TenCV, nv.HoTen";

            return DataProvider.Instance.ExecuteQueryWithParameters(query);
        }
    }
}