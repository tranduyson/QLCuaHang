using System;
using System.Data;
using System.IO;
using DTO.Report;
using QLCuaHang.DAL;

namespace QLCuaHang.BLL
{
    public class BaoCaoDoanhThuKhachHangBLL
    {
        private BaoCaoDoanhThuKhachHangDAL baoCaoDAL = new BaoCaoDoanhThuKhachHangDAL();

        public List<DoanhThuKhachHangDTO> LayDoanhThuTheoKhachHang(string? tuNgay = null, string? denNgay = null)
        {
            return baoCaoDAL.LayDoanhThuKhachHangDTOs(tuNgay, denNgay);
        }

    }
}