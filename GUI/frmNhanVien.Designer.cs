namespace GUI
{
    partial class frmNhanVien
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
            dataGridViewNhanVien = new DataGridView();
            btnTimKiem = new MaterialSkin.Controls.MaterialButton();
            txtTimKiem = new MaterialSkin.Controls.MaterialTextBox();
            btnAdd = new MaterialSkin.Controls.MaterialButton();
            btnUpdate = new MaterialSkin.Controls.MaterialButton();
            btnDelete = new MaterialSkin.Controls.MaterialButton();
            lblMaNV = new Label();
            lblHoTen = new Label();
            lblNgaySinh = new Label();
            lblNgayVaoLam = new Label();
            lblLuongCoBan = new Label();
            lblMaCV = new Label();
            lblEmail = new Label();
            lblDiaChi = new Label();
            txtMaNV = new TextBox();
            txtHoTen = new TextBox();
            datNgaySinh = new DateTimePicker();
            richTextDiaChi = new RichTextBox();
            txtEmail = new TextBox();
            cbChucVu = new ComboBox();
            datNgayVaoLam = new DateTimePicker();
            numLuong = new NumericUpDown();
            btnLamMoi = new MaterialSkin.Controls.MaterialButton();
            lblGioiTinh = new Label();
            txtSDT = new TextBox();
            lblSDT = new Label();
            radNam = new RadioButton();
            radNu = new RadioButton();
            radKhac = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNhanVien).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numLuong).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewNhanVien
            // 
            dataGridViewNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNhanVien.Location = new Point(462, 93);
            dataGridViewNhanVien.Margin = new Padding(3, 2, 3, 2);
            dataGridViewNhanVien.Name = "dataGridViewNhanVien";
            dataGridViewNhanVien.RowHeadersWidth = 51;
            dataGridViewNhanVien.Size = new Size(657, 390);
            dataGridViewNhanVien.TabIndex = 0;
            dataGridViewNhanVien.CellContentClick += dataGridViewNhanVien_CellContentClick;
            dataGridViewNhanVien.SelectionChanged += dataGridViewNhanVien_SelectionChanged;
            // 
            // btnTimKiem
            // 
            btnTimKiem.AutoSize = false;
            btnTimKiem.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnTimKiem.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            btnTimKiem.Depth = 0;
            btnTimKiem.HighEmphasis = true;
            btnTimKiem.Icon = null;
            btnTimKiem.Location = new Point(1033, 43);
            btnTimKiem.Margin = new Padding(4);
            btnTimKiem.MouseState = MaterialSkin.MouseState.HOVER;
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.NoAccentTextColor = Color.Empty;
            btnTimKiem.Size = new Size(86, 32);
            btnTimKiem.TabIndex = 3;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnTimKiem.UseAccentColor = false;
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click_1;
            // 
            // txtTimKiem
            // 
            txtTimKiem.AnimateReadOnly = false;
            txtTimKiem.BorderStyle = BorderStyle.None;
            txtTimKiem.Depth = 0;
            txtTimKiem.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTimKiem.LeadingIcon = null;
            txtTimKiem.Location = new Point(562, 43);
            txtTimKiem.Margin = new Padding(3, 2, 3, 2);
            txtTimKiem.MaxLength = 50;
            txtTimKiem.MouseState = MaterialSkin.MouseState.OUT;
            txtTimKiem.Multiline = false;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(452, 36);
            txtTimKiem.TabIndex = 4;
            txtTimKiem.Text = "";
            txtTimKiem.TrailingIcon = null;
            txtTimKiem.UseTallSize = false;
            txtTimKiem.TextChanged += materialTextBox1_TextChanged;
            txtTimKiem.KeyDown += txtTimKiem_KeyDown_1;
            // 
            // btnAdd
            // 
            btnAdd.AutoSize = false;
            btnAdd.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAdd.Depth = 0;
            btnAdd.HighEmphasis = true;
            btnAdd.Icon = null;
            btnAdd.Location = new Point(39, 432);
            btnAdd.Margin = new Padding(4);
            btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            btnAdd.Name = "btnAdd";
            btnAdd.NoAccentTextColor = Color.Empty;
            btnAdd.Size = new Size(81, 27);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Thêm";
            btnAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAdd.UseAccentColor = false;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.AutoSize = false;
            btnUpdate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUpdate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnUpdate.Depth = 0;
            btnUpdate.HighEmphasis = true;
            btnUpdate.Icon = null;
            btnUpdate.Location = new Point(175, 432);
            btnUpdate.Margin = new Padding(4);
            btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            btnUpdate.Name = "btnUpdate";
            btnUpdate.NoAccentTextColor = Color.Empty;
            btnUpdate.Size = new Size(79, 27);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Sửa";
            btnUpdate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnUpdate.UseAccentColor = false;
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.AutoSize = false;
            btnDelete.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDelete.BackColor = SystemColors.ActiveBorder;
            btnDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnDelete.Depth = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.HighEmphasis = true;
            btnDelete.Icon = null;
            btnDelete.Location = new Point(311, 432);
            btnDelete.Margin = new Padding(4);
            btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            btnDelete.Name = "btnDelete";
            btnDelete.NoAccentTextColor = Color.Empty;
            btnDelete.Size = new Size(82, 27);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Xóa";
            btnDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnDelete.UseAccentColor = true;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblMaNV
            // 
            lblMaNV.BorderStyle = BorderStyle.FixedSingle;
            lblMaNV.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMaNV.ForeColor = SystemColors.ActiveCaptionText;
            lblMaNV.Location = new Point(14, 43);
            lblMaNV.Margin = new Padding(5);
            lblMaNV.Name = "lblMaNV";
            lblMaNV.Size = new Size(101, 23);
            lblMaNV.TabIndex = 8;
            lblMaNV.Text = "Mã";
            lblMaNV.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHoTen
            // 
            lblHoTen.BorderStyle = BorderStyle.FixedSingle;
            lblHoTen.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblHoTen.ForeColor = SystemColors.ActiveCaptionText;
            lblHoTen.Location = new Point(14, 76);
            lblHoTen.Margin = new Padding(5);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(101, 23);
            lblHoTen.TabIndex = 9;
            lblHoTen.Text = "Họ tên";
            lblHoTen.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.BorderStyle = BorderStyle.FixedSingle;
            lblNgaySinh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNgaySinh.ForeColor = SystemColors.ActiveCaptionText;
            lblNgaySinh.Location = new Point(14, 142);
            lblNgaySinh.Margin = new Padding(5);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(101, 23);
            lblNgaySinh.TabIndex = 10;
            lblNgaySinh.Text = "Ngày sinh";
            lblNgaySinh.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNgayVaoLam
            // 
            lblNgayVaoLam.BorderStyle = BorderStyle.FixedSingle;
            lblNgayVaoLam.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNgayVaoLam.ForeColor = SystemColors.ActiveCaptionText;
            lblNgayVaoLam.Location = new Point(12, 343);
            lblNgayVaoLam.Margin = new Padding(5);
            lblNgayVaoLam.Name = "lblNgayVaoLam";
            lblNgayVaoLam.Size = new Size(101, 23);
            lblNgayVaoLam.TabIndex = 11;
            lblNgayVaoLam.Text = "Ngày vào làm";
            lblNgayVaoLam.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLuongCoBan
            // 
            lblLuongCoBan.BorderStyle = BorderStyle.FixedSingle;
            lblLuongCoBan.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLuongCoBan.ForeColor = SystemColors.ActiveCaptionText;
            lblLuongCoBan.Location = new Point(12, 376);
            lblLuongCoBan.Margin = new Padding(5);
            lblLuongCoBan.Name = "lblLuongCoBan";
            lblLuongCoBan.Size = new Size(101, 23);
            lblLuongCoBan.TabIndex = 15;
            lblLuongCoBan.Text = "Lương";
            lblLuongCoBan.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMaCV
            // 
            lblMaCV.BorderStyle = BorderStyle.FixedSingle;
            lblMaCV.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMaCV.ForeColor = SystemColors.ActiveCaptionText;
            lblMaCV.Location = new Point(12, 310);
            lblMaCV.Margin = new Padding(5);
            lblMaCV.Name = "lblMaCV";
            lblMaCV.Size = new Size(101, 23);
            lblMaCV.TabIndex = 14;
            lblMaCV.Text = "Chức vụ";
            lblMaCV.TextAlign = ContentAlignment.MiddleCenter;
            lblMaCV.Click += lblMaCV_Click;
            // 
            // lblEmail
            // 
            lblEmail.BorderStyle = BorderStyle.FixedSingle;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEmail.ForeColor = SystemColors.ActiveCaptionText;
            lblEmail.Location = new Point(14, 213);
            lblEmail.Margin = new Padding(5);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(101, 23);
            lblEmail.TabIndex = 13;
            lblEmail.Text = "Email";
            lblEmail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDiaChi
            // 
            lblDiaChi.BorderStyle = BorderStyle.FixedSingle;
            lblDiaChi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDiaChi.ForeColor = SystemColors.ActiveCaptionText;
            lblDiaChi.Location = new Point(12, 252);
            lblDiaChi.Margin = new Padding(5);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(101, 23);
            lblDiaChi.TabIndex = 12;
            lblDiaChi.Text = "Địa chỉ";
            lblDiaChi.TextAlign = ContentAlignment.MiddleCenter;
            lblDiaChi.Click += lblDiaChi_Click;
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(154, 43);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.ReadOnly = true;
            txtMaNV.Size = new Size(135, 23);
            txtMaNV.TabIndex = 16;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(154, 76);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(271, 23);
            txtHoTen.TabIndex = 17;
            txtHoTen.TextChanged += txtHoTen_TextChanged;
            // 
            // datNgaySinh
            // 
            datNgaySinh.Format = DateTimePickerFormat.Custom;
            datNgaySinh.Location = new Point(154, 142);
            datNgaySinh.Name = "datNgaySinh";
            datNgaySinh.Size = new Size(135, 23);
            datNgaySinh.TabIndex = 19;
            datNgaySinh.ValueChanged += datNgaySinh_ValueChanged;
            // 
            // richTextDiaChi
            // 
            richTextDiaChi.Location = new Point(154, 253);
            richTextDiaChi.Name = "richTextDiaChi";
            richTextDiaChi.Size = new Size(271, 47);
            richTextDiaChi.TabIndex = 22;
            richTextDiaChi.Text = "";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(154, 213);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(271, 23);
            txtEmail.TabIndex = 21;
            // 
            // cbChucVu
            // 
            cbChucVu.FormattingEnabled = true;
            cbChucVu.Location = new Point(152, 310);
            cbChucVu.Name = "cbChucVu";
            cbChucVu.Size = new Size(273, 23);
            cbChucVu.TabIndex = 23;
            // 
            // datNgayVaoLam
            // 
            datNgayVaoLam.Format = DateTimePickerFormat.Custom;
            datNgayVaoLam.Location = new Point(152, 343);
            datNgayVaoLam.Name = "datNgayVaoLam";
            datNgayVaoLam.Size = new Size(135, 23);
            datNgayVaoLam.TabIndex = 24;
            // 
            // numLuong
            // 
            numLuong.Location = new Point(152, 376);
            numLuong.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numLuong.Name = "numLuong";
            numLuong.Size = new Size(275, 23);
            numLuong.TabIndex = 25;
            // 
            // btnLamMoi
            // 
            btnLamMoi.AutoSize = false;
            btnLamMoi.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLamMoi.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            btnLamMoi.Depth = 0;
            btnLamMoi.HighEmphasis = true;
            btnLamMoi.Icon = null;
            btnLamMoi.Location = new Point(462, 43);
            btnLamMoi.Margin = new Padding(4);
            btnLamMoi.MouseState = MaterialSkin.MouseState.HOVER;
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.NoAccentTextColor = Color.Empty;
            btnLamMoi.Size = new Size(93, 32);
            btnLamMoi.TabIndex = 24;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnLamMoi.UseAccentColor = false;
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click_1;
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.BorderStyle = BorderStyle.FixedSingle;
            lblGioiTinh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblGioiTinh.ForeColor = SystemColors.ActiveCaptionText;
            lblGioiTinh.Location = new Point(14, 109);
            lblGioiTinh.Margin = new Padding(5);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(101, 23);
            lblGioiTinh.TabIndex = 25;
            lblGioiTinh.Text = "Giới Tính";
            lblGioiTinh.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(154, 175);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(271, 23);
            txtSDT.TabIndex = 20;
            txtSDT.TextChanged += textBox1_TextChanged_1;
            // 
            // lblSDT
            // 
            lblSDT.BorderStyle = BorderStyle.FixedSingle;
            lblSDT.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSDT.ForeColor = SystemColors.ActiveCaptionText;
            lblSDT.Location = new Point(14, 175);
            lblSDT.Margin = new Padding(5);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(101, 23);
            lblSDT.TabIndex = 27;
            lblSDT.Text = "Điện thoại";
            lblSDT.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // radNam
            // 
            radNam.AutoSize = true;
            radNam.Location = new Point(154, 105);
            radNam.Name = "radNam";
            radNam.Size = new Size(51, 19);
            radNam.TabIndex = 18;
            radNam.TabStop = true;
            radNam.Text = "Nam";
            radNam.UseVisualStyleBackColor = true;
            // 
            // radNu
            // 
            radNu.AutoSize = true;
            radNu.Location = new Point(234, 105);
            radNu.Name = "radNu";
            radNu.Size = new Size(41, 19);
            radNu.TabIndex = 30;
            radNu.TabStop = true;
            radNu.Text = "Nữ";
            radNu.UseVisualStyleBackColor = true;
            // 
            // radKhac
            // 
            radKhac.AutoSize = true;
            radKhac.Location = new Point(299, 105);
            radKhac.Name = "radKhac";
            radKhac.Size = new Size(51, 19);
            radKhac.TabIndex = 31;
            radKhac.TabStop = true;
            radKhac.Text = "Khác";
            radKhac.UseVisualStyleBackColor = true;
            // 
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1137, 509);
            Controls.Add(radKhac);
            Controls.Add(radNu);
            Controls.Add(radNam);
            Controls.Add(txtSDT);
            Controls.Add(lblSDT);
            Controls.Add(lblGioiTinh);
            Controls.Add(btnLamMoi);
            Controls.Add(numLuong);
            Controls.Add(datNgayVaoLam);
            Controls.Add(cbChucVu);
            Controls.Add(txtEmail);
            Controls.Add(richTextDiaChi);
            Controls.Add(datNgaySinh);
            Controls.Add(txtHoTen);
            Controls.Add(txtMaNV);
            Controls.Add(lblLuongCoBan);
            Controls.Add(lblMaCV);
            Controls.Add(lblEmail);
            Controls.Add(lblDiaChi);
            Controls.Add(lblNgayVaoLam);
            Controls.Add(lblNgaySinh);
            Controls.Add(lblHoTen);
            Controls.Add(lblMaNV);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtTimKiem);
            Controls.Add(btnTimKiem);
            Controls.Add(dataGridViewNhanVien);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmNhanVien";
            Text = "frmNhanVien";
            Load += frmNhanVien_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewNhanVien).EndInit();
            ((System.ComponentModel.ISupportInitialize)numLuong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewNhanVien;
        private MaterialSkin.Controls.MaterialButton btnTimKiem;
        private MaterialSkin.Controls.MaterialTextBox txtTimKiem;
        private MaterialSkin.Controls.MaterialButton btnAdd;
        private MaterialSkin.Controls.MaterialButton btnUpdate;
        private MaterialSkin.Controls.MaterialButton btnDelete;
        private Label lblMaNV;
        private Label lblHoTen;
        private Label lblNgaySinh;
        private Label lblNgayVaoLam;
        private Label lblLuongCoBan;
        private Label lblMaCV;
        private Label lblEmail;
        private Label lblDiaChi;
        private TextBox txtMaNV;
        private TextBox txtHoTen;
        private DateTimePicker datNgaySinh;
        private RichTextBox richTextDiaChi;
        private TextBox txtEmail;
        private ComboBox cbChucVu;
        private DateTimePicker datNgayVaoLam;
        private NumericUpDown numLuong;
        private MaterialSkin.Controls.MaterialButton btnLamMoi;
        private Label lblGioiTinh;
        private TextBox txtSDT;
        private Label lblSDT;
        private RadioButton radNam;
        private RadioButton radNu;
        private RadioButton radKhac;
    }
}