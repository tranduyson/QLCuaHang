namespace GUI
{
    partial class frmChiTietPhieuNhap
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
            numSoLuong = new NumericUpDown();
            lblSoLuong = new Label();
            numThanhTien = new NumericUpDown();
            lblThanhTien = new Label();
            txtMaSP = new TextBox();
            lblMaSP = new Label();
            numGiaNhap = new NumericUpDown();
            lblGiaNhap = new Label();
            txtMaPN = new TextBox();
            lblMaPN = new Label();
            btnLamMoi = new MaterialSkin.Controls.MaterialButton();
            btnDelete = new MaterialSkin.Controls.MaterialButton();
            btnUpdate = new MaterialSkin.Controls.MaterialButton();
            btnAdd = new MaterialSkin.Controls.MaterialButton();
            txtTimKiem = new MaterialSkin.Controls.MaterialTextBox();
            btnTimKiem = new MaterialSkin.Controls.MaterialButton();
            dataGridViewChiTietPhieuNhap = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numThanhTien).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numGiaNhap).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewChiTietPhieuNhap).BeginInit();
            SuspendLayout();
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(240, 170);
            numSoLuong.Margin = new Padding(3, 4, 3, 4);
            numSoLuong.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(154, 27);
            numSoLuong.TabIndex = 67;
            // 
            // lblSoLuong
            // 
            lblSoLuong.BorderStyle = BorderStyle.FixedSingle;
            lblSoLuong.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSoLuong.ForeColor = SystemColors.ActiveCaptionText;
            lblSoLuong.Location = new Point(78, 170);
            lblSoLuong.Margin = new Padding(6, 7, 6, 7);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(115, 30);
            lblSoLuong.TabIndex = 66;
            lblSoLuong.Text = "Số Lượng";
            lblSoLuong.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numThanhTien
            // 
            numThanhTien.Location = new Point(240, 281);
            numThanhTien.Margin = new Padding(3, 4, 3, 4);
            numThanhTien.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numThanhTien.Name = "numThanhTien";
            numThanhTien.Size = new Size(154, 27);
            numThanhTien.TabIndex = 65;
            // 
            // lblThanhTien
            // 
            lblThanhTien.BorderStyle = BorderStyle.FixedSingle;
            lblThanhTien.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblThanhTien.ForeColor = SystemColors.ActiveCaptionText;
            lblThanhTien.Location = new Point(78, 281);
            lblThanhTien.Margin = new Padding(6, 7, 6, 7);
            lblThanhTien.Name = "lblThanhTien";
            lblThanhTien.Size = new Size(115, 30);
            lblThanhTien.TabIndex = 64;
            lblThanhTien.Text = "Thành tiền";
            lblThanhTien.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(240, 112);
            txtMaSP.Margin = new Padding(3, 4, 3, 4);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.ReadOnly = true;
            txtMaSP.Size = new Size(154, 27);
            txtMaSP.TabIndex = 63;
            // 
            // lblMaSP
            // 
            lblMaSP.BorderStyle = BorderStyle.FixedSingle;
            lblMaSP.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMaSP.ForeColor = SystemColors.ActiveCaptionText;
            lblMaSP.Location = new Point(78, 112);
            lblMaSP.Margin = new Padding(6, 7, 6, 7);
            lblMaSP.Name = "lblMaSP";
            lblMaSP.Size = new Size(115, 30);
            lblMaSP.TabIndex = 62;
            lblMaSP.Text = "Mã sản phẩm";
            lblMaSP.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numGiaNhap
            // 
            numGiaNhap.Location = new Point(240, 226);
            numGiaNhap.Margin = new Padding(3, 4, 3, 4);
            numGiaNhap.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numGiaNhap.Name = "numGiaNhap";
            numGiaNhap.Size = new Size(154, 27);
            numGiaNhap.TabIndex = 61;
            // 
            // lblGiaNhap
            // 
            lblGiaNhap.BorderStyle = BorderStyle.FixedSingle;
            lblGiaNhap.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblGiaNhap.ForeColor = SystemColors.ActiveCaptionText;
            lblGiaNhap.Location = new Point(78, 226);
            lblGiaNhap.Margin = new Padding(6, 7, 6, 7);
            lblGiaNhap.Name = "lblGiaNhap";
            lblGiaNhap.Size = new Size(115, 30);
            lblGiaNhap.TabIndex = 60;
            lblGiaNhap.Text = "Giá nhập";
            lblGiaNhap.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtMaPN
            // 
            txtMaPN.Location = new Point(240, 55);
            txtMaPN.Margin = new Padding(3, 4, 3, 4);
            txtMaPN.Name = "txtMaPN";
            txtMaPN.ReadOnly = true;
            txtMaPN.Size = new Size(154, 27);
            txtMaPN.TabIndex = 59;
            // 
            // lblMaPN
            // 
            lblMaPN.BorderStyle = BorderStyle.FixedSingle;
            lblMaPN.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMaPN.ForeColor = SystemColors.ActiveCaptionText;
            lblMaPN.Location = new Point(78, 52);
            lblMaPN.Margin = new Padding(6, 7, 6, 7);
            lblMaPN.Name = "lblMaPN";
            lblMaPN.Size = new Size(115, 30);
            lblMaPN.TabIndex = 58;
            lblMaPN.Text = "Mã phiếu nhập";
            lblMaPN.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLamMoi
            // 
            btnLamMoi.AutoSize = false;
            btnLamMoi.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLamMoi.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            btnLamMoi.Depth = 0;
            btnLamMoi.HighEmphasis = true;
            btnLamMoi.Icon = null;
            btnLamMoi.Location = new Point(503, 46);
            btnLamMoi.Margin = new Padding(5);
            btnLamMoi.MouseState = MaterialSkin.MouseState.HOVER;
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.NoAccentTextColor = Color.Empty;
            btnLamMoi.Size = new Size(106, 43);
            btnLamMoi.TabIndex = 57;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnLamMoi.UseAccentColor = false;
            btnLamMoi.UseVisualStyleBackColor = true;
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
            btnDelete.Location = new Point(357, 391);
            btnDelete.Margin = new Padding(5);
            btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            btnDelete.Name = "btnDelete";
            btnDelete.NoAccentTextColor = Color.Empty;
            btnDelete.Size = new Size(91, 44);
            btnDelete.TabIndex = 56;
            btnDelete.Text = "Xóa";
            btnDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnDelete.UseAccentColor = true;
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.AutoSize = false;
            btnUpdate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUpdate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnUpdate.Depth = 0;
            btnUpdate.HighEmphasis = true;
            btnUpdate.Icon = null;
            btnUpdate.Location = new Point(202, 391);
            btnUpdate.Margin = new Padding(5);
            btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            btnUpdate.Name = "btnUpdate";
            btnUpdate.NoAccentTextColor = Color.Empty;
            btnUpdate.Size = new Size(87, 44);
            btnUpdate.TabIndex = 55;
            btnUpdate.Text = "Sửa";
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
            btnAdd.Location = new Point(44, 391);
            btnAdd.Margin = new Padding(5);
            btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            btnAdd.Name = "btnAdd";
            btnAdd.NoAccentTextColor = Color.Empty;
            btnAdd.Size = new Size(90, 44);
            btnAdd.TabIndex = 54;
            btnAdd.Text = "Thêm";
            btnAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAdd.UseAccentColor = false;
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            txtTimKiem.AnimateReadOnly = false;
            txtTimKiem.BorderStyle = BorderStyle.None;
            txtTimKiem.Depth = 0;
            txtTimKiem.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTimKiem.LeadingIcon = null;
            txtTimKiem.Location = new Point(617, 46);
            txtTimKiem.MaxLength = 50;
            txtTimKiem.MouseState = MaterialSkin.MouseState.OUT;
            txtTimKiem.Multiline = false;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(517, 36);
            txtTimKiem.TabIndex = 53;
            txtTimKiem.Text = "";
            txtTimKiem.TrailingIcon = null;
            txtTimKiem.UseTallSize = false;
            // 
            // btnTimKiem
            // 
            btnTimKiem.AutoSize = false;
            btnTimKiem.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnTimKiem.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            btnTimKiem.Depth = 0;
            btnTimKiem.HighEmphasis = true;
            btnTimKiem.Icon = null;
            btnTimKiem.Location = new Point(1156, 46);
            btnTimKiem.Margin = new Padding(5);
            btnTimKiem.MouseState = MaterialSkin.MouseState.HOVER;
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.NoAccentTextColor = Color.Empty;
            btnTimKiem.Size = new Size(98, 43);
            btnTimKiem.TabIndex = 52;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnTimKiem.UseAccentColor = false;
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // dataGridViewChiTietPhieuNhap
            // 
            dataGridViewChiTietPhieuNhap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewChiTietPhieuNhap.Location = new Point(503, 113);
            dataGridViewChiTietPhieuNhap.Name = "dataGridViewChiTietPhieuNhap";
            dataGridViewChiTietPhieuNhap.RowHeadersWidth = 51;
            dataGridViewChiTietPhieuNhap.Size = new Size(751, 520);
            dataGridViewChiTietPhieuNhap.TabIndex = 51;
            // 
            // frmChiTietPhieuNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1299, 679);
            Controls.Add(numSoLuong);
            Controls.Add(lblSoLuong);
            Controls.Add(numThanhTien);
            Controls.Add(lblThanhTien);
            Controls.Add(txtMaSP);
            Controls.Add(lblMaSP);
            Controls.Add(numGiaNhap);
            Controls.Add(lblGiaNhap);
            Controls.Add(txtMaPN);
            Controls.Add(lblMaPN);
            Controls.Add(btnLamMoi);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtTimKiem);
            Controls.Add(btnTimKiem);
            Controls.Add(dataGridViewChiTietPhieuNhap);
            Name = "frmChiTietPhieuNhap";
            Text = "frmChiTietPhieuNhap";
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)numThanhTien).EndInit();
            ((System.ComponentModel.ISupportInitialize)numGiaNhap).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewChiTietPhieuNhap).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numSoLuong;
        private Label lblSoLuong;
        private NumericUpDown numThanhTien;
        private Label lblThanhTien;
        private TextBox txtMaSP;
        private Label lblMaSP;
        private NumericUpDown numGiaNhap;
        private Label lblGiaNhap;
        private TextBox txtMaPN;
        private Label lblMaPN;
        private MaterialSkin.Controls.MaterialButton btnLamMoi;
        private MaterialSkin.Controls.MaterialButton btnDelete;
        private MaterialSkin.Controls.MaterialButton btnUpdate;
        private MaterialSkin.Controls.MaterialButton btnAdd;
        private MaterialSkin.Controls.MaterialTextBox txtTimKiem;
        private MaterialSkin.Controls.MaterialButton btnTimKiem;
        private DataGridView dataGridViewChiTietPhieuNhap;
    }
}