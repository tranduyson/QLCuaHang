using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using DTO.Report;
using QLCuaHang.BLL;
using QLCuaHang.DTO;

namespace GUI
{
    public partial class frmChiTietDonHangTheoMaDH : Form
    {
        private readonly BaoCaoChiTietDonHangBLL baoCaoBLL = new BaoCaoChiTietDonHangBLL();


        public frmChiTietDonHangTheoMaDH()
        {
            InitializeComponent();

            dgChiTietDonHang.ReadOnly = true;
            dgChiTietDonHang.MultiSelect = false;

            // Gán lại HeaderText và định dạng cho các cột đã tạo sẵn trong Designer 
            dgChiTietDonHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }


        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string maDH = txtMaDH.Text.Trim();


            var chiTietDonHangDTOs = baoCaoBLL.LayChiTietDonHang(maDH);
            dgChiTietDonHang.AutoGenerateColumns = false;

            dgChiTietDonHang.DataSource = new BindingList<BaoCaoChiTietDonHangDTO>(chiTietDonHangDTOs);
            dgChiTietDonHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            // Định dạng số tiền nếu có cột DonGia và ThanhTien
            if (dgChiTietDonHang.Columns["DonGia"] != null)
            {
                dgChiTietDonHang.Columns["DonGia"].DefaultCellStyle.Format = "N0";
                dgChiTietDonHang.Columns["DonGia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            if (dgChiTietDonHang.Columns["ThanhTien"] != null)
            {
                dgChiTietDonHang.Columns["ThanhTien"].DefaultCellStyle.Format = "N0";
                dgChiTietDonHang.Columns["ThanhTien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }


        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dgChiTietDonHang = new DataGridView();
            MaDH = new DataGridViewTextBoxColumn();
            MaSP = new DataGridViewTextBoxColumn();
            TenSP = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            ThanhTien = new DataGridViewTextBoxColumn();
            NgayDH = new DataGridViewTextBoxColumn();
            TenKH = new DataGridViewTextBoxColumn();
            SDTKhachHang = new DataGridViewTextBoxColumn();
            TenNhanVien = new DataGridViewTextBoxColumn();
            lblMaDH = new Label();
            btnXoa = new MaterialSkin.Controls.MaterialButton();
            btnTimKiem = new MaterialSkin.Controls.MaterialButton();
            txtMaDH = new MaterialSkin.Controls.MaterialTextBox();
            ((ISupportInitialize)dgChiTietDonHang).BeginInit();
            SuspendLayout();
            // 
            // dgChiTietDonHang
            // 
            dgChiTietDonHang.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgChiTietDonHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgChiTietDonHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgChiTietDonHang.Columns.AddRange(new DataGridViewColumn[] { MaDH, MaSP, TenSP, SoLuong, DonGia, ThanhTien, NgayDH, TenKH, SDTKhachHang, TenNhanVien });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgChiTietDonHang.DefaultCellStyle = dataGridViewCellStyle5;
            dgChiTietDonHang.Location = new Point(41, 121);
            dgChiTietDonHang.Name = "dgChiTietDonHang";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgChiTietDonHang.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgChiTietDonHang.RowHeadersWidth = 51;
            dgChiTietDonHang.Size = new Size(924, 491);
            dgChiTietDonHang.TabIndex = 43;
            // 
            // MaDH
            // 
            MaDH.DataPropertyName = "MaDH";
            MaDH.HeaderText = "Mã đơn hàng";
            MaDH.MinimumWidth = 6;
            MaDH.Name = "MaDH";
            MaDH.Width = 125;
            // 
            // MaSP
            // 
            MaSP.DataPropertyName = "MaSP";
            MaSP.HeaderText = "Mã SP";
            MaSP.MinimumWidth = 6;
            MaSP.Name = "MaSP";
            MaSP.Width = 125;
            // 
            // TenSP
            // 
            TenSP.DataPropertyName = "TenSP";
            TenSP.HeaderText = "Tên sản phẩm";
            TenSP.MinimumWidth = 6;
            TenSP.Name = "TenSP";
            TenSP.Width = 125;
            // 
            // SoLuong
            // 
            SoLuong.DataPropertyName = "SoLuong";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            SoLuong.DefaultCellStyle = dataGridViewCellStyle2;
            SoLuong.HeaderText = "Số lượng";
            SoLuong.MinimumWidth = 6;
            SoLuong.Name = "SoLuong";
            SoLuong.Width = 80;
            // 
            // DonGia
            // 
            DonGia.DataPropertyName = "DonGia";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            DonGia.DefaultCellStyle = dataGridViewCellStyle3;
            DonGia.HeaderText = "Đơn giá";
            DonGia.MinimumWidth = 6;
            DonGia.Name = "DonGia";
            DonGia.Width = 125;
            // 
            // ThanhTien
            // 
            ThanhTien.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            ThanhTien.DefaultCellStyle = dataGridViewCellStyle4;
            ThanhTien.HeaderText = "Thành tiền";
            ThanhTien.MinimumWidth = 6;
            ThanhTien.Name = "ThanhTien";
            ThanhTien.Width = 125;
            // 
            // NgayDH
            // 
            NgayDH.DataPropertyName = "NgayDH";
            NgayDH.HeaderText = "Ngày đặt hàng";
            NgayDH.MinimumWidth = 6;
            NgayDH.Name = "NgayDH";
            NgayDH.Width = 125;
            // 
            // TenKH
            // 
            TenKH.DataPropertyName = "TenKH";
            TenKH.HeaderText = "Khách hàng";
            TenKH.MinimumWidth = 6;
            TenKH.Name = "TenKH";
            TenKH.Width = 125;
            // 
            // SDTKhachHang
            // 
            SDTKhachHang.DataPropertyName = "SDTKhachHang";
            SDTKhachHang.HeaderText = "SĐT KH";
            SDTKhachHang.MinimumWidth = 6;
            SDTKhachHang.Name = "SDTKhachHang";
            SDTKhachHang.Width = 125;
            // 
            // TenNhanVien
            // 
            TenNhanVien.DataPropertyName = "TenNhanVien";
            TenNhanVien.HeaderText = "Nhân viên";
            TenNhanVien.MinimumWidth = 6;
            TenNhanVien.Name = "TenNhanVien";
            TenNhanVien.Width = 125;
            // 
            // lblMaDH
            // 
            lblMaDH.BorderStyle = BorderStyle.FixedSingle;
            lblMaDH.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMaDH.ForeColor = SystemColors.ActiveCaptionText;
            lblMaDH.Location = new Point(64, 57);
            lblMaDH.Margin = new Padding(6, 7, 6, 7);
            lblMaDH.Name = "lblMaDH";
            lblMaDH.Size = new Size(140, 30);
            lblMaDH.TabIndex = 46;
            lblMaDH.Text = "Mã đơn hàng";
            lblMaDH.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnXoa
            // 
            btnXoa.AutoSize = false;
            btnXoa.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnXoa.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnXoa.Depth = 0;
            btnXoa.Enabled = false;
            btnXoa.HighEmphasis = true;
            btnXoa.Icon = null;
            btnXoa.Location = new Point(818, 54);
            btnXoa.Margin = new Padding(5);
            btnXoa.MouseState = MaterialSkin.MouseState.HOVER;
            btnXoa.Name = "btnXoa";
            btnXoa.NoAccentTextColor = Color.Empty;
            btnXoa.Size = new Size(137, 36);
            btnXoa.TabIndex = 68;
            btnXoa.Text = "In Danh sách";
            btnXoa.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnXoa.UseAccentColor = false;
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            btnTimKiem.AutoSize = false;
            btnTimKiem.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnTimKiem.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnTimKiem.Depth = 0;
            btnTimKiem.HighEmphasis = true;
            btnTimKiem.Icon = null;
            btnTimKiem.Location = new Point(701, 54);
            btnTimKiem.Margin = new Padding(5);
            btnTimKiem.MouseState = MaterialSkin.MouseState.HOVER;
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.NoAccentTextColor = Color.Empty;
            btnTimKiem.Size = new Size(93, 36);
            btnTimKiem.TabIndex = 67;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnTimKiem.UseAccentColor = false;
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtMaDH
            // 
            txtMaDH.AnimateReadOnly = false;
            txtMaDH.BorderStyle = BorderStyle.None;
            txtMaDH.Depth = 0;
            txtMaDH.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtMaDH.LeadingIcon = null;
            txtMaDH.Location = new Point(213, 56);
            txtMaDH.MaxLength = 50;
            txtMaDH.MouseState = MaterialSkin.MouseState.OUT;
            txtMaDH.Multiline = false;
            txtMaDH.Name = "txtMaDH";
            txtMaDH.Size = new Size(462, 36);
            txtMaDH.TabIndex = 69;
            txtMaDH.Text = "";
            txtMaDH.TrailingIcon = null;
            txtMaDH.UseTallSize = false;
            // 
            // frmChiTietDonHangTheoMaDH
            // 
            ClientSize = new Size(989, 679);
            Controls.Add(txtMaDH);
            Controls.Add(btnXoa);
            Controls.Add(btnTimKiem);
            Controls.Add(lblMaDH);
            Controls.Add(dgChiTietDonHang);
            Name = "frmChiTietDonHangTheoMaDH";
            Text = "Chi tiết đơn hàng theo MaSP";
            Load += frmChiTietDonHangTheoMaDH_Load;
            ((ISupportInitialize)dgChiTietDonHang).EndInit();
            ResumeLayout(false);

        }
        private DataGridView dgChiTietDonHang;
        private Label lblMaDH;
        private MaterialSkin.Controls.MaterialButton btnXoa;
        private MaterialSkin.Controls.MaterialButton btnTimKiem;

        private void frmChiTietDonHangTheoMaDH_Load(object sender, EventArgs e)
        {
            // Có thể load mặc định tất cả đơn hàng nếu cần
            HienThiDuLieuChiTietDonHang();
        }
        private void HienThiDuLieuChiTietDonHang()
        {
            string maDH = txtMaDH.Text.Trim();

            var chiTietDonHangDTOs = baoCaoBLL.LayChiTietDonHang(maDH);
            dgChiTietDonHang.AutoGenerateColumns = false;

            dgChiTietDonHang.DataSource = new BindingList<BaoCaoChiTietDonHangDTO>(chiTietDonHangDTOs);
        }
        private MaterialSkin.Controls.MaterialTextBox txtMaDH;
        private DataGridViewTextBoxColumn MaDH;
        private DataGridViewTextBoxColumn MaSP;
        private DataGridViewTextBoxColumn TenSP;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewTextBoxColumn ThanhTien;
        private DataGridViewTextBoxColumn NgayDH;
        private DataGridViewTextBoxColumn TenKH;
        private DataGridViewTextBoxColumn SDTKhachHang;
        private DataGridViewTextBoxColumn TenNhanVien;
    }
}
