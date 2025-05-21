namespace GUI
{
    partial class frmBaoCaoSanPhamBanChay
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            btnXoa = new MaterialSkin.Controls.MaterialButton();
            dgBaoCaoSanPhamBanChay = new DataGridView();
            MaSP = new DataGridViewTextBoxColumn();
            TenSP = new DataGridViewTextBoxColumn();
            DonVi = new DataGridViewTextBoxColumn();
            TongSoLuong = new DataGridViewTextBoxColumn();
            TongDoanhThu = new DataGridViewTextBoxColumn();
            GiaBan = new DataGridViewTextBoxColumn();
            TonKho = new DataGridViewTextBoxColumn();
            label2 = new Label();
            label1 = new Label();
            datDenNgay = new DateTimePicker();
            btnTimKiem = new MaterialSkin.Controls.MaterialButton();
            datTuNgay = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgBaoCaoSanPhamBanChay).BeginInit();
            SuspendLayout();
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
            btnXoa.Location = new Point(806, 61);
            btnXoa.Margin = new Padding(5);
            btnXoa.MouseState = MaterialSkin.MouseState.HOVER;
            btnXoa.Name = "btnXoa";
            btnXoa.NoAccentTextColor = Color.Empty;
            btnXoa.Size = new Size(137, 36);
            btnXoa.TabIndex = 80;
            btnXoa.Text = "In Danh sách";
            btnXoa.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnXoa.UseAccentColor = false;
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // dgBaoCaoSanPhamBanChay
            // 
            dgBaoCaoSanPhamBanChay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgBaoCaoSanPhamBanChay.Columns.AddRange(new DataGridViewColumn[] { MaSP, TenSP, DonVi, TongSoLuong, TongDoanhThu, GiaBan, TonKho });
            dgBaoCaoSanPhamBanChay.Location = new Point(32, 127);
            dgBaoCaoSanPhamBanChay.Name = "dgBaoCaoSanPhamBanChay";
            dgBaoCaoSanPhamBanChay.RowHeadersWidth = 51;
            dgBaoCaoSanPhamBanChay.Size = new Size(953, 491);
            dgBaoCaoSanPhamBanChay.TabIndex = 79;
            // 
            // MaSP
            // 
            MaSP.DataPropertyName = "MaSP";
            MaSP.HeaderText = "MaSP";
            MaSP.MinimumWidth = 6;
            MaSP.Name = "MaSP";
            MaSP.Width = 125;
            // 
            // TenSP
            // 
            TenSP.DataPropertyName = "TenSP";
            TenSP.HeaderText = "Tên SP";
            TenSP.MinimumWidth = 6;
            TenSP.Name = "TenSP";
            TenSP.Width = 125;
            // 
            // DonVi
            // 
            DonVi.DataPropertyName = "DonVi";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            DonVi.DefaultCellStyle = dataGridViewCellStyle1;
            DonVi.HeaderText = "Đơn vị";
            DonVi.MinimumWidth = 6;
            DonVi.Name = "DonVi";
            DonVi.Width = 125;
            // 
            // TongSoLuong
            // 
            TongSoLuong.DataPropertyName = "TongSoLuong";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            TongSoLuong.DefaultCellStyle = dataGridViewCellStyle2;
            TongSoLuong.HeaderText = "Tổng số lượng";
            TongSoLuong.MinimumWidth = 6;
            TongSoLuong.Name = "TongSoLuong";
            TongSoLuong.Width = 125;
            // 
            // TongDoanhThu
            // 
            TongDoanhThu.DataPropertyName = "TongDoanhThu";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            TongDoanhThu.DefaultCellStyle = dataGridViewCellStyle3;
            TongDoanhThu.HeaderText = "Tổng doanh thu";
            TongDoanhThu.MinimumWidth = 6;
            TongDoanhThu.Name = "TongDoanhThu";
            TongDoanhThu.Width = 125;
            // 
            // GiaBan
            // 
            GiaBan.DataPropertyName = "GiaBan";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            GiaBan.DefaultCellStyle = dataGridViewCellStyle4;
            GiaBan.HeaderText = "Giá bán";
            GiaBan.MinimumWidth = 6;
            GiaBan.Name = "GiaBan";
            GiaBan.Width = 125;
            // 
            // TonKho
            // 
            TonKho.DataPropertyName = "TonKho";
            TonKho.HeaderText = "Tồn kho";
            TonKho.MinimumWidth = 6;
            TonKho.Name = "TonKho";
            TonKho.Width = 125;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(379, 72);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 78;
            label2.Text = "Đến ngày";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 77);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 77;
            label1.Text = "Từ ngày";
            // 
            // datDenNgay
            // 
            datDenNgay.Format = DateTimePickerFormat.Custom;
            datDenNgay.Location = new Point(483, 67);
            datDenNgay.Margin = new Padding(3, 4, 3, 4);
            datDenNgay.Name = "datDenNgay";
            datDenNgay.Size = new Size(162, 27);
            datDenNgay.TabIndex = 76;
            // 
            // btnTimKiem
            // 
            btnTimKiem.AutoSize = false;
            btnTimKiem.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnTimKiem.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnTimKiem.Depth = 0;
            btnTimKiem.HighEmphasis = true;
            btnTimKiem.Icon = null;
            btnTimKiem.Location = new Point(689, 61);
            btnTimKiem.Margin = new Padding(5);
            btnTimKiem.MouseState = MaterialSkin.MouseState.HOVER;
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.NoAccentTextColor = Color.Empty;
            btnTimKiem.Size = new Size(93, 36);
            btnTimKiem.TabIndex = 75;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnTimKiem.UseAccentColor = false;
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click_1;
            // 
            // datTuNgay
            // 
            datTuNgay.Format = DateTimePickerFormat.Custom;
            datTuNgay.Location = new Point(141, 72);
            datTuNgay.Margin = new Padding(3, 4, 3, 4);
            datTuNgay.Name = "datTuNgay";
            datTuNgay.Size = new Size(162, 27);
            datTuNgay.TabIndex = 74;
            // 
            // frmBaoCaoSanPhamBanChay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1079, 679);
            Controls.Add(btnXoa);
            Controls.Add(dgBaoCaoSanPhamBanChay);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(datDenNgay);
            Controls.Add(btnTimKiem);
            Controls.Add(datTuNgay);
            Name = "frmBaoCaoSanPhamBanChay";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Sản phẩm bán chạy";
            ((System.ComponentModel.ISupportInitialize)dgBaoCaoSanPhamBanChay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnXoa;
        private DataGridView dgBaoCaoSanPhamBanChay;
        private DataGridViewTextBoxColumn MaSP;
        private DataGridViewTextBoxColumn TenSP;
        private DataGridViewTextBoxColumn DonVi;
        private DataGridViewTextBoxColumn TongSoLuong;
        private DataGridViewTextBoxColumn TongDoanhThu;
        private DataGridViewTextBoxColumn GiaBan;
        private DataGridViewTextBoxColumn TonKho;
        private Label label2;
        private Label label1;
        private DateTimePicker datDenNgay;
        private MaterialSkin.Controls.MaterialButton btnTimKiem;
        private DateTimePicker datTuNgay;
    }
}