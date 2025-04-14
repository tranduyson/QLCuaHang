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
            btnDelete = new MaterialSkin.Controls.MaterialButton();
            btnUpdate = new MaterialSkin.Controls.MaterialButton();
            btnAdd = new MaterialSkin.Controls.MaterialButton();
            btnLamMoi = new MaterialSkin.Controls.MaterialButton();
            txtTimKiem = new MaterialSkin.Controls.MaterialTextBox();
            btnTimKiem = new MaterialSkin.Controls.MaterialButton();
            dataGridViewPhieuNhap = new DataGridView();
            txtMaPN = new TextBox();
            lblMaPN = new Label();
            datNgayNhap = new DateTimePicker();
            lblNgayNhap = new Label();
            numTongTien = new NumericUpDown();
            lblTongTien = new Label();
            txtMaNV = new TextBox();
            lblMaNV = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPhieuNhap).BeginInit();
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
            btnDelete.Location = new Point(361, 356);
            btnDelete.Margin = new Padding(5);
            btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            btnDelete.Name = "btnDelete";
            btnDelete.NoAccentTextColor = Color.Empty;
            btnDelete.Size = new Size(94, 36);
            btnDelete.TabIndex = 10;
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
            btnUpdate.Location = new Point(206, 356);
            btnUpdate.Margin = new Padding(5);
            btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            btnUpdate.Name = "btnUpdate";
            btnUpdate.NoAccentTextColor = Color.Empty;
            btnUpdate.Size = new Size(90, 36);
            btnUpdate.TabIndex = 9;
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
            btnAdd.Location = new Point(51, 356);
            btnAdd.Margin = new Padding(5);
            btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            btnAdd.Name = "btnAdd";
            btnAdd.NoAccentTextColor = Color.Empty;
            btnAdd.Size = new Size(93, 36);
            btnAdd.TabIndex = 8;
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
            btnLamMoi.Location = new Point(533, 64);
            btnLamMoi.Margin = new Padding(5);
            btnLamMoi.MouseState = MaterialSkin.MouseState.HOVER;
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.NoAccentTextColor = Color.Empty;
            btnLamMoi.Size = new Size(106, 43);
            btnLamMoi.TabIndex = 28;
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
            txtTimKiem.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTimKiem.LeadingIcon = null;
            txtTimKiem.Location = new Point(647, 64);
            txtTimKiem.MaxLength = 50;
            txtTimKiem.MouseState = MaterialSkin.MouseState.OUT;
            txtTimKiem.Multiline = false;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(517, 36);
            txtTimKiem.TabIndex = 27;
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
            btnTimKiem.Location = new Point(1186, 58);
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
            // 
            // dataGridViewPhieuNhap
            // 
            dataGridViewPhieuNhap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPhieuNhap.Location = new Point(533, 115);
            dataGridViewPhieuNhap.Name = "dataGridViewPhieuNhap";
            dataGridViewPhieuNhap.RowHeadersWidth = 51;
            dataGridViewPhieuNhap.Size = new Size(751, 520);
            dataGridViewPhieuNhap.TabIndex = 25;
            // 
            // txtMaPN
            // 
            txtMaPN.Location = new Point(213, 80);
            txtMaPN.Margin = new Padding(3, 4, 3, 4);
            txtMaPN.Name = "txtMaPN";
            txtMaPN.ReadOnly = true;
            txtMaPN.Size = new Size(154, 27);
            txtMaPN.TabIndex = 30;
            // 
            // lblMaPN
            // 
            lblMaPN.BorderStyle = BorderStyle.FixedSingle;
            lblMaPN.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMaPN.ForeColor = SystemColors.ActiveCaptionText;
            lblMaPN.Location = new Point(51, 77);
            lblMaPN.Margin = new Padding(6, 7, 6, 7);
            lblMaPN.Name = "lblMaPN";
            lblMaPN.Size = new Size(115, 30);
            lblMaPN.TabIndex = 29;
            lblMaPN.Text = "Mã phiếu nhập";
            lblMaPN.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // datNgayNhap
            // 
            datNgayNhap.Format = DateTimePickerFormat.Custom;
            datNgayNhap.Location = new Point(213, 198);
            datNgayNhap.Margin = new Padding(3, 4, 3, 4);
            datNgayNhap.Name = "datNgayNhap";
            datNgayNhap.Size = new Size(154, 27);
            datNgayNhap.TabIndex = 32;
            // 
            // lblNgayNhap
            // 
            lblNgayNhap.BorderStyle = BorderStyle.FixedSingle;
            lblNgayNhap.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNgayNhap.ForeColor = SystemColors.ActiveCaptionText;
            lblNgayNhap.Location = new Point(51, 195);
            lblNgayNhap.Margin = new Padding(6, 7, 6, 7);
            lblNgayNhap.Name = "lblNgayNhap";
            lblNgayNhap.Size = new Size(115, 30);
            lblNgayNhap.TabIndex = 31;
            lblNgayNhap.Text = "Ngày nhập";
            lblNgayNhap.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numTongTien
            // 
            numTongTien.Location = new Point(213, 251);
            numTongTien.Margin = new Padding(3, 4, 3, 4);
            numTongTien.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numTongTien.Name = "numTongTien";
            numTongTien.Size = new Size(154, 27);
            numTongTien.TabIndex = 36;
            // 
            // lblTongTien
            // 
            lblTongTien.BorderStyle = BorderStyle.FixedSingle;
            lblTongTien.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTongTien.ForeColor = SystemColors.ActiveCaptionText;
            lblTongTien.Location = new Point(51, 251);
            lblTongTien.Margin = new Padding(6, 7, 6, 7);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(115, 30);
            lblTongTien.TabIndex = 34;
            lblTongTien.Text = "Tổng Tiền";
            lblTongTien.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(213, 137);
            txtMaNV.Margin = new Padding(3, 4, 3, 4);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.ReadOnly = true;
            txtMaNV.Size = new Size(154, 27);
            txtMaNV.TabIndex = 38;
            // 
            // lblMaNV
            // 
            lblMaNV.BorderStyle = BorderStyle.FixedSingle;
            lblMaNV.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMaNV.ForeColor = SystemColors.ActiveCaptionText;
            lblMaNV.Location = new Point(51, 137);
            lblMaNV.Margin = new Padding(6, 7, 6, 7);
            lblMaNV.Name = "lblMaNV";
            lblMaNV.Size = new Size(115, 30);
            lblMaNV.TabIndex = 37;
            lblMaNV.Text = "Mã nhân viên";
            lblMaNV.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmPhieuNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1299, 679);
            Controls.Add(txtMaNV);
            Controls.Add(lblMaNV);
            Controls.Add(numTongTien);
            Controls.Add(lblTongTien);
            Controls.Add(datNgayNhap);
            Controls.Add(lblNgayNhap);
            Controls.Add(txtMaPN);
            Controls.Add(lblMaPN);
            Controls.Add(btnLamMoi);
            Controls.Add(txtTimKiem);
            Controls.Add(btnTimKiem);
            Controls.Add(dataGridViewPhieuNhap);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Name = "frmPhieuNhap";
            Text = "frmPhieuNhap";
            ((System.ComponentModel.ISupportInitialize)dataGridViewPhieuNhap).EndInit();
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
        private DataGridView dataGridViewPhieuNhap;
        private TextBox txtMaPN;
        private Label lblMaPN;
        private DateTimePicker datNgayNhap;
        private Label lblNgayNhap;
        private NumericUpDown numTongTien;
        private Label lblTongTien;
        private TextBox txtMaNV;
        private Label lblMaNV;
    }
}