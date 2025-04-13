using System;
using System.Collections.Generic;
using System.Windows.Forms;
using QLCuaHang.BLL;
using QLCuaHang.DTO;

namespace GUI
{
    public partial class frmChucVu : Form
    {
        private readonly ChucVuBLL cvBLL = new ChucVuBLL();

        public frmChucVu()
        {
            InitializeComponent();
            LoadChucVu();

            dataGridViewChucVu.MultiSelect = false;
            dataGridViewChucVu.ReadOnly = true;
        }

        private void LoadChucVu()
        {
            var chucvus = cvBLL.GetAll();
            dataGridViewChucVu.DataSource = cvBLL.GetAll();
        }

        private void ClearForm()
        {
            txtMaCV.Clear();
            txtTenCV.Clear();
            numHeSoLuong.Value = 0;
            dataGridViewChucVu.ClearSelection();
        }

        private ChucVuDTO GetFormData()
        {
            return new ChucVuDTO
            {
                MaCV = txtMaCV.Text.Trim(),
                TenCV = txtTenCV.Text.Trim(),
                HeSoLuong = (float)numHeSoLuong.Value
            };
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenCV.Text))
            {
                MessageBox.Show("Vui lòng nhập tên chức vụ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ChucVuDTO cv = new ChucVuDTO
            {
                MaCV = cvBLL.GenerateNewMaCV(), // Mã tự động
                TenCV = txtTenCV.Text.Trim(),
                HeSoLuong = (float)numHeSoLuong.Value
            };

            bool kq = cvBLL.Add(cv);
            if (kq)
            {
                MessageBox.Show("Thêm chức vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadChucVu();
                ClearForm();
            }
            else
            {
                MessageBox.Show("Thêm chức vụ thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaCV.Text))
            {
                MessageBox.Show("Vui lòng chọn chức vụ cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ChucVuDTO cv = new ChucVuDTO
            {
                MaCV = txtMaCV.Text.Trim(),
                TenCV = txtTenCV.Text.Trim(),
                HeSoLuong = (float)numHeSoLuong.Value
            };

            bool kq = cvBLL.Update(cv);
            if (kq)
            {
                MessageBox.Show("Cập nhật chức vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadChucVu();
                ClearForm();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string maCV = txtMaCV.Text.Trim();

            if (string.IsNullOrEmpty(maCV))
            {
                MessageBox.Show("Vui lòng chọn chức vụ cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa chức vụ này?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                bool isDeleted = cvBLL.Delete(maCV);

                if (isDeleted)
                {
                    MessageBox.Show("Xóa chức vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadChucVu();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Không thể xóa chức vụ. Có thể chức vụ này đang được sử dụng bởi nhân viên!",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            
            txtTimKiem.Text = "";
            ClearForm();
            LoadChucVu();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();
            dataGridViewChucVu.DataSource = cvBLL.SearchByName(keyword);
        }

        private void dataGridViewChucVu_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewChucVu.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridViewChucVu.SelectedRows[0];

                txtMaCV.Text = row.Cells["MaCV"].Value?.ToString();
                txtTenCV.Text = row.Cells["TenCV"].Value?.ToString();

                if (row.Cells["HeSoLuong"].Value != DBNull.Value)
                    numHeSoLuong.Value = Convert.ToDecimal(row.Cells["HeSoLuong"].Value);
            }
        }

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimKiem_Click(sender, e);
            }
        }

        private void frmChucVu_Load(object sender, EventArgs e)
        {
            LoadChucVu();
        }

        private void frmChucVu_Load_1(object sender, EventArgs e)
        {

        }

        private void dataGridViewChucVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}