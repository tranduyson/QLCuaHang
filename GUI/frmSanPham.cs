using System;
using System.Collections.Generic;
using System.Windows.Forms;
using QLCuaHang.BLL;
using QLCuaHang.DAL;
using QLCuaHang.DTO;

namespace GUI
{
    public partial class frmSanPham : Form
    {
        private readonly SanPhamBLL spBLL = new SanPhamBLL();

        public frmSanPham()
        {
            InitializeComponent();
            LoadSanPham();

            dataGridViewSanPham.MultiSelect = false;
            dataGridViewSanPham.ReadOnly = true;
        }

        private void LoadSanPham()
        {
            dataGridViewSanPham.DataSource = spBLL.GetAll();
        }

        private void ClearForm()
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            txtDonVi.Clear();
            numGiaBan.Value = 0;
            numGiaNhap.Value = 0;
            numTonKho.Value = 0;
            dataGridViewSanPham.ClearSelection();
        }

        private SanPhamDTO GetFormData(bool isNew = false)
        {
            var masp = txtMaSP.Text.Trim();
            //nếu là tạo mới thì mã sản phẩm là tự động 
            if (isNew)
            {
                masp = spBLL.GenerateNewMaSP();
            }
            return new SanPhamDTO
            {
                MaSP = masp,
                TenSP = txtTenSP.Text.Trim(),
                DonVi = txtDonVi.Text.Trim(),
                GiaBan = numGiaBan.Value,
                GiaNhap = numGiaNhap.Value,
                TonKho = (int)numTonKho.Value
            };
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenSP.Text))
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SanPhamDTO sp = GetFormData(true); // true = thêm mới -> sinh mã tự động

            bool result = spBLL.Add(sp);

            if (result)
            {
                MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSanPham();
                ClearForm();
            }
            else
            {
                MessageBox.Show("Thêm sản phẩm thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSP.Text))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SanPhamDTO sp = GetFormData();

            bool result = spBLL.Update(sp);
            if (result)
            {
                MessageBox.Show("Cập nhật sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSanPham();
                ClearForm();
            }
            else
            {
                MessageBox.Show("Cập nhật sản phẩm thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string maSP = txtMaSP.Text.Trim();

            if (string.IsNullOrEmpty(maSP))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                bool deleted = spBLL.Delete(maSP);

                if (deleted)
                {
                    MessageBox.Show("Xóa sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadSanPham();
                }
            }
        }


        private void dataGridViewSanPham_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewSanPham.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridViewSanPham.SelectedRows[0];

                txtMaSP.Text = row.Cells["MaSP"].Value?.ToString();
                txtTenSP.Text = row.Cells["TenSP"].Value?.ToString();
                txtDonVi.Text = row.Cells["DonVi"].Value?.ToString();

                if (row.Cells["GiaBan"].Value != DBNull.Value)
                    numGiaBan.Value = Convert.ToDecimal(row.Cells["GiaBan"].Value);

                if (row.Cells["GiaNhap"].Value != DBNull.Value)
                    numGiaNhap.Value = Convert.ToDecimal(row.Cells["GiaNhap"].Value);

                if (row.Cells["TonKho"].Value != DBNull.Value)
                    numTonKho.Value = Convert.ToDecimal(row.Cells["TonKho"].Value);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
            ClearForm();
            LoadSanPham();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();
            dataGridViewSanPham.DataSource = spBLL.SearchByName(keyword);
        }

        private void dataGridViewSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        public SanPhamDTO SanPhamDuocChon { get; set; }
    }
}
