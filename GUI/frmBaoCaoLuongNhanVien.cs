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

namespace GUI
{
    public partial class frmBaoCaoLuongNhanVien : Form
    {
        private BaoCaoLuongNhanVienBLL luongBLL = new BaoCaoLuongNhanVienBLL();

        public frmBaoCaoLuongNhanVien()
        {
            InitializeComponent();
        }

        private void frmBaoCaoLuongNhanVien_Load(object sender, EventArgs e)
        {
            dgLuongNhanVien.ReadOnly = true;
            dgLuongNhanVien.MultiSelect = false;
            dgLuongNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            LoadComboBoxNhanVien();
            LoadDuLieuLuong(); // Hiển thị tất cả lúc đầu
        }

        private void LoadComboBoxNhanVien()
        {
            var danhSach = luongBLL.LayLuongNhanVien();
            comTenNV.DataSource = danhSach;
            comTenNV.DisplayMember = "HoTen";
            comTenNV.ValueMember = "MaNV";
            comTenNV.SelectedIndex = -1;
        }

        private void LoadDuLieuLuong(string tenNhanVien = null)
        {
            var danhSach = luongBLL.LayLuongNhanVien(tenNhanVien);
            dgLuongNhanVien.AutoGenerateColumns = true;
            dgLuongNhanVien.DataSource = danhSach;

  

            if (dgLuongNhanVien.Columns["LuongCoBan"] != null)
                dgLuongNhanVien.Columns["LuongCoBan"].DefaultCellStyle.Format = "N0";

            if (dgLuongNhanVien.Columns["TongLuong"] != null)
                dgLuongNhanVien.Columns["TongLuong"].DefaultCellStyle.Format = "N0";
        }


        private void btnXem_Click(object sender, EventArgs e)
        {
            string tenNV = comTenNV.Text.Trim();
            LoadDuLieuLuong(string.IsNullOrEmpty(tenNV) ? null : tenNV);
        }
    }
}
