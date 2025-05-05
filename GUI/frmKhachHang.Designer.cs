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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhachHang));
            txtTenKH = new TextBox();
            lblTenKH = new Label();
            txtMaKH = new TextBox();
            lblMaKH = new Label();
            btnTimKiem = new MaterialSkin.Controls.MaterialButton();
            btnLamMoi = new MaterialSkin.Controls.MaterialButton();
            btnDelete = new MaterialSkin.Controls.MaterialButton();
            btnUpdate = new MaterialSkin.Controls.MaterialButton();
            btnAdd = new MaterialSkin.Controls.MaterialButton();
            txtTimKiem = new MaterialSkin.Controls.MaterialTextBox();
            dataGridViewKhachHang = new DataGridView();
            txtSDT = new TextBox();
            lblSDT = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            richTextDiaChi = new RichTextBox();
            lblDiaChi = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewKhachHang).BeginInit();
            SuspendLayout();
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(189, 166);
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
            lblTenKH.Location = new Point(29, 166);
            lblTenKH.Margin = new Padding(6, 7, 6, 7);
            lblTenKH.Name = "lblTenKH";
            lblTenKH.Size = new Size(125, 30);
            lblTenKH.TabIndex = 56;
            lblTenKH.Text = "Tên khách hàng";
            lblTenKH.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtMaKH
            // 
            txtMaKH.Location = new Point(189, 115);
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
            lblMaKH.Location = new Point(29, 115);
            lblMaKH.Margin = new Padding(6, 7, 6, 7);
            lblMaKH.Name = "lblMaKH";
            lblMaKH.Size = new Size(125, 30);
            lblMaKH.TabIndex = 51;
            lblMaKH.Text = "Mã khách hàng";
            lblMaKH.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnTimKiem
            // 
            btnTimKiem.AutoSize = false;
            btnTimKiem.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnTimKiem.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            btnTimKiem.Depth = 0;
            btnTimKiem.HighEmphasis = true;
            btnTimKiem.Icon = null;
            btnTimKiem.Location = new Point(1186, 72);
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
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.AutoSize = false;
            btnLamMoi.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLamMoi.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            btnLamMoi.Depth = 0;
            btnLamMoi.HighEmphasis = true;
            btnLamMoi.Icon = null;
            btnLamMoi.Location = new Point(541, 72);
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
            btnDelete.Location = new Point(380, 461);
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
            btnUpdate.Location = new Point(222, 461);
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
            btnAdd.Location = new Point(69, 461);
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
            btnAdd.Click += btnAdd_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.AnimateReadOnly = false;
            txtTimKiem.BorderStyle = BorderStyle.None;
            txtTimKiem.Depth = 0;
            txtTimKiem.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTimKiem.LeadingIcon = null;
            txtTimKiem.Location = new Point(655, 72);
            txtTimKiem.MaxLength = 50;
            txtTimKiem.MouseState = MaterialSkin.MouseState.OUT;
            txtTimKiem.Multiline = false;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(509, 50);
            txtTimKiem.TabIndex = 40;
            txtTimKiem.Text = "";
            txtTimKiem.TrailingIcon = null;
            // 
            // dataGridViewKhachHang
            // 
            dataGridViewKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewKhachHang.Location = new Point(541, 154);
            dataGridViewKhachHang.Name = "dataGridViewKhachHang";
            dataGridViewKhachHang.RowHeadersWidth = 51;
            dataGridViewKhachHang.Size = new Size(732, 434);
            dataGridViewKhachHang.TabIndex = 38;
            dataGridViewKhachHang.CellContentClick += dataGridViewKhachHang_CellContentClick;
            dataGridViewKhachHang.SelectionChanged += dataGridViewKhachHang_SelectionChanged;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(189, 219);
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
            lblSDT.Location = new Point(29, 219);
            lblSDT.Margin = new Padding(6, 7, 6, 7);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(125, 30);
            lblSDT.TabIndex = 58;
            lblSDT.Text = "Số điện thoại";
            lblSDT.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(189, 270);
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
            lblEmail.Location = new Point(29, 270);
            lblEmail.Margin = new Padding(6, 7, 6, 7);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(125, 30);
            lblEmail.TabIndex = 60;
            lblEmail.Text = "Email";
            lblEmail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // richTextDiaChi
            // 
            richTextDiaChi.Location = new Point(189, 323);
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
            lblDiaChi.Location = new Point(26, 322);
            lblDiaChi.Margin = new Padding(6, 7, 6, 7);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(128, 30);
            lblDiaChi.TabIndex = 61;
            lblDiaChi.Text = "Địa chỉ";
            lblDiaChi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(56, 32);
            label1.Name = "label1";
            label1.Size = new Size(407, 36);
            label1.TabIndex = 63;
            label1.Text = "QUẢN LÝ KHÁCH HÀNG";
            // 
            // frmKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1299, 623);
            Controls.Add(label1);
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
            Controls.Add(btnTimKiem);
            Controls.Add(btnLamMoi);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtTimKiem);
            Controls.Add(dataGridViewKhachHang);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmKhachHang";
            StartPosition = FormStartPosition.CenterScreen;
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
        private Label label1;
    }
}