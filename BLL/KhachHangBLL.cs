using System;
using System.Collections.Generic;
using QLCuaHang.DAL;
using QLCuaHang.DTO;
namespace QLCuaHang.BLL
{
    public class KhachHangBLL
    {
        private readonly KhachHangDAL dal = KhachHangDAL.Instance;
        // Lấy toàn bộ khách hàng
        public List<KhachHangDTO> GetAll()
        {
            return dal.GetListKhachHang();
        }
        // Tìm kiếm theo tên
        public List<KhachHangDTO> SearchByName(string tenKH)
        {
            return dal.SearchKhachHangByName(tenKH);
        }

        // Tìm kiếm theo số điện thoại
        public List<KhachHangDTO> SearchByPhone(string sdt)
        {
            return dal.SearchKhachHangByPhone(sdt);
        }

        // Lấy khách hàng theo số điện thoại chính xác
        public KhachHangDTO GetByPhone(string sdt)
        {
            if (string.IsNullOrEmpty(sdt))
                return null;

            return dal.GetKhachHangByPhone(sdt);
        }

        // Lấy chi tiết khách theo mã
        public KhachHangDTO GetByMaKH(string maKH)
        {
            return dal.GetKhachHangByMa(maKH);
        }

        // Thêm mới khách hàng
        /// <summary>
        /// Thêm mới khách hàng với kiểm tra trùng số điện thoại
        /// </summary>
        /// <param name="kh">Thông tin khách hàng</param>
        /// <param name="outMess">Thông báo lỗi nếu có</param>
        /// <returns>true nếu thêm thành công, false nếu thất bại</returns>
        public bool Add(KhachHangDTO kh, out string outMess)
        {
            outMess = string.Empty;
            // Kiểm tra số điện thoại đã tồn tại chưa
            if (!string.IsNullOrEmpty(kh.SDT))
            {
                KhachHangDTO existingCustomer = GetByPhone(kh.SDT);
                if (existingCustomer != null)
                {
                    outMess = "Số điện thoại đã tồn tại trong hệ thống!";
                    return false;
                }
            }
            // Nếu không trùng, tiến hành thêm mới
            bool result = dal.InsertKhachHang(kh.MaKH, kh.TenKH, kh.SDT, kh.DiaChi, kh.Email);
            if (!result)
            {
                outMess = "Không thể thêm khách hàng vào cơ sở dữ liệu!";
            }
            return result;
        }

        /// <summary>
        /// Thêm mới hoặc cập nhật khách hàng dựa trên số điện thoại
        /// </summary>
        /// <param name="kh">Thông tin khách hàng</param>
        /// <param name="outMess">Thông báo kết quả</param>
        /// <returns>true nếu thành công, false nếu thất bại</returns>
        public bool AddOrUpdate(KhachHangDTO kh, out string outMess)
        {
            outMess = string.Empty;

            if (string.IsNullOrEmpty(kh.SDT))
            {
                outMess = "Số điện thoại không được để trống!";
                return false;
            }

            // Kiểm tra số điện thoại đã tồn tại chưa
            KhachHangDTO existingCustomer = GetByPhone(kh.SDT);

            if (existingCustomer != null)
            {
                // Đã tồn tại, tiến hành cập nhật thông tin
                kh.MaKH = existingCustomer.MaKH;

                // Nếu không truyền tên, giữ nguyên tên cũ
                if (string.IsNullOrEmpty(kh.TenKH))
                {
                    kh.TenKH = existingCustomer.TenKH;
                }

                // Nếu không truyền địa chỉ, giữ nguyên địa chỉ cũ
                if (string.IsNullOrEmpty(kh.DiaChi))
                {
                    kh.DiaChi = existingCustomer.DiaChi;
                }

                bool result = Update(kh);
                if (result)
                {
                    outMess = "Cập nhật thông tin khách hàng thành công!";
                }
                else
                {
                    outMess = "Không thể cập nhật thông tin khách hàng!";
                }
                return result;
            }
            else
            {
                // Chưa tồn tại, tiến hành thêm mới
                if (string.IsNullOrEmpty(kh.MaKH))
                {
                    kh.MaKH = GenerateNewMaKH();
                }

                bool result = dal.InsertKhachHang(kh.MaKH, kh.TenKH, kh.SDT, kh.DiaChi, "");
                if (result)
                {
                    outMess = "Thêm khách hàng mới thành công!";
                }
                else
                {
                    outMess = "Không thể thêm khách hàng vào cơ sở dữ liệu!";
                }
                return result;
            }
        }

        // Cập nhật thông tin khách hàng
        public bool Update(KhachHangDTO kh)
        {
            return dal.UpdateKhachHang(kh.MaKH, kh.TenKH, kh.SDT, kh.DiaChi, kh.Email);
        }

        // Xoá khách hàng
        public bool Delete(string maKH)
        {
            return dal.DeleteKhachHang(maKH);
        }

        // Sinh mã khách hàng mới
        public string GenerateNewMaKH()
        {
            return dal.GenerateNewMaKH();
        }
    }
}