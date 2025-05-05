using System;
using System.Collections.Generic;
using System.Xml.Linq;
using QLCuaHang.DAL;
using QLCuaHang.DTO;

namespace QLCuaHang.BLL
{
    public class DonHangBLL
    {
        private readonly DonHangDAL dal = DonHangDAL.Instance;

        // Lấy tất cả đơn hàng
        public List<DonHangDTO> GetAll()
        {
            return dal.GetListDonHang();
        }

        // Lấy đơn hàng theo mã
        public DonHangDTO GetByMaDH(string maDH)
        {
            return dal.GetDonHangByMa(maDH);
        }

        // Thêm đơn hàng mới
        public bool Add(DonHangDTO dh, out string outmess)
        {
            outmess = string.Empty;

            // Thêm đơn hàng chính
            bool isSuccess = dal.InsertDonHang(dh.MaDH, dh.NgayDH, dh.MaKH, dh.MaNV, dh.TongTien);
            if (!isSuccess)
            {
                outmess = "Thêm đơn hàng thất bại.";
                return false;
            }

            // Thêm từng dòng chi tiết
            foreach (var ct in dh.DSChiTiet)
            {
                bool result = dal.InsertChiTietDonHang(ct.MaDH, ct.MaSP, ct.SoLuong, ct.DonGia, ct.ThanhTien);
                if (!result)
                {
                    outmess = $"Thêm chi tiết đơn hàng cho sản phẩm {ct.MaSP} thất bại.";
                    return false;
                }
            }

            outmess = "Thêm đơn hàng thành công.";
            return true;
        }

        // Xoá đơn hàng và chi tiết
        public bool Delete(string maDH)
        {
            return dal.DeleteDonHang(maDH);
        }

        // Sinh mã tự động
        public string GenerateNewMaDH()
        {
            return dal.GenerateNewMaDH();
        }
        public bool Update(DonHangDTO dh)
        {
            return DonHangDAL.Instance.Update(dh); // Giả sử DAL có hàm Update
        }
        public List<DonHangDTO> SearchByName(string name)
        {
            return dal.SearchDonHangByMaDH(name);
        }

        public List<DonHangDTO> SearchDonHang(string? maDH, DateTime? fromDate, DateTime? toDate, string? maNV, string? maKH)
        {
            return dal.SearchDonHang(maDH, fromDate, toDate, maNV, maKH);
        }

    }
}
