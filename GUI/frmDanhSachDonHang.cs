using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCuaHang.BLL;
using QLCuaHang.DTO;

namespace GUI
{
    public partial class frmDanhSachDonHang : Form
    {
        NhanVienBLL nhanVienBLL = new NhanVienBLL();
        KhachHangBLL khachHangBLL = new KhachHangBLL();
        DonHangBLL donHangBLL = new DonHangBLL();

        public frmDanhSachDonHang()
        {
            InitializeComponent();

            comHoTen.DataSource = nhanVienBLL.GetAll();
            comHoTen.SelectedIndex = -1;
            comKhachHang.DataSource = khachHangBLL.GetAll();
            comKhachHang.SelectedIndex = -1;

            datTuNgay.Format = DateTimePickerFormat.Custom;
            datTuNgay.CustomFormat = "dd/MM/yyyy";

            datDenNgay.Format = DateTimePickerFormat.Custom;
            datDenNgay.CustomFormat = "dd/MM/yyyy";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var maNV = comHoTen.SelectedValue?.ToString();
            var maKH = comKhachHang.SelectedValue?.ToString();
            var maHD = txtMaHD.Text;
            var tuNgay = datTuNgay.Value;
            var denNgay = datDenNgay.Value;
            var donHangList = donHangBLL.SearchDonHang(maHD, tuNgay, denNgay, maNV, maKH);

            // First bind the data source
            dataGridViewDSDonHang.DataSource = new BindingList<DonHangDTO>(donHangList);

            // Then customize column names and properties
            dataGridViewDSDonHang.Columns["MaDH"].HeaderText = "Mã đơn hàng";
            dataGridViewDSDonHang.Columns["TenKH"].HeaderText = "Khách hàng";
            dataGridViewDSDonHang.Columns["TenNV"].HeaderText = "Nhân viên";
            dataGridViewDSDonHang.Columns["NgayDH"].HeaderText = "Ngày đơn hàng";
            dataGridViewDSDonHang.Columns["TongTien"].HeaderText = "Tổng tiền";

            // Optional: Hide any columns you don't want to display
            // dataGridViewDSDonHang.Columns["SomeColumnToHide"].Visible = false;

            dataGridViewDSDonHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
