//using System;
//using System.Data;
//using System.IO;
//using FastReport;
//using QLCuaHang.DAL;

//namespace QLCuaHang.BLL
//{
//    public class BaoCaoTonKhoBLL
//    {
//        private BaoCaoTonKhoDAL baoCaoDAL = new BaoCaoTonKhoDAL();

//        public DataTable LayTonKho()
//        {
//            return baoCaoDAL.LayTonKho();
//        }

//        public void TaoBaoCaoTonKho(bool hienThiXemTruoc = true)
//        {
//            DataTable dt = LayTonKho();

//            //using (Report report = new Report())
//            //{
//            //    // Tải template báo cáo
//            //    report.Load(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Reports", "BaoCaoTonKho.frx"));

//            //    // Đăng ký nguồn dữ liệu
//            //    report.RegisterData(dt, "TonKhoData");

//            //    // Đặt các tham số báo cáo
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