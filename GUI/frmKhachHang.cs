using System;
using System.Collections.Generic;
using System.Windows.Forms;
using QLCuaHang.BLL;
using QLCuaHang.DTO;

namespace GUI
{
    public partial class frmKhachHang : Form
    {
        private readonly KhachHangBLL khBLL = new KhachHangBLL();

        public frmKhachHang()
        {
            InitializeComponent();
            LoadKhachHang();

            dataGridViewKhachHang.MultiSelect = false;
            dataGridViewKhachHang.ReadOnly = true;
        }

        private void LoadKhachHang()
        {
            dataGridViewKhachHang.DataSource = khBLL.GetAll();
        }

        private void ClearForm()
        {
            txtMaKH.Clear();
            txtTenKH.Clear();
            txtSDT.Clear();
            richTextDiaChi.Clear();
            txtEmail.Clear();
            dataGridViewKhachHang.ClearSelection();
        }

        private KhachHangDTO GetFormData()
        {
            return new KhachHangDTO(
                txtMaKH.Text.Trim(),
                txtTenKH.Text.Trim(),
                txtSDT.Text.Trim(),
                richTextDiaChi.Text.Trim(),
                txtEmail.Text.Trim()
            );
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenKH.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra số điện thoại hợp lệ
            if (!string.IsNullOrWhiteSpace(txtSDT.Text) && !IsValidPhoneNumber(txtSDT.Text.Trim()))
            {
                MessageBox.Show("Số điện thoại không hợp lệ. Vui lòng kiểm tra lại.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            KhachHangDTO kh = new KhachHangDTO(
                    khBLL.GenerateNewMaKH(),
                    txtTenKH.Text.Trim(),
                    txtSDT.Text.Trim(),
                    richTextDiaChi.Text.Trim(),
                    txtEmail.Text.Trim()
            );

            string errorMessage;
            bool kq = khBLL.Add(kh, out errorMessage);

            if (kq)
            {
                MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadKhachHang();
                ClearForm();
            }
            else
            {
                if (!string.IsNullOrEmpty(errorMessage))
                {
                    MessageBox.Show(errorMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Thêm khách hàng thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaKH.Text))
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            KhachHangDTO kh = new KhachHangDTO
            (
                txtMaKH.Text.Trim(),
                txtTenKH.Text.Trim(),
                txtSDT.Text.Trim(),
                richTextDiaChi.Text.Trim(),
                txtEmail.Text.Trim()
            );

            bool kq = khBLL.Update(kh);
            if (kq)
            {
                MessageBox.Show("Cập nhật khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadKhachHang();
                ClearForm();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string maKH = txtMaKH.Text.Trim();

            if (string.IsNullOrEmpty(maKH))
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                bool isDeleted = khBLL.Delete(maKH);

                if (isDeleted)
                {
                    MessageBox.Show("Xóa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadKhachHang();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Không thể xóa khách hàng. Có thể khách hàng này có liên quan đến đơn hàng!",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
            ClearForm();
            LoadKhachHang();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();
            dataGridViewKhachHang.DataSource = khBLL.SearchByName(keyword);
        }

        private void dataGridViewKhachHang_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewKhachHang.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridViewKhachHang.SelectedRows[0];

                txtMaKH.Text = row.Cells["MaKH"].Value?.ToString();
                txtTenKH.Text = row.Cells["TenKH"].Value?.ToString();
                txtSDT.Text = row.Cells["SDT"].Value?.ToString();
                richTextDiaChi.Text = row.Cells["DiaChi"].Value?.ToString();
                txtEmail.Text = row.Cells["Email"].Value?.ToString();
            }
        }

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimKiem_Click(sender, e);
            }
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            LoadKhachHang();
        }

        // Hàm kiểm tra số điện thoại hợp lệ
        private bool IsValidPhoneNumber(string phoneNumber)
        {
            // Kiểm tra số điện thoại là 10-11 chữ số
            if (string.IsNullOrEmpty(phoneNumber))
                return true; // Cho phép để trống

            // Kiểm tra là số và có độ dài hợp lệ
            return System.Text.RegularExpressions.Regex.IsMatch(phoneNumber, @"^\d{9,11}$");
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {

        }
    }
}