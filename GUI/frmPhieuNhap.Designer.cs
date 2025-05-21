namespace GUI
{
    partial class frmPhieuNhap
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            txtDonVi = new TextBox();
            lbl = new Label();
            comSanPham = new ComboBox();
            btnXoa = new MaterialSkin.Controls.MaterialButton();
            txtMaSP = new TextBox();
            label2 = new Label();
            numSoLuong = new NumericUpDown();
            lblSoLuong = new Label();
            numDonGia = new NumericUpDown();
            btnUpdate = new MaterialSkin.Controls.MaterialButton();
            btnAdd = new MaterialSkin.Controls.MaterialButton();
            lblDonGia = new Label();
            numThanhTien = new NumericUpDown();
            lblThanhTien = new Label();
            lblMaSP = new Label();
            dataGridViewChiTietPhieuNhap = new DataGridView();
            txtTongTien = new Label();
            lblTongTienBangChu = new Label();
            btnTaoDonHang = new MaterialSkin.Controls.MaterialButton();
            lblTongTien = new Label();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDonGia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numThanhTien).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewChiTietPhieuNhap).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(544, 12);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 0;
            label1.Text = "PHIẾU NHẬP";
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(23, 49);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1316, 213);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtDonVi);
            groupBox2.Controls.Add(lbl);
            groupBox2.Controls.Add(comSanPham);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(txtMaSP);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(numSoLuong);
            groupBox2.Controls.Add(lblSoLuong);
            groupBox2.Controls.Add(numDonGia);
            groupBox2.Controls.Add(btnUpdate);
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Controls.Add(lblDonGia);
            groupBox2.Controls.Add(numThanhTien);
            groupBox2.Controls.Add(lblThanhTien);
            groupBox2.Controls.Add(lblMaSP);
            groupBox2.Controls.Add(dataGridViewChiTietPhieuNhap);
            groupBox2.Location = new Point(23, 268);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1316, 424);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // txtDonVi
            // 
            txtDonVi.Location = new Point(1093, 29);
            txtDonVi.Margin = new Padding(3, 4, 3, 4);
            txtDonVi.Name = "txtDonVi";
            txtDonVi.ReadOnly = true;
            txtDonVi.Size = new Size(150, 27);
            txtDonVi.TabIndex = 85;
            // 
            // lbl
            // 
            lbl.BorderStyle = BorderStyle.FixedSingle;
            lbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl.ForeColor = SystemColors.ActiveCaptionText;
            lbl.Location = new Point(1014, 28);
            lbl.Margin = new Padding(6, 7, 6, 7);
            lbl.Name = "lbl";
            lbl.Size = new Size(70, 30);
            lbl.TabIndex = 84;
            lbl.Text = "DVT";
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comSanPham
            // 
            comSanPham.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comSanPham.FormattingEnabled = true;
            comSanPham.Location = new Point(218, 30);
            comSanPham.Name = "comSanPham";
            comSanPham.Size = new Size(488, 26);
            comSanPham.TabIndex = 83;
            comSanPham.SelectedIndexChanged += comSanPham_SelectedIndexChanged;
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
            btnXoa.Location = new Point(550, 115);
            btnXoa.Margin = new Padding(5);
            btnXoa.MouseState = MaterialSkin.MouseState.HOVER;
            btnXoa.Name = "btnXoa";
            btnXoa.NoAccentTextColor = Color.Empty;
            btnXoa.Size = new Size(90, 36);
            btnXoa.TabIndex = 82;
            btnXoa.Text = "Xóa";
            btnXoa.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnXoa.UseAccentColor = false;
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(837, 30);
            txtMaSP.Margin = new Padding(3, 4, 3, 4);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.ReadOnly = true;
            txtMaSP.Size = new Size(150, 27);
            txtMaSP.TabIndex = 81;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(758, 29);
            label2.Margin = new Padding(6, 7, 6, 7);
            label2.Name = "label2";
            label2.Size = new Size(70, 30);
            label2.TabIndex = 80;
            label2.Text = "Mã ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(218, 74);
            numSoLuong.Margin = new Padding(2, 3, 2, 3);
            numSoLuong.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numSoLuong.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(162, 27);
            numSoLuong.TabIndex = 79;
            numSoLuong.TextAlign = HorizontalAlignment.Right;
            numSoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblSoLuong
            // 
            lblSoLuong.BorderStyle = BorderStyle.FixedSingle;
            lblSoLuong.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSoLuong.ForeColor = SystemColors.ActiveCaptionText;
            lblSoLuong.Location = new Point(34, 74);
            lblSoLuong.Margin = new Padding(6, 7, 6, 7);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(140, 30);
            lblSoLuong.TabIndex = 78;
            lblSoLuong.Text = "Số lượng";
            lblSoLuong.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numDonGia
            // 
            numDonGia.Location = new Point(518, 71);
            numDonGia.Margin = new Padding(2, 3, 2, 3);
            numDonGia.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numDonGia.Name = "numDonGia";
            numDonGia.Size = new Size(188, 27);
            numDonGia.TabIndex = 77;
            numDonGia.TextAlign = HorizontalAlignment.Right;
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
            btnUpdate.Location = new Point(389, 115);
            btnUpdate.Margin = new Padding(5);
            btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            btnUpdate.Name = "btnUpdate";
            btnUpdate.NoAccentTextColor = Color.Empty;
            btnUpdate.Size = new Size(90, 36);
            btnUpdate.TabIndex = 71;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnUpdate.UseAccentColor = false;
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.AutoSize = false;
            btnAdd.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAdd.Depth = 0;
            btnAdd.HighEmphasis = true;
            btnAdd.Icon = null;
            btnAdd.Location = new Point(221, 115);
            btnAdd.Margin = new Padding(5);
            btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            btnAdd.Name = "btnAdd";
            btnAdd.NoAccentTextColor = Color.Empty;
            btnAdd.Size = new Size(93, 36);
            btnAdd.TabIndex = 70;
            btnAdd.Text = "Thêm";
            btnAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAdd.UseAccentColor = false;
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // lblDonGia
            // 
            lblDonGia.BorderStyle = BorderStyle.FixedSingle;
            lblDonGia.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDonGia.ForeColor = SystemColors.ActiveCaptionText;
            lblDonGia.Location = new Point(404, 71);
            lblDonGia.Margin = new Padding(6, 7, 6, 7);
            lblDonGia.Name = "lblDonGia";
            lblDonGia.Size = new Size(94, 30);
            lblDonGia.TabIndex = 76;
            lblDonGia.Text = "Đơn giá";
            lblDonGia.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numThanhTien
            // 
            numThanhTien.Location = new Point(945, 71);
            numThanhTien.Margin = new Padding(2, 3, 2, 3);
            numThanhTien.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numThanhTien.Name = "numThanhTien";
            numThanhTien.Size = new Size(311, 27);
            numThanhTien.TabIndex = 75;
            numThanhTien.TextAlign = HorizontalAlignment.Right;
            // 
            // lblThanhTien
            // 
            lblThanhTien.BorderStyle = BorderStyle.FixedSingle;
            lblThanhTien.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblThanhTien.ForeColor = SystemColors.ActiveCaptionText;
            lblThanhTien.Location = new Point(758, 71);
            lblThanhTien.Margin = new Padding(6, 7, 6, 7);
            lblThanhTien.Name = "lblThanhTien";
            lblThanhTien.Size = new Size(140, 30);
            lblThanhTien.TabIndex = 74;
            lblThanhTien.Text = "Thành tiền";
            lblThanhTien.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMaSP
            // 
            lblMaSP.BorderStyle = BorderStyle.FixedSingle;
            lblMaSP.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMaSP.ForeColor = SystemColors.ActiveCaptionText;
            lblMaSP.Location = new Point(34, 30);
            lblMaSP.Margin = new Padding(6, 7, 6, 7);
            lblMaSP.Name = "lblMaSP";
            lblMaSP.Size = new Size(140, 30);
            lblMaSP.TabIndex = 73;
            lblMaSP.Text = "Sản phẩm";
            lblMaSP.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridViewChiTietPhieuNhap
            // 
            dataGridViewChiTietPhieuNhap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewChiTietPhieuNhap.Location = new Point(31, 159);
            dataGridViewChiTietPhieuNhap.Name = "dataGridViewChiTietPhieuNhap";
            dataGridViewChiTietPhieuNhap.RowHeadersWidth = 51;
            dataGridViewChiTietPhieuNhap.Size = new Size(1225, 243);
            dataGridViewChiTietPhieuNhap.TabIndex = 72;
            // 
            // txtTongTien
            // 
            txtTongTien.AutoSize = true;
            txtTongTien.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTongTien.ForeColor = Color.Black;
            txtTongTien.Location = new Point(654, 707);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(14, 20);
            txtTongTien.TabIndex = 69;
            txtTongTien.Text = ".";
            // 
            // lblTongTienBangChu
            // 
            lblTongTienBangChu.AutoSize = true;
            lblTongTienBangChu.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTongTienBangChu.ForeColor = Color.Black;
            lblTongTienBangChu.Location = new Point(790, 707);
            lblTongTienBangChu.Name = "lblTongTienBangChu";
            lblTongTienBangChu.Size = new Size(19, 20);
            lblTongTienBangChu.TabIndex = 68;
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
            btnTaoDonHang.Location = new Point(1150, 734);
            btnTaoDonHang.Margin = new Padding(5);
            btnTaoDonHang.MouseState = MaterialSkin.MouseState.HOVER;
            btnTaoDonHang.Name = "btnTaoDonHang";
            btnTaoDonHang.NoAccentTextColor = Color.Empty;
            btnTaoDonHang.Size = new Size(184, 39);
            btnTaoDonHang.TabIndex = 67;
            btnTaoDonHang.Text = "Tạo đơn hàng";
            btnTaoDonHang.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnTaoDonHang.UseAccentColor = false;
            btnTaoDonHang.UseVisualStyleBackColor = true;
            // 
            // lblTongTien
            // 
            lblTongTien.BorderStyle = BorderStyle.FixedSingle;
            lblTongTien.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTongTien.ForeColor = SystemColors.ActiveCaptionText;
            lblTongTien.Location = new Point(541, 702);
            lblTongTien.Margin = new Padding(6, 7, 6, 7);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(81, 30);
            lblTongTien.TabIndex = 66;
            lblTongTien.Text = "Tổng Tiền";
            lblTongTien.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmPhieuNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1433, 780);
            Controls.Add(txtTongTien);
            Controls.Add(lblTongTienBangChu);
            Controls.Add(btnTaoDonHang);
            Controls.Add(lblTongTien);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "frmPhieuNhap";
            Text = "frmPhieuNhap";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDonGia).EndInit();
            ((System.ComponentModel.ISupportInitialize)numThanhTien).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewChiTietPhieuNhap).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtDonVi;
        private Label lbl;
        private ComboBox comSanPham;
        private MaterialSkin.Controls.MaterialButton btnXoa;
        private TextBox txtMaSP;
        private Label label2;
        private NumericUpDown numSoLuong;
        private Label lblSoLuong;
        private NumericUpDown numDonGia;
        private MaterialSkin.Controls.MaterialButton btnUpdate;
        private MaterialSkin.Controls.MaterialButton btnAdd;
        private Label lblDonGia;
        private NumericUpDown numThanhTien;
        private Label lblThanhTien;
        private Label lblMaSP;
        private DataGridView dataGridViewChiTietPhieuNhap;
        private Label txtTongTien;
        private Label lblTongTienBangChu;
        private MaterialSkin.Controls.MaterialButton btnTaoDonHang;
        private Label lblTongTien;
    }
}