using System;
using System.Windows.Forms;
using QLCuaHang.BLL;
using QLCuaHang.DTO;

namespace GUI
{
    public partial class frmDonHang : Form
    {
        private readonly DonHangBLL dhBLL = new DonHangBLL();
        private readonly ChiTietDonHangBLL chiTietDonHangBLL = new ChiTietDonHangBLL();
        private readonly NhanVienBLL nhanVienBLL = new NhanVienBLL();
        private readonly SanPhamBLL sanPhamBLL = new SanPhamBLL();
        private readonly KhachHangBLL khachHangBLL = new KhachHangBLL();
        private string maKhachHang = string.Empty; // Biến lưu mã khách hàng hiện tại

        public frmDonHang()
        {
            InitializeComponent();
            dataGridViewChiTietDonHang.MultiSelect = false;
            dataGridViewChiTietDonHang.ReadOnly = true;

            datNgayDH.Format = DateTimePickerFormat.Custom;
            datNgayDH.CustomFormat = "dd/MM/yyyy";

            //tạo cột
            dataGridViewChiTietDonHang.Columns.Add("MaSP", "Mã SP");
            dataGridViewChiTietDonHang.Columns.Add("TenSP", "Tên SP");
            dataGridViewChiTietDonHang.Columns.Add("DonVi", "Đơn vị tính");
            dataGridViewChiTietDonHang.Columns.Add("DonGia", "Đơn Giá");
            dataGridViewChiTietDonHang.Columns.Add("SoLuong", "Số Lượng");
            dataGridViewChiTietDonHang.Columns.Add("ThanhTien", "Thành Tiền");
            dataGridViewChiTietDonHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Gắn sự kiện KeyDown cho textbox số điện thoại
            txtSDT.KeyDown += TxtSDT_KeyDown;

            LayDuLieuMacDinhChoForm();
        }

        private void TxtSDT_KeyDown(object sender, KeyEventArgs e)
        {
            // Khi người dùng nhấn Enter sau khi nhập số điện thoại
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Ngăn tiếng "beep"
                e.Handled = true; // Đánh dấu sự kiện đã được xử lý

                // Tìm thông tin khách hàng theo số điện thoại
                TimKhachHangTheoSDT();
            }
        }

        // Tìm khách hàng theo số điện thoại và hiển thị thông tin
        private void TimKhachHangTheoSDT()
        {
            string sdt = txtSDT.Text.Trim();
            if (!string.IsNullOrEmpty(sdt))
            {
                KhachHangDTO kh = khachHangBLL.GetByPhone(sdt);
                if (kh != null)
                {
                    // Nếu tìm thấy khách hàng, hiển thị thông tin
                    txtTenKH.Text = kh.TenKH;
                    richTextDiaChi.Text = kh.DiaChi;
                    maKhachHang = kh.MaKH; // Lưu mã khách hàng
                }
                else
                {
                    // Nếu không tìm thấy, xóa các trường và đặt focus vào tên khách hàng
                    txtTenKH.Text = string.Empty;
                    richTextDiaChi.Text = string.Empty;
                    maKhachHang = string.Empty;
                    MessageBox.Show("Không tìm thấy khách hàng với số điện thoại này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTenKH.Focus();
                }
            }
        }

        private void LayDuLieuMacDinhChoForm()
        {
            comHoTen.DataSource = nhanVienBLL.GetAll();
            comHoTen.DisplayMember = "HoTen";
            comHoTen.ValueMember = "MaNV";
            comHoTen.SelectedIndex = -1;
            comHoTen.SelectedIndexChanged += ComHoTen_SelectedIndexChanged;

            comSanPham.DataSource = sanPhamBLL.GetAll();
            comSanPham.DisplayMember = "TenSP";
            comSanPham.ValueMember = "MaSP";
            comSanPham.SelectedIndex = -1;
            comSanPham.SelectedIndexChanged += ComSanPham_SelectedIndexChanged;
        }
        private void ComHoTen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comHoTen.SelectedIndex != -1 && comHoTen.SelectedValue != null)
            {
                // Hiển thị MaNV lên TextBox
                txtMaNV.Text = comHoTen.SelectedValue.ToString();
            }
            else
            {
                txtMaNV.Clear(); // Nếu chưa chọn thì xóa
            }
        }

        //tính toán thành tiền
        private void TinhThanhTien()
        {
            numThanhTien.Value = numDonGia.Value * numSoLuong.Value;
        }

        private void ComSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comSanPham.SelectedIndex != -1 && comSanPham.SelectedValue != null)
            {
                txtMaSP.Text = comSanPham.SelectedValue.ToString();
                //đổ giá bán theo sản phẩm
                var sanpham = sanPhamBLL.SearchSanPhamByMa(comSanPham.SelectedValue.ToString());

                numDonGia.Value = sanpham.GiaBan;
                txtDonVi.Text = sanpham.DonVi;
                numSoLuong.Value = 1;
                numThanhTien.Value = numDonGia.Value * numSoLuong.Value;
            }
            else
            {
                txtMaSP.Clear();
            }
        }

        private void frmDonHang_Load(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            datNgayDH.Value = DateTime.Now;
            txtMaNV.Clear();
            dataGridViewChiTietDonHang.ClearSelection();
            txtSDT.Clear();
            txtTenKH.Clear();
            richTextDiaChi.Clear();
            maKhachHang = string.Empty;
            dataGridViewChiTietDonHang.Rows.Clear();
            txtTongTien.Text = "0 đ";
            lblTongTienBangChu.Text = "Bằng chữ: Không đồng";
            txtMaDH.Clear();

            ClearSanPhamInputs();

            txtSDT.Focus();
        }

        private void ClearSanPhamInputs()
        {
            txtMaSP.Clear();
            comSanPham.SelectedIndex = -1; // hoặc comSanPham.Text = "";
            numDonGia.Value = 0;
            txtDonVi.Clear();
            numSoLuong.Value = 1; // hoặc 0 tùy logic của bạn
            numThanhTien.Value = 0;

            txtMaSP.Focus(); // đưa con trỏ về lại ô nhập đầu tiên
        }

        private DonHangDTO GetFormData(bool isNew = false)
        {
            string maDH = isNew ? dhBLL.GenerateNewMaDH() : txtMaDH.Text.Trim();

            if (string.IsNullOrEmpty(maDH))
            {
                MessageBox.Show("Không thể tạo mã đơn hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            try
            {
                return new DonHangDTO
                {
                    MaDH = maDH,
                    NgayDH = datNgayDH.Value,
                    MaNV = txtMaNV.Text.Trim(),
                    MaKH = maKhachHang // Thêm mã khách hàng vào đơn hàng
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi dữ liệu đơn hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Kiểm tra sản phẩm đã được chọn chưa
            if (string.IsNullOrWhiteSpace(txtMaSP.Text) || string.IsNullOrWhiteSpace(comSanPham.Text))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm trước khi thêm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra số lượng > 0
            if (numSoLuong.Value <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Nếu hợp lệ, thêm vào và clear form
            ThemChiTietDonHang();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSP.Text))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                SuaChiTietSanPham();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật đơn hàng:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string maDH = txtMaDH.Text.Trim();

            if (string.IsNullOrEmpty(maDH))
            {
                MessageBox.Show("Vui lòng chọn đơn hàng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("Bạn có chắc muốn xóa đơn hàng này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                bool deleted = dhBLL.Delete(maDH);
                if (deleted)
                {
                    MessageBox.Show("Xóa đơn hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Không thể xóa đơn hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void dataGridViewDonHang_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewDonHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtTenNhanVien_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void lblhoadon_Click(object sender, EventArgs e)
        {

        }

        private void lblSDT_Click(object sender, EventArgs e)
        {

        }

        private void comHoTen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblTongTien_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Tạo đơn hàng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTaoDonHang_Click(object sender, EventArgs e)
        {
            // Kiểm tra các điều kiện cần thiết
            if (string.IsNullOrEmpty(txtMaNV.Text.Trim()))
            {
                MessageBox.Show("Vui lòng chọn nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comHoTen.Focus();
                return;
            }

            // Kiểm tra số điện thoại khách hàng đã nhập chưa
            if (string.IsNullOrEmpty(txtSDT.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return;
            }

            // Kiểm tra tên khách hàng đã nhập chưa
            if (string.IsNullOrEmpty(txtTenKH.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenKH.Focus();
                return;
            }

            // Kiểm tra danh sách sản phẩm đã có sản phẩm chưa
            if (dataGridViewChiTietDonHang.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng thêm ít nhất một sản phẩm vào đơn hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Xử lý thông tin khách hàng trước khi tạo đơn hàng
                XuLyThongTinKhachHang();

                // Tạo đơn hàng mới
                DonHangDTO donHang = GetFormData(true);
                if (donHang != null)
                {
                    // Thêm đơn hàng vào cơ sở dữ liệu
                    bool result = dhBLL.Add(donHang, out string message);
                    if (result)
                    {
                        // Lưu lại mã đơn hàng mới tạo
                        txtMaDH.Text = donHang.MaDH;

                        // Thêm chi tiết đơn hàng
                        TaoChiTietDonHang(donHang.MaDH);

                        MessageBox.Show("Tạo đơn hàng thành công!\nMã đơn hàng: " + donHang.MaDH, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Hỏi người dùng có muốn tạo đơn hàng mới không
                        DialogResult dialogResult = MessageBox.Show("Bạn có muốn tạo đơn hàng mới?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes)
                        {
                            ClearForm();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không thể tạo đơn hàng. " + message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tạo đơn hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Phương thức xử lý thông tin khách hàng
        private void XuLyThongTinKhachHang()
        {
            string sdt = txtSDT.Text.Trim();
            string tenKH = txtTenKH.Text.Trim();
            string diaChi = richTextDiaChi.Text.Trim();

            // Tạo đối tượng khách hàng từ thông tin nhập
            KhachHangDTO kh = new KhachHangDTO(khachHangBLL.GenerateNewMaKH(), tenKH, sdt, diaChi, null);

            // Sử dụng phương thức AddOrUpdate để thêm mới hoặc cập nhật khách hàng
            if (khachHangBLL.AddOrUpdate(kh, out string outMess))
            {
                // Lấy mã khách hàng sau khi thêm/cập nhật
                KhachHangDTO khachHang = khachHangBLL.GetByPhone(sdt);
                if (khachHang != null)
                {
                    maKhachHang = khachHang.MaKH;
                }
                else
                {
                    throw new Exception("Không thể lấy thông tin khách hàng sau khi thêm/cập nhật.");
                }
            }
            else
            {
                throw new Exception("Không thể xử lý thông tin khách hàng: " + outMess);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void numSoLuong_ValueChanged(object sender, EventArgs e)
        {
            TinhThanhTien();
        }

        private void numDonGia_ValueChanged(object sender, EventArgs e)
        {
            TinhThanhTien();
        }

        /// <summary>
        /// thêm sản phẩm
        /// </summary>
        private void ThemChiTietDonHang()
        {
            // Lấy dữ liệu từ các control
            string maSP = txtMaSP.Text.Trim();
            string tenSP = comSanPham.Text.Trim(); // giả sử tên sản phẩm lấy từ ComboBox
            decimal donGia = numDonGia.Value;
            string donVi = txtDonVi.Text;
            int soLuong = (int)numSoLuong.Value;
            decimal thanhTien = donGia * soLuong;

            // Thêm vào DataGridView
            dataGridViewChiTietDonHang.Rows.Add(maSP, tenSP, donVi, donGia, soLuong, thanhTien);

            comSanPham.Focus();

            ClearSanPhamInputs();
            // Cập nhật tổng tiền
            CapNhatTongTien();
        }

        private void TaoChiTietDonHang(string maDH)
        {
            // Duyệt qua các dòng trong DataGridView và thêm vào CSDL
            foreach (DataGridViewRow row in dataGridViewChiTietDonHang.Rows)
            {
                if (row.Cells["MaSP"].Value != null)
                {
                    string maSP = row.Cells["MaSP"].Value.ToString();
                    int soLuong = Convert.ToInt32(row.Cells["SoLuong"].Value);
                    decimal donGia = Convert.ToDecimal(row.Cells["DonGia"].Value);

                    // Gọi hàm thêm chi tiết đơn hàng (cần bổ sung vào DonHangBLL)
                    chiTietDonHangBLL.InsertChiTietDonHang(maDH, maSP, soLuong, donGia);
                }
            }
        }

        private void SuaChiTietSanPham()
        {
            if (dataGridViewChiTietDonHang.CurrentRow != null)
            {
                DataGridViewRow row = dataGridViewChiTietDonHang.CurrentRow;

                row.Cells["MaSP"].Value = txtMaSP.Text.Trim();
                row.Cells["TenSP"].Value = comSanPham.Text.Trim();
                row.Cells["DonGia"].Value = numDonGia.Value;
                row.Cells["DonVi"].Value = txtDonVi.Text;
                row.Cells["SoLuong"].Value = numSoLuong.Value;
                row.Cells["ThanhTien"].Value = numDonGia.Value * numSoLuong.Value;

                CapNhatTongTien();
                ClearSanPhamInputs();
            }
        }

        private void dataGridViewChiTietDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridViewChiTietDonHang.Rows[e.RowIndex].Cells["MaSP"].Value != null)
            {
                DataGridViewRow row = dataGridViewChiTietDonHang.Rows[e.RowIndex];

                txtMaSP.Text = row.Cells["MaSP"].Value.ToString();
                txtDonVi.Text = row.Cells["DonVi"].Value.ToString();
                comSanPham.Text = row.Cells["TenSP"].Value.ToString();
                numDonGia.Value = Convert.ToDecimal(row.Cells["DonGia"].Value);
                numSoLuong.Value = Convert.ToInt32(row.Cells["SoLuong"].Value);
                numThanhTien.Value = Convert.ToDecimal(row.Cells["ThanhTien"].Value);

                // Hiển thị nút sửa và xóa (giả sử bạn có 2 nút này)
                btnUpdate.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void XoaChiTietSanPham()
        {
            if (dataGridViewChiTietDonHang.CurrentRow != null)
            {
                dataGridViewChiTietDonHang.Rows.Remove(dataGridViewChiTietDonHang.CurrentRow);
                CapNhatTongTien();
                ClearSanPhamInputs();
            }
        }

        /// <summary>
        /// Hàm tính tổng tiền
        /// </summary>
        private void CapNhatTongTien()
        {
            decimal tongTien = 0;

            foreach (DataGridViewRow row in dataGridViewChiTietDonHang.Rows)
            {
                if (row.Cells["ThanhTien"].Value != null)
                {
                    tongTien += Convert.ToDecimal(row.Cells["ThanhTien"].Value);
                }
            }

            txtTongTien.Text = tongTien.ToString("N0") + " đ";  // hiển thị: 1,234,567 đ

            lblTongTienBangChu.Text = "Bằng chữ: " + SoTienBangChu(tongTien); // nếu có hàm chuyển số sang chữ
        }

        public string SoTienBangChu(decimal soTien)
        {
            string[] dv = { "", "nghìn", "triệu", "tỷ" };
            string[] chuSo = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };

            string s = ((long)soTien).ToString();
            string ketQua = "";
            int i, j, donVi, chuc, tram;

            int len = s.Length;
            int soGroup = 0;

            while (len > 0)
            {
                int groupLen = len >= 3 ? 3 : len;
                int groupStart = len - groupLen;
                string group = s.Substring(groupStart, groupLen);

                len -= groupLen;

                if (int.TryParse(group, out int n) && n > 0)
                {
                    int so = int.Parse(group);
                    tram = so / 100;
                    chuc = (so % 100) / 10;
                    donVi = so % 10;

                    string chu = "";

                    if (tram > 0)
                    {
                        chu += chuSo[tram] + " trăm";
                        if (chuc == 0 && donVi > 0)
                            chu += " linh";
                    }

                    if (chuc > 0)
                    {
                        if (chuc == 1)
                            chu += " mười";
                        else
                            chu += " " + chuSo[chuc] + " mươi";

                        if (donVi == 1)
                            chu += " mốt";
                        else if (donVi == 5)
                            chu += " lăm";
                        else if (donVi > 0)
                            chu += " " + chuSo[donVi];
                    }
                    else if (donVi > 0)
                    {
                        chu += " " + chuSo[donVi];
                    }

                    chu = chu.Trim() + " " + dv[soGroup];
                    ketQua = chu + " " + ketQua;
                }

                soGroup++;
            }

            ketQua = ketQua.Trim();
            if (ketQua == "")
                ketQua = "không đồng";
            else
                ketQua += " đồng";

            // Viết hoa chữ cái đầu
            return char.ToUpper(ketQua[0]) + ketQua.Substring(1);
        }

        private void lblTongTienBangChu_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            XoaChiTietSanPham();
        }


        private void txtTongTien_Click(object sender, EventArgs e)
        {

        }

        private void frmDonHang_Load_1(object sender, EventArgs e)
        {

        }

        private void comSanPham_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}