using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Report
{
        public class SanPhamBanChayDTO
        {
            public string MaSP { get; set; }
            public string TenSP { get; set; }
            public string DonVi { get; set; }
            public int TongSoLuong { get; set; }
            public decimal TongDoanhThu { get; set; }
            public decimal GiaBan { get; set; }
            public int TonKho { get; set; }
        }

    }
