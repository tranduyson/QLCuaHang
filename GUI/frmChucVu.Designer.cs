namespace GUI
{
    partial class frmChucVu
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
            btnLamMoi = new MaterialSkin.Controls.MaterialButton();
            btnDelete = new MaterialSkin.Controls.MaterialButton();
            btnUpdate = new MaterialSkin.Controls.MaterialButton();
            btnAdd = new MaterialSkin.Controls.MaterialButton();
            txtTimKiem = new MaterialSkin.Controls.MaterialTextBox();
            dataGridViewChucVu = new DataGridView();
            btnTimKiem = new MaterialSkin.Controls.MaterialButton();
            txtTenCV = new TextBox();
            lblSDT = new Label();
            numHeSoLuong = new NumericUpDown();
            txtMaCV = new TextBox();
            lblHeSoLuong = new Label();
            lblHoTen = new Label();
            materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            materialButton2 = new MaterialSkin.Controls.MaterialButton();
            materialButton3 = new MaterialSkin.Controls.MaterialButton();
            materialButton4 = new MaterialSkin.Controls.MaterialButton();
            materialButton5 = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)dataGridViewChucVu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numHeSoLuong).BeginInit();
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
            btnLamMoi.Location = new Point(451, 34);
            btnLamMoi.Margin = new Padding(4);
            btnLamMoi.MouseState = MaterialSkin.MouseState.HOVER;
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.NoAccentTextColor = Color.Empty;
            btnLamMoi.Size = new Size(93, 32);
            btnLamMoi.TabIndex = 30;
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
            btnDelete.Location = new Point(303, 179);
            btnDelete.Margin = new Padding(4);
            btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            btnDelete.Name = "btnDelete";
            btnDelete.NoAccentTextColor = Color.Empty;
            btnDelete.Size = new Size(82, 27);
            btnDelete.TabIndex = 29;
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
            btnUpdate.Location = new Point(167, 179);
            btnUpdate.Margin = new Padding(4);
            btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            btnUpdate.Name = "btnUpdate";
            btnUpdate.NoAccentTextColor = Color.Empty;
            btnUpdate.Size = new Size(79, 27);
            btnUpdate.TabIndex = 28;
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
            btnAdd.Location = new Point(31, 179);
            btnAdd.Margin = new Padding(4);
            btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            btnAdd.Name = "btnAdd";
            btnAdd.NoAccentTextColor = Color.Empty;
            btnAdd.Size = new Size(81, 27);
            btnAdd.TabIndex = 27;
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
            txtTimKiem.Location = new Point(551, 34);
            txtTimKiem.Margin = new Padding(3, 2, 3, 2);
            txtTimKiem.MaxLength = 50;
            txtTimKiem.MouseState = MaterialSkin.MouseState.OUT;
            txtTimKiem.Multiline = false;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(452, 36);
            txtTimKiem.TabIndex = 26;
            txtTimKiem.Text = "";
            txtTimKiem.TrailingIcon = null;
            txtTimKiem.UseTallSize = false;
            // 
            // dataGridViewChucVu
            // 
            dataGridViewChucVu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewChucVu.Location = new Point(451, 84);
            dataGridViewChucVu.Margin = new Padding(3, 2, 3, 2);
            dataGridViewChucVu.Name = "dataGridViewChucVu";
            dataGridViewChucVu.RowHeadersWidth = 51;
            dataGridViewChucVu.Size = new Size(657, 390);
            dataGridViewChucVu.TabIndex = 25;
            dataGridViewChucVu.CellContentClick += dataGridViewChucVu_CellContentClick;
            dataGridViewChucVu.SelectionChanged += dataGridViewChucVu_SelectionChanged;
            // 
            // btnTimKiem
            // 
            btnTimKiem.AutoSize = false;
            btnTimKiem.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnTimKiem.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            btnTimKiem.Depth = 0;
            btnTimKiem.HighEmphasis = true;
            btnTimKiem.Icon = null;
            btnTimKiem.Location = new Point(1022, 34);
            btnTimKiem.Margin = new Padding(4);
            btnTimKiem.MouseState = MaterialSkin.MouseState.HOVER;
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.NoAccentTextColor = Color.Empty;
            btnTimKiem.Size = new Size(86, 32);
            btnTimKiem.TabIndex = 31;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnTimKiem.UseAccentColor = false;
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTenCV
            // 
            txtTenCV.Location = new Point(148, 72);
            txtTenCV.Name = "txtTenCV";
            txtTenCV.Size = new Size(271, 23);
            txtTenCV.TabIndex = 35;
            // 
            // lblSDT
            // 
            lblSDT.BorderStyle = BorderStyle.FixedSingle;
            lblSDT.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSDT.ForeColor = SystemColors.ActiveCaptionText;
            lblSDT.Location = new Point(8, 72);
            lblSDT.Margin = new Padding(5);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(101, 23);
            lblSDT.TabIndex = 37;
            lblSDT.Text = "Tên chức vụ";
            lblSDT.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numHeSoLuong
            // 
            numHeSoLuong.Location = new Point(148, 117);
            numHeSoLuong.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numHeSoLuong.Name = "numHeSoLuong";
            numHeSoLuong.Size = new Size(155, 23);
            numHeSoLuong.TabIndex = 36;
            numHeSoLuong.TextAlign = HorizontalAlignment.Right;
            // 
            // txtMaCV
            // 
            txtMaCV.Location = new Point(148, 34);
            txtMaCV.Name = "txtMaCV";
            txtMaCV.ReadOnly = true;
            txtMaCV.Size = new Size(271, 23);
            txtMaCV.TabIndex = 34;
            // 
            // lblHeSoLuong
            // 
            lblHeSoLuong.BorderStyle = BorderStyle.FixedSingle;
            lblHeSoLuong.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblHeSoLuong.ForeColor = SystemColors.ActiveCaptionText;
            lblHeSoLuong.Location = new Point(8, 117);
            lblHeSoLuong.Margin = new Padding(5);
            lblHeSoLuong.Name = "lblHeSoLuong";
            lblHeSoLuong.Size = new Size(101, 23);
            lblHeSoLuong.TabIndex = 33;
            lblHeSoLuong.Text = "Hệ số lương";
            lblHeSoLuong.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHoTen
            // 
            lblHoTen.BorderStyle = BorderStyle.FixedSingle;
            lblHoTen.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblHoTen.ForeColor = SystemColors.ActiveCaptionText;
            lblHoTen.Location = new Point(8, 34);
            lblHoTen.Margin = new Padding(5);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(101, 23);
            lblHoTen.TabIndex = 32;
            lblHoTen.Text = "Mã chức vụ";
            lblHoTen.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // materialTextBox1
            // 
            materialTextBox1.AnimateReadOnly = false;
            materialTextBox1.BorderStyle = BorderStyle.None;
            materialTextBox1.Depth = 0;
            materialTextBox1.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox1.LeadingIcon = null;
            materialTextBox1.Location = new Point(551, 34);
            materialTextBox1.Margin = new Padding(3, 2, 3, 2);
            materialTextBox1.MaxLength = 50;
            materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox1.Multiline = false;
            materialTextBox1.Name = "materialTextBox1";
            materialTextBox1.Size = new Size(452, 36);
            materialTextBox1.TabIndex = 26;
            materialTextBox1.Text = "";
            materialTextBox1.TrailingIcon = null;
            materialTextBox1.UseTallSize = false;
            // 
            // materialButton1
            // 
            materialButton1.AutoSize = false;
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(31, 179);
            materialButton1.Margin = new Padding(4);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(81, 27);
            materialButton1.TabIndex = 27;
            materialButton1.Text = "Thêm";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += btnAdd_Click;
            // 
            // materialButton2
            // 
            materialButton2.AutoSize = false;
            materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = null;
            materialButton2.Location = new Point(167, 179);
            materialButton2.Margin = new Padding(4);
            materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(79, 27);
            materialButton2.TabIndex = 28;
            materialButton2.Text = "Sửa";
            materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = true;
            materialButton2.Click += btnUpdate_Click;
            // 
            // materialButton3
            // 
            materialButton3.AutoSize = false;
            materialButton3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton3.BackColor = SystemColors.ActiveBorder;
            materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton3.Depth = 0;
            materialButton3.FlatStyle = FlatStyle.Flat;
            materialButton3.HighEmphasis = true;
            materialButton3.Icon = null;
            materialButton3.Location = new Point(303, 179);
            materialButton3.Margin = new Padding(4);
            materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton3.Name = "materialButton3";
            materialButton3.NoAccentTextColor = Color.Empty;
            materialButton3.Size = new Size(82, 27);
            materialButton3.TabIndex = 29;
            materialButton3.Text = "Xóa";
            materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            materialButton3.UseAccentColor = true;
            materialButton3.UseVisualStyleBackColor = false;
            materialButton3.Click += btnDelete_Click;
            // 
            // materialButton4
            // 
            materialButton4.AutoSize = false;
            materialButton4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton4.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            materialButton4.Depth = 0;
            materialButton4.HighEmphasis = true;
            materialButton4.Icon = null;
            materialButton4.Location = new Point(451, 34);
            materialButton4.Margin = new Padding(4);
            materialButton4.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton4.Name = "materialButton4";
            materialButton4.NoAccentTextColor = Color.Empty;
            materialButton4.Size = new Size(93, 32);
            materialButton4.TabIndex = 30;
            materialButton4.Text = "Làm mới";
            materialButton4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            materialButton4.UseAccentColor = false;
            materialButton4.UseVisualStyleBackColor = true;
            materialButton4.Click += btnLamMoi_Click;
            // 
            // materialButton5
            // 
            materialButton5.AutoSize = false;
            materialButton5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton5.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            materialButton5.Depth = 0;
            materialButton5.HighEmphasis = true;
            materialButton5.Icon = null;
            materialButton5.Location = new Point(1022, 34);
            materialButton5.Margin = new Padding(4);
            materialButton5.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton5.Name = "materialButton5";
            materialButton5.NoAccentTextColor = Color.Empty;
            materialButton5.Size = new Size(86, 32);
            materialButton5.TabIndex = 31;
            materialButton5.Text = "Tìm kiếm";
            materialButton5.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton5.UseAccentColor = false;
            materialButton5.UseVisualStyleBackColor = true;
            materialButton5.Click += btnTimKiem_Click;
            // 
            // frmChucVu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1137, 509);
            Controls.Add(txtTenCV);
            Controls.Add(lblSDT);
            Controls.Add(numHeSoLuong);
            Controls.Add(txtMaCV);
            Controls.Add(lblHeSoLuong);
            Controls.Add(lblHoTen);
            Controls.Add(materialButton5);
            Controls.Add(btnTimKiem);
            Controls.Add(materialButton4);
            Controls.Add(btnLamMoi);
            Controls.Add(materialButton3);
            Controls.Add(btnDelete);
            Controls.Add(materialButton2);
            Controls.Add(btnUpdate);
            Controls.Add(materialButton1);
            Controls.Add(materialTextBox1);
            Controls.Add(btnAdd);
            Controls.Add(txtTimKiem);
            Controls.Add(dataGridViewChucVu);
            Name = "frmChucVu";
            Text = "frmChucVu";
            Load += frmChucVu_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridViewChucVu).EndInit();
            ((System.ComponentModel.ISupportInitialize)numHeSoLuong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnLamMoi;
        private MaterialSkin.Controls.MaterialButton btnDelete;
        private MaterialSkin.Controls.MaterialButton btnUpdate;
        private MaterialSkin.Controls.MaterialButton btnAdd;
        private MaterialSkin.Controls.MaterialTextBox txtTimKiem;
        private DataGridView dataGridViewChucVu;
        private MaterialSkin.Controls.MaterialButton btnTimKiem;
        private TextBox txtTenCV;
        private Label lblSDT;
        private NumericUpDown numHeSoLuong;
        private TextBox txtMaCV;
        private Label lblHeSoLuong;
        private Label lblHoTen;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private MaterialSkin.Controls.MaterialButton materialButton4;
        private MaterialSkin.Controls.MaterialButton materialButton5;
    }
}