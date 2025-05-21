using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO.Report;
using QLCuaHang.BLL;
using QLCuaHang.DAL;

namespace GUI
{
    public partial class frmBaoCaoDoanhThuKhachHang : Form
    {
        private readonly BaoCaoDoanhThuKhachHangBLL baoCaoDoanhThuKhachHangBLL = new BaoCaoDoanhThuKhachHangBLL();

        public frmBaoCaoDoanhThuKhachHang()
        {
            InitializeComponent();

            dgBaoCaoDoanhThuKhachHang.ReadOnly = true;
            dgBaoCaoDoanhThuKhachHang.MultiSelect = false;

            DateTime today = DateTime.Today;
            // Ngày đầu tháng
            datTuNgay.Value = new DateTime(today.Year, today.Month, 1);
            // Ngày cuối tháng
            datDenNgay.Value = new DateTime(today.Year, today.Month, DateTime.DaysInMonth(today.Year, today.Month));

            datTuNgay.Format = DateTimePickerFormat.Custom;
            datTuNgay.CustomFormat = "dd/MM/yyyy";

            datDenNgay.Format = DateTimePickerFormat.Custom;
            datDenNgay.CustomFormat = "dd/MM/yyyy";
        }

        private void frmBaoCaoDoanhThuKhachHang_Load(object sender, EventArgs e)
        {
            // Có thể load mặc định tất cả đơn hàng nếu cần
            LayDuLieuMacDinhChoForm();
        }
        private void LayDuLieuMacDinhChoForm()
        {
            DateTime today = DateTime.Today;

            // Ngày đầu tháng
            datTuNgay.Value = new DateTime(today.Year, today.Month, 1);

            // Ngày cuối tháng
            datDenNgay.Value = new DateTime(today.Year, today.Month, DateTime.DaysInMonth(today.Year, today.Month));
            string tungay = datTuNgay.Value.ToString("yyyy-MM-dd");
            string denngay = datDenNgay.Value.ToString("yyyy-MM-dd");

            var baoCaoDoanhThuKhachHangDto = baoCaoDoanhThuKhachHangBLL.LayDoanhThuTheoKhachHang(tungay, denngay);
            dgBaoCaoDoanhThuKhachHang.DataSource = new BindingList<DoanhThuKhachHangDTO>(baoCaoDoanhThuKhachHangDto);

            dgBaoCaoDoanhThuKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tungay = datTuNgay.Value.ToString("yyyy-MM-dd");
            string denngay = datDenNgay.Value.ToString("yyyy-MM-dd");

            dgBaoCaoDoanhThuKhachHang.AutoGenerateColumns = false;

            var baoCaoDoanhThuKhachHangDto = baoCaoDoanhThuKhachHangBLL.LayDoanhThuTheoKhachHang(tungay, denngay);
            dgBaoCaoDoanhThuKhachHang.DataSource = new BindingList<DoanhThuKhachHangDTO>(baoCaoDoanhThuKhachHangDto);
        }
    }
}
