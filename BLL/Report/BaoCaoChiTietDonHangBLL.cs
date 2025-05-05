//using System;
//using System.Data;
//using System.IO;
//using FastReport;
//using QLCuaHang.DAL;

//namespace QLCuaHang.BLL
//{
//    public class BaoCaoChiTietDonHangBLL
//    {
//        private BaoCaoChiTietDonHangDAL baoCaoDAL = new BaoCaoChiTietDonHangDAL();

//        public DataTable LayChiTietDonHang(string maDonHang = null)
//        {
//            return baoCaoDAL.LayChiTietDonHang(maDonHang);
//        }

//        public void TaoBaoCaoChiTietDonHang(string maDonHang = null, bool hienThiXemTruoc = true)
//        {
//            DataTable dt = LayChiTietDonHang(maDonHang);

//            //using (Report report = new Report())
//            //{
//            //    // Tải template báo cáo
//            //    report.Load(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Reports", "BaoCaoChiTietDonHang.frx"));

//            //    // Đăng ký nguồn dữ liệu
//            //    report.RegisterData(dt, "ChiTietDonHangData");

//            //    // Đặt các tham số báo cáo
//            //    report.SetParameterValue("MaDonHang", maDonHang ?? "Tất cả đơn hàng");
//            //    report.SetParameterValue("NgayBaoCao", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));

//            //    // Hiển thị xem trước hoặc in/xuất trực tiếp
//            //    if (hienThiXemTruoc)
//            //    {
//            //        //report.Show();
//            //    }
//            //    else
//            //        report.Prepare();
//            //}
//        }
//    }
//}