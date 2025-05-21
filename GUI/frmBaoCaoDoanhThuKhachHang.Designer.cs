namespace GUI
{
    partial class frmBaoCaoDoanhThuKhachHang
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
            btnXoa = new MaterialSkin.Controls.MaterialButton();
            dgBaoCaoDoanhThuKhachHang = new DataGridView();
            MaKH = new DataGridViewTextBoxColumn();
            TenKH = new DataGridViewTextBoxColumn();
            SDT = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            SoDonHang = new DataGridViewTextBoxColumn();
            TongDoanhThu = new DataGridViewTextBoxColumn();
            label2 = new Label();
            label1 = new Label();
            datDenNgay = new DateTimePicker();
            btnTimKiem = new MaterialSkin.Controls.MaterialButton();
            datTuNgay = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgBaoCaoDoanhThuKhachHang).BeginInit();
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
            btnXoa.Location = new Point(818, 55);
            btnXoa.Margin = new Padding(5);
            btnXoa.MouseState = MaterialSkin.MouseState.HOVER;
            btnXoa.Name = "btnXoa";
            btnXoa.NoAccentTextColor = Color.Empty;
            btnXoa.Size = new Size(137, 36);
            btnXoa.TabIndex = 73;
            btnXoa.Text = "In Danh sách";
            btnXoa.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnXoa.UseAccentColor = false;
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // dgBaoCaoDoanhThuKhachHang
            // 
            dgBaoCaoDoanhThuKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgBaoCaoDoanhThuKhachHang.Columns.AddRange(new DataGridViewColumn[] { MaKH, TenKH, SDT, DiaChi, Email, SoDonHang, TongDoanhThu });
            dgBaoCaoDoanhThuKhachHang.Location = new Point(36, 118);
            dgBaoCaoDoanhThuKhachHang.Name = "dgBaoCaoDoanhThuKhachHang";
            dgBaoCaoDoanhThuKhachHang.RowHeadersWidth = 51;
            dgBaoCaoDoanhThuKhachHang.Size = new Size(930, 491);
            dgBaoCaoDoanhThuKhachHang.TabIndex = 72;
            // 
            // MaKH
            // 
            MaKH.DataPropertyName = "MaKH";
            MaKH.HeaderText = "MaKH";
            MaKH.MinimumWidth = 6;
            MaKH.Name = "MaKH";
            MaKH.Width = 125;
            // 
            // TenKH
            // 
            TenKH.DataPropertyName = "TenKH";
            TenKH.HeaderText = "TenKH";
            TenKH.MinimumWidth = 6;
            TenKH.Name = "TenKH";
            TenKH.Width = 125;
            // 
            // SDT
            // 
            SDT.DataPropertyName = "SDT";
            SDT.HeaderText = "SDT";
            SDT.MinimumWidth = 6;
            SDT.Name = "SDT";
            SDT.Width = 125;
            // 
            // DiaChi
            // 
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.HeaderText = "Địa chỉ";
            DiaChi.MinimumWidth = 6;
            DiaChi.Name = "DiaChi";
            DiaChi.Width = 125;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.Width = 125;
            // 
            // SoDonHang
            // 
            SoDonHang.DataPropertyName = "SoDonHang";
            SoDonHang.HeaderText = "Số đơn hàng";
            SoDonHang.MinimumWidth = 6;
            SoDonHang.Name = "SoDonHang";
            SoDonHang.Width = 125;
            // 
            // TongDoanhThu
            // 
            TongDoanhThu.DataPropertyName = "TongDoanhThu";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            TongDoanhThu.DefaultCellStyle = dataGridViewCellStyle1;
            TongDoanhThu.HeaderText = "Tổng doanh thu";
            TongDoanhThu.MinimumWidth = 6;
            TongDoanhThu.Name = "TongDoanhThu";
            TongDoanhThu.Width = 125;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(373, 65);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 71;
            label2.Text = "Đến ngày";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 63);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 70;
            label1.Text = "Từ ngày";
            // 
            // datDenNgay
            // 
            datDenNgay.Format = DateTimePickerFormat.Custom;
            datDenNgay.Location = new Point(470, 60);
            datDenNgay.Margin = new Padding(3, 4, 3, 4);
            datDenNgay.Name = "datDenNgay";
            datDenNgay.Size = new Size(162, 27);
            datDenNgay.TabIndex = 69;
            // 
            // btnTimKiem
            // 
            btnTimKiem.AutoSize = false;
            btnTimKiem.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnTimKiem.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnTimKiem.Depth = 0;
            btnTimKiem.HighEmphasis = true;
            btnTimKiem.Icon = null;
            btnTimKiem.Location = new Point(701, 55);
            btnTimKiem.Margin = new Padding(5);
            btnTimKiem.MouseState = MaterialSkin.MouseState.HOVER;
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.NoAccentTextColor = Color.Empty;
            btnTimKiem.Size = new Size(93, 36);
            btnTimKiem.TabIndex = 68;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnTimKiem.UseAccentColor = false;
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // datTuNgay
            // 
            datTuNgay.Format = DateTimePickerFormat.Custom;
            datTuNgay.Location = new Point(143, 58);
            datTuNgay.Margin = new Padding(3, 4, 3, 4);
            datTuNgay.Name = "datTuNgay";
            datTuNgay.Size = new Size(162, 27);
            datTuNgay.TabIndex = 67;
            // 
            // frmBaoCaoDoanhThuKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(994, 679);
            Controls.Add(btnXoa);
            Controls.Add(dgBaoCaoDoanhThuKhachHang);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(datDenNgay);
            Controls.Add(btnTimKiem);
            Controls.Add(datTuNgay);
            Name = "frmBaoCaoDoanhThuKhachHang";
            Text = "Doanh thu theo khách hàng";
            ((System.ComponentModel.ISupportInitialize)dgBaoCaoDoanhThuKhachHang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnXoa;
        private DataGridView dgBaoCaoDoanhThuKhachHang;
        private Label label2;
        private Label label1;
        private DateTimePicker datDenNgay;
        private MaterialSkin.Controls.MaterialButton btnTimKiem;
        private DateTimePicker datTuNgay;
        private DataGridViewTextBoxColumn MaKH;
        private DataGridViewTextBoxColumn TenKH;
        private DataGridViewTextBoxColumn SDT;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn SoDonHang;
        private DataGridViewTextBoxColumn TongDoanhThu;
    }
}