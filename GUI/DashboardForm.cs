using System;
using System.Windows.Forms;
using GUI;
using QLCuaHang.DTO;

namespace DashboardWinForm
{
    public partial class frmDashboard : Form
    {
        private NhanVienDTO nhanVien;

        public frmDashboard(NhanVienDTO nv)
        {
            this.nhanVien = nv;

            InitializeComponent();
            LoadFormToTab(new frmNhanVien(), tabNhanVien);
            LoadFormToTab(new frmKhachHang(), tabKhachHang);
            LoadFormToTab(new frmChucVu(), tabChucVu);
            LoadFormToTab(new frmSanPham(), tabSanPham);


            LoadFormToTab(new frmDonHang(), tabDonHang);
            LoadFormToTab(new frmDanhSachDonHang(), tabDSDonHang);
            LoadFormToTab(new frmPhieuNhap(), tabPhieuNhap);
            LoadFormToTab(new frmBaoCao(), tabBaoCao);

            lblwellcome.Text = string.Format("Xin chào, {0}", nv.HoTen);
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
            btnBaoCao = new Button();
            btnDangXuat = new Button();
            lblwellcome = new Label();
            button1 = new Button();
            label1 = new Label();
            button8 = new Button();
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
            tabPhieuNhap = new TabPage();
            tabDSDonHang = new TabPage();
            tabBaoCao = new TabPage();
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
            tabControl1.Controls.Add(tabPhieuNhap);
            tabControl1.Controls.Add(tabDSDonHang);
            tabControl1.Controls.Add(tabBaoCao);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1301, 640);
            tabControl1.TabIndex = 0;
            // 
            // tabTongQuan
            // 
            tabTongQuan.BackColor = Color.Transparent;
            tabTongQuan.Controls.Add(btnBaoCao);
            tabTongQuan.Controls.Add(btnDangXuat);
            tabTongQuan.Controls.Add(lblwellcome);
            tabTongQuan.Controls.Add(button1);
            tabTongQuan.Controls.Add(label1);
            tabTongQuan.Controls.Add(button8);
            tabTongQuan.Controls.Add(button5);
            tabTongQuan.Controls.Add(button6);
            tabTongQuan.Controls.Add(button3);
            tabTongQuan.Controls.Add(btnNhanVien);
            tabTongQuan.Controls.Add(btnDonHang);
            tabTongQuan.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabTongQuan.ForeColor = Color.DodgerBlue;
            tabTongQuan.Location = new Point(4, 29);
            tabTongQuan.Name = "tabTongQuan";
            tabTongQuan.Padding = new Padding(3);
            tabTongQuan.Size = new Size(1293, 607);
            tabTongQuan.TabIndex = 0;
            tabTongQuan.Text = "🏠 Tổng quan";
            // 
            // btnBaoCao
            // 
            btnBaoCao.BackColor = Color.WhiteSmoke;
            btnBaoCao.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBaoCao.ForeColor = Color.Black;
            btnBaoCao.Image = (Image)resources.GetObject("btnBaoCao.Image");
            btnBaoCao.Location = new Point(555, 456);
            btnBaoCao.Name = "btnBaoCao";
            btnBaoCao.Size = new Size(142, 133);
            btnBaoCao.TabIndex = 13;
            btnBaoCao.Text = "Báo cáo";
            btnBaoCao.TextAlign = ContentAlignment.BottomCenter;
            btnBaoCao.UseVisualStyleBackColor = false;
            btnBaoCao.Click += btnBaoCao_Click;
            // 
            // btnDangXuat
            // 
            btnDangXuat.BackColor = Color.WhiteSmoke;
            btnDangXuat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangXuat.ForeColor = Color.Black;
            btnDangXuat.Image = (Image)resources.GetObject("btnDangXuat.Image");
            btnDangXuat.ImageAlign = ContentAlignment.TopCenter;
            btnDangXuat.Location = new Point(1153, 6);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(98, 91);
            btnDangXuat.TabIndex = 12;
            btnDangXuat.Text = "Đăng xuất";
            btnDangXuat.TextAlign = ContentAlignment.BottomCenter;
            btnDangXuat.UseVisualStyleBackColor = false;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // lblwellcome
            // 
            lblwellcome.AutoSize = true;
            lblwellcome.BackColor = Color.White;
            lblwellcome.BorderStyle = BorderStyle.FixedSingle;
            lblwellcome.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblwellcome.ForeColor = Color.Black;
            lblwellcome.Location = new Point(875, 54);
            lblwellcome.Name = "lblwellcome";
            lblwellcome.Size = new Size(21, 33);
            lblwellcome.TabIndex = 10;
            lblwellcome.Text = ".";
            // 
            // button1
            // 
            button1.BackColor = Color.WhiteSmoke;
            button1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.BottomCenter;
            button1.Location = new Point(758, 102);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.No;
            button1.Size = new Size(142, 134);
            button1.TabIndex = 9;
            button1.Text = "DS Đơn hàng";
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 25.8000011F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(471, 30);
            label1.Name = "label1";
            label1.Size = new Size(346, 57);
            label1.TabIndex = 8;
            label1.Text = "TỔNG QUAN";
            label1.Click += label1_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.WhiteSmoke;
            button8.DialogResult = DialogResult.Abort;
            button8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.ForeColor = Color.Black;
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.ImageAlign = ContentAlignment.BottomCenter;
            button8.Location = new Point(353, 456);
            button8.Name = "button8";
            button8.Size = new Size(142, 134);
            button8.TabIndex = 7;
            button8.Text = "Phiếu nhập";
            button8.TextImageRelation = TextImageRelation.ImageAboveText;
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.WhiteSmoke;
            button5.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.Black;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.BottomCenter;
            button5.Location = new Point(353, 102);
            button5.Name = "button5";
            button5.Size = new Size(142, 134);
            button5.TabIndex = 4;
            button5.Text = "Sản phẩm";
            button5.TextImageRelation = TextImageRelation.ImageAboveText;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.WhiteSmoke;
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.Black;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.Location = new Point(353, 284);
            button6.Name = "button6";
            button6.Size = new Size(142, 133);
            button6.TabIndex = 3;
            button6.Text = "Khách hàng";
            button6.TextAlign = ContentAlignment.BottomCenter;
            button6.TextImageRelation = TextImageRelation.ImageAboveText;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.WhiteSmoke;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Black;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.BottomCenter;
            button3.Location = new Point(758, 456);
            button3.Name = "button3";
            button3.Size = new Size(142, 134);
            button3.TabIndex = 2;
            button3.Text = "Chức vụ";
            button3.TextImageRelation = TextImageRelation.ImageAboveText;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // btnNhanVien
            // 
            btnNhanVien.BackColor = Color.WhiteSmoke;
            btnNhanVien.DialogResult = DialogResult.Abort;
            btnNhanVien.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNhanVien.ForeColor = Color.Black;
            btnNhanVien.Image = (Image)resources.GetObject("btnNhanVien.Image");
            btnNhanVien.Location = new Point(758, 284);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Size = new Size(142, 134);
            btnNhanVien.TabIndex = 1;
            btnNhanVien.Text = "Nhân viên";
            btnNhanVien.TextImageRelation = TextImageRelation.ImageAboveText;
            btnNhanVien.UseVisualStyleBackColor = false;
            btnNhanVien.Click += btnNhanVien_Click;
            // 
            // btnDonHang
            // 
            btnDonHang.BackColor = Color.WhiteSmoke;
            btnDonHang.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDonHang.ForeColor = Color.Black;
            btnDonHang.Image = (Image)resources.GetObject("btnDonHang.Image");
            btnDonHang.ImageAlign = ContentAlignment.BottomCenter;
            btnDonHang.Location = new Point(555, 102);
            btnDonHang.Name = "btnDonHang";
            btnDonHang.RightToLeft = RightToLeft.No;
            btnDonHang.Size = new Size(142, 134);
            btnDonHang.TabIndex = 0;
            btnDonHang.Text = "Tạo đơn hàng";
            btnDonHang.TextImageRelation = TextImageRelation.ImageAboveText;
            btnDonHang.UseVisualStyleBackColor = false;
            btnDonHang.Click += btnDonHang_Click;
            // 
            // tabDonHang
            // 
            tabDonHang.BackColor = Color.Transparent;
            tabDonHang.Location = new Point(4, 29);
            tabDonHang.Name = "tabDonHang";
            tabDonHang.Padding = new Padding(3);
            tabDonHang.Size = new Size(1293, 607);
            tabDonHang.TabIndex = 3;
            tabDonHang.Text = "\U0001f9fe Tạo đơn hàng";
            // 
            // tabKhachHang
            // 
            tabKhachHang.BackColor = Color.Transparent;
            tabKhachHang.Location = new Point(4, 29);
            tabKhachHang.Name = "tabKhachHang";
            tabKhachHang.Padding = new Padding(3);
            tabKhachHang.Size = new Size(1293, 607);
            tabKhachHang.TabIndex = 1;
            tabKhachHang.Text = "👥 Khách hàng";
            // 
            // tabNhanVien
            // 
            tabNhanVien.BackColor = Color.Transparent;
            tabNhanVien.Location = new Point(4, 29);
            tabNhanVien.Name = "tabNhanVien";
            tabNhanVien.Padding = new Padding(3);
            tabNhanVien.Size = new Size(1293, 607);
            tabNhanVien.TabIndex = 2;
            tabNhanVien.Text = "👤 nhân viên";
            // 
            // tabChucVu
            // 
            tabChucVu.BackColor = Color.Transparent;
            tabChucVu.Location = new Point(4, 29);
            tabChucVu.Name = "tabChucVu";
            tabChucVu.Size = new Size(1293, 607);
            tabChucVu.TabIndex = 4;
            tabChucVu.Text = "\U0001f9d1‍💼 Chức vụ";
            // 
            // tabSanPham
            // 
            tabSanPham.BackColor = Color.Transparent;
            tabSanPham.Location = new Point(4, 29);
            tabSanPham.Name = "tabSanPham";
            tabSanPham.Size = new Size(1293, 607);
            tabSanPham.TabIndex = 5;
            tabSanPham.Text = "📦 Sản phẩm";
            // 
            // tabPhieuNhap
            // 
            tabPhieuNhap.BackColor = Color.Transparent;
            tabPhieuNhap.Location = new Point(4, 29);
            tabPhieuNhap.Name = "tabPhieuNhap";
            tabPhieuNhap.Size = new Size(1293, 607);
            tabPhieuNhap.TabIndex = 7;
            tabPhieuNhap.Text = "📥 Phiếu nhập";
            // 
            // tabDSDonHang
            // 
            tabDSDonHang.Location = new Point(4, 29);
            tabDSDonHang.Name = "tabDSDonHang";
            tabDSDonHang.Size = new Size(1293, 607);
            tabDSDonHang.TabIndex = 8;
            tabDSDonHang.Text = "\t📄DS Đơn Hàng";
            tabDSDonHang.UseVisualStyleBackColor = true;
            // 
            // tabBaoCao
            // 
            tabBaoCao.Location = new Point(4, 29);
            tabBaoCao.Name = "tabBaoCao";
            tabBaoCao.Size = new Size(1293, 607);
            tabBaoCao.TabIndex = 9;
            tabBaoCao.Text = "📈 Báo cáo";
            tabBaoCao.UseVisualStyleBackColor = true;
            // 
            // frmDashboard
            // 
            ClientSize = new Size(1301, 640);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QUẢN LÝ CỬA HÀNG MINI";
            tabControl1.ResumeLayout(false);
            tabTongQuan.ResumeLayout(false);
            tabTongQuan.PerformLayout();
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
        private Button button5;
        private Button button6;
        private Button button3;
        private Button btnNhanVien;
        private Button button8;
        private TabPage tabDSDonHang;
        private TabPage tabPhieuNhap;

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

        private void button8_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPhieuNhap;
        }
        private Label label1;
        private Button button1;
        private Label lblwellcome;

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            // Xóa thông tin đăng nhập
            GUI.Properties.Settings.Default.LoggedInMaNV = string.Empty;
            GUI.Properties.Settings.Default.Save();

            frmDangNhap loginForm = new frmDangNhap();
            this.Close();
        }
        private Button btnDangXuat;

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabDSDonHang;
        }
        private TabPage tabBaoCao;
        private Button btnBaoCao;

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabBaoCao;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
