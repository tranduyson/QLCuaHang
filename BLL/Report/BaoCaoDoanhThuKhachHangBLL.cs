//using System;
//using System.Data;
//using System.IO;
//using FastReport;
//using QLCuaHang.DAL;

//namespace QLCuaHang.BLL
//{
//    public class BaoCaoDoanhThuKhachHangBLL
//    {
//        private BaoCaoDoanhThuKhachHangDAL baoCaoDAL = new BaoCaoDoanhThuKhachHangDAL();

//        public DataTable LayDoanhThuTheoKhachHang(DateTime? tuNgay = null, DateTime? denNgay = null)
//        {
//            return baoCaoDAL.LayDoanhThuTheoKhachHang(tuNgay, denNgay);
//        }

//        public void TaoBaoCaoDoanhThuTheoKhachHang(DateTime? tuNgay = null, DateTime? denNgay = null, bool hienThiXemTruoc = true)
//        {
//            DataTable dt = LayDoanhThuTheoKhachHang(tuNgay, denNgay);

//            //using (Report report = new Report())
//            //{
//            //    // Tải template báo cáo
//            //    report.Load(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Reports", "BaoCaoDoanhThuKhachHang.frx"));

//            //    // Đăng ký nguồn dữ liệu
//            //    report.RegisterData(dt, "DoanhThuKhachHangData");

//            //    // Đặt các tham số báo cáo
//            //    report.SetParameterValue("TuNgay", tuNgay?.ToString("dd/MM/yyyy") ?? "Tất cả");
//            //    report.SetParameterValue("DenNgay", denNgay?.ToString("dd/MM/yyyy") ?? "Tất cả");
//            //    report.SetParameterValue("NgayBaoCao", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));

//            //    // Hiển thị xem trước hoặc in/xuất trực tiếp

//            //}
//        }
//    }
//}