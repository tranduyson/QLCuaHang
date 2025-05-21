namespace GUI
{
    partial class frmBaoCaoTonKho
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            dgTonKho = new DataGridView();
            MaSP = new DataGridViewTextBoxColumn();
            TenSP = new DataGridViewTextBoxColumn();
            DonVi = new DataGridViewTextBoxColumn();
            GiaNhap = new DataGridViewTextBoxColumn();
            GiaBan = new DataGridViewTextBoxColumn();
            GiaTriTonKho = new DataGridViewTextBoxColumn();
            TrangThai = new DataGridViewTextBoxColumn();
            TonKho = new DataGridViewTextBoxColumn();
            comSanPham = new ComboBox();
            lblSanPham = new Label();
            btnInDanhSach = new MaterialSkin.Controls.MaterialButton();
            btnTimKiem = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)dgTonKho).BeginInit();
            SuspendLayout();
            // 
            // dgTonKho
            // 
            dgTonKho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgTonKho.Columns.AddRange(new DataGridViewColumn[] { MaSP, TenSP, DonVi, GiaNhap, GiaBan, GiaTriTonKho, TrangThai, TonKho });
            dgTonKho.Location = new Point(41, 116);
            dgTonKho.Name = "dgTonKho";
            dgTonKho.RowHeadersWidth = 51;
            dgTonKho.Size = new Size(1054, 491);
            dgTonKho.TabIndex = 80;
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
            // GiaNhap
            // 
            GiaNhap.DataPropertyName = "GiaNhap";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            GiaNhap.DefaultCellStyle = dataGridViewCellStyle2;
            GiaNhap.HeaderText = "Giá nhập";
            GiaNhap.MinimumWidth = 6;
            GiaNhap.Name = "GiaNhap";
            GiaNhap.Width = 125;
            // 
            // GiaBan
            // 
            GiaBan.DataPropertyName = "GiaBan";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            GiaBan.DefaultCellStyle = dataGridViewCellStyle3;
            GiaBan.HeaderText = "Giá bán";
            GiaBan.MinimumWidth = 6;
            GiaBan.Name = "GiaBan";
            GiaBan.Width = 125;
            // 
            // GiaTriTonKho
            // 
            GiaTriTonKho.DataPropertyName = "GiaTriTonKho";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            GiaTriTonKho.DefaultCellStyle = dataGridViewCellStyle4;
            GiaTriTonKho.HeaderText = "Giá trị tồn";
            GiaTriTonKho.MinimumWidth = 6;
            GiaTriTonKho.Name = "GiaTriTonKho";
            GiaTriTonKho.Width = 125;
            // 
            // TrangThai
            // 
            TrangThai.DataPropertyName = "TrangThai";
            TrangThai.HeaderText = "Trạng thái";
            TrangThai.MinimumWidth = 6;
            TrangThai.Name = "TrangThai";
            TrangThai.Width = 125;
            // 
            // TonKho
            // 
            TonKho.DataPropertyName = "TonKho";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            TonKho.DefaultCellStyle = dataGridViewCellStyle5;
            TonKho.HeaderText = "Tồn kho";
            TonKho.MinimumWidth = 6;
            TonKho.Name = "TonKho";
            TonKho.Width = 125;
            // 
            // comSanPham
            // 
            comSanPham.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comSanPham.FormattingEnabled = true;
            comSanPham.Location = new Point(278, 58);
            comSanPham.Name = "comSanPham";
            comSanPham.Size = new Size(417, 26);
            comSanPham.TabIndex = 83;
            // 
            // lblSanPham
            // 
            lblSanPham.BorderStyle = BorderStyle.FixedSingle;
            lblSanPham.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSanPham.ForeColor = SystemColors.ActiveCaptionText;
            lblSanPham.Location = new Point(90, 54);
            lblSanPham.Margin = new Padding(6, 7, 6, 7);
            lblSanPham.Name = "lblSanPham";
            lblSanPham.Size = new Size(140, 30);
            lblSanPham.TabIndex = 82;
            lblSanPham.Text = "Sản phẩm";
            lblSanPham.TextAlign = ContentAlignment.MiddleCenter;
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
            btnInDanhSach.Location = new Point(855, 52);
            btnInDanhSach.Margin = new Padding(5);
            btnInDanhSach.MouseState = MaterialSkin.MouseState.HOVER;
            btnInDanhSach.Name = "btnInDanhSach";
            btnInDanhSach.NoAccentTextColor = Color.Empty;
            btnInDanhSach.Size = new Size(137, 36);
            btnInDanhSach.TabIndex = 85;
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
            btnTimKiem.Location = new Point(738, 52);
            btnTimKiem.Margin = new Padding(5);
            btnTimKiem.MouseState = MaterialSkin.MouseState.HOVER;
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.NoAccentTextColor = Color.Empty;
            btnTimKiem.Size = new Size(93, 36);
            btnTimKiem.TabIndex = 84;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnTimKiem.UseAccentColor = false;
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // frmBaoCaoTonKho
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1140, 679);
            Controls.Add(btnInDanhSach);
            Controls.Add(btnTimKiem);
            Controls.Add(comSanPham);
            Controls.Add(lblSanPham);
            Controls.Add(dgTonKho);
            Name = "frmBaoCaoTonKho";
            Text = "Tồn kho sản phẩm";
            ((System.ComponentModel.ISupportInitialize)dgTonKho).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgTonKho;
        private ComboBox comSanPham;
        private Label lblSanPham;
        private MaterialSkin.Controls.MaterialButton btnInDanhSach;
        private MaterialSkin.Controls.MaterialButton btnTimKiem;
        private DataGridViewTextBoxColumn MaSP;
        private DataGridViewTextBoxColumn TenSP;
        private DataGridViewTextBoxColumn DonVi;
        private DataGridViewTextBoxColumn GiaNhap;
        private DataGridViewTextBoxColumn GiaBan;
        private DataGridViewTextBoxColumn GiaTriTonKho;
        private DataGridViewTextBoxColumn TrangThai;
        private DataGridViewTextBoxColumn TonKho;
    }
}