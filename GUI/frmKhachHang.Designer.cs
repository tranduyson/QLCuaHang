namespace GUI
{
    partial class frmKhachHang
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
            txtTenKH = new TextBox();
            lblTenKH = new Label();
            txtMaKH = new TextBox();
            lblMaKH = new Label();
            materialButton5 = new MaterialSkin.Controls.MaterialButton();
            btnTimKiem = new MaterialSkin.Controls.MaterialButton();
            materialButton4 = new MaterialSkin.Controls.MaterialButton();
            btnLamMoi = new MaterialSkin.Controls.MaterialButton();
            materialButton3 = new MaterialSkin.Controls.MaterialButton();
            btnDelete = new MaterialSkin.Controls.MaterialButton();
            materialButton2 = new MaterialSkin.Controls.MaterialButton();
            btnUpdate = new MaterialSkin.Controls.MaterialButton();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            btnAdd = new MaterialSkin.Controls.MaterialButton();
            txtTimKiem = new MaterialSkin.Controls.MaterialTextBox();
            dataGridViewKhachHang = new DataGridView();
            txtSDT = new TextBox();
            lblSDT = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            richTextDiaChi = new RichTextBox();
            lblDiaChi = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewKhachHang).BeginInit();
            SuspendLayout();
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(181, 96);
            txtTenKH.Margin = new Padding(3, 4, 3, 4);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(309, 27);
            txtTenKH.TabIndex = 54;
            // 
            // lblTenKH
            // 
            lblTenKH.BorderStyle = BorderStyle.FixedSingle;
            lblTenKH.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTenKH.ForeColor = SystemColors.ActiveCaptionText;
            lblTenKH.Location = new Point(21, 96);
            lblTenKH.Margin = new Padding(6, 7, 6, 7);
            lblTenKH.Name = "lblTenKH";
            lblTenKH.Size = new Size(125, 30);
            lblTenKH.TabIndex = 56;
            lblTenKH.Text = "Tên khách hàng";
            lblTenKH.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtMaKH
            // 
            txtMaKH.Location = new Point(181, 45);
            txtMaKH.Margin = new Padding(3, 4, 3, 4);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.ReadOnly = true;
            txtMaKH.Size = new Size(309, 27);
            txtMaKH.TabIndex = 53;
            // 
            // lblMaKH
            // 
            lblMaKH.BorderStyle = BorderStyle.FixedSingle;
            lblMaKH.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMaKH.ForeColor = SystemColors.ActiveCaptionText;
            lblMaKH.Location = new Point(21, 45);
            lblMaKH.Margin = new Padding(6, 7, 6, 7);
            lblMaKH.Name = "lblMaKH";
            lblMaKH.Size = new Size(125, 30);
            lblMaKH.TabIndex = 51;
            lblMaKH.Text = "Mã khách hàng";
            lblMaKH.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // materialButton5
            // 
            materialButton5.AutoSize = false;
            materialButton5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton5.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            materialButton5.Depth = 0;
            materialButton5.HighEmphasis = true;
            materialButton5.Icon = null;
            materialButton5.Location = new Point(1190, 45);
            materialButton5.Margin = new Padding(5);
            materialButton5.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton5.Name = "materialButton5";
            materialButton5.NoAccentTextColor = Color.Empty;
            materialButton5.Size = new Size(90, 53);
            materialButton5.TabIndex = 50;
            materialButton5.Text = "Tìm kiếm";
            materialButton5.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton5.UseAccentColor = false;
            materialButton5.UseVisualStyleBackColor = true;
            materialButton5.Click += btnTimKiem_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.AutoSize = false;
            btnTimKiem.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnTimKiem.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            btnTimKiem.Depth = 0;
            btnTimKiem.HighEmphasis = true;
            btnTimKiem.Icon = null;
            btnTimKiem.Location = new Point(1190, 45);
            btnTimKiem.Margin = new Padding(5);
            btnTimKiem.MouseState = MaterialSkin.MouseState.HOVER;
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.NoAccentTextColor = Color.Empty;
            btnTimKiem.Size = new Size(90, 53);
            btnTimKiem.TabIndex = 49;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnTimKiem.UseAccentColor = false;
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // materialButton4
            // 
            materialButton4.AutoSize = false;
            materialButton4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton4.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            materialButton4.Depth = 0;
            materialButton4.HighEmphasis = true;
            materialButton4.Icon = null;
            materialButton4.Location = new Point(538, 45);
            materialButton4.Margin = new Padding(5);
            materialButton4.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton4.Name = "materialButton4";
            materialButton4.NoAccentTextColor = Color.Empty;
            materialButton4.Size = new Size(98, 53);
            materialButton4.TabIndex = 48;
            materialButton4.Text = "Làm mới";
            materialButton4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            materialButton4.UseAccentColor = false;
            materialButton4.UseVisualStyleBackColor = true;
            materialButton4.Click += btnLamMoi_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.AutoSize = false;
            btnLamMoi.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLamMoi.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            btnLamMoi.Depth = 0;
            btnLamMoi.HighEmphasis = true;
            btnLamMoi.Icon = null;
            btnLamMoi.Location = new Point(538, 45);
            btnLamMoi.Margin = new Padding(5);
            btnLamMoi.MouseState = MaterialSkin.MouseState.HOVER;
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.NoAccentTextColor = Color.Empty;
            btnLamMoi.Size = new Size(98, 53);
            btnLamMoi.TabIndex = 47;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnLamMoi.UseAccentColor = false;
            btnLamMoi.UseVisualStyleBackColor = true;
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
            materialButton3.Location = new Point(365, 347);
            materialButton3.Margin = new Padding(5);
            materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton3.Name = "materialButton3";
            materialButton3.NoAccentTextColor = Color.Empty;
            materialButton3.Size = new Size(86, 46);
            materialButton3.TabIndex = 46;
            materialButton3.Text = "Xóa";
            materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            materialButton3.UseAccentColor = true;
            materialButton3.UseVisualStyleBackColor = false;
            materialButton3.Click += btnDelete_Click;
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
            btnDelete.Location = new Point(365, 347);
            btnDelete.Margin = new Padding(5);
            btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            btnDelete.Name = "btnDelete";
            btnDelete.NoAccentTextColor = Color.Empty;
            btnDelete.Size = new Size(86, 46);
            btnDelete.TabIndex = 45;
            btnDelete.Text = "Xóa";
            btnDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnDelete.UseAccentColor = true;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // materialButton2
            // 
            materialButton2.AutoSize = false;
            materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = null;
            materialButton2.Location = new Point(210, 347);
            materialButton2.Margin = new Padding(5);
            materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(82, 46);
            materialButton2.TabIndex = 44;
            materialButton2.Text = "Sửa";
            materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = true;
            materialButton2.Click += btnUpdate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.AutoSize = false;
            btnUpdate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUpdate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnUpdate.Depth = 0;
            btnUpdate.HighEmphasis = true;
            btnUpdate.Icon = null;
            btnUpdate.Location = new Point(210, 347);
            btnUpdate.Margin = new Padding(5);
            btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            btnUpdate.Name = "btnUpdate";
            btnUpdate.NoAccentTextColor = Color.Empty;
            btnUpdate.Size = new Size(82, 46);
            btnUpdate.TabIndex = 43;
            btnUpdate.Text = "Sửa";
            btnUpdate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnUpdate.UseAccentColor = false;
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // materialButton1
            // 
            materialButton1.AutoSize = false;
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(54, 347);
            materialButton1.Margin = new Padding(5);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(85, 46);
            materialButton1.TabIndex = 42;
            materialButton1.Text = "Thêm";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += btnAdd_Click;
            // 
            // btnAdd
            // 
            btnAdd.AutoSize = false;
            btnAdd.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAdd.Depth = 0;
            btnAdd.HighEmphasis = true;
            btnAdd.Icon = null;
            btnAdd.Location = new Point(54, 347);
            btnAdd.Margin = new Padding(5);
            btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            btnAdd.Name = "btnAdd";
            btnAdd.NoAccentTextColor = Color.Empty;
            btnAdd.Size = new Size(85, 46);
            btnAdd.TabIndex = 41;
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
            txtTimKiem.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTimKiem.LeadingIcon = null;
            txtTimKiem.Location = new Point(652, 45);
            txtTimKiem.MaxLength = 50;
            txtTimKiem.MouseState = MaterialSkin.MouseState.OUT;
            txtTimKiem.Multiline = false;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(509, 36);
            txtTimKiem.TabIndex = 40;
            txtTimKiem.Text = "";
            txtTimKiem.TrailingIcon = null;
            txtTimKiem.UseTallSize = false;
            // 
            // dataGridViewKhachHang
            // 
            dataGridViewKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewKhachHang.Location = new Point(538, 112);
            dataGridViewKhachHang.Name = "dataGridViewKhachHang";
            dataGridViewKhachHang.RowHeadersWidth = 51;
            dataGridViewKhachHang.Size = new Size(743, 530);
            dataGridViewKhachHang.TabIndex = 38;
            dataGridViewKhachHang.SelectionChanged += dataGridViewKhachHang_SelectionChanged;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(181, 149);
            txtSDT.Margin = new Padding(3, 4, 3, 4);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(309, 27);
            txtSDT.TabIndex = 57;
            // 
            // lblSDT
            // 
            lblSDT.BorderStyle = BorderStyle.FixedSingle;
            lblSDT.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSDT.ForeColor = SystemColors.ActiveCaptionText;
            lblSDT.Location = new Point(21, 149);
            lblSDT.Margin = new Padding(6, 7, 6, 7);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(125, 30);
            lblSDT.TabIndex = 58;
            lblSDT.Text = "Số điện thoại";
            lblSDT.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(181, 200);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(309, 27);
            txtEmail.TabIndex = 59;
            // 
            // lblEmail
            // 
            lblEmail.BorderStyle = BorderStyle.FixedSingle;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEmail.ForeColor = SystemColors.ActiveCaptionText;
            lblEmail.Location = new Point(21, 200);
            lblEmail.Margin = new Padding(6, 7, 6, 7);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(125, 30);
            lblEmail.TabIndex = 60;
            lblEmail.Text = "Email";
            lblEmail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // richTextDiaChi
            // 
            richTextDiaChi.Location = new Point(181, 253);
            richTextDiaChi.Margin = new Padding(3, 4, 3, 4);
            richTextDiaChi.Name = "richTextDiaChi";
            richTextDiaChi.Size = new Size(309, 61);
            richTextDiaChi.TabIndex = 62;
            richTextDiaChi.Text = "";
            // 
            // lblDiaChi
            // 
            lblDiaChi.BorderStyle = BorderStyle.FixedSingle;
            lblDiaChi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDiaChi.ForeColor = SystemColors.ActiveCaptionText;
            lblDiaChi.Location = new Point(18, 252);
            lblDiaChi.Margin = new Padding(6, 7, 6, 7);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(128, 30);
            lblDiaChi.TabIndex = 61;
            lblDiaChi.Text = "Địa chỉ";
            lblDiaChi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1299, 679);
            Controls.Add(richTextDiaChi);
            Controls.Add(lblDiaChi);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtSDT);
            Controls.Add(lblSDT);
            Controls.Add(txtTenKH);
            Controls.Add(lblTenKH);
            Controls.Add(txtMaKH);
            Controls.Add(lblMaKH);
            Controls.Add(materialButton5);
            Controls.Add(btnTimKiem);
            Controls.Add(materialButton4);
            Controls.Add(btnLamMoi);
            Controls.Add(materialButton3);
            Controls.Add(btnDelete);
            Controls.Add(materialButton2);
            Controls.Add(btnUpdate);
            Controls.Add(materialButton1);
            Controls.Add(btnAdd);
            Controls.Add(txtTimKiem);
            Controls.Add(dataGridViewKhachHang);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmKhachHang";
            Text = "frmKhachHang";
            Load += frmKhachHang_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewKhachHang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTenKH;
        private Label lblTenKH;
        private TextBox txtMaKH;
        private Label lblMaKH;
        private MaterialSkin.Controls.MaterialButton materialButton5;
        private MaterialSkin.Controls.MaterialButton btnTimKiem;
        private MaterialSkin.Controls.MaterialButton materialButton4;
        private MaterialSkin.Controls.MaterialButton btnLamMoi;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private MaterialSkin.Controls.MaterialButton btnDelete;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialButton btnUpdate;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton btnAdd;
        private MaterialSkin.Controls.MaterialTextBox txtTimKiem;
        private DataGridView dataGridViewKhachHang;
        private TextBox txtSDT;
        private Label lblSDT;
        private TextBox txtEmail;
        private Label lblEmail;
        private RichTextBox richTextDiaChi;
        private Label lblDiaChi;
    }
}