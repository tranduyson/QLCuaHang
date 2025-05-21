using System.Data;
using DTO.Report;
using QLCuaHang.DAL;

namespace QLCuaHang.BLL
{
    public class BaoCaoChiTietDonHangBLL
    {
        private BaoCaoChiTietDonHangDAL baoCaoDAL = new BaoCaoChiTietDonHangDAL();

        public List<BaoCaoChiTietDonHangDTO> LayChiTietDonHang(string maDonHang = null)
        {
            return baoCaoDAL.LayChiTietDonHang(maDonHang);
        }

    }
}