using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DashboardWinForm;
using QLCuaHang.BLL;
using QLCuaHang.DTO;

namespace GUI
{
    public partial class frmDangNhap : Form
    {
        private readonly NhanVienBLL nhanVienBLL = new NhanVienBLL();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = true;

            txtMatKhau.KeyDown += txtMatKhau_KeyDown;

        }
        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Ngăn tiếng "beep"
                e.Handled = true; // Đánh dấu sự kiện đã được xử lý

                XuLyDangNhap();
            }
        }


        private void ckHienThiMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = !ckHienThiMatKhau.Checked;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void XuLyDangNhap()
        {
            string tenDangNhap = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text;

            NhanVienBLL bll = new NhanVienBLL();
            if (bll.DangNhap(tenDangNhap, matKhau))
            {
                NhanVienDTO nv = bll.GetByMaNV(tenDangNhap);

                // Lưu lại thông tin đăng nhập
                Properties.Settings.Default.LoggedInMaNV = nv.MaNV;
                Properties.Settings.Default.Save();

                frmDashboard dashboard = new frmDashboard(nv);
                dashboard.FormClosed += (s, args) => this.Close();
                dashboard.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            XuLyDangNhap();
        }

        private void ckHienThiMatKhau_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void txtTenDangNhap_Enter(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == "👤 Mã nhân viên")
            {
                txtTenDangNhap.Text = "";
                txtTenDangNhap.ForeColor = Color.Black;
            }
        }

        private void txtTenDangNhap_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
            {
                txtTenDangNhap.Text = "👤 Mã nhân viên";
                txtTenDangNhap.ForeColor = Color.Gray;
            }
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
            txtTenDangNhap.Text = "👤 Mã nhân viên";
            txtTenDangNhap.ForeColor = Color.Gray;

            txtMatKhau.Text = "🔒 **********";
            txtMatKhau.ForeColor = Color.Gray;
            txtMatKhau.UseSystemPasswordChar = false;
        }
        private void txtMatKhau_Enter(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "🔒 **********")
            {
                txtMatKhau.Text = "";
                txtMatKhau.ForeColor = Color.Black;
                txtMatKhau.UseSystemPasswordChar = true;
            }
        }

        private void txtMatKhau_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                txtMatKhau.UseSystemPasswordChar = false;
                txtMatKhau.Text = "🔒 **********";
                txtMatKhau.ForeColor = Color.Gray;
            }
        }



    }
}
