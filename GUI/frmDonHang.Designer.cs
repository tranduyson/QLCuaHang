namespace GUI
{
    partial class frmDonHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDonHang));
            btnUpdate = new MaterialSkin.Controls.MaterialButton();
            btnAdd = new MaterialSkin.Controls.MaterialButton();
            lblTongTien = new Label();
            datNgayDH = new DateTimePicker();
            lblNgayDH = new Label();
            txtMaDH = new TextBox();
            lblMaDH = new Label();
            groupBox1 = new GroupBox();
            txtMaNV = new TextBox();
            lblMaNV = new Label();
            txtTenKH = new TextBox();
            richTextDiaChi = new RichTextBox();
            txtSDT = new TextBox();
            lblSDT = new Label();
            lblDiaChi = new Label();
            comHoTen = new ComboBox();
            lblTenKH = new Label();
            lblHoTen = new Label();
            lblMaSP = new Label();
            dataGridViewChiTietDonHang = new DataGridView();
            groupBox2 = new GroupBox();
            txtDonVi = new TextBox();
            lbl = new Label();
            comSanPham = new ComboBox();
            btnXoa = new MaterialSkin.Controls.MaterialButton();
            txtMaSP = new TextBox();
            label1 = new Label();
            numSoLuong = new NumericUpDown();
            lblSoLuong = new Label();
            numDonGia = new NumericUpDown();
            lblDonGia = new Label();
            numThanhTien = new NumericUpDown();
            lblThanhTien = new Label();
            lblTongTienBangChu = new Label();
            btnTaoDonHang = new MaterialSkin.Controls.MaterialButton();
            txtTongTien = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewChiTietDonHang).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDonGia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numThanhTien).BeginInit();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.AutoSize = false;
            btnUpdate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUpdate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnUpdate.Depth = 0;
            btnUpdate.Enabled = false;
            btnUpdate.HighEmphasis = true;
            btnUpdate.Icon = null;
            btnUpdate.Location = new Point(390, 135);
            btnUpdate.Margin = new Padding(5);
            btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            btnUpdate.Name = "btnUpdate";
            btnUpdate.NoAccentTextColor = Color.Empty;
            btnUpdate.Size = new Size(90, 36);
            btnUpdate.TabIndex = 38;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnUpdate.UseAccentColor = false;
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.AutoSize = false;
            btnAdd.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAdd.Depth = 0;
            btnAdd.HighEmphasis = true;
            btnAdd.Icon = null;
            btnAdd.Location = new Point(222, 135);
            btnAdd.Margin = new Padding(5);
            btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            btnAdd.Name = "btnAdd";
            btnAdd.NoAccentTextColor = Color.Empty;
            btnAdd.Size = new Size(93, 36);
            btnAdd.TabIndex = 37;
            btnAdd.Text = "Thêm";
            btnAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAdd.UseAccentColor = false;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblTongTien
            // 
            lblTongTien.BorderStyle = BorderStyle.FixedSingle;
            lblTongTien.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTongTien.ForeColor = SystemColors.ActiveCaptionText;
            lblTongTien.Location = new Point(557, 677);
            lblTongTien.Margin = new Padding(6, 7, 6, 7);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(81, 30);
            lblTongTien.TabIndex = 48;
            lblTongTien.Text = "Tổng Tiền";
            lblTongTien.TextAlign = ContentAlignment.MiddleCenter;
            lblTongTien.Click += lblTongTien_Click;
            // 
            // datNgayDH
            // 
            datNgayDH.Format = DateTimePickerFormat.Custom;
            datNgayDH.Location = new Point(949, 81);
            datNgayDH.Margin = new Padding(3, 4, 3, 4);
            datNgayDH.Name = "datNgayDH";
            datNgayDH.Size = new Size(162, 27);
            datNgayDH.TabIndex = 5;
            // 
            // lblNgayDH
            // 
            lblNgayDH.BorderStyle = BorderStyle.FixedSingle;
            lblNgayDH.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNgayDH.ForeColor = SystemColors.ActiveCaptionText;
            lblNgayDH.Location = new Point(762, 78);
            lblNgayDH.Margin = new Padding(6, 7, 6, 7);
            lblNgayDH.Name = "lblNgayDH";
            lblNgayDH.Size = new Size(140, 30);
            lblNgayDH.TabIndex = 46;
            lblNgayDH.Text = "Ngày bán";
            lblNgayDH.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtMaDH
            // 
            txtMaDH.Location = new Point(949, 28);
            txtMaDH.Margin = new Padding(3, 4, 3, 4);
            txtMaDH.Name = "txtMaDH";
            txtMaDH.ReadOnly = true;
            txtMaDH.Size = new Size(162, 27);
            txtMaDH.TabIndex = 4;
            // 
            // lblMaDH
            // 
            lblMaDH.BorderStyle = BorderStyle.FixedSingle;
            lblMaDH.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMaDH.ForeColor = SystemColors.ActiveCaptionText;
            lblMaDH.Location = new Point(762, 25);
            lblMaDH.Margin = new Padding(6, 7, 6, 7);
            lblMaDH.Name = "lblMaDH";
            lblMaDH.Size = new Size(140, 30);
            lblMaDH.TabIndex = 44;
            lblMaDH.Text = "Mã đơn hàng";
            lblMaDH.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtMaNV);
            groupBox1.Controls.Add(lblMaNV);
            groupBox1.Controls.Add(txtTenKH);
            groupBox1.Controls.Add(richTextDiaChi);
            groupBox1.Controls.Add(txtSDT);
            groupBox1.Controls.Add(lblSDT);
            groupBox1.Controls.Add(lblDiaChi);
            groupBox1.Controls.Add(comHoTen);
            groupBox1.Controls.Add(lblTenKH);
            groupBox1.Controls.Add(lblMaDH);
            groupBox1.Controls.Add(txtMaDH);
            groupBox1.Controls.Add(lblNgayDH);
            groupBox1.Controls.Add(datNgayDH);
            groupBox1.Controls.Add(lblHoTen);
            groupBox1.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Red;
            groupBox1.Location = new Point(102, 93);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1275, 209);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Chung";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(949, 172);
            txtMaNV.Margin = new Padding(3, 4, 3, 4);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.ReadOnly = true;
            txtMaNV.Size = new Size(162, 27);
            txtMaNV.TabIndex = 66;
            // 
            // lblMaNV
            // 
            lblMaNV.BorderStyle = BorderStyle.FixedSingle;
            lblMaNV.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMaNV.ForeColor = SystemColors.ActiveCaptionText;
            lblMaNV.Location = new Point(762, 172);
            lblMaNV.Margin = new Padding(6, 7, 6, 7);
            lblMaNV.Name = "lblMaNV";
            lblMaNV.Size = new Size(140, 30);
            lblMaNV.TabIndex = 65;
            lblMaNV.Text = "Mã nhân viên";
            lblMaNV.TextAlign = ContentAlignment.MiddleCenter;
            lblMaNV.Click += label2_Click;
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(222, 76);
            txtTenKH.Margin = new Padding(3, 4, 3, 4);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(488, 27);
            txtTenKH.TabIndex = 2;
            // 
            // richTextDiaChi
            // 
            richTextDiaChi.Location = new Point(222, 130);
            richTextDiaChi.Margin = new Padding(3, 4, 3, 4);
            richTextDiaChi.Name = "richTextDiaChi";
            richTextDiaChi.Size = new Size(488, 61);
            richTextDiaChi.TabIndex = 3;
            richTextDiaChi.Text = "";
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(222, 28);
            txtSDT.Margin = new Padding(3, 4, 3, 4);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(488, 27);
            txtSDT.TabIndex = 1;
            // 
            // lblSDT
            // 
            lblSDT.BorderStyle = BorderStyle.FixedSingle;
            lblSDT.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSDT.ForeColor = SystemColors.ActiveCaptionText;
            lblSDT.Location = new Point(35, 30);
            lblSDT.Margin = new Padding(6, 7, 6, 7);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(140, 30);
            lblSDT.TabIndex = 59;
            lblSDT.Text = "Điện thoại";
            lblSDT.TextAlign = ContentAlignment.MiddleCenter;
            lblSDT.Click += lblSDT_Click;
            // 
            // lblDiaChi
            // 
            lblDiaChi.BorderStyle = BorderStyle.FixedSingle;
            lblDiaChi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDiaChi.ForeColor = SystemColors.ActiveCaptionText;
            lblDiaChi.Location = new Point(35, 128);
            lblDiaChi.Margin = new Padding(6, 7, 6, 7);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(140, 30);
            lblDiaChi.TabIndex = 57;
            lblDiaChi.Text = "Địa chỉ";
            lblDiaChi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comHoTen
            // 
            comHoTen.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comHoTen.FormattingEnabled = true;
            comHoTen.Location = new Point(949, 130);
            comHoTen.Name = "comHoTen";
            comHoTen.Size = new Size(311, 26);
            comHoTen.TabIndex = 6;
            // 
            // lblTenKH
            // 
            lblTenKH.BorderStyle = BorderStyle.FixedSingle;
            lblTenKH.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTenKH.ForeColor = SystemColors.ActiveCaptionText;
            lblTenKH.Location = new Point(35, 78);
            lblTenKH.Margin = new Padding(6, 7, 6, 7);
            lblTenKH.Name = "lblTenKH";
            lblTenKH.Size = new Size(140, 30);
            lblTenKH.TabIndex = 50;
            lblTenKH.Text = "Tên Khách Hàng";
            lblTenKH.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHoTen
            // 
            lblHoTen.BorderStyle = BorderStyle.FixedSingle;
            lblHoTen.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblHoTen.ForeColor = SystemColors.ActiveCaptionText;
            lblHoTen.Location = new Point(762, 128);
            lblHoTen.Margin = new Padding(6, 7, 6, 7);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(140, 30);
            lblHoTen.TabIndex = 50;
            lblHoTen.Text = "Nhân Viên";
            lblHoTen.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMaSP
            // 
            lblMaSP.BorderStyle = BorderStyle.FixedSingle;
            lblMaSP.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMaSP.ForeColor = SystemColors.ActiveCaptionText;
            lblMaSP.Location = new Point(35, 50);
            lblMaSP.Margin = new Padding(6, 7, 6, 7);
            lblMaSP.Name = "lblMaSP";
            lblMaSP.Size = new Size(140, 30);
            lblMaSP.TabIndex = 44;
            lblMaSP.Text = "Sản phẩm";
            lblMaSP.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridViewChiTietDonHang
            // 
            dataGridViewChiTietDonHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewChiTietDonHang.Location = new Point(32, 179);
            dataGridViewChiTietDonHang.Name = "dataGridViewChiTietDonHang";
            dataGridViewChiTietDonHang.RowHeadersWidth = 51;
            dataGridViewChiTietDonHang.Size = new Size(1225, 177);
            dataGridViewChiTietDonHang.TabIndex = 40;
            dataGridViewChiTietDonHang.CellClick += dataGridViewChiTietDonHang_CellClick;
            dataGridViewChiTietDonHang.CellContentClick += dataGridViewDonHang_CellContentClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtDonVi);
            groupBox2.Controls.Add(lbl);
            groupBox2.Controls.Add(comSanPham);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(txtMaSP);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(numSoLuong);
            groupBox2.Controls.Add(lblSoLuong);
            groupBox2.Controls.Add(numDonGia);
            groupBox2.Controls.Add(btnUpdate);
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Controls.Add(lblDonGia);
            groupBox2.Controls.Add(numThanhTien);
            groupBox2.Controls.Add(lblThanhTien);
            groupBox2.Controls.Add(lblMaSP);
            groupBox2.Controls.Add(dataGridViewChiTietDonHang);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.Red;
            groupBox2.Location = new Point(102, 297);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1275, 368);
            groupBox2.TabIndex = 56;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông Tin các mặt hàng";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // txtDonVi
            // 
            txtDonVi.Location = new Point(1094, 49);
            txtDonVi.Margin = new Padding(3, 4, 3, 4);
            txtDonVi.Name = "txtDonVi";
            txtDonVi.ReadOnly = true;
            txtDonVi.Size = new Size(150, 27);
            txtDonVi.TabIndex = 69;
            // 
            // lbl
            // 
            lbl.BorderStyle = BorderStyle.FixedSingle;
            lbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl.ForeColor = SystemColors.ActiveCaptionText;
            lbl.Location = new Point(1015, 48);
            lbl.Margin = new Padding(6, 7, 6, 7);
            lbl.Name = "lbl";
            lbl.Size = new Size(70, 30);
            lbl.TabIndex = 68;
            lbl.Text = "DVT";
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comSanPham
            // 
            comSanPham.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comSanPham.FormattingEnabled = true;
            comSanPham.Location = new Point(219, 50);
            comSanPham.Name = "comSanPham";
            comSanPham.Size = new Size(488, 26);
            comSanPham.TabIndex = 67;
            comSanPham.SelectedIndexChanged += comSanPham_SelectedIndexChanged_1;
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
            btnXoa.Location = new Point(551, 135);
            btnXoa.Margin = new Padding(5);
            btnXoa.MouseState = MaterialSkin.MouseState.HOVER;
            btnXoa.Name = "btnXoa";
            btnXoa.NoAccentTextColor = Color.Empty;
            btnXoa.Size = new Size(90, 36);
            btnXoa.TabIndex = 65;
            btnXoa.Text = "Xóa";
            btnXoa.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnXoa.UseAccentColor = false;
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(838, 50);
            txtMaSP.Margin = new Padding(3, 4, 3, 4);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.ReadOnly = true;
            txtMaSP.Size = new Size(150, 27);
            txtMaSP.TabIndex = 64;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(759, 49);
            label1.Margin = new Padding(6, 7, 6, 7);
            label1.Name = "label1";
            label1.Size = new Size(70, 30);
            label1.TabIndex = 63;
            label1.Text = "Mã ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(219, 94);
            numSoLuong.Margin = new Padding(2, 3, 2, 3);
            numSoLuong.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numSoLuong.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(162, 27);
            numSoLuong.TabIndex = 61;
            numSoLuong.TextAlign = HorizontalAlignment.Right;
            numSoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numSoLuong.ValueChanged += numSoLuong_ValueChanged;
            // 
            // lblSoLuong
            // 
            lblSoLuong.BorderStyle = BorderStyle.FixedSingle;
            lblSoLuong.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSoLuong.ForeColor = SystemColors.ActiveCaptionText;
            lblSoLuong.Location = new Point(35, 94);
            lblSoLuong.Margin = new Padding(6, 7, 6, 7);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(140, 30);
            lblSoLuong.TabIndex = 60;
            lblSoLuong.Text = "Số lượng";
            lblSoLuong.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numDonGia
            // 
            numDonGia.Location = new Point(519, 91);
            numDonGia.Margin = new Padding(2, 3, 2, 3);
            numDonGia.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numDonGia.Name = "numDonGia";
            numDonGia.Size = new Size(188, 27);
            numDonGia.TabIndex = 59;
            numDonGia.TextAlign = HorizontalAlignment.Right;
            numDonGia.ValueChanged += numDonGia_ValueChanged;
            // 
            // lblDonGia
            // 
            lblDonGia.BorderStyle = BorderStyle.FixedSingle;
            lblDonGia.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDonGia.ForeColor = SystemColors.ActiveCaptionText;
            lblDonGia.Location = new Point(405, 91);
            lblDonGia.Margin = new Padding(6, 7, 6, 7);
            lblDonGia.Name = "lblDonGia";
            lblDonGia.Size = new Size(94, 30);
            lblDonGia.TabIndex = 58;
            lblDonGia.Text = "Đơn giá";
            lblDonGia.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numThanhTien
            // 
            numThanhTien.Location = new Point(946, 91);
            numThanhTien.Margin = new Padding(2, 3, 2, 3);
            numThanhTien.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numThanhTien.Name = "numThanhTien";
            numThanhTien.Size = new Size(311, 27);
            numThanhTien.TabIndex = 57;
            numThanhTien.TextAlign = HorizontalAlignment.Right;
            // 
            // lblThanhTien
            // 
            lblThanhTien.BorderStyle = BorderStyle.FixedSingle;
            lblThanhTien.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblThanhTien.ForeColor = SystemColors.ActiveCaptionText;
            lblThanhTien.Location = new Point(759, 91);
            lblThanhTien.Margin = new Padding(6, 7, 6, 7);
            lblThanhTien.Name = "lblThanhTien";
            lblThanhTien.Size = new Size(140, 30);
            lblThanhTien.TabIndex = 56;
            lblThanhTien.Text = "Thành tiền";
            lblThanhTien.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTongTienBangChu
            // 
            lblTongTienBangChu.AutoSize = true;
            lblTongTienBangChu.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTongTienBangChu.ForeColor = Color.Black;
            lblTongTienBangChu.Location = new Point(806, 682);
            lblTongTienBangChu.Name = "lblTongTienBangChu";
            lblTongTienBangChu.Size = new Size(19, 20);
            lblTongTienBangChu.TabIndex = 64;
            lblTongTienBangChu.Text = " .";
            // 
            // btnTaoDonHang
            // 
            btnTaoDonHang.AutoSize = false;
            btnTaoDonHang.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnTaoDonHang.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnTaoDonHang.Depth = 0;
            btnTaoDonHang.HighEmphasis = true;
            btnTaoDonHang.Icon = null;
            btnTaoDonHang.Location = new Point(1166, 709);
            btnTaoDonHang.Margin = new Padding(5);
            btnTaoDonHang.MouseState = MaterialSkin.MouseState.HOVER;
            btnTaoDonHang.Name = "btnTaoDonHang";
            btnTaoDonHang.NoAccentTextColor = Color.Empty;
            btnTaoDonHang.Size = new Size(184, 39);
            btnTaoDonHang.TabIndex = 63;
            btnTaoDonHang.Text = "Tạo đơn hàng";
            btnTaoDonHang.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnTaoDonHang.UseAccentColor = false;
            btnTaoDonHang.UseVisualStyleBackColor = true;
            btnTaoDonHang.Click += btnTaoDonHang_Click;
            // 
            // txtTongTien
            // 
            txtTongTien.AutoSize = true;
            txtTongTien.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTongTien.ForeColor = Color.Black;
            txtTongTien.Location = new Point(670, 682);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(14, 20);
            txtTongTien.TabIndex = 65;
            txtTongTien.Text = ".";
            txtTongTien.Click += txtTongTien_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(589, 46);
            label2.Name = "label2";
            label2.Size = new Size(374, 46);
            label2.TabIndex = 66;
            label2.Text = "HÓA ĐƠN BÁN HÀNG";
            // 
            // frmDonHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1476, 731);
            Controls.Add(label2);
            Controls.Add(txtTongTien);
            Controls.Add(lblTongTienBangChu);
            Controls.Add(btnTaoDonHang);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lblTongTien);
            ForeColor = Color.Red;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmDonHang";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmDonHang";
            Load += frmDonHang_Load_1;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewChiTietDonHang).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDonGia).EndInit();
            ((System.ComponentModel.ISupportInitialize)numThanhTien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaterialSkin.Controls.MaterialButton btnUpdate;
        private MaterialSkin.Controls.MaterialButton btnAdd;
        private Label lblTongTien;
        private DateTimePicker datNgayDH;
        private Label lblNgayDH;
        private TextBox txtMaDH;
        private Label lblMaDH;
        private GroupBox groupBox1;
        private Label lblTenKH;
        private Label lblHoTen;
        private TextBox txtSDT;
        private Label lblSDT;
        private Label lblDiaChi;
        private ComboBox comHoTen;
        private Label label8;
        private Label label5;
        private TextBox textBox3;
        private Label lblMaSP;
        private DataGridView dataGridViewChiTietDonHang;
        private TextBox textBox2;
        private TextBox txtTenKH;
        private GroupBox groupBox2;
        private NumericUpDown numThanhTien;
        private Label lblThanhTien;
        private NumericUpDown numSoLuong;
        private Label lblSoLuong;
        private NumericUpDown numDonGia;
        private Label lblDonGia;
        private RichTextBox richTextDiaChi;
        private MaterialSkin.Controls.MaterialButton btnTaoDonHang;
        private TextBox txtMaSP;
        private Label label1;
        private Label lblTongTienBangChu;
        private MaterialSkin.Controls.MaterialButton btnXoa;
        private TextBox txtMaNV;
        private Label lblMaNV;
        private ComboBox comSanPham;
        private Label txtTongTien;
        private TextBox textBox1;
        private Label lbl;
        private TextBox txtDonVi;
        private Label label2;
    }
}