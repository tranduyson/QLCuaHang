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
                string query = "SELECT COUNT(*) FROM KhachHang WHERE SDT = @SDT";
                int count = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query, new object[] { kh.SDT }));

                if (count > 0)
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
