using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public static class Utils
    {
        public static string FormatTien(decimal soTien)
        {
            return string.Format("{0:N0}", soTien); // Phân cách hàng nghìn, không có chữ số thập phân
        }

        public static string FormatTien(object soTien)
        {
            if (decimal.TryParse(soTien.ToString(), out decimal value))
            {
                return FormatTien(value);
            }
            return "0";
        }
    }

}
