using System.Data;
using DTO.Report;
using QLCuaHang.DAL;

namespace QLCuaHang.BLL
{
    public class BaoCaoLuongNhanVienBLL
    {
        private BaoCaoLuongNhanVienDAL baoCaoDAL = new BaoCaoLuongNhanVienDAL();

        public List<BaoCaoLuongNhanVienDTO> LayLuongNhanVien()
        {
            return baoCaoDAL.LayBaoCaoLuongNhanVienDTOs();
        }
        public List<BaoCaoLuongNhanVienDTO> LayLuongNhanVien(string tenNhanVien = null)
        {
            return baoCaoDAL.LayBaoCaoLuongNhanVienDTOs(tenNhanVien);
        }


    }
}