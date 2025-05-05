using System.Collections.Generic;
using QLCuaHang.DAL;
using QLCuaHang.DTO;

namespace QLCuaHang.BLL
{
    public class LuongBLL
    {
        private readonly LuongDAL dal = LuongDAL.Instance;

        // Lấy toàn bộ danh sách lương
        public List<LuongDTO> GetAll()
        {
            return dal.GetListLuong();
        }

        // Tìm theo mã nhân viên
        public List<LuongDTO> SearchByMaNV(string maNV)
        {
            return dal.SearchLuongByMaNV(maNV);
        }

        // Thêm mới lương
        public bool Add(LuongDTO luong)
        {
            return dal.InsertLuong(
                luong.MaLuong,
                luong.MaNV,
                luong.Thang,
                luong.Nam,
                luong.TongLuong
            );
        }

        // Cập nhật lương
        public bool Update(LuongDTO luong)
        {
            return dal.UpdateLuong(
                luong.MaLuong,
                luong.MaNV,
                luong.Thang,
                luong.Nam,
                luong.TongLuong
            );
        }

        // Xoá bản ghi lương
        public bool Delete(string maLuong)
        {
            return dal.DeleteLuong(maLuong);
        }

        // Tạo mã lương tự động
        public string GenerateNewMaLuong()
        {
            return dal.GenerateNewMaLuong();
        }
    }
}
