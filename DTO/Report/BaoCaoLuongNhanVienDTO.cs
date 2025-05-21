using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Report
{
    public class BaoCaoLuongNhanVienDTO
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }

        public string MaCV { get; set; }
        public string TenCV { get; set; }
        public decimal HeSoLuong { get; set; }
        public decimal LuongCoBan { get; set; }
        public decimal TongLuong { get; set; }

        public DateTime NgayVaoLam { get; set; }
        public int SoThangLamViec { get; set; }
    }

}
