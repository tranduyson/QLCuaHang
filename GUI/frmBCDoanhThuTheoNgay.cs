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
using QLCuaHang.DTO;

namespace GUI
{
    public partial class frmBCDoanhThuTheoNgay : Form
    {
        private readonly BaoCaoDoanhThuBLL baoCaoDoanhThuBLL = new BaoCaoDoanhThuBLL();
        public frmBCDoanhThuTheoNgay()
        {
            InitializeComponent();

            dgDoanhThuTheoNgay.MultiSelect = false;
            dgDoanhThuTheoNgay.ReadOnly = true;

            DateTime today = DateTime.Today;
            // Ngày đầu tháng
            datTuNgay.Value = new DateTime(today.Year, today.Month, 1);
            // Ngày cuối tháng
            datDenNgay.Value = new DateTime(today.Year, today.Month, DateTime.DaysInMonth(today.Year, today.Month));

            datTuNgay.Format = DateTimePickerFormat.Custom;
            datTuNgay.CustomFormat = "dd/MM/yyyy";

            datDenNgay.Format = DateTimePickerFormat.Custom;
            datDenNgay.CustomFormat = "dd/MM/yyyy";
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

            var doanhThuTheoNgayDTOs = baoCaoDoanhThuBLL.LayDoanhThuTheoNgay(tungay, denngay);
            dgDoanhThuTheoNgay.DataSource = new BindingList<DoanhThuTheoNgayDTO>(doanhThuTheoNgayDTOs);

            dgDoanhThuTheoNgay.Columns["NgayDonHang"].HeaderText = "Ngày đơn hàng";
            dgDoanhThuTheoNgay.Columns["NgayDonHang"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgDoanhThuTheoNgay.Columns["DoanhThu"].HeaderText = "Doanh thu";
            dgDoanhThuTheoNgay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Format cột tiền
            if (dgDoanhThuTheoNgay.Columns["DoanhThu"] != null)
            {
                dgDoanhThuTheoNgay.Columns["DoanhThu"].DefaultCellStyle.Format = "N0"; // hàng nghìn
                dgDoanhThuTheoNgay.Columns["DoanhThu"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }


        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tungay = datTuNgay.Value.ToString("yyyy-MM-dd");
            string denngay = datDenNgay.Value.ToString("yyyy-MM-dd");

            dgDoanhThuTheoNgay.AutoGenerateColumns = false;

            var doanhThuTheoNgayDTOs = baoCaoDoanhThuBLL.LayDoanhThuTheoNgay(tungay, denngay);
            dgDoanhThuTheoNgay.DataSource = new BindingList<DoanhThuTheoNgayDTO>(doanhThuTheoNgayDTOs);

            // Định dạng cột DoanhThu
            if (dgDoanhThuTheoNgay.Columns["DoanhThu"] != null)
            {
                dgDoanhThuTheoNgay.Columns["DoanhThu"].DefaultCellStyle.Format = "N0"; // Phân cách hàng nghìn
                dgDoanhThuTheoNgay.Columns["DoanhThu"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }
    }
}
