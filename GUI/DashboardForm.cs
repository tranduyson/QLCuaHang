using System;
using System.Windows.Forms;
using GUI;

namespace DashboardWinForm
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
            LoadFormToTab(new frmNhanVien(), tabNhanVien);
            LoadFormToTab(new frmKhachHang(), tabKhachHang);
            LoadFormToTab(new frmChucVu(), tabChucVu);
            LoadFormToTab(new frmSanPham(), tabSanPham);
            LoadFormToTab(new frmChiTietDonHang(), tabChiTietDonHang);
            LoadFormToTab(new frmChiTietPhieuNhap(), tabChiTietNhap);
            LoadFormToTab(new frmDonHang(), tabDonHang);
            LoadFormToTab(new frmLuong(), tabLuong);
            LoadFormToTab(new frmPhieuNhap(), tabPhieuNhap);
        }
        private void LoadFormToTab(Form form, TabPage tab)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            tab.Controls.Clear();        // Xoá nội dung cũ nếu có
            tab.Controls.Add(form);      // Thêm form con
            form.Show();                 // Hiển thị
        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            tabControl1 = new TabControl();
            tabTongQuan = new TabPage();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button3 = new Button();
            btnNhanVien = new Button();
            btnDonHang = new Button();
            tabDonHang = new TabPage();
            tabKhachHang = new TabPage();
            tabNhanVien = new TabPage();
            tabChucVu = new TabPage();
            tabSanPham = new TabPage();
            tabLuong = new TabPage();
            tabPhieuNhap = new TabPage();
            tabChiTietNhap = new TabPage();
            tabChiTietDonHang = new TabPage();
            tabControl1.SuspendLayout();
            tabTongQuan.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabTongQuan);
            tabControl1.Controls.Add(tabDonHang);
            tabControl1.Controls.Add(tabKhachHang);
            tabControl1.Controls.Add(tabNhanVien);
            tabControl1.Controls.Add(tabChucVu);
            tabControl1.Controls.Add(tabSanPham);
            tabControl1.Controls.Add(tabLuong);
            tabControl1.Controls.Add(tabPhieuNhap);
            tabControl1.Controls.Add(tabChiTietNhap);
            tabControl1.Controls.Add(tabChiTietDonHang);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1299, 679);
            tabControl1.TabIndex = 0;
            // 
            // tabTongQuan
            // 
            tabTongQuan.Controls.Add(button7);
            tabTongQuan.Controls.Add(button8);
            tabTongQuan.Controls.Add(button9);
            tabTongQuan.Controls.Add(button4);
            tabTongQuan.Controls.Add(button5);
            tabTongQuan.Controls.Add(button6);
            tabTongQuan.Controls.Add(button3);
            tabTongQuan.Controls.Add(btnNhanVien);
            tabTongQuan.Controls.Add(btnDonHang);
            tabTongQuan.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabTongQuan.ForeColor = Color.Blue;
            tabTongQuan.Location = new Point(4, 29);
            tabTongQuan.Name = "tabTongQuan";
            tabTongQuan.Padding = new Padding(3);
            tabTongQuan.Size = new Size(1291, 646);
            tabTongQuan.TabIndex = 0;
            tabTongQuan.Text = "🏠 Tổng quan";
            tabTongQuan.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.ImageAlign = ContentAlignment.TopCenter;
            button7.Location = new Point(894, 473);
            button7.Name = "button7";
            button7.Size = new Size(142, 134);
            button7.TabIndex = 8;
            button7.Text = "Chi tiết phiếu nhập";
            button7.TextAlign = ContentAlignment.BottomCenter;
            button7.TextImageRelation = TextImageRelation.ImageAboveText;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.DialogResult = DialogResult.Abort;
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.ImageAlign = ContentAlignment.TopCenter;
            button8.Location = new Point(582, 473);
            button8.Name = "button8";
            button8.Size = new Size(142, 134);
            button8.TabIndex = 7;
            button8.Text = "Phiếu nhập";
            button8.TextImageRelation = TextImageRelation.ImageAboveText;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Image = (Image)resources.GetObject("button9.Image");
            button9.ImageAlign = ContentAlignment.TopCenter;
            button9.Location = new Point(273, 473);
            button9.Name = "button9";
            button9.Size = new Size(142, 134);
            button9.TabIndex = 6;
            button9.Text = "Chi tiết đơn hàng";
            button9.TextAlign = ContentAlignment.BottomCenter;
            button9.TextImageRelation = TextImageRelation.ImageAboveText;
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button4
            // 
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.TopCenter;
            button4.Location = new Point(894, 265);
            button4.Name = "button4";
            button4.Size = new Size(142, 134);
            button4.TabIndex = 5;
            button4.Text = "Lương";
            button4.TextAlign = ContentAlignment.BottomCenter;
            button4.TextImageRelation = TextImageRelation.ImageAboveText;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.TopCenter;
            button5.Location = new Point(582, 265);
            button5.Name = "button5";
            button5.Size = new Size(142, 134);
            button5.TabIndex = 4;
            button5.Text = "Sản phẩm";
            button5.TextAlign = ContentAlignment.BottomCenter;
            button5.TextImageRelation = TextImageRelation.ImageAboveText;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.TopCenter;
            button6.Location = new Point(273, 265);
            button6.Name = "button6";
            button6.Size = new Size(142, 134);
            button6.TabIndex = 3;
            button6.Text = "Khách hàng";
            button6.TextAlign = ContentAlignment.BottomCenter;
            button6.TextImageRelation = TextImageRelation.ImageAboveText;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button3
            // 
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.TopCenter;
            button3.Location = new Point(894, 55);
            button3.Name = "button3";
            button3.Size = new Size(142, 134);
            button3.TabIndex = 2;
            button3.Text = "Chức vụ";
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.TextImageRelation = TextImageRelation.ImageAboveText;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btnNhanVien
            // 
            btnNhanVien.DialogResult = DialogResult.Abort;
            btnNhanVien.Image = (Image)resources.GetObject("btnNhanVien.Image");
            btnNhanVien.ImageAlign = ContentAlignment.TopCenter;
            btnNhanVien.Location = new Point(582, 55);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Size = new Size(142, 134);
            btnNhanVien.TabIndex = 1;
            btnNhanVien.Text = "Nhân viên";
            btnNhanVien.TextImageRelation = TextImageRelation.ImageAboveText;
            btnNhanVien.UseVisualStyleBackColor = true;
            btnNhanVien.Click += btnNhanVien_Click;
            // 
            // btnDonHang
            // 
            btnDonHang.Image = (Image)resources.GetObject("btnDonHang.Image");
            btnDonHang.ImageAlign = ContentAlignment.TopCenter;
            btnDonHang.Location = new Point(273, 55);
            btnDonHang.Name = "btnDonHang";
            btnDonHang.Size = new Size(142, 134);
            btnDonHang.TabIndex = 0;
            btnDonHang.Text = "Đơn hàng";
            btnDonHang.TextAlign = ContentAlignment.BottomCenter;
            btnDonHang.TextImageRelation = TextImageRelation.ImageAboveText;
            btnDonHang.UseVisualStyleBackColor = true;
            btnDonHang.Click += btnDonHang_Click;
            // 
            // tabDonHang
            // 
            tabDonHang.Location = new Point(4, 29);
            tabDonHang.Name = "tabDonHang";
            tabDonHang.Padding = new Padding(3);
            tabDonHang.Size = new Size(1291, 646);
            tabDonHang.TabIndex = 3;
            tabDonHang.Text = "\U0001f9fe Đơn hàng";
            tabDonHang.UseVisualStyleBackColor = true;
            // 
            // tabKhachHang
            // 
            tabKhachHang.Location = new Point(4, 29);
            tabKhachHang.Name = "tabKhachHang";
            tabKhachHang.Padding = new Padding(3);
            tabKhachHang.Size = new Size(1291, 646);
            tabKhachHang.TabIndex = 1;
            tabKhachHang.Text = "👥 Khách hàng";
            tabKhachHang.UseVisualStyleBackColor = true;
            // 
            // tabNhanVien
            // 
            tabNhanVien.Location = new Point(4, 29);
            tabNhanVien.Name = "tabNhanVien";
            tabNhanVien.Padding = new Padding(3);
            tabNhanVien.Size = new Size(1291, 646);
            tabNhanVien.TabIndex = 2;
            tabNhanVien.Text = "👤 nhân viên";
            tabNhanVien.UseVisualStyleBackColor = true;
            // 
            // tabChucVu
            // 
            tabChucVu.Location = new Point(4, 29);
            tabChucVu.Name = "tabChucVu";
            tabChucVu.Size = new Size(1291, 646);
            tabChucVu.TabIndex = 4;
            tabChucVu.Text = "\U0001f9d1‍💼 Chức vụ";
            tabChucVu.UseVisualStyleBackColor = true;
            // 
            // tabSanPham
            // 
            tabSanPham.Location = new Point(4, 29);
            tabSanPham.Name = "tabSanPham";
            tabSanPham.Size = new Size(1291, 646);
            tabSanPham.TabIndex = 5;
            tabSanPham.Text = "📦 Sản phẩm";
            tabSanPham.UseVisualStyleBackColor = true;
            // 
            // tabLuong
            // 
            tabLuong.Location = new Point(4, 29);
            tabLuong.Name = "tabLuong";
            tabLuong.Size = new Size(1291, 646);
            tabLuong.TabIndex = 6;
            tabLuong.Text = "💰 Lương";
            tabLuong.UseVisualStyleBackColor = true;
            // 
            // tabPhieuNhap
            // 
            tabPhieuNhap.Location = new Point(4, 29);
            tabPhieuNhap.Name = "tabPhieuNhap";
            tabPhieuNhap.Size = new Size(1291, 646);
            tabPhieuNhap.TabIndex = 7;
            tabPhieuNhap.Text = "📥 Phiếu nhập";
            tabPhieuNhap.UseVisualStyleBackColor = true;
            // 
            // tabChiTietNhap
            // 
            tabChiTietNhap.Location = new Point(4, 29);
            tabChiTietNhap.Name = "tabChiTietNhap";
            tabChiTietNhap.Size = new Size(1291, 646);
            tabChiTietNhap.TabIndex = 8;
            tabChiTietNhap.Text = "📋 Chi tiết phiếu nhập";
            tabChiTietNhap.UseVisualStyleBackColor = true;
            // 
            // tabChiTietDonHang
            // 
            tabChiTietDonHang.Location = new Point(4, 29);
            tabChiTietDonHang.Name = "tabChiTietDonHang";
            tabChiTietDonHang.Size = new Size(1291, 646);
            tabChiTietDonHang.TabIndex = 9;
            tabChiTietDonHang.Text = "📄 Chi tiết đơn hàng";
            tabChiTietDonHang.UseVisualStyleBackColor = true;
            // 
            // frmDashboard
            // 
            ClientSize = new Size(1299, 679);
            Controls.Add(tabControl1);
            Name = "frmDashboard";
            tabControl1.ResumeLayout(false);
            tabTongQuan.ResumeLayout(false);
            ResumeLayout(false);

        }
        private TabControl tabControl1;
        private TabPage tabTongQuan;
        private TabPage tabKhachHang;
        private TabPage tabNhanVien;
        private TabPage tabDonHang;
        private TabPage tabChucVu;
        private TabPage tabSanPham;
        private Button btnDonHang;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button3;
        private Button btnNhanVien;
        private Button button7;
        private Button button8;
        private Button button9;
        private TabPage tabLuong;
        private TabPage tabPhieuNhap;
        private TabPage tabChiTietNhap;
        private TabPage tabChiTietDonHang;

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabNhanVien;
        }

        private void btnDonHang_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabDonHang;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabChucVu;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabKhachHang;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabSanPham;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabLuong;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabChiTietDonHang;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPhieuNhap;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabChiTietNhap;
        }
    }
}
