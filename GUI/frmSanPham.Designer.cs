namespace GUI
{
    partial class frmSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSanPham));
            btnLamMoi = new MaterialSkin.Controls.MaterialButton();
            btnDelete = new MaterialSkin.Controls.MaterialButton();
            btnUpdate = new MaterialSkin.Controls.MaterialButton();
            btnAdd = new MaterialSkin.Controls.MaterialButton();
            txtTimKiem = new MaterialSkin.Controls.MaterialTextBox();
            btnTimKiem = new MaterialSkin.Controls.MaterialButton();
            dataGridViewSanPham = new DataGridView();
            txtMaSP = new TextBox();
            lblMaSP = new Label();
            txtTenSP = new TextBox();
            lblTenSP = new Label();
            txtDonVi = new TextBox();
            lblDonVi = new Label();
            numGiaNhap = new NumericUpDown();
            lblGiaNhap = new Label();
            numGiaBan = new NumericUpDown();
            lblGiaBan = new Label();
            numTonKho = new NumericUpDown();
            lblTonKho = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSanPham).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numGiaNhap).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numGiaBan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numTonKho).BeginInit();
            SuspendLayout();
            // 
            // btnLamMoi
            // 
            btnLamMoi.AutoSize = false;
            btnLamMoi.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLamMoi.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            btnLamMoi.Depth = 0;
            btnLamMoi.HighEmphasis = true;
            btnLamMoi.Icon = null;
            btnLamMoi.Location = new Point(626, 101);
            btnLamMoi.Margin = new Padding(5);
            btnLamMoi.MouseState = MaterialSkin.MouseState.HOVER;
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.NoAccentTextColor = Color.Empty;
            btnLamMoi.Size = new Size(106, 43);
            btnLamMoi.TabIndex = 31;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnLamMoi.UseAccentColor = false;
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
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
            btnDelete.Location = new Point(471, 516);
            btnDelete.Margin = new Padding(5);
            btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            btnDelete.Name = "btnDelete";
            btnDelete.NoAccentTextColor = Color.Empty;
            btnDelete.Size = new Size(91, 44);
            btnDelete.TabIndex = 30;
            btnDelete.Text = "Xóa";
            btnDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnDelete.UseAccentColor = true;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.AutoSize = false;
            btnUpdate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUpdate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnUpdate.Depth = 0;
            btnUpdate.HighEmphasis = true;
            btnUpdate.Icon = null;
            btnUpdate.Location = new Point(316, 516);
            btnUpdate.Margin = new Padding(5);
            btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            btnUpdate.Name = "btnUpdate";
            btnUpdate.NoAccentTextColor = Color.Empty;
            btnUpdate.Size = new Size(87, 44);
            btnUpdate.TabIndex = 29;
            btnUpdate.Text = "Sửa";
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
            btnAdd.Location = new Point(161, 516);
            btnAdd.Margin = new Padding(5);
            btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            btnAdd.Name = "btnAdd";
            btnAdd.NoAccentTextColor = Color.Empty;
            btnAdd.Size = new Size(90, 44);
            btnAdd.TabIndex = 28;
            btnAdd.Text = "Thêm";
            btnAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAdd.UseAccentColor = false;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.AnimateReadOnly = false;
            txtTimKiem.BorderStyle = BorderStyle.None;
            txtTimKiem.Depth = 0;
            txtTimKiem.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTimKiem.LeadingIcon = null;
            txtTimKiem.Location = new Point(740, 101);
            txtTimKiem.MaxLength = 50;
            txtTimKiem.MouseState = MaterialSkin.MouseState.OUT;
            txtTimKiem.Multiline = false;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(517, 50);
            txtTimKiem.TabIndex = 27;
            txtTimKiem.Text = "";
            txtTimKiem.TrailingIcon = null;
            // 
            // btnTimKiem
            // 
            btnTimKiem.AutoSize = false;
            btnTimKiem.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnTimKiem.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            btnTimKiem.Depth = 0;
            btnTimKiem.HighEmphasis = true;
            btnTimKiem.Icon = null;
            btnTimKiem.Location = new Point(1279, 101);
            btnTimKiem.Margin = new Padding(5);
            btnTimKiem.MouseState = MaterialSkin.MouseState.HOVER;
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.NoAccentTextColor = Color.Empty;
            btnTimKiem.Size = new Size(98, 43);
            btnTimKiem.TabIndex = 26;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnTimKiem.UseAccentColor = false;
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // dataGridViewSanPham
            // 
            dataGridViewSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSanPham.Location = new Point(626, 180);
            dataGridViewSanPham.Name = "dataGridViewSanPham";
            dataGridViewSanPham.RowHeadersWidth = 51;
            dataGridViewSanPham.Size = new Size(751, 434);
            dataGridViewSanPham.TabIndex = 25;
            dataGridViewSanPham.CellContentClick += dataGridViewSanPham_CellContentClick;
            dataGridViewSanPham.SelectionChanged += dataGridViewSanPham_SelectionChanged;
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(297, 145);
            txtMaSP.Margin = new Padding(3, 4, 3, 4);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.ReadOnly = true;
            txtMaSP.Size = new Size(154, 27);
            txtMaSP.TabIndex = 39;
            // 
            // lblMaSP
            // 
            lblMaSP.BorderStyle = BorderStyle.FixedSingle;
            lblMaSP.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMaSP.ForeColor = SystemColors.ActiveCaptionText;
            lblMaSP.Location = new Point(136, 142);
            lblMaSP.Margin = new Padding(6, 7, 6, 7);
            lblMaSP.Name = "lblMaSP";
            lblMaSP.Size = new Size(115, 30);
            lblMaSP.TabIndex = 38;
            lblMaSP.Text = "Mã sản phẩm";
            lblMaSP.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtTenSP
            // 
            txtTenSP.Location = new Point(295, 196);
            txtTenSP.Margin = new Padding(3, 4, 3, 4);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(309, 27);
            txtTenSP.TabIndex = 41;
            // 
            // lblTenSP
            // 
            lblTenSP.BorderStyle = BorderStyle.FixedSingle;
            lblTenSP.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTenSP.ForeColor = SystemColors.ActiveCaptionText;
            lblTenSP.Location = new Point(135, 196);
            lblTenSP.Margin = new Padding(6, 7, 6, 7);
            lblTenSP.Name = "lblTenSP";
            lblTenSP.Size = new Size(115, 30);
            lblTenSP.TabIndex = 40;
            lblTenSP.Text = "Tên sản phẩm";
            lblTenSP.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDonVi
            // 
            txtDonVi.Location = new Point(295, 252);
            txtDonVi.Margin = new Padding(3, 4, 3, 4);
            txtDonVi.Name = "txtDonVi";
            txtDonVi.Size = new Size(309, 27);
            txtDonVi.TabIndex = 43;
            // 
            // lblDonVi
            // 
            lblDonVi.BorderStyle = BorderStyle.FixedSingle;
            lblDonVi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDonVi.ForeColor = SystemColors.ActiveCaptionText;
            lblDonVi.Location = new Point(135, 252);
            lblDonVi.Margin = new Padding(6, 7, 6, 7);
            lblDonVi.Name = "lblDonVi";
            lblDonVi.Size = new Size(115, 30);
            lblDonVi.TabIndex = 42;
            lblDonVi.Text = "Đơn vị";
            lblDonVi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numGiaNhap
            // 
            numGiaNhap.Location = new Point(296, 359);
            numGiaNhap.Margin = new Padding(3, 4, 3, 4);
            numGiaNhap.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numGiaNhap.Name = "numGiaNhap";
            numGiaNhap.Size = new Size(314, 27);
            numGiaNhap.TabIndex = 45;
            // 
            // lblGiaNhap
            // 
            lblGiaNhap.BorderStyle = BorderStyle.FixedSingle;
            lblGiaNhap.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblGiaNhap.ForeColor = SystemColors.ActiveCaptionText;
            lblGiaNhap.Location = new Point(136, 359);
            lblGiaNhap.Margin = new Padding(6, 7, 6, 7);
            lblGiaNhap.Name = "lblGiaNhap";
            lblGiaNhap.Size = new Size(115, 30);
            lblGiaNhap.TabIndex = 44;
            lblGiaNhap.Text = "Giá Nhập";
            lblGiaNhap.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numGiaBan
            // 
            numGiaBan.Location = new Point(295, 306);
            numGiaBan.Margin = new Padding(3, 4, 3, 4);
            numGiaBan.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numGiaBan.Name = "numGiaBan";
            numGiaBan.Size = new Size(314, 27);
            numGiaBan.TabIndex = 47;
            // 
            // lblGiaBan
            // 
            lblGiaBan.BorderStyle = BorderStyle.FixedSingle;
            lblGiaBan.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblGiaBan.ForeColor = SystemColors.ActiveCaptionText;
            lblGiaBan.Location = new Point(135, 306);
            lblGiaBan.Margin = new Padding(6, 7, 6, 7);
            lblGiaBan.Name = "lblGiaBan";
            lblGiaBan.Size = new Size(115, 30);
            lblGiaBan.TabIndex = 46;
            lblGiaBan.Text = "Giá bán";
            lblGiaBan.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numTonKho
            // 
            numTonKho.Location = new Point(296, 413);
            numTonKho.Margin = new Padding(3, 4, 3, 4);
            numTonKho.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numTonKho.Name = "numTonKho";
            numTonKho.Size = new Size(314, 27);
            numTonKho.TabIndex = 49;
            // 
            // lblTonKho
            // 
            lblTonKho.BorderStyle = BorderStyle.FixedSingle;
            lblTonKho.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTonKho.ForeColor = SystemColors.ActiveCaptionText;
            lblTonKho.Location = new Point(136, 413);
            lblTonKho.Margin = new Padding(6, 7, 6, 7);
            lblTonKho.Name = "lblTonKho";
            lblTonKho.Size = new Size(115, 30);
            lblTonKho.TabIndex = 48;
            lblTonKho.Text = "Tồn kho";
            lblTonKho.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Snap ITC", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(179, 75);
            label1.Name = "label1";
            label1.Size = new Size(354, 36);
            label1.TabIndex = 50;
            label1.Text = "QUẢN LÝ SẢN PHẨM";
            // 
            // frmSanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1455, 623);
            Controls.Add(label1);
            Controls.Add(numTonKho);
            Controls.Add(lblTonKho);
            Controls.Add(numGiaBan);
            Controls.Add(lblGiaBan);
            Controls.Add(numGiaNhap);
            Controls.Add(lblGiaNhap);
            Controls.Add(txtDonVi);
            Controls.Add(lblDonVi);
            Controls.Add(txtTenSP);
            Controls.Add(lblTenSP);
            Controls.Add(txtMaSP);
            Controls.Add(lblMaSP);
            Controls.Add(btnLamMoi);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtTimKiem);
            Controls.Add(btnTimKiem);
            Controls.Add(dataGridViewSanPham);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmSanPham";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmSanPham";
            ((System.ComponentModel.ISupportInitialize)dataGridViewSanPham).EndInit();
            ((System.ComponentModel.ISupportInitialize)numGiaNhap).EndInit();
            ((System.ComponentModel.ISupportInitialize)numGiaBan).EndInit();
            ((System.ComponentModel.ISupportInitialize)numTonKho).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnLamMoi;
        private MaterialSkin.Controls.MaterialButton btnDelete;
        private MaterialSkin.Controls.MaterialButton btnUpdate;
        private MaterialSkin.Controls.MaterialButton btnAdd;
        private MaterialSkin.Controls.MaterialTextBox txtTimKiem;
        private MaterialSkin.Controls.MaterialButton btnTimKiem;
        private DataGridView dataGridViewSanPham;
        private TextBox txtMaSP;
        private Label lblMaSP;
        private TextBox txtTenSP;
        private Label lblTenSP;
        private TextBox txtDonVi;
        private Label lblDonVi;
        private NumericUpDown numGiaNhap;
        private Label lblGiaNhap;
        private NumericUpDown numGiaBan;
        private Label lblGiaBan;
        private NumericUpDown numTonKho;
        private Label lblTonKho;
        private Label label1;
    }
}