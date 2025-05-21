using System.Collections.Generic;
using DTO.Report;
using QLCuaHang.DAL;

namespace QLCuaHang.BLL
{
    public class BaoCaoTonKhoBLL
    {
        private BaoCaoTonKhoDAL baoCaoDAL = new BaoCaoTonKhoDAL();

        // Hàm không tham số
        public List<BaoCaoTonKhoDTO> LayTonKho()
        {
            return baoCaoDAL.LayBaoCaoTonKhoDTOs();
        }

        // ➕ Thêm hàm có tham số tìm kiếm
        public List<BaoCaoTonKhoDTO> LayTonKho(string tenSanPham)
        {
            return baoCaoDAL.LayBaoCaoTonKhoDTOs(tenSanPham);
        }
    }
}
