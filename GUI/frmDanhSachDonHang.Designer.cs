namespace GUI
{
    partial class frmDanhSachDonHang
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
            dataGridViewDSDonHang = new DataGridView();
            groupBox1 = new GroupBox();
            lblMaHD = new Label();
            txtMaHD = new TextBox();
            btnTimKiem = new MaterialSkin.Controls.MaterialButton();
            comKhachHang = new ComboBox();
            lblKhachHang = new Label();
            lblDenNgay = new Label();
            datDenNgay = new DateTimePicker();
            comHoTen = new ComboBox();
            lblTuNgay = new Label();
            datTuNgay = new DateTimePicker();
            lblHoTen = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDSDonHang).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewDSDonHang
            // 
            dataGridViewDSDonHang.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewDSDonHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDSDonHang.Location = new Point(107, 236);
            dataGridViewDSDonHang.Name = "dataGridViewDSDonHang";
            dataGridViewDSDonHang.RowHeadersWidth = 51;
            dataGridViewDSDonHang.Size = new Size(1275, 504);
            dataGridViewDSDonHang.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblMaHD);
            groupBox1.Controls.Add(txtMaHD);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(comKhachHang);
            groupBox1.Controls.Add(lblKhachHang);
            groupBox1.Controls.Add(lblDenNgay);
            groupBox1.Controls.Add(datDenNgay);
            groupBox1.Controls.Add(comHoTen);
            groupBox1.Controls.Add(lblTuNgay);
            groupBox1.Controls.Add(datTuNgay);
            groupBox1.Controls.Add(lblHoTen);
            groupBox1.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Red;
            groupBox1.Location = new Point(107, 88);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1275, 142);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm hóa đơn";
            // 
            // lblMaHD
            // 
            lblMaHD.BorderStyle = BorderStyle.FixedSingle;
            lblMaHD.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMaHD.ForeColor = SystemColors.ActiveCaptionText;
            lblMaHD.Location = new Point(651, 38);
            lblMaHD.Margin = new Padding(6, 7, 6, 7);
            lblMaHD.Name = "lblMaHD";
            lblMaHD.Size = new Size(129, 30);
            lblMaHD.TabIndex = 73;
            lblMaHD.Text = "Mã hóa đơn";
            lblMaHD.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtMaHD
            // 
            txtMaHD.Location = new Point(806, 37);
            txtMaHD.Name = "txtMaHD";
            txtMaHD.Size = new Size(299, 27);
            txtMaHD.TabIndex = 72;
            // 
            // btnTimKiem
            // 
            btnTimKiem.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnTimKiem.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnTimKiem.Depth = 0;
            btnTimKiem.HighEmphasis = true;
            btnTimKiem.Icon = null;
            btnTimKiem.Location = new Point(1135, 81);
            btnTimKiem.Margin = new Padding(4, 6, 4, 6);
            btnTimKiem.MouseState = MaterialSkin.MouseState.HOVER;
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.NoAccentTextColor = Color.Empty;
            btnTimKiem.Size = new Size(86, 36);
            btnTimKiem.TabIndex = 71;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnTimKiem.UseAccentColor = false;
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // comKhachHang
            // 
            comKhachHang.DisplayMember = "TenKH";
            comKhachHang.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comKhachHang.FormattingEnabled = true;
            comKhachHang.Location = new Point(651, 87);
            comKhachHang.Name = "comKhachHang";
            comKhachHang.Size = new Size(454, 26);
            comKhachHang.TabIndex = 69;
            comKhachHang.ValueMember = "MaKH";
            // 
            // lblKhachHang
            // 
            lblKhachHang.BorderStyle = BorderStyle.FixedSingle;
            lblKhachHang.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblKhachHang.ForeColor = SystemColors.ActiveCaptionText;
            lblKhachHang.Location = new Point(513, 83);
            lblKhachHang.Margin = new Padding(6, 7, 6, 7);
            lblKhachHang.Name = "lblKhachHang";
            lblKhachHang.Size = new Size(129, 30);
            lblKhachHang.TabIndex = 70;
            lblKhachHang.Text = "Khách hàng";
            lblKhachHang.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDenNgay
            // 
            lblDenNgay.BorderStyle = BorderStyle.FixedSingle;
            lblDenNgay.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDenNgay.ForeColor = SystemColors.ActiveCaptionText;
            lblDenNgay.Location = new Point(364, 34);
            lblDenNgay.Margin = new Padding(6, 7, 6, 7);
            lblDenNgay.Name = "lblDenNgay";
            lblDenNgay.Size = new Size(140, 31);
            lblDenNgay.TabIndex = 68;
            lblDenNgay.Text = "Đến ngày";
            lblDenNgay.TextAlign = ContentAlignment.MiddleCenter;
            lblDenNgay.Click += label1_Click;
            // 
            // datDenNgay
            // 
            datDenNgay.Format = DateTimePickerFormat.Custom;
            datDenNgay.Location = new Point(513, 38);
            datDenNgay.Margin = new Padding(3, 4, 3, 4);
            datDenNgay.Name = "datDenNgay";
            datDenNgay.Size = new Size(129, 27);
            datDenNgay.TabIndex = 67;
            // 
            // comHoTen
            // 
            comHoTen.DisplayMember = "HoTen";
            comHoTen.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comHoTen.FormattingEnabled = true;
            comHoTen.Location = new Point(184, 89);
            comHoTen.Name = "comHoTen";
            comHoTen.Size = new Size(320, 26);
            comHoTen.TabIndex = 6;
            comHoTen.ValueMember = "MaNV";
            // 
            // lblTuNgay
            // 
            lblTuNgay.BorderStyle = BorderStyle.FixedSingle;
            lblTuNgay.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTuNgay.ForeColor = SystemColors.ActiveCaptionText;
            lblTuNgay.Location = new Point(35, 34);
            lblTuNgay.Margin = new Padding(6, 7, 6, 7);
            lblTuNgay.Name = "lblTuNgay";
            lblTuNgay.Size = new Size(140, 30);
            lblTuNgay.TabIndex = 46;
            lblTuNgay.Text = "Từ Ngày";
            lblTuNgay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // datTuNgay
            // 
            datTuNgay.Format = DateTimePickerFormat.Custom;
            datTuNgay.Location = new Point(184, 38);
            datTuNgay.Margin = new Padding(3, 4, 3, 4);
            datTuNgay.Name = "datTuNgay";
            datTuNgay.Size = new Size(162, 27);
            datTuNgay.TabIndex = 5;
            // 
            // lblHoTen
            // 
            lblHoTen.BorderStyle = BorderStyle.FixedSingle;
            lblHoTen.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblHoTen.ForeColor = SystemColors.ActiveCaptionText;
            lblHoTen.Location = new Point(35, 85);
            lblHoTen.Margin = new Padding(6, 7, 6, 7);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(140, 30);
            lblHoTen.TabIndex = 50;
            lblHoTen.Text = "Nhân Viên";
            lblHoTen.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(511, 39);
            label1.Name = "label1";
            label1.Size = new Size(486, 41);
            label1.TabIndex = 6;
            label1.Text = "QUẢN LÝ DANH SÁCH HÓA ĐƠN";
            label1.Click += label1_Click_1;
            // 
            // frmDanhSachDonHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1468, 772);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(dataGridViewDSDonHang);
            ForeColor = Color.Red;
            Name = "frmDanhSachDonHang";
            Text = "frmDanhSachDonHang";
            ((System.ComponentModel.ISupportInitialize)dataGridViewDSDonHang).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewDSDonHang;
        private GroupBox groupBox1;
        private ComboBox comHoTen;
        private Label lblTuNgay;
        private DateTimePicker datTuNgay;
        private Label lblHoTen;
        private Label lblDenNgay;
        private DateTimePicker datDenNgay;
        private MaterialSkin.Controls.MaterialButton btnTimKiem;
        private ComboBox comKhachHang;
        private Label lblKhachHang;
        private Label label1;
        private Label lblMaHD;
        private TextBox txtMaHD;
    }
}