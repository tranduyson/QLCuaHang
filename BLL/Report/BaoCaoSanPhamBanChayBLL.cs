using System.Data;
using DTO.Report;
using QLCuaHang.DAL;

namespace QLCuaHang.BLL
{
    public class BaoCaoSanPhamBanChayBLL
    {
        private readonly BaoCaoSanPhamBanChayDAL dal = new BaoCaoSanPhamBanChayDAL();

        public List<SanPhamBanChayDTO> LaySanPhamBanChay(string? tuNgay = null, string? denNgay = null, int soLuongHienThi = 20)
        {
            return dal.LaySanPhamBanChayDTOs(tuNgay, denNgay, soLuongHienThi);
        }

    }

}