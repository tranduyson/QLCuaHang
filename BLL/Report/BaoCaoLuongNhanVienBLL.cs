//using System;
//using System.Data;
//using System.IO;
//using FastReport;
//using QLCuaHang.DAL;

//namespace QLCuaHang.BLL
//{
//    public class BaoCaoLuongNhanVienBLL
//    {
//        private BaoCaoLuongNhanVienDAL baoCaoDAL = new BaoCaoLuongNhanVienDAL();

//        public DataTable LayLuongNhanVien()
//        {
//            return baoCaoDAL.LayLuongNhanVien();
//        }

//        public void TaoBaoCaoLuongNhanVien(bool hienThiXemTruoc = true)
//        {
//            DataTable dt = LayLuongNhanVien();

//            //using (Report report = new Report())
//            //{
//            //    // Tải template báo cáo
//            //    report.Load(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Reports", "BaoCaoLuongNhanVien.frx"));

//            //    // Đăng ký nguồn dữ liệu
//            //    report.RegisterData(dt, "LuongNhanVienData");

//            //    // Đặt các tham số báo cáo
//            //    report.SetParameterValue("ThangBaoCao", DateTime.Now.ToString("MM/yyyy"));
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