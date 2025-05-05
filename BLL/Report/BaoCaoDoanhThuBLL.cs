//using System;
//using System.Data;
//using System.IO;
//using QLCuaHang.DAL;
//using FastReport;
//using FastReport.Utils;

//namespace QLCuaHang.BLL
//{
//    public class BaoCaoDoanhThuBLL
//    {
//        private BaoCaoDoanhThuDAL baoCaoDAL = new BaoCaoDoanhThuDAL();

//        public DataTable LayDoanhThuTheoNgay(DateTime? tuNgay = null, DateTime? denNgay = null)
//        {
//            return baoCaoDAL.LayDoanhThuTheoNgay(tuNgay, denNgay);
//        }



//        public void TaoBaoCaoDoanhThuTheoNgay(DateTime? tuNgay = null, DateTime? denNgay = null, bool hienThiXemTruoc = true)
//        {
//            DataTable dt = LayDoanhThuTheoNgay(tuNgay, denNgay);

//            //using (Report report = new Report())
//            //{
//            //    report.Load(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Reports", "BaoCaoDoanhThuTheoNgay.frx"));

//            //    report.RegisterData(dt, "DoanhThuData");

//            //    report.SetParameterValue("TuNgay", tuNgay?.ToString("dd/MM/yyyy") ?? "Tất cả");
//            //    report.SetParameterValue("DenNgay", denNgay?.ToString("dd/MM/yyyy") ?? "Tất cả");
//            //    report.SetParameterValue("NgayBaoCao", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));

//            //    report.Show();
//            //}
//        }
//    }
//}