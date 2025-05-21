using System;
using System.Data;
using System.IO;
using DTO.Report;
using QLCuaHang.DAL;

namespace QLCuaHang.BLL
{
    public class BaoCaoDoanhThuBLL
    {
        private BaoCaoDoanhThuDAL baoCaoDAL = new BaoCaoDoanhThuDAL();

        public List<DoanhThuTheoNgayDTO> LayDoanhThuTheoNgay(string? tuNgay = null, string? denNgay = null)
        {
            return baoCaoDAL.LayDoanhThuTheoNgay(tuNgay, denNgay);
        }
    }
}