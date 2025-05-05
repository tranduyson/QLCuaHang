using System.Collections.Generic;
using QLCuaHang.DAL;
using QLCuaHang.DTO;

namespace QLCuaHang.BLL
{
    public class SanPhamBLL
    {
        private SanPhamDAL dal = new SanPhamDAL();

        public List<SanPhamDTO> GetAll() => dal.GetAll();

        public bool Add(SanPhamDTO sp) => dal.InsertSanPham(sp.MaSP,sp.TenSP,sp.DonVi,sp.GiaNhap,sp.GiaBan,sp.TonKho);

        public bool Update(SanPhamDTO sp) => dal.Update(sp);

        public bool Delete(string maSP) => dal.Delete(maSP);
        public List<SanPhamDTO> SearchByName(string name)
        {
            return dal.SearchSanPhamByName(name);
        }

        public SanPhamDTO SearchSanPhamByMa(string code)
        {
            return dal.SearchSanPhamByMa(code);
        }

        //mã sản phẩm tự động tăng
        public string GenerateNewMaSP()
        {
            return dal.GenerateNewMaSP();
        }
    }
}
