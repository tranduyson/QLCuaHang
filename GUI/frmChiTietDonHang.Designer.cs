namespace GUI
{
    partial class frmChiTietDonHang
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
            btnTimKiem = new MaterialSkin.Controls.MaterialButton();
            dataGridViewChiTietDonHang = new DataGridView();
            txtMaSP = new TextBox();
            lblMaSP = new Label();
            numDonGia = new NumericUpDown();
            lblDonGia = new Label();
            txtMaDH = new TextBox();
            lblMaDH = new Label();
            numThanhTien = new NumericUpDown();
            lblThanhTien = new Label();
            numSoLuong = new NumericUpDown();
            lblSoLuong = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewChiTietDonHang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDonGia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numThanhTien).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
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
            btnLamMoi.Location = new Point(510, 46);
            btnLamMoi.Margin = new Padding(5);
            btnLamMoi.MouseState = MaterialSkin.MouseState.HOVER;
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.NoAccentTextColor = Color.Empty;
            btnLamMoi.Size = new Size(106, 43);
            btnLamMoi.TabIndex = 38;
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
            btnDelete.Location = new Point(364, 391);
            btnDelete.Margin = new Padding(5);
            btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            btnDelete.Name = "btnDelete";
            btnDelete.NoAccentTextColor = Color.Empty;
            btnDelete.Size = new Size(91, 44);
            btnDelete.TabIndex = 37;
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
            btnUpdate.Location = new Point(209, 391);
            btnUpdate.Margin = new Padding(5);
            btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            btnUpdate.Name = "btnUpdate";
            btnUpdate.NoAccentTextColor = Color.Empty;
            btnUpdate.Size = new Size(87, 44);
            btnUpdate.TabIndex = 36;
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
            btnAdd.Location = new Point(51, 391);
            btnAdd.Margin = new Padding(5);
            btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            btnAdd.Name = "btnAdd";
            btnAdd.NoAccentTextColor = Color.Empty;
            btnAdd.Size = new Size(90, 44);
            btnAdd.TabIndex = 35;
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
            txtTimKiem.Location = new Point(624, 46);
            txtTimKiem.MaxLength = 50;
            txtTimKiem.MouseState = MaterialSkin.MouseState.OUT;
            txtTimKiem.Multiline = false;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(517, 36);
            txtTimKiem.TabIndex = 34;
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
            btnTimKiem.Location = new Point(1163, 46);
            btnTimKiem.Margin = new Padding(5);
            btnTimKiem.MouseState = MaterialSkin.MouseState.HOVER;
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.NoAccentTextColor = Color.Empty;
            btnTimKiem.Size = new Size(98, 43);
            btnTimKiem.TabIndex = 33;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnTimKiem.UseAccentColor = false;
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // dataGridViewChiTietDonHang
            // 
            dataGridViewChiTietDonHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewChiTietDonHang.Location = new Point(510, 113);
            dataGridViewChiTietDonHang.Name = "dataGridViewChiTietDonHang";
            dataGridViewChiTietDonHang.RowHeadersWidth = 51;
            dataGridViewChiTietDonHang.Size = new Size(751, 520);
            dataGridViewChiTietDonHang.TabIndex = 32;
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(247, 112);
            txtMaSP.Margin = new Padding(3, 4, 3, 4);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.ReadOnly = true;
            txtMaSP.Size = new Size(154, 27);
            txtMaSP.TabIndex = 46;
            // 
            // lblMaSP
            // 
            lblMaSP.BorderStyle = BorderStyle.FixedSingle;
            lblMaSP.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMaSP.ForeColor = SystemColors.ActiveCaptionText;
            lblMaSP.Location = new Point(85, 112);
            lblMaSP.Margin = new Padding(6, 7, 6, 7);
            lblMaSP.Name = "lblMaSP";
            lblMaSP.Size = new Size(115, 30);
            lblMaSP.TabIndex = 45;
            lblMaSP.Text = "Mã sản phẩm";
            lblMaSP.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numDonGia
            // 
            numDonGia.Location = new Point(247, 226);
            numDonGia.Margin = new Padding(3, 4, 3, 4);
            numDonGia.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numDonGia.Name = "numDonGia";
            numDonGia.Size = new Size(154, 27);
            numDonGia.TabIndex = 44;
            // 
            // lblDonGia
            // 
            lblDonGia.BorderStyle = BorderStyle.FixedSingle;
            lblDonGia.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDonGia.ForeColor = SystemColors.ActiveCaptionText;
            lblDonGia.Location = new Point(85, 226);
            lblDonGia.Margin = new Padding(6, 7, 6, 7);
            lblDonGia.Name = "lblDonGia";
            lblDonGia.Size = new Size(115, 30);
            lblDonGia.TabIndex = 43;
            lblDonGia.Text = "Đơn giá";
            lblDonGia.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtMaDH
            // 
            txtMaDH.Location = new Point(247, 55);
            txtMaDH.Margin = new Padding(3, 4, 3, 4);
            txtMaDH.Name = "txtMaDH";
            txtMaDH.ReadOnly = true;
            txtMaDH.Size = new Size(154, 27);
            txtMaDH.TabIndex = 40;
            // 
            // lblMaDH
            // 
            lblMaDH.BorderStyle = BorderStyle.FixedSingle;
            lblMaDH.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMaDH.ForeColor = SystemColors.ActiveCaptionText;
            lblMaDH.Location = new Point(85, 52);
            lblMaDH.Margin = new Padding(6, 7, 6, 7);
            lblMaDH.Name = "lblMaDH";
            lblMaDH.Size = new Size(115, 30);
            lblMaDH.TabIndex = 39;
            lblMaDH.Text = "Mã đơn hàng";
            lblMaDH.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numThanhTien
            // 
            numThanhTien.Location = new Point(247, 281);
            numThanhTien.Margin = new Padding(3, 4, 3, 4);
            numThanhTien.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numThanhTien.Name = "numThanhTien";
            numThanhTien.Size = new Size(154, 27);
            numThanhTien.TabIndex = 48;
            // 
            // lblThanhTien
            // 
            lblThanhTien.BorderStyle = BorderStyle.FixedSingle;
            lblThanhTien.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblThanhTien.ForeColor = SystemColors.ActiveCaptionText;
            lblThanhTien.Location = new Point(85, 281);
            lblThanhTien.Margin = new Padding(6, 7, 6, 7);
            lblThanhTien.Name = "lblThanhTien";
            lblThanhTien.Size = new Size(115, 30);
            lblThanhTien.TabIndex = 47;
            lblThanhTien.Text = "Thành tiền";
            lblThanhTien.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(247, 170);
            numSoLuong.Margin = new Padding(3, 4, 3, 4);
            numSoLuong.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(154, 27);
            numSoLuong.TabIndex = 50;
            // 
            // lblSoLuong
            // 
            lblSoLuong.BorderStyle = BorderStyle.FixedSingle;
            lblSoLuong.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSoLuong.ForeColor = SystemColors.ActiveCaptionText;
            lblSoLuong.Location = new Point(85, 170);
            lblSoLuong.Margin = new Padding(6, 7, 6, 7);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(115, 30);
            lblSoLuong.TabIndex = 49;
            lblSoLuong.Text = "Số Lượng";
            lblSoLuong.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmChiTietDonHang
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
            Controls.Add(numDonGia);
            Controls.Add(lblDonGia);
            Controls.Add(txtMaDH);
            Controls.Add(lblMaDH);
            Controls.Add(btnLamMoi);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtTimKiem);
            Controls.Add(btnTimKiem);
            Controls.Add(dataGridViewChiTietDonHang);
            Name = "frmChiTietDonHang";
            Text = "frmChiTietDonHang";
            ((System.ComponentModel.ISupportInitialize)dataGridViewChiTietDonHang).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDonGia).EndInit();
            ((System.ComponentModel.ISupportInitialize)numThanhTien).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
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
        private DataGridView dataGridViewChiTietDonHang;
        private TextBox txtMaSP;
        private Label lblMaSP;
        private NumericUpDown numDonGia;
        private Label lblDonGia;
        private TextBox txtMaDH;
        private Label lblMaDH;
        private NumericUpDown numThanhTien;
        private Label lblThanhTien;
        private NumericUpDown numSoLuong;
        private Label lblSoLuong;
    }
}