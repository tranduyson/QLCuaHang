using System;
using System.Collections.Generic;
using System.Windows.Forms;
using QLCuaHang.BLL;
using QLCuaHang.DTO;

namespace GUI
{
    public partial class frmNhanVien : Form
    {
        private readonly NhanVienBLL nvBLL = new NhanVienBLL();
        private readonly ChucVuBLL cvBLL = new ChucVuBLL();

        public frmNhanVien()
        {
            InitializeComponent();
            LoadChucVu();
            LoadNhanVien();

            cbChucVu.DataSource = cvBLL.GetAll();
            cbChucVu.ValueMember = "MaCV";
            cbChucVu.DisplayMember = "TenCV";

            dataGridViewNhanVien.MultiSelect = false;
            dataGridViewNhanVien.ReadOnly = true;

            datNgaySinh.Format = DateTimePickerFormat.Custom;
            datNgaySinh.CustomFormat = "dd/MM/yyyy";
            datNgaySinh.CustomFormat = " ";
            datNgayVaoLam.Format = DateTimePickerFormat.Custom;
            datNgayVaoLam.CustomFormat = "dd/MM/yyyy";

            radNam.Checked = true;



        }

        private void LoadChucVu()
        {

        }

        private void LoadNhanVien()
        {
            dataGridViewNhanVien.DataSource = nvBLL.GetAll();
        }

        private void ClearForm()
        {

        }

        private NhanVienDTO GetFormData()
        {
            return new NhanVienDTO
            {
            };
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var nv = GetFormData();
            if (nvBLL.Add(nv))
            {
                MessageBox.Show("Thêm nhân viên thành công!");
                LoadNhanVien();
                ClearForm();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var nv = GetFormData();
            if (nvBLL.Update(nv))
            {
                MessageBox.Show("Cập nhật thành công!");
                LoadNhanVien();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();
            dataGridViewNhanVien.DataSource = nvBLL.SearchByName(keyword);
        }

        private void dataGridViewNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();
            dataGridViewNhanVien.DataSource = nvBLL.SearchByName(keyword);
        }

        private void materialTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void lblMaCV_Click(object sender, EventArgs e)
        {

        }

        private void lblDiaChi_Click(object sender, EventArgs e)
        {

        }

        private void datNgaySinh_ValueChanged(object sender, EventArgs e)
        {
            datNgaySinh.Format = DateTimePickerFormat.Short;
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLamMoi_Click_1(object sender, EventArgs e)
        {
            //bỏ chọn grid
            dataGridViewNhanVien.ClearSelection();
            //xóa dữ liệu tìm kiếm
            txtTimKiem.Text = "";

            ResetForm();
        }

        private void dataGridViewNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewNhanVien.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridViewNhanVien.SelectedRows[0];

                // Đổ dữ liệu từ dòng được chọn vào các control
                txtMaNV.Text = row.Cells["MaNV"].Value?.ToString();
                txtHoTen.Text = row.Cells["HoTen"].Value?.ToString();
                txtEmail.Text = row.Cells["Email"].Value?.ToString();
                richTextDiaChi.Text = row.Cells["DiaChi"].Value?.ToString();
                string gioiTinh = row.Cells["GioiTinh"].Value?.ToString();

                if (gioiTinh == "Nam")
                    radNam.Checked = true;
                else if (gioiTinh == "Nữ")
                    radNu.Checked = true;
                else
                    radKhac.Checked = true;


                txtSDT.Text = row.Cells["SDT"].Value?.ToString();

                // DateTimePicker
                if (row.Cells["NgaySinh"].Value != DBNull.Value)
                    datNgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);

                if (row.Cells["NgayVaoLam"].Value != DBNull.Value)
                    datNgayVaoLam.Value = Convert.ToDateTime(row.Cells["NgayVaoLam"].Value);

                // NumericUpDown
                if (row.Cells["LuongCoBan"].Value != DBNull.Value)
                    numLuong.Value = Convert.ToDecimal(row.Cells["LuongCoBan"].Value);

                // ComboBox chức vụ
                if (row.Cells["MaCV"].Value != DBNull.Value)
                    cbChucVu.SelectedValue = row.Cells["MaCV"].Value;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Lấy mã nhân viên từ textbox
            string maNV = txtMaNV.Text.Trim();

            if (string.IsNullOrEmpty(maNV))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Xác nhận trước khi xóa
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                bool isDeleted = nvBLL.Delete(maNV); // Gọi BLL xử lý

                if (isDeleted)
                {
                    MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadNhanVien(); // Refresh lại danh sách
                    ResetForm();    // Làm mới form nếu có
                }
                else
                {
                    MessageBox.Show("Không thể xóa nhân viên. Vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ResetForm()
        {
            txtMaNV.Clear();
            txtHoTen.Clear();
            txtEmail.Clear();
            txtSDT.Clear();
            richTextDiaChi.Clear();
            numLuong.Value = 0;
            datNgaySinh.Format = DateTimePickerFormat.Custom;
            datNgaySinh.CustomFormat = " ";
            datNgayVaoLam.Format = DateTimePickerFormat.Custom;
            datNgayVaoLam.CustomFormat = " ";
            cbChucVu.SelectedIndex = -1;
            radNam.Checked = true;
            radNu.Checked = false;
            radKhac.Checked = false;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNV.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Xử lý giới tính
            string gioiTinh = "";
            if (radNam.Checked)
                gioiTinh = "Nam";
            else if (radNu.Checked)
                gioiTinh = "Nữ";
            else if (radKhac.Checked)
                gioiTinh = "Khác";


            NhanVienDTO nv = new NhanVienDTO
            {
                MaNV = txtMaNV.Text.Trim(),
                HoTen = txtHoTen.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                DiaChi = richTextDiaChi.Text.Trim(),
                GioiTinh = gioiTinh,
                SDT = txtSDT.Text.Trim(),
                NgaySinh = datNgaySinh.Value,
                NgayVaoLam = datNgayVaoLam.Value,
                LuongCoBan = Convert.ToDecimal(numLuong.Value),
                MaCV = cbChucVu.SelectedValue?.ToString()
            };

            bool kq = nvBLL.Update(nv);
            if (kq)
            {
                MessageBox.Show("Cập nhật nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadNhanVien();
                ResetForm();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin Mã NV và Họ Tên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Xử lý giới tính
            string gioiTinh = "";
            if (radNam.Checked)
                gioiTinh = "Nam";
            else if (radNu.Checked)
                gioiTinh = "Nữ";
            else if (radKhac.Checked)
                gioiTinh = "Khác";

            NhanVienDTO nv = new NhanVienDTO
            {
                MaNV = nvBLL.GenerateNewMaNV(),//mã tự động
                HoTen = txtHoTen.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                GioiTinh = gioiTinh,
                SDT = txtSDT.Text.Trim(),
                DiaChi = richTextDiaChi.Text.Trim(),
                NgaySinh = datNgaySinh.Value,
                NgayVaoLam = datNgayVaoLam.Value,
                LuongCoBan = Convert.ToDecimal(numLuong.Value),
                MaCV = cbChucVu.SelectedValue?.ToString()
            };

            bool kq = nvBLL.Add(nv);
            if (kq)
            {
                MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadNhanVien();  // Refresh lại DataGridView
                ResetForm();     // Làm mới form
            }
            else
            {
                MessageBox.Show("Thêm nhân viên thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtGioiTinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void datNgayVaoLam_ValueChanged(object sender, EventArgs e)
        {
            datNgayVaoLam.Format = DateTimePickerFormat.Short;
        }

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Gọi hàm tìm kiếm ở đây
                LoadNhanVien();
            }
        }

        private void txtTimKiem_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Gọi hàm tìm kiếm ở đây
                LoadNhanVien();
            }
        }
    }
}
