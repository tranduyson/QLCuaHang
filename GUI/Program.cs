using DashboardWinForm;
using QLCuaHang.BLL;
using QLCuaHang.DTO;

namespace GUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string maNV = Properties.Settings.Default.LoggedInMaNV;
            if (!string.IsNullOrEmpty(maNV))
            {
                NhanVienDTO nv = new NhanVienBLL().GetByMaNV(maNV);
                Application.Run(new frmDashboard(nv));
            }
            else
            {
                Application.Run(new frmDangNhap());
            }
        }

    }
}