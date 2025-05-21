namespace GUI
{
    partial class frmBaoCaoLuongNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dgLuongNhanVien = new DataGridView();
            btnInDanhSach = new MaterialSkin.Controls.MaterialButton();
            btnTimKiem = new MaterialSkin.Controls.MaterialButton();
            comTenNV = new ComboBox();
            lblTenNV = new Label();
            MaNV = new DataGridViewTextBoxColumn();
            HoTen = new DataGridViewTextBoxColumn();
            NgaySinh = new DataGridViewTextBoxColumn();
            GioiTinh = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            SDT = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            MaCV = new DataGridViewTextBoxColumn();
            TenCV = new DataGridViewTextBoxColumn();
            HeSoLuong = new DataGridViewTextBoxColumn();
            LuongCoBan = new DataGridViewTextBoxColumn();
            TongLuong = new DataGridViewTextBoxColumn();
            NgayVaoLam = new DataGridViewTextBoxColumn();
            SoThangLamViec = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgLuongNhanVien).BeginInit();
            SuspendLayout();
            // 
            // dgLuongNhanVien
            // 
            dgLuongNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgLuongNhanVien.Columns.AddRange(new DataGridViewColumn[] { MaNV, HoTen, NgaySinh, GioiTinh, DiaChi, SDT, Email, MaCV, TenCV, HeSoLuong, LuongCoBan, TongLuong, NgayVaoLam, SoThangLamViec });
            dgLuongNhanVien.Location = new Point(64, 123);
            dgLuongNhanVien.Name = "dgLuongNhanVien";
            dgLuongNhanVien.RowHeadersWidth = 51;
            dgLuongNhanVien.Size = new Size(1050, 491);
            dgLuongNhanVien.TabIndex = 81;
            // 
            // btnInDanhSach
            // 
            btnInDanhSach.AutoSize = false;
            btnInDanhSach.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnInDanhSach.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnInDanhSach.Depth = 0;
            btnInDanhSach.Enabled = false;
            btnInDanhSach.HighEmphasis = true;
            btnInDanhSach.Icon = null;
            btnInDanhSach.Location = new Point(848, 58);
            btnInDanhSach.Margin = new Padding(5);
            btnInDanhSach.MouseState = MaterialSkin.MouseState.HOVER;
            btnInDanhSach.Name = "btnInDanhSach";
            btnInDanhSach.NoAccentTextColor = Color.Empty;
            btnInDanhSach.Size = new Size(137, 36);
            btnInDanhSach.TabIndex = 89;
            btnInDanhSach.Text = "In Danh sách";
            btnInDanhSach.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInDanhSach.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnInDanhSach.UseAccentColor = false;
            btnInDanhSach.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            btnTimKiem.AutoSize = false;
            btnTimKiem.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnTimKiem.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnTimKiem.Depth = 0;
            btnTimKiem.HighEmphasis = true;
            btnTimKiem.Icon = null;
            btnTimKiem.Location = new Point(731, 58);
            btnTimKiem.Margin = new Padding(5);
            btnTimKiem.MouseState = MaterialSkin.MouseState.HOVER;
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.NoAccentTextColor = Color.Empty;
            btnTimKiem.Size = new Size(93, 36);
            btnTimKiem.TabIndex = 88;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnTimKiem.UseAccentColor = false;
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnXem_Click;
            // 
            // comTenNV
            // 
            comTenNV.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comTenNV.FormattingEnabled = true;
            comTenNV.Location = new Point(271, 64);
            comTenNV.Name = "comTenNV";
            comTenNV.Size = new Size(417, 26);
            comTenNV.TabIndex = 87;
            // 
            // lblTenNV
            // 
            lblTenNV.BorderStyle = BorderStyle.FixedSingle;
            lblTenNV.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTenNV.ForeColor = SystemColors.ActiveCaptionText;
            lblTenNV.Location = new Point(83, 60);
            lblTenNV.Margin = new Padding(6, 7, 6, 7);
            lblTenNV.Name = "lblTenNV";
            lblTenNV.Size = new Size(140, 30);
            lblTenNV.TabIndex = 86;
            lblTenNV.Text = "Tên NV";
            lblTenNV.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MaNV
            // 
            MaNV.DataPropertyName = "MaNV";
            MaNV.HeaderText = "Mã NV";
            MaNV.MinimumWidth = 6;
            MaNV.Name = "MaNV";
            MaNV.Width = 125;
            // 
            // HoTen
            // 
            HoTen.DataPropertyName = "HoTen";
            HoTen.HeaderText = "Họ tên";
            HoTen.MinimumWidth = 6;
            HoTen.Name = "HoTen";
            HoTen.Width = 125;
            // 
            // NgaySinh
            // 
            NgaySinh.DataPropertyName = "NgaySinh";
            NgaySinh.HeaderText = "Ngày sinh";
            NgaySinh.MinimumWidth = 6;
            NgaySinh.Name = "NgaySinh";
            NgaySinh.Width = 125;
            // 
            // GioiTinh
            // 
            GioiTinh.DataPropertyName = "GioiTinh";
            GioiTinh.HeaderText = "Giới tính";
            GioiTinh.MinimumWidth = 6;
            GioiTinh.Name = "GioiTinh";
            GioiTinh.Width = 125;
            // 
            // DiaChi
            // 
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.HeaderText = "Địa chỉ";
            DiaChi.MinimumWidth = 6;
            DiaChi.Name = "DiaChi";
            DiaChi.Width = 125;
            // 
            // SDT
            // 
            SDT.DataPropertyName = "SDT";
            SDT.HeaderText = "SDT";
            SDT.MinimumWidth = 6;
            SDT.Name = "SDT";
            SDT.Width = 125;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.Width = 125;
            // 
            // MaCV
            // 
            MaCV.DataPropertyName = "MaCV";
            MaCV.HeaderText = "Mã CV";
            MaCV.MinimumWidth = 6;
            MaCV.Name = "MaCV";
            MaCV.Width = 125;
            // 
            // TenCV
            // 
            TenCV.DataPropertyName = "TenCV";
            TenCV.HeaderText = "Chức vụ";
            TenCV.MinimumWidth = 6;
            TenCV.Name = "TenCV";
            TenCV.Width = 125;
            // 
            // HeSoLuong
            // 
            HeSoLuong.DataPropertyName = "HeSoLuong";
            HeSoLuong.HeaderText = "Hệ số lương";
            HeSoLuong.MinimumWidth = 6;
            HeSoLuong.Name = "HeSoLuong";
            HeSoLuong.Width = 125;
            // 
            // LuongCoBan
            // 
            LuongCoBan.DataPropertyName = "LuongCoBan";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            LuongCoBan.DefaultCellStyle = dataGridViewCellStyle1;
            LuongCoBan.HeaderText = "Lương cơ bản";
            LuongCoBan.MinimumWidth = 6;
            LuongCoBan.Name = "LuongCoBan";
            LuongCoBan.Width = 125;
            // 
            // TongLuong
            // 
            TongLuong.DataPropertyName = "TongLuong";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            TongLuong.DefaultCellStyle = dataGridViewCellStyle2;
            TongLuong.HeaderText = "Tổng lương";
            TongLuong.MinimumWidth = 6;
            TongLuong.Name = "TongLuong";
            TongLuong.Width = 125;
            // 
            // NgayVaoLam
            // 
            NgayVaoLam.DataPropertyName = "NgayVaoLam";
            NgayVaoLam.HeaderText = "Ngày vào làm";
            NgayVaoLam.MinimumWidth = 6;
            NgayVaoLam.Name = "NgayVaoLam";
            NgayVaoLam.Width = 125;
            // 
            // SoThangLamViec
            // 
            SoThangLamViec.DataPropertyName = "SoThangLamViec";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            SoThangLamViec.DefaultCellStyle = dataGridViewCellStyle3;
            SoThangLamViec.HeaderText = "Số tháng làm việc";
            SoThangLamViec.MinimumWidth = 6;
            SoThangLamViec.Name = "SoThangLamViec";
            SoThangLamViec.Width = 125;
            // 
            // frmBaoCaoLuongNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1156, 679);
            Controls.Add(btnInDanhSach);
            Controls.Add(btnTimKiem);
            Controls.Add(comTenNV);
            Controls.Add(lblTenNV);
            Controls.Add(dgLuongNhanVien);
            Name = "frmBaoCaoLuongNhanVien";
            Text = "Lương nhân viên";
            ((System.ComponentModel.ISupportInitialize)dgLuongNhanVien).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgLuongNhanVien;
        private MaterialSkin.Controls.MaterialButton btnInDanhSach;
        private MaterialSkin.Controls.MaterialButton btnTimKiem;
        private ComboBox comTenNV;
        private Label lblTenNV;
        private DataGridViewTextBoxColumn MaNV;
        private DataGridViewTextBoxColumn HoTen;
        private DataGridViewTextBoxColumn NgaySinh;
        private DataGridViewTextBoxColumn GioiTinh;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn SDT;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn MaCV;
        private DataGridViewTextBoxColumn TenCV;
        private DataGridViewTextBoxColumn HeSoLuong;
        private DataGridViewTextBoxColumn LuongCoBan;
        private DataGridViewTextBoxColumn TongLuong;
        private DataGridViewTextBoxColumn NgayVaoLam;
        private DataGridViewTextBoxColumn SoThangLamViec;
    }
}