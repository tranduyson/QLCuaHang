namespace GUI
{
    partial class frmDonHang
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
            btnDelete = new MaterialSkin.Controls.MaterialButton();
            btnUpdate = new MaterialSkin.Controls.MaterialButton();
            btnAdd = new MaterialSkin.Controls.MaterialButton();
            btnLamMoi = new MaterialSkin.Controls.MaterialButton();
            txtTimKiem = new MaterialSkin.Controls.MaterialTextBox();
            btnTimKiem = new MaterialSkin.Controls.MaterialButton();
            dataGridViewDonHang = new DataGridView();
            txtMaNV = new TextBox();
            lblMaNV = new Label();
            numTongTien = new NumericUpDown();
            lblTongTien = new Label();
            datNgayDH = new DateTimePicker();
            lblNgayDH = new Label();
            txtMaDH = new TextBox();
            lblMaDH = new Label();
            txtMaKH = new TextBox();
            lblMaKH = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDonHang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numTongTien).BeginInit();
            SuspendLayout();
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
            btnDelete.Location = new Point(367, 590);
            btnDelete.Margin = new Padding(5);
            btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            btnDelete.Name = "btnDelete";
            btnDelete.NoAccentTextColor = Color.Empty;
            btnDelete.Size = new Size(94, 36);
            btnDelete.TabIndex = 39;
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
            btnUpdate.Location = new Point(212, 590);
            btnUpdate.Margin = new Padding(5);
            btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            btnUpdate.Name = "btnUpdate";
            btnUpdate.NoAccentTextColor = Color.Empty;
            btnUpdate.Size = new Size(90, 36);
            btnUpdate.TabIndex = 38;
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
            btnAdd.Location = new Point(57, 590);
            btnAdd.Margin = new Padding(5);
            btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            btnAdd.Name = "btnAdd";
            btnAdd.NoAccentTextColor = Color.Empty;
            btnAdd.Size = new Size(93, 36);
            btnAdd.TabIndex = 37;
            btnAdd.Text = "Thêm";
            btnAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAdd.UseAccentColor = false;
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            btnLamMoi.AutoSize = false;
            btnLamMoi.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLamMoi.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            btnLamMoi.Depth = 0;
            btnLamMoi.HighEmphasis = true;
            btnLamMoi.Icon = null;
            btnLamMoi.Location = new Point(530, 53);
            btnLamMoi.Margin = new Padding(5);
            btnLamMoi.MouseState = MaterialSkin.MouseState.HOVER;
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.NoAccentTextColor = Color.Empty;
            btnLamMoi.Size = new Size(106, 43);
            btnLamMoi.TabIndex = 43;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnLamMoi.UseAccentColor = false;
            btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            txtTimKiem.AnimateReadOnly = false;
            txtTimKiem.BorderStyle = BorderStyle.None;
            txtTimKiem.Depth = 0;
            txtTimKiem.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTimKiem.LeadingIcon = null;
            txtTimKiem.Location = new Point(644, 53);
            txtTimKiem.MaxLength = 50;
            txtTimKiem.MouseState = MaterialSkin.MouseState.OUT;
            txtTimKiem.Multiline = false;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(517, 36);
            txtTimKiem.TabIndex = 42;
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
            btnTimKiem.Location = new Point(1183, 47);
            btnTimKiem.Margin = new Padding(5);
            btnTimKiem.MouseState = MaterialSkin.MouseState.HOVER;
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.NoAccentTextColor = Color.Empty;
            btnTimKiem.Size = new Size(98, 43);
            btnTimKiem.TabIndex = 41;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnTimKiem.UseAccentColor = false;
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDonHang
            // 
            dataGridViewDonHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDonHang.Location = new Point(530, 120);
            dataGridViewDonHang.Name = "dataGridViewDonHang";
            dataGridViewDonHang.RowHeadersWidth = 51;
            dataGridViewDonHang.Size = new Size(751, 520);
            dataGridViewDonHang.TabIndex = 40;
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(219, 170);
            txtMaNV.Margin = new Padding(3, 4, 3, 4);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.ReadOnly = true;
            txtMaNV.Size = new Size(154, 27);
            txtMaNV.TabIndex = 51;
            // 
            // lblMaNV
            // 
            lblMaNV.BorderStyle = BorderStyle.FixedSingle;
            lblMaNV.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMaNV.ForeColor = SystemColors.ActiveCaptionText;
            lblMaNV.Location = new Point(32, 170);
            lblMaNV.Margin = new Padding(6, 7, 6, 7);
            lblMaNV.Name = "lblMaNV";
            lblMaNV.Size = new Size(140, 30);
            lblMaNV.TabIndex = 50;
            lblMaNV.Text = "Mã nhân viên";
            lblMaNV.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numTongTien
            // 
            numTongTien.Location = new Point(219, 289);
            numTongTien.Margin = new Padding(3, 4, 3, 4);
            numTongTien.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numTongTien.Name = "numTongTien";
            numTongTien.Size = new Size(154, 27);
            numTongTien.TabIndex = 49;
            // 
            // lblTongTien
            // 
            lblTongTien.BorderStyle = BorderStyle.FixedSingle;
            lblTongTien.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTongTien.ForeColor = SystemColors.ActiveCaptionText;
            lblTongTien.Location = new Point(32, 286);
            lblTongTien.Margin = new Padding(6, 7, 6, 7);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(140, 30);
            lblTongTien.TabIndex = 48;
            lblTongTien.Text = "Tổng Tiền";
            lblTongTien.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // datNgayDH
            // 
            datNgayDH.Format = DateTimePickerFormat.Custom;
            datNgayDH.Location = new Point(219, 233);
            datNgayDH.Margin = new Padding(3, 4, 3, 4);
            datNgayDH.Name = "datNgayDH";
            datNgayDH.Size = new Size(154, 27);
            datNgayDH.TabIndex = 47;
            // 
            // lblNgayDH
            // 
            lblNgayDH.BorderStyle = BorderStyle.FixedSingle;
            lblNgayDH.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNgayDH.ForeColor = SystemColors.ActiveCaptionText;
            lblNgayDH.Location = new Point(32, 230);
            lblNgayDH.Margin = new Padding(6, 7, 6, 7);
            lblNgayDH.Name = "lblNgayDH";
            lblNgayDH.Size = new Size(140, 30);
            lblNgayDH.TabIndex = 46;
            lblNgayDH.Text = "Ngày đơn hàng";
            lblNgayDH.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtMaDH
            // 
            txtMaDH.Location = new Point(219, 56);
            txtMaDH.Margin = new Padding(3, 4, 3, 4);
            txtMaDH.Name = "txtMaDH";
            txtMaDH.ReadOnly = true;
            txtMaDH.Size = new Size(154, 27);
            txtMaDH.TabIndex = 45;
            // 
            // lblMaDH
            // 
            lblMaDH.BorderStyle = BorderStyle.FixedSingle;
            lblMaDH.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMaDH.ForeColor = SystemColors.ActiveCaptionText;
            lblMaDH.Location = new Point(32, 53);
            lblMaDH.Margin = new Padding(6, 7, 6, 7);
            lblMaDH.Name = "lblMaDH";
            lblMaDH.Size = new Size(140, 30);
            lblMaDH.TabIndex = 44;
            lblMaDH.Text = "Mã đơn hàng";
            lblMaDH.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtMaKH
            // 
            txtMaKH.Location = new Point(219, 110);
            txtMaKH.Margin = new Padding(3, 4, 3, 4);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.ReadOnly = true;
            txtMaKH.Size = new Size(154, 27);
            txtMaKH.TabIndex = 53;
            txtMaKH.TextChanged += textBox1_TextChanged;
            // 
            // lblMaKH
            // 
            lblMaKH.BorderStyle = BorderStyle.FixedSingle;
            lblMaKH.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMaKH.ForeColor = SystemColors.ActiveCaptionText;
            lblMaKH.Location = new Point(32, 110);
            lblMaKH.Margin = new Padding(6, 7, 6, 7);
            lblMaKH.Name = "lblMaKH";
            lblMaKH.Size = new Size(140, 30);
            lblMaKH.TabIndex = 52;
            lblMaKH.Text = "Mã khách hàng";
            lblMaKH.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmDonHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1299, 679);
            Controls.Add(txtMaKH);
            Controls.Add(lblMaKH);
            Controls.Add(txtMaNV);
            Controls.Add(lblMaNV);
            Controls.Add(numTongTien);
            Controls.Add(lblTongTien);
            Controls.Add(datNgayDH);
            Controls.Add(lblNgayDH);
            Controls.Add(txtMaDH);
            Controls.Add(lblMaDH);
            Controls.Add(btnLamMoi);
            Controls.Add(txtTimKiem);
            Controls.Add(btnTimKiem);
            Controls.Add(dataGridViewDonHang);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Name = "frmDonHang";
            Text = "frmDonHang";
            ((System.ComponentModel.ISupportInitialize)dataGridViewDonHang).EndInit();
            ((System.ComponentModel.ISupportInitialize)numTongTien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnDelete;
        private MaterialSkin.Controls.MaterialButton btnUpdate;
        private MaterialSkin.Controls.MaterialButton btnAdd;
        private MaterialSkin.Controls.MaterialButton btnLamMoi;
        private MaterialSkin.Controls.MaterialTextBox txtTimKiem;
        private MaterialSkin.Controls.MaterialButton btnTimKiem;
        private DataGridView dataGridViewDonHang;
        private TextBox txtMaNV;
        private Label lblMaNV;
        private NumericUpDown numTongTien;
        private Label lblTongTien;
        private DateTimePicker datNgayDH;
        private Label lblNgayDH;
        private TextBox txtMaDH;
        private Label lblMaDH;
        private TextBox txtMaKH;
        private Label lblMaKH;
    }
}