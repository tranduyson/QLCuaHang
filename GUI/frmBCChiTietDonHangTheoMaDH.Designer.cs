namespace GUI
{
    partial class frmBCChiTietDonHangTheoMaSP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
       

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnXoa = new MaterialSkin.Controls.MaterialButton();
            btnTimKiem = new MaterialSkin.Controls.MaterialButton();
            dgChiTietDoHang = new DataGridView();
            lblMaDH = new Label();
            txtMaDH = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgChiTietDoHang).BeginInit();
       
            // 
            // btnXoa
            // 
            btnXoa.AutoSize = false;
            btnXoa.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnXoa.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnXoa.Depth = 0;
            btnXoa.Enabled = false;
            btnXoa.HighEmphasis = true;
            btnXoa.Icon = null;
            btnXoa.Location = new Point(809, 42);
            btnXoa.Margin = new Padding(5);
            btnXoa.MouseState = MaterialSkin.MouseState.HOVER;
            btnXoa.Name = "btnXoa";
            btnXoa.NoAccentTextColor = Color.Empty;
            btnXoa.Size = new Size(137, 36);
            btnXoa.TabIndex = 68;
            btnXoa.Text = "In Danh sách";
            btnXoa.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnXoa.UseAccentColor = false;
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            btnTimKiem.AutoSize = false;
            btnTimKiem.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnTimKiem.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnTimKiem.Depth = 0;
            btnTimKiem.HighEmphasis = true;
            btnTimKiem.Icon = null;
            btnTimKiem.Location = new Point(692, 42);
            btnTimKiem.Margin = new Padding(5);
            btnTimKiem.MouseState = MaterialSkin.MouseState.HOVER;
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.NoAccentTextColor = Color.Empty;
            btnTimKiem.Size = new Size(93, 36);
            btnTimKiem.TabIndex = 67;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnTimKiem.UseAccentColor = false;
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // dgChiTietDoHang
            // 
            dgChiTietDoHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgChiTietDoHang.Location = new Point(35, 110);
            dgChiTietDoHang.Name = "dgChiTietDoHang";
            dgChiTietDoHang.RowHeadersWidth = 51;
            dgChiTietDoHang.Size = new Size(924, 491);
            dgChiTietDoHang.TabIndex = 69;
            // 
            // lblMaDH
            // 
            lblMaDH.BorderStyle = BorderStyle.FixedSingle;
            lblMaDH.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMaDH.ForeColor = SystemColors.ActiveCaptionText;
            lblMaDH.Location = new Point(63, 42);
            lblMaDH.Margin = new Padding(6, 7, 6, 7);
            lblMaDH.Name = "lblMaDH";
            lblMaDH.Size = new Size(151, 30);
            lblMaDH.TabIndex = 71;
            lblMaDH.Text = "Mã đơn hàng";
            lblMaDH.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtMaDH
            // 
            txtMaDH.Location = new Point(223, 44);
            txtMaDH.Margin = new Padding(3, 4, 3, 4);
            txtMaDH.Name = "txtMaDH";
            txtMaDH.ReadOnly = true;
            txtMaDH.Size = new Size(439, 27);
            txtMaDH.TabIndex = 70;
            // 
            // frmBCChiTietDonHangTheoMaSP
            // 
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnXoa;
        private MaterialSkin.Controls.MaterialButton btnTimKiem;
        private DataGridView dgChiTietDoHang;
        private Label lblMaDH;
        private TextBox txtMaDH;
    }
}