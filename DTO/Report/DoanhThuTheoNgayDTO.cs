using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Report
{
    public class DoanhThuTheoNgayDTO
    {
        public DateTime NgayDonHang { get; set; }
        public decimal DoanhThu { get; set; }

        public DoanhThuTheoNgayDTO(DateTime ngayDonHang, decimal doanhThu)
        {
            NgayDonHang = ngayDonHang;
            DoanhThu = doanhThu;
        }
    }

}
