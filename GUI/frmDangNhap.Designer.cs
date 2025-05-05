namespace GUI
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            lblTenDangNhap = new Label();
            lblMatKhau = new Label();
            txtTenDangNhap = new TextBox();
            txtMatKhau = new TextBox();
            btnDangNhap = new Button();
            ckHienThiMatKhau = new CheckBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblTenDangNhap
            // 
            lblTenDangNhap.AutoSize = true;
            lblTenDangNhap.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTenDangNhap.Image = (Image)resources.GetObject("lblTenDangNhap.Image");
            lblTenDangNhap.Location = new Point(181, 134);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new Size(128, 23);
            lblTenDangNhap.TabIndex = 0;
            lblTenDangNhap.Text = "Tên đăng nhập:";
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMatKhau.Image = (Image)resources.GetObject("lblMatKhau.Image");
            lblMatKhau.Location = new Point(181, 198);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(88, 23);
            lblMatKhau.TabIndex = 1;
            lblMatKhau.Text = "Mật khẩu:";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.BorderStyle = BorderStyle.FixedSingle;
            txtTenDangNhap.Location = new Point(181, 160);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(359, 27);
            txtTenDangNhap.TabIndex = 2;
            txtTenDangNhap.TextAlign = HorizontalAlignment.Center;
            txtTenDangNhap.TextChanged += textBox1_TextChanged;
            txtTenDangNhap.Enter += txtTenDangNhap_Enter;
            txtTenDangNhap.Leave += txtTenDangNhap_Leave;
            // 
            // txtMatKhau
            // 
            txtMatKhau.BorderStyle = BorderStyle.FixedSingle;
            txtMatKhau.Location = new Point(181, 224);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(359, 27);
            txtMatKhau.TabIndex = 3;
            txtMatKhau.TextAlign = HorizontalAlignment.Center;
            txtMatKhau.Enter += txtMatKhau_Enter;
            txtMatKhau.Leave += txtMatKhau_Leave;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Location = new Point(272, 299);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(185, 56);
            btnDangNhap.TabIndex = 4;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // ckHienThiMatKhau
            // 
            ckHienThiMatKhau.AutoSize = true;
            ckHienThiMatKhau.BackgroundImage = (Image)resources.GetObject("ckHienThiMatKhau.BackgroundImage");
            ckHienThiMatKhau.Location = new Point(202, 257);
            ckHienThiMatKhau.Name = "ckHienThiMatKhau";
            ckHienThiMatKhau.Size = new Size(148, 24);
            ckHienThiMatKhau.TabIndex = 5;
            ckHienThiMatKhau.Text = "HIển thị mật khẩu";
            ckHienThiMatKhau.UseVisualStyleBackColor = true;
            ckHienThiMatKhau.CheckedChanged += ckHienThiMatKhau_CheckedChanged_1;
            ckHienThiMatKhau.Click += ckHienThiMatKhau_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(140, 63);
            label1.Name = "label1";
            label1.Size = new Size(495, 44);
            label1.TabIndex = 6;
            label1.Text = "HỆ THỐNG ĐĂNG NHẬP";
            label1.Click += label1_Click;
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(702, 405);
            Controls.Add(label1);
            Controls.Add(ckHienThiMatKhau);
            Controls.Add(btnDangNhap);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTenDangNhap);
            Controls.Add(lblMatKhau);
            Controls.Add(lblTenDangNhap);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý cửa hàng";
            Load += frmDangNhap_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTenDangNhap;
        private Label lblMatKhau;
        private TextBox txtTenDangNhap;
        private TextBox textBox2;
        private Button btnDangNhap;
        public TextBox txtMatKhau;
        private CheckBox ckHienThiMatKhau;
        private Label label1;
    }
}