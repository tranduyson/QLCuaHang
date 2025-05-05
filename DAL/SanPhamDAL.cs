using System;
using System.Collections.Generic;
using System.Data;
using QLCuaHang.DTO;

namespace QLCuaHang.DAL
{
    public class SanPhamDAL
    {
        public List<SanPhamDTO> GetAll()
        {
            List<SanPhamDTO> list = new List<SanPhamDTO>();
            string query = "SELECT * FROM SanPham";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                SanPhamDTO sp = new SanPhamDTO
                {
                    MaSP = row["MaSP"].ToString(),
                    TenSP = row["TenSP"].ToString(),
                    DonVi = row["DonVi"].ToString(),
                    GiaBan = Convert.ToDecimal(row["GiaBan"]),
                    GiaNhap = Convert.ToDecimal(row["GiaNhap"]),
                    TonKho = Convert.ToInt32(row["TonKho"])
                };
                list.Add(sp);
            }

            return list;
        }

        public bool InsertSanPham(string maSP, string tenSP, string donVi, decimal giaBan, decimal giaNhap, int tonKho)
        {
            string query = "INSERT INTO SanPham VALUES (@MaSP, @TenSP, @DonVi, @GiaBan, @GiaNhap, @TonKho)";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[]
            {
        maSP, tenSP, donVi, giaBan, giaNhap, tonKho
            });

            return result > 0;
        }




        public bool Update(SanPhamDTO sp)
        {
            string query = @"UPDATE SanPham SET 
                             TenSP = @TenSP,
                             DonVi = @DonVi,
                             GiaBan = @GiaBan,
                             GiaNhap = @GiaNhap,
                             TonKho = @TonKho
                             WHERE MaSP = @MaSP";
            object[] parameters = {
                sp.TenSP, sp.DonVi, sp.GiaBan, sp.GiaNhap, sp.TonKho, sp.MaSP
            };

            return DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool Delete(string maSP)
        {
            string query = "DELETE FROM SanPham WHERE MaSP = @MaSP";
            object[] parameters = { maSP };

            return DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0;
        }
        public string GenerateNewMaSP()
        {
            string query = "SELECT TOP 1 MaSP FROM SanPham ORDER BY MaSP DESC";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                string lstMaSP = data.Rows[0]["MaSP"].ToString();
                int number = int.Parse(lstMaSP.Substring(2));
                return "SP" + (number + 1).ToString("D3");
            }

            return "SP001";
        }

        public List<SanPhamDTO> SearchSanPhamByName(string name)
        {
            List<SanPhamDTO> list = new List<SanPhamDTO>();

            string query = "SELECT * FROM SanPham WHERE TenSP LIKE N'%' + @TenSP + '%'";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { name });

            foreach (DataRow row in data.Rows)
            {
                SanPhamDTO sp = new SanPhamDTO(
                    row["MaSP"].ToString(),
                    row["TenSP"].ToString(),
                    row["DonVi"].ToString(),
                    decimal.Parse(row["GiaBan"].ToString()),
                    decimal.Parse(row["GiaNhap"].ToString()),
                    int.Parse(row["TonKho"].ToString())
                );

                list.Add(sp);
            }

            return list;
        }

        public SanPhamDTO SearchSanPhamByMa(string maSP)
        {
            string query = "SELECT * FROM SanPham WHERE MaSP = @MaSP"; // Tìm theo mã sản phẩm chính xác

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maSP });

            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0]; // Lấy dòng đầu tiên (nếu có)

                SanPhamDTO sp = new SanPhamDTO(
                    row["MaSP"].ToString(),
                    row["TenSP"].ToString(),
                    row["DonVi"].ToString(),
                    decimal.Parse(row["GiaBan"].ToString()),
                    decimal.Parse(row["GiaNhap"].ToString()),
                    int.Parse(row["TonKho"].ToString())
                );

                return sp; // Trả về đối tượng SanPhamDTO
            }

            return null; // Nếu không tìm thấy, trả về null
        }


    }
}
