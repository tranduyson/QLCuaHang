using System;
using System.Collections.Generic;
using QLCuaHang.DAL;
using QLCuaHang.DTO;

namespace QLCuaHang.BLL
{
    public class NhanVienBLL
    {
        private readonly NhanVienDAL dal = NhanVienDAL.Instance;

        public List<NhanVienDTO> GetAll()
        {
            return dal.GetListNhanVien();
        }

        public List<NhanVienDTO> SearchByName(string hoTen)
        {
            return dal.SearchNhanVienByName(hoTen);
        }

        public NhanVienDTO GetByMaNV(string maNV)
        {
            return dal.GetNhanVienByMa(maNV);
        }

        public bool Add(NhanVienDTO nv)
        {
            return dal.InsertNhanVien(nv.MaNV, nv.HoTen, nv.NgaySinh, nv.GioiTinh, nv.DiaChi,
                                      nv.SDT, nv.Email, nv.MaCV, nv.LuongCoBan, nv.NgayVaoLam, MD5Helper.Encrypt(nv.MatKhau));
        }

        /// <summary>
        /// Cập nhật nhân viên
        /// </summary>
        /// <param name="nv"></param>
        /// <returns></returns>
        public bool Update(NhanVienDTO nv)
        {
            var nhanvien = dal.GetNhanVienByMa(nv.MaNV);
            var matkhau = nhanvien.MatKhau;
            //nếu mật khẩu không để trống thì không cập nhật mật khẩu
            if (nv.MatKhau != null  && nv.MatKhau != "")
            {
                matkhau = MD5Helper.Encrypt(nv.MatKhau);
            }

            return dal.UpdateNhanVien(nv.MaNV, nv.HoTen, nv.NgaySinh, nv.GioiTinh, nv.DiaChi,
                                      nv.SDT, nv.Email, nv.MaCV, nv.LuongCoBan, nv.NgayVaoLam, matkhau);
        }

        public bool Delete(string maNV)
        {
            return dal.DeleteNhanVien(maNV);
        }

        public string GenerateNewMaNV()
        {
            return dal.GenerateNewMaNV();
        }

        /// <summary>
        /// Xử lý đăng nhập
        /// </summary>
        /// <param name="maNV"></param>
        /// <param name="matKhau"></param>
        /// <returns></returns>
        public bool DangNhap(string maNV, string matKhau)
        {
            string matKhauMD5 = MD5Helper.Encrypt(matKhau);
            return dal.DangNhap(maNV, matKhauMD5);
        }

    }
}
