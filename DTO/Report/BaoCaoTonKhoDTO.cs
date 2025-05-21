using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Report
{
    public class BaoCaoTonKhoDTO
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string DonVi { get; set; }
        public decimal GiaBan { get; set; }
        public decimal GiaNhap { get; set; }
        public int TonKho { get; set; }
        public decimal GiaTriTonKho { get; set; }
        public string TrangThai { get; set; }
    }

}
