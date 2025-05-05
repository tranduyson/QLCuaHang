//using System;
//using System.Data;
//using System.IO;
//using FastReport;
//using QLCuaHang.DAL;

//namespace QLCuaHang.BLL
//{
//    public class BaoCaoSanPhamBanChayBLL
//    {
//        private BaoCaoSanPhamBanChayDAL baoCaoDAL = new BaoCaoSanPhamBanChayDAL();

//        public DataTable LaySanPhamBanChay(DateTime? tuNgay = null, DateTime? denNgay = null, int soLuongHienThi = 20)
//        {
//            return baoCaoDAL.LaySanPhamBanChay(tuNgay, denNgay, soLuongHienThi);
//        }

//        public void TaoBaoCaoSanPhamBanChay(DateTime? tuNgay = null, DateTime? denNgay = null, int soLuongHienThi = 20, bool hienThiXemTruoc = true)
//        {
//            DataTable dt = LaySanPhamBanChay(tuNgay, denNgay, soLuongHienThi);

//            //using (Report report = new Report())
//            //{
//            //    // Tải template báo cáo
//            //    report.Load(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Reports", "BaoCaoSanPhamBanChay.frx"));

//            //    // Đăng ký nguồn dữ liệu
//            //    report.RegisterData(dt, "SanPhamBanChayData");

//            //    // Đặt các tham số báo cáo
//            //    report.SetParameterValue("TuNgay", tuNgay?.ToString("dd/MM/yyyy") ?? "Tất cả");
//            //    report.SetParameterValue("DenNgay", denNgay?.ToString("dd/MM/yyyy") ?? "Tất cả");
//            //    report.SetParameterValue("SoLuongHienThi", soLuongHienThi);
//            //    report.SetParameterValue("NgayBaoCao", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));

//            //    // Hiển thị xem trước hoặc in/xuất trực tiếp
//            //    if (hienThiXemTruoc)
//            //    {
//            //        report.Show();
//            //    }
//            //    else
//            //        report.Prepare();
//            //}
//        }
//    }
//}