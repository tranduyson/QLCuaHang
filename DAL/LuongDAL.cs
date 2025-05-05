using System;
using System.Collections.Generic;
using System.Data;
using QLCuaHang.DTO;

namespace QLCuaHang.DAL
{
    public class LuongDAL
    {
        private static LuongDAL instance;

        public static LuongDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new LuongDAL();
                return instance;
            }
            private set => instance = value;
        }

        private LuongDAL() { }

        // 1. Lấy danh sách lương đầy đủ
        public List<LuongDTO> GetListLuong()
        {
            List<LuongDTO> list = new List<LuongDTO>();

            string query = @"
                SELECT 
                    l.MaLuong, l.MaNV, nv.HoTen AS TenNV, nv.MaCV, cv.TenCV,
                    nv.LuongCoBan, cv.HeSoLuong, l.Thang, l.Nam, l.TongLuong
                FROM Luong l
                JOIN NhanVien nv ON l.MaNV = nv.MaNV
                JOIN ChucVu cv ON nv.MaCV = cv.MaCV";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                LuongDTO luong = new LuongDTO(
                    row["MaLuong"].ToString(),
                    row["MaNV"].ToString(),
                    row["TenNV"].ToString(),
                    row["MaCV"].ToString(),
                    row["TenCV"].ToString(),
                    float.Parse(row["HeSoLuong"].ToString()),
                    decimal.Parse(row["LuongCoBan"].ToString()),
                    int.Parse(row["Thang"].ToString()),
                    int.Parse(row["Nam"].ToString()),
                    decimal.Parse(row["TongLuong"].ToString())
                );

                list.Add(luong);
            }

            return list;
        }

        // 2. Tìm kiếm theo mã nhân viên
        public List<LuongDTO> SearchLuongByMaNV(string maNV)
        {
            List<LuongDTO> list = new List<LuongDTO>();

            string query = @"
                SELECT 
                    l.MaLuong, l.MaNV, nv.HoTen AS TenNV, nv.MaCV, cv.TenCV,
                    nv.LuongCoBan, cv.HeSoLuong, l.Thang, l.Nam, l.TongLuong
                FROM Luong l
                JOIN NhanVien nv ON l.MaNV = nv.MaNV
                JOIN ChucVu cv ON nv.MaCV = cv.MaCV
                WHERE l.MaNV LIKE '%' + @MaNV + '%'";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maNV });

            foreach (DataRow row in data.Rows)
            {
                LuongDTO luong = new LuongDTO(
                    row["MaLuong"].ToString(),
                    row["MaNV"].ToString(),
                    row["TenNV"].ToString(),
                    row["MaCV"].ToString(),
                    row["TenCV"].ToString(),
                    float.Parse(row["HeSoLuong"].ToString()),
                    decimal.Parse(row["LuongCoBan"].ToString()),
                    int.Parse(row["Thang"].ToString()),
                    int.Parse(row["Nam"].ToString()),
                    decimal.Parse(row["TongLuong"].ToString())
                );

                list.Add(luong);
            }

            return list;
        }

        // 3. Thêm lương
        public bool InsertLuong(string maLuong, string maNV, int thang, int nam, decimal tongLuong)
        {
            string query = "INSERT INTO Luong VALUES (@MaLuong, @MaNV, @Thang, @Nam, @TongLuong)";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] {
                maLuong, maNV, thang, nam, tongLuong
            });
            return result > 0;
        }

        // 4. Cập nhật lương
        public bool UpdateLuong(string maLuong, string maNV, int thang, int nam, decimal tongLuong)
        {
            string query = "UPDATE Luong SET MaNV = @MaNV, Thang = @Thang, Nam = @Nam, TongLuong = @TongLuong WHERE MaLuong = @MaLuong";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] {
                maNV, thang, nam, tongLuong, maLuong
            });
            return result > 0;
        }

        // 5. Xóa lương
        public bool DeleteLuong(string maLuong)
        {
            string query = "DELETE FROM Luong WHERE MaLuong = @MaLuong";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maLuong });
            return result > 0;
        }

        // 6. Tạo mã tự động
        public string GenerateNewMaLuong()
        {
            string query = "SELECT TOP 1 MaLuong FROM Luong ORDER BY MaLuong DESC";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                string last = data.Rows[0]["MaLuong"].ToString(); // LU009
                int num = int.Parse(last.Substring(2));
                return "LU" + (num + 1).ToString("D3");
            }

            return "LU001";
        }
    }
}
