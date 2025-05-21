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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChucVu));
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
            label1 = new Label();
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
            btnLamMoi.Location = new Point(633, 122);
            btnLamMoi.Margin = new Padding(5);
            btnLamMoi.MouseState = MaterialSkin.MouseState.HOVER;
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.NoAccentTextColor = Color.Empty;
            btnLamMoi.Size = new Size(94, 43);
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
            btnDelete.Location = new Point(473, 410);
            btnDelete.Margin = new Padding(5);
            btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            btnDelete.Name = "btnDelete";
            btnDelete.NoAccentTextColor = Color.Empty;
            btnDelete.Size = new Size(94, 36);
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
            btnUpdate.Location = new Point(318, 410);
            btnUpdate.Margin = new Padding(5);
            btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            btnUpdate.Name = "btnUpdate";
            btnUpdate.NoAccentTextColor = Color.Empty;
            btnUpdate.Size = new Size(90, 36);
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
            btnAdd.Location = new Point(162, 410);
            btnAdd.Margin = new Padding(5);
            btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            btnAdd.Name = "btnAdd";
            btnAdd.NoAccentTextColor = Color.Empty;
            btnAdd.Size = new Size(93, 36);
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
            txtTimKiem.Location = new Point(735, 122);
            txtTimKiem.MaxLength = 50;
            txtTimKiem.MouseState = MaterialSkin.MouseState.OUT;
            txtTimKiem.Multiline = false;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(517, 50);
            txtTimKiem.TabIndex = 26;
            txtTimKiem.Text = "";
            txtTimKiem.TrailingIcon = null;
            // 
            // dataGridViewChucVu
            // 
            dataGridViewChucVu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewChucVu.Location = new Point(633, 195);
            dataGridViewChucVu.Name = "dataGridViewChucVu";
            dataGridViewChucVu.RowHeadersWidth = 51;
            dataGridViewChucVu.Size = new Size(732, 434);
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
            btnTimKiem.Location = new Point(1260, 122);
            btnTimKiem.Margin = new Padding(5);
            btnTimKiem.MouseState = MaterialSkin.MouseState.HOVER;
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.NoAccentTextColor = Color.Empty;
            btnTimKiem.Size = new Size(106, 43);
            btnTimKiem.TabIndex = 31;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnTimKiem.UseAccentColor = false;
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTenCV
            // 
            txtTenCV.Location = new Point(284, 208);
            txtTenCV.Margin = new Padding(3, 4, 3, 4);
            txtTenCV.Name = "txtTenCV";
            txtTenCV.Size = new Size(309, 27);
            txtTenCV.TabIndex = 35;
            // 
            // lblSDT
            // 
            lblSDT.BorderStyle = BorderStyle.FixedSingle;
            lblSDT.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSDT.ForeColor = SystemColors.ActiveCaptionText;
            lblSDT.Location = new Point(124, 208);
            lblSDT.Margin = new Padding(6, 7, 6, 7);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(115, 30);
            lblSDT.TabIndex = 37;
            lblSDT.Text = "Tên chức vụ";
            lblSDT.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numHeSoLuong
            // 
            numHeSoLuong.Location = new Point(284, 268);
            numHeSoLuong.Margin = new Padding(3, 4, 3, 4);
            numHeSoLuong.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numHeSoLuong.Name = "numHeSoLuong";
            numHeSoLuong.Size = new Size(177, 27);
            numHeSoLuong.TabIndex = 36;
            numHeSoLuong.TextAlign = HorizontalAlignment.Right;
            // 
            // txtMaCV
            // 
            txtMaCV.Location = new Point(284, 159);
            txtMaCV.Margin = new Padding(3, 4, 3, 4);
            txtMaCV.Name = "txtMaCV";
            txtMaCV.ReadOnly = true;
            txtMaCV.Size = new Size(309, 27);
            txtMaCV.TabIndex = 34;
            // 
            // lblHeSoLuong
            // 
            lblHeSoLuong.BorderStyle = BorderStyle.FixedSingle;
            lblHeSoLuong.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblHeSoLuong.ForeColor = SystemColors.ActiveCaptionText;
            lblHeSoLuong.Location = new Point(124, 268);
            lblHeSoLuong.Margin = new Padding(6, 7, 6, 7);
            lblHeSoLuong.Name = "lblHeSoLuong";
            lblHeSoLuong.Size = new Size(115, 30);
            lblHeSoLuong.TabIndex = 33;
            lblHeSoLuong.Text = "Hệ số lương";
            lblHeSoLuong.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHoTen
            // 
            lblHoTen.BorderStyle = BorderStyle.FixedSingle;
            lblHoTen.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblHoTen.ForeColor = SystemColors.ActiveCaptionText;
            lblHoTen.Location = new Point(124, 157);
            lblHoTen.Margin = new Padding(6, 7, 6, 7);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(115, 30);
            lblHoTen.TabIndex = 32;
            lblHoTen.Text = "Mã chức vụ";
            lblHoTen.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(220, 68);
            label1.Name = "label1";
            label1.Size = new Size(319, 36);
            label1.TabIndex = 38;
            label1.Text = "QUẢN LÝ CHỨC VỤ";
            // 
            // frmChucVu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1502, 679);
            Controls.Add(label1);
            Controls.Add(txtTenCV);
            Controls.Add(lblSDT);
            Controls.Add(numHeSoLuong);
            Controls.Add(txtMaCV);
            Controls.Add(lblHeSoLuong);
            Controls.Add(lblHoTen);
            Controls.Add(btnTimKiem);
            Controls.Add(btnLamMoi);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtTimKiem);
            Controls.Add(dataGridViewChucVu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmChucVu";
            StartPosition = FormStartPosition.CenterScreen;
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
        private Label label1;
    }
}