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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanVien));
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
            label1 = new Label();
            label2 = new Label();
            txtMatKhau = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNhanVien).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numLuong).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewNhanVien
            // 
            dataGridViewNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNhanVien.Location = new Point(515, 124);
            dataGridViewNhanVien.Name = "dataGridViewNhanVien";
            dataGridViewNhanVien.RowHeadersWidth = 51;
            dataGridViewNhanVien.Size = new Size(751, 470);
            dataGridViewNhanVien.TabIndex = 0;
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
            btnTimKiem.Location = new Point(1154, 50);
            btnTimKiem.Margin = new Padding(5);
            btnTimKiem.MouseState = MaterialSkin.MouseState.HOVER;
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.NoAccentTextColor = Color.Empty;
            btnTimKiem.Size = new Size(112, 43);
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
            txtTimKiem.Location = new Point(629, 50);
            txtTimKiem.MaxLength = 50;
            txtTimKiem.MouseState = MaterialSkin.MouseState.OUT;
            txtTimKiem.Multiline = false;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(517, 50);
            txtTimKiem.TabIndex = 4;
            txtTimKiem.Text = "";
            txtTimKiem.TrailingIcon = null;
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
            btnAdd.Location = new Point(43, 654);
            btnAdd.Margin = new Padding(5);
            btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            btnAdd.Name = "btnAdd";
            btnAdd.NoAccentTextColor = Color.Empty;
            btnAdd.Size = new Size(93, 36);
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
            btnUpdate.Location = new Point(198, 654);
            btnUpdate.Margin = new Padding(5);
            btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            btnUpdate.Name = "btnUpdate";
            btnUpdate.NoAccentTextColor = Color.Empty;
            btnUpdate.Size = new Size(90, 36);
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
            btnDelete.Location = new Point(353, 654);
            btnDelete.Margin = new Padding(5);
            btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            btnDelete.Name = "btnDelete";
            btnDelete.NoAccentTextColor = Color.Empty;
            btnDelete.Size = new Size(94, 36);
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
            lblMaNV.Location = new Point(25, 77);
            lblMaNV.Margin = new Padding(6, 7, 6, 7);
            lblMaNV.Name = "lblMaNV";
            lblMaNV.Size = new Size(115, 30);
            lblMaNV.TabIndex = 8;
            lblMaNV.Text = "Mã";
            lblMaNV.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHoTen
            // 
            lblHoTen.BorderStyle = BorderStyle.FixedSingle;
            lblHoTen.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblHoTen.ForeColor = SystemColors.ActiveCaptionText;
            lblHoTen.Location = new Point(27, 124);
            lblHoTen.Margin = new Padding(6, 7, 6, 7);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(115, 30);
            lblHoTen.TabIndex = 9;
            lblHoTen.Text = "Họ tên";
            lblHoTen.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.BorderStyle = BorderStyle.FixedSingle;
            lblNgaySinh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNgaySinh.ForeColor = SystemColors.ActiveCaptionText;
            lblNgaySinh.Location = new Point(27, 212);
            lblNgaySinh.Margin = new Padding(6, 7, 6, 7);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(115, 30);
            lblNgaySinh.TabIndex = 10;
            lblNgaySinh.Text = "Ngày sinh";
            lblNgaySinh.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNgayVaoLam
            // 
            lblNgayVaoLam.BorderStyle = BorderStyle.FixedSingle;
            lblNgayVaoLam.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNgayVaoLam.ForeColor = SystemColors.ActiveCaptionText;
            lblNgayVaoLam.Location = new Point(25, 480);
            lblNgayVaoLam.Margin = new Padding(6, 7, 6, 7);
            lblNgayVaoLam.Name = "lblNgayVaoLam";
            lblNgayVaoLam.Size = new Size(115, 30);
            lblNgayVaoLam.TabIndex = 11;
            lblNgayVaoLam.Text = "Ngày vào làm";
            lblNgayVaoLam.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLuongCoBan
            // 
            lblLuongCoBan.BorderStyle = BorderStyle.FixedSingle;
            lblLuongCoBan.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLuongCoBan.ForeColor = SystemColors.ActiveCaptionText;
            lblLuongCoBan.Location = new Point(25, 524);
            lblLuongCoBan.Margin = new Padding(6, 7, 6, 7);
            lblLuongCoBan.Name = "lblLuongCoBan";
            lblLuongCoBan.Size = new Size(115, 30);
            lblLuongCoBan.TabIndex = 15;
            lblLuongCoBan.Text = "Lương";
            lblLuongCoBan.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMaCV
            // 
            lblMaCV.BorderStyle = BorderStyle.FixedSingle;
            lblMaCV.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMaCV.ForeColor = SystemColors.ActiveCaptionText;
            lblMaCV.Location = new Point(25, 436);
            lblMaCV.Margin = new Padding(6, 7, 6, 7);
            lblMaCV.Name = "lblMaCV";
            lblMaCV.Size = new Size(115, 30);
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
            lblEmail.Location = new Point(27, 307);
            lblEmail.Margin = new Padding(6, 7, 6, 7);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(115, 30);
            lblEmail.TabIndex = 13;
            lblEmail.Text = "Email";
            lblEmail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDiaChi
            // 
            lblDiaChi.BorderStyle = BorderStyle.FixedSingle;
            lblDiaChi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDiaChi.ForeColor = SystemColors.ActiveCaptionText;
            lblDiaChi.Location = new Point(25, 359);
            lblDiaChi.Margin = new Padding(6, 7, 6, 7);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(115, 30);
            lblDiaChi.TabIndex = 12;
            lblDiaChi.Text = "Địa chỉ";
            lblDiaChi.TextAlign = ContentAlignment.MiddleCenter;
            lblDiaChi.Click += lblDiaChi_Click;
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(187, 80);
            txtMaNV.Margin = new Padding(3, 4, 3, 4);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.ReadOnly = true;
            txtMaNV.Size = new Size(154, 27);
            txtMaNV.TabIndex = 16;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(187, 124);
            txtHoTen.Margin = new Padding(3, 4, 3, 4);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(309, 27);
            txtHoTen.TabIndex = 17;
            txtHoTen.TextChanged += txtHoTen_TextChanged;
            // 
            // datNgaySinh
            // 
            datNgaySinh.Format = DateTimePickerFormat.Custom;
            datNgaySinh.Location = new Point(187, 212);
            datNgaySinh.Margin = new Padding(3, 4, 3, 4);
            datNgaySinh.Name = "datNgaySinh";
            datNgaySinh.Size = new Size(154, 27);
            datNgaySinh.TabIndex = 19;
            datNgaySinh.ValueChanged += datNgaySinh_ValueChanged;
            // 
            // richTextDiaChi
            // 
            richTextDiaChi.Location = new Point(187, 360);
            richTextDiaChi.Margin = new Padding(3, 4, 3, 4);
            richTextDiaChi.Name = "richTextDiaChi";
            richTextDiaChi.Size = new Size(309, 61);
            richTextDiaChi.TabIndex = 22;
            richTextDiaChi.Text = "";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(187, 307);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(309, 27);
            txtEmail.TabIndex = 21;
            // 
            // cbChucVu
            // 
            cbChucVu.FormattingEnabled = true;
            cbChucVu.Location = new Point(185, 436);
            cbChucVu.Margin = new Padding(3, 4, 3, 4);
            cbChucVu.Name = "cbChucVu";
            cbChucVu.Size = new Size(311, 28);
            cbChucVu.TabIndex = 23;
            // 
            // datNgayVaoLam
            // 
            datNgayVaoLam.Format = DateTimePickerFormat.Custom;
            datNgayVaoLam.Location = new Point(185, 480);
            datNgayVaoLam.Margin = new Padding(3, 4, 3, 4);
            datNgayVaoLam.Name = "datNgayVaoLam";
            datNgayVaoLam.Size = new Size(154, 27);
            datNgayVaoLam.TabIndex = 24;
            // 
            // numLuong
            // 
            numLuong.Location = new Point(185, 524);
            numLuong.Margin = new Padding(3, 4, 3, 4);
            numLuong.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numLuong.Name = "numLuong";
            numLuong.Size = new Size(314, 27);
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
            btnLamMoi.Location = new Point(515, 50);
            btnLamMoi.Margin = new Padding(5);
            btnLamMoi.MouseState = MaterialSkin.MouseState.HOVER;
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.NoAccentTextColor = Color.Empty;
            btnLamMoi.Size = new Size(106, 43);
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
            lblGioiTinh.Location = new Point(27, 168);
            lblGioiTinh.Margin = new Padding(6, 7, 6, 7);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(115, 30);
            lblGioiTinh.TabIndex = 25;
            lblGioiTinh.Text = "Giới Tính";
            lblGioiTinh.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(187, 256);
            txtSDT.Margin = new Padding(3, 4, 3, 4);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(309, 27);
            txtSDT.TabIndex = 20;
            txtSDT.TextChanged += textBox1_TextChanged_1;
            // 
            // lblSDT
            // 
            lblSDT.BorderStyle = BorderStyle.FixedSingle;
            lblSDT.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSDT.ForeColor = SystemColors.ActiveCaptionText;
            lblSDT.Location = new Point(27, 256);
            lblSDT.Margin = new Padding(6, 7, 6, 7);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(115, 30);
            lblSDT.TabIndex = 27;
            lblSDT.Text = "Điện thoại";
            lblSDT.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // radNam
            // 
            radNam.AutoSize = true;
            radNam.ForeColor = SystemColors.InactiveCaptionText;
            radNam.Location = new Point(187, 163);
            radNam.Margin = new Padding(3, 4, 3, 4);
            radNam.Name = "radNam";
            radNam.Size = new Size(62, 24);
            radNam.TabIndex = 18;
            radNam.TabStop = true;
            radNam.Text = "Nam";
            radNam.UseVisualStyleBackColor = true;
            // 
            // radNu
            // 
            radNu.AutoSize = true;
            radNu.ForeColor = SystemColors.InactiveCaptionText;
            radNu.Location = new Point(278, 163);
            radNu.Margin = new Padding(3, 4, 3, 4);
            radNu.Name = "radNu";
            radNu.Size = new Size(50, 24);
            radNu.TabIndex = 30;
            radNu.TabStop = true;
            radNu.Text = "Nữ";
            radNu.UseVisualStyleBackColor = true;
            // 
            // radKhac
            // 
            radKhac.AutoSize = true;
            radKhac.ForeColor = SystemColors.ActiveCaptionText;
            radKhac.Location = new Point(353, 163);
            radKhac.Margin = new Padding(3, 4, 3, 4);
            radKhac.Name = "radKhac";
            radKhac.Size = new Size(62, 24);
            radKhac.TabIndex = 31;
            radKhac.TabStop = true;
            radKhac.Text = "Khác";
            radKhac.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(72, 21);
            label1.Name = "label1";
            label1.Size = new Size(375, 36);
            label1.TabIndex = 32;
            label1.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(25, 577);
            label2.Margin = new Padding(6, 7, 6, 7);
            label2.Name = "label2";
            label2.Size = new Size(115, 30);
            label2.TabIndex = 33;
            label2.Text = "Mật khẩu";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(185, 580);
            txtMatKhau.Margin = new Padding(3, 4, 3, 4);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(309, 27);
            txtMatKhau.TabIndex = 34;
            // 
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1299, 722);
            Controls.Add(txtMatKhau);
            Controls.Add(label2);
            Controls.Add(label1);
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
            ForeColor = SystemColors.InactiveCaptionText;
            MaximizeBox = false;
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
        private Label label1;
        private Label label2;
        private TextBox txtMatKhau;
    }
}