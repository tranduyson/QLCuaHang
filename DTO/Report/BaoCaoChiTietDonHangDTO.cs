using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Report
{
    public class BaoCaoChiTietDonHangDTO
    {
        public string MaDH { get; set; }             // Mã đơn hàng
        public string MaSP { get; set; }             // Mã sản phẩm
        public string TenSP { get; set; }            // Tên sản phẩm
        public int SoLuong { get; set; }             // Số lượng
        public decimal DonGia { get; set; }          // Đơn giá
        public decimal ThanhTien { get; set; }       // Thành tiền
        public DateTime NgayDH { get; set; }         // Ngày đặt hàng
        public string TenKH { get; set; }            // Tên khách hàng
        public string SDTKhachHang { get; set; }     // Số điện thoại khách hàng
        public string TenNhanVien { get; set; }      // Tên nhân viên
    }


}
