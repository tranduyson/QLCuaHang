namespace GUI
{
    partial class frmBaoCao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaoCao));
            btnXemDoanhThuTheoNgay = new Button();
            btnXemBaoCaoDoanhThuTheoKhach = new Button();
            btn_BaoCaoTonKhoSanPHam = new Button();
            button4 = new Button();
            btnBaoCaoSanPhamBanChay = new Button();
            btnBaoCaoLuongNhanVien = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnXemDoanhThuTheoNgay
            // 
            btnXemDoanhThuTheoNgay.Image = (Image)resources.GetObject("btnXemDoanhThuTheoNgay.Image");
            btnXemDoanhThuTheoNgay.ImageAlign = ContentAlignment.TopCenter;
            btnXemDoanhThuTheoNgay.Location = new Point(390, 150);
            btnXemDoanhThuTheoNgay.Name = "btnXemDoanhThuTheoNgay";
            btnXemDoanhThuTheoNgay.Size = new Size(196, 193);
            btnXemDoanhThuTheoNgay.TabIndex = 0;
            btnXemDoanhThuTheoNgay.Text = "Báo cáo tổng doanh thu theo ngày";
            btnXemDoanhThuTheoNgay.TextAlign = ContentAlignment.BottomCenter;
            btnXemDoanhThuTheoNgay.UseVisualStyleBackColor = true;
            btnXemDoanhThuTheoNgay.Click += btnXemDoanhThuTheoNgay_Click;
            // 
            // btnXemBaoCaoDoanhThuTheoKhach
            // 
            btnXemBaoCaoDoanhThuTheoKhach.Image = (Image)resources.GetObject("btnXemBaoCaoDoanhThuTheoKhach.Image");
            btnXemBaoCaoDoanhThuTheoKhach.ImageAlign = ContentAlignment.TopCenter;
            btnXemBaoCaoDoanhThuTheoKhach.Location = new Point(897, 150);
            btnXemBaoCaoDoanhThuTheoKhach.Name = "btnXemBaoCaoDoanhThuTheoKhach";
            btnXemBaoCaoDoanhThuTheoKhach.Size = new Size(187, 193);
            btnXemBaoCaoDoanhThuTheoKhach.TabIndex = 1;
            btnXemBaoCaoDoanhThuTheoKhach.Text = "Báo cáo tổng hợp doanh thu theo khách hàng";
            btnXemBaoCaoDoanhThuTheoKhach.TextAlign = ContentAlignment.BottomCenter;
            btnXemBaoCaoDoanhThuTheoKhach.UseVisualStyleBackColor = true;
            btnXemBaoCaoDoanhThuTheoKhach.Click += btnXemBaoCaoDoanhThuTheoKhach_Click;
            // 
            // btn_BaoCaoTonKhoSanPHam
            // 
            btn_BaoCaoTonKhoSanPHam.Image = (Image)resources.GetObject("btn_BaoCaoTonKhoSanPHam.Image");
            btn_BaoCaoTonKhoSanPHam.ImageAlign = ContentAlignment.TopCenter;
            btn_BaoCaoTonKhoSanPHam.Location = new Point(648, 396);
            btn_BaoCaoTonKhoSanPHam.Name = "btn_BaoCaoTonKhoSanPHam";
            btn_BaoCaoTonKhoSanPHam.Size = new Size(196, 182);
            btn_BaoCaoTonKhoSanPHam.TabIndex = 2;
            btn_BaoCaoTonKhoSanPHam.Text = "Báo cáo tồn kho sản phẩm";
            btn_BaoCaoTonKhoSanPHam.TextAlign = ContentAlignment.BottomCenter;
            btn_BaoCaoTonKhoSanPHam.UseVisualStyleBackColor = true;
            btn_BaoCaoTonKhoSanPHam.Click += btn_BaoCaoTonKhoSanPHam_Click;
            // 
            // button4
            // 
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.TopCenter;
            button4.Location = new Point(648, 150);
            button4.Name = "button4";
            button4.Size = new Size(196, 193);
            button4.TabIndex = 3;
            button4.Text = "Báo cáo chi tiết đơn hàng theo mã đơn hàng";
            button4.TextAlign = ContentAlignment.BottomCenter;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // btnBaoCaoSanPhamBanChay
            // 
            btnBaoCaoSanPhamBanChay.Image = (Image)resources.GetObject("btnBaoCaoSanPhamBanChay.Image");
            btnBaoCaoSanPhamBanChay.ImageAlign = ContentAlignment.TopCenter;
            btnBaoCaoSanPhamBanChay.Location = new Point(390, 396);
            btnBaoCaoSanPhamBanChay.Name = "btnBaoCaoSanPhamBanChay";
            btnBaoCaoSanPhamBanChay.Size = new Size(196, 182);
            btnBaoCaoSanPhamBanChay.TabIndex = 4;
            btnBaoCaoSanPhamBanChay.Text = "Báo cáo sản phẩm bán chạy nhất";
            btnBaoCaoSanPhamBanChay.TextAlign = ContentAlignment.BottomCenter;
            btnBaoCaoSanPhamBanChay.UseVisualStyleBackColor = true;
            btnBaoCaoSanPhamBanChay.Click += btnBaoCaoSanPhamBanChay_Click;
            // 
            // btnBaoCaoLuongNhanVien
            // 
            btnBaoCaoLuongNhanVien.Image = (Image)resources.GetObject("btnBaoCaoLuongNhanVien.Image");
            btnBaoCaoLuongNhanVien.ImageAlign = ContentAlignment.TopCenter;
            btnBaoCaoLuongNhanVien.Location = new Point(897, 396);
            btnBaoCaoLuongNhanVien.Name = "btnBaoCaoLuongNhanVien";
            btnBaoCaoLuongNhanVien.Size = new Size(187, 182);
            btnBaoCaoLuongNhanVien.TabIndex = 5;
            btnBaoCaoLuongNhanVien.Text = "Báo cáo lương nhân viên theo chức vụ";
            btnBaoCaoLuongNhanVien.TextAlign = ContentAlignment.BottomCenter;
            btnBaoCaoLuongNhanVien.UseVisualStyleBackColor = true;
            btnBaoCaoLuongNhanVien.Click += btnBaoCaoLuongNhanVien_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(671, 70);
            label1.Name = "label1";
            label1.Size = new Size(172, 46);
            label1.TabIndex = 6;
            label1.Text = "BÁO CÁO";
            // 
            // frmBaoCao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1299, 679);
            Controls.Add(label1);
            Controls.Add(btnBaoCaoLuongNhanVien);
            Controls.Add(btnBaoCaoSanPhamBanChay);
            Controls.Add(button4);
            Controls.Add(btn_BaoCaoTonKhoSanPHam);
            Controls.Add(btnXemBaoCaoDoanhThuTheoKhach);
            Controls.Add(btnXemDoanhThuTheoNgay);
            Name = "frmBaoCao";
            Text = "frmBaoCao";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button btnXemBaoCaoDoanhThuTheoKhach;
        private Button btn_BaoCaoTonKhoSanPHam;
        private Button button4;
        private Button btnBaoCaoSanPhamBanChay;
        private Button btnBaoCaoLuongNhanVien;
        private Label label1;
        private Button btnXemDoanhThuTheoNgay;
    }
}