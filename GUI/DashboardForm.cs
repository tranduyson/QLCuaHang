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
            tabDonHang = new TabPage();
            tabKhachHang = new TabPage();
            tabNhanVien = new TabPage();
            tabChucVu = new TabPage();
            tabSanPham = new TabPage();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
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
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1299, 679);
            tabControl1.TabIndex = 0;
            // 
            // tabTongQuan
            // 
            tabTongQuan.Controls.Add(button4);
            tabTongQuan.Controls.Add(button5);
            tabTongQuan.Controls.Add(button6);
            tabTongQuan.Controls.Add(button3);
            tabTongQuan.Controls.Add(button2);
            tabTongQuan.Controls.Add(button1);
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
            // tabDonHang
            // 
            tabDonHang.Location = new Point(4, 29);
            tabDonHang.Name = "tabDonHang";
            tabDonHang.Padding = new Padding(3);
            tabDonHang.Size = new Size(1238, 622);
            tabDonHang.TabIndex = 3;
            tabDonHang.Text = "Đơn hàng";
            tabDonHang.UseVisualStyleBackColor = true;
            // 
            // tabKhachHang
            // 
            tabKhachHang.Location = new Point(4, 29);
            tabKhachHang.Name = "tabKhachHang";
            tabKhachHang.Padding = new Padding(3);
            tabKhachHang.Size = new Size(1238, 622);
            tabKhachHang.TabIndex = 1;
            tabKhachHang.Text = "Khách hàng";
            tabKhachHang.UseVisualStyleBackColor = true;
            // 
            // tabNhanVien
            // 
            tabNhanVien.Location = new Point(4, 29);
            tabNhanVien.Name = "tabNhanVien";
            tabNhanVien.Padding = new Padding(3);
            tabNhanVien.Size = new Size(1238, 622);
            tabNhanVien.TabIndex = 2;
            tabNhanVien.Text = "👤 Người dùng\n\n";
            tabNhanVien.UseVisualStyleBackColor = true;
            // 
            // tabChucVu
            // 
            tabChucVu.Location = new Point(4, 29);
            tabChucVu.Name = "tabChucVu";
            tabChucVu.Size = new Size(1238, 622);
            tabChucVu.TabIndex = 4;
            tabChucVu.Text = "Chức vụ";
            tabChucVu.UseVisualStyleBackColor = true;
            // 
            // tabSanPham
            // 
            tabSanPham.Location = new Point(4, 29);
            tabSanPham.Name = "tabSanPham";
            tabSanPham.Size = new Size(1238, 622);
            tabSanPham.TabIndex = 5;
            tabSanPham.Text = "Sản phẩm";
            tabSanPham.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(188, 131);
            button1.Name = "button1";
            button1.Size = new Size(142, 134);
            button1.TabIndex = 0;
            button1.Text = "Đơn hàng";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.TopCenter;
            button2.Location = new Point(430, 131);
            button2.Name = "button2";
            button2.Size = new Size(142, 134);
            button2.TabIndex = 1;
            button2.Text = "Đơn hàng";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.TextImageRelation = TextImageRelation.ImageAboveText;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.TopCenter;
            button3.Location = new Point(685, 131);
            button3.Name = "button3";
            button3.Size = new Size(142, 134);
            button3.TabIndex = 2;
            button3.Text = "Đơn hàng";
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.TextImageRelation = TextImageRelation.ImageAboveText;
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.TopCenter;
            button4.Location = new Point(685, 320);
            button4.Name = "button4";
            button4.Size = new Size(142, 134);
            button4.TabIndex = 5;
            button4.Text = "Đơn hàng";
            button4.TextAlign = ContentAlignment.BottomCenter;
            button4.TextImageRelation = TextImageRelation.ImageAboveText;
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.TopCenter;
            button5.Location = new Point(430, 320);
            button5.Name = "button5";
            button5.Size = new Size(142, 134);
            button5.TabIndex = 4;
            button5.Text = "Đơn hàng";
            button5.TextAlign = ContentAlignment.BottomCenter;
            button5.TextImageRelation = TextImageRelation.ImageAboveText;
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.TopCenter;
            button6.Location = new Point(188, 320);
            button6.Name = "button6";
            button6.Size = new Size(142, 134);
            button6.TabIndex = 3;
            button6.Text = "Đơn hàng";
            button6.TextAlign = ContentAlignment.BottomCenter;
            button6.TextImageRelation = TextImageRelation.ImageAboveText;
            button6.UseVisualStyleBackColor = true;
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
        private Button button1;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button3;
        private Button button2;
    }
}
