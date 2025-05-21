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

namespace GUI
{
    public partial class frmBaoCaoTonKho : Form
    {
        private readonly BaoCaoTonKhoBLL _baoCaoTonKhoBLL = new BaoCaoTonKhoBLL();
        public frmBaoCaoTonKho()
        {
            InitializeComponent();
        }
        private void frmBaoCaoTonKho_Load(object sender, EventArgs e)
        {
            dgTonKho.ReadOnly = true;
            dgTonKho.MultiSelect = false;
            dgTonKho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            LoadDuLieuTonKho();
        }


        private void LoadDuLieuTonKho(string tenSanPham = null)
        {
            List<BaoCaoTonKhoDTO> danhSach = _baoCaoTonKhoBLL.LayTonKho(tenSanPham);
            dgTonKho.DataSource = danhSach;

            // Định dạng tiền tệ cho cột giá
            if (dgTonKho.Columns["GiaNhap"] != null)
                dgTonKho.Columns["GiaNhap"].DefaultCellStyle.Format = "N0";
            if (dgTonKho.Columns["GiaBan"] != null)
                dgTonKho.Columns["GiaBan"].DefaultCellStyle.Format = "N0";
            if (dgTonKho.Columns["GiaTriTonKho"] != null)
                dgTonKho.Columns["GiaTriTonKho"].DefaultCellStyle.Format = "N0";
        }
        private void LoadComboBoxSanPham()
        {
            var danhSach = _baoCaoTonKhoBLL.LayTonKho(); // lấy toàn bộ sản phẩm

            comSanPham.DataSource = danhSach;
            comSanPham.DisplayMember = "TenSP";  // Tên hiển thị
            comSanPham.ValueMember = "MaSP";     // Giá trị thực sự
            comSanPham.SelectedIndex = -1;       // Không chọn gì ban đầu
        }


        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tenSanPham = comSanPham.Text.Trim();
            LoadDuLieuTonKho(tenSanPham);
        }

    }
}
