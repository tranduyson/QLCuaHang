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

namespace GUI
{
    public partial class frmBaoCao : Form
    {
        public frmBaoCao()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXemDoanhThuTheoNgay_Click(object sender, EventArgs e)
        {
            frmBCDoanhThuTheoNgay frm = new frmBCDoanhThuTheoNgay();
            frm.FormClosed += (s, args) => this.Close();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmChiTietDonHangTheoMaDH frm = new frmChiTietDonHangTheoMaDH();
            frm.FormClosed += (s, args) => this.Close();
            frm.Show();
        }

        private void btnXemBaoCaoDoanhThuTheoKhach_Click(object sender, EventArgs e)
        {
            frmBaoCaoDoanhThuKhachHang frm = new frmBaoCaoDoanhThuKhachHang();
            frm.FormClosed += (s, args) => this.Close();
            frm.Show();
        }

        private void btnBaoCaoSanPhamBanChay_Click(object sender, EventArgs e)
        {
            frmBaoCaoSanPhamBanChay frm = new frmBaoCaoSanPhamBanChay();
            frm.FormClosed += (s, args) => this.Close();
            frm.Show();
        }

        private void btn_BaoCaoTonKhoSanPHam_Click(object sender, EventArgs e)
        {
            frmBaoCaoTonKho frm = new frmBaoCaoTonKho();
            frm.FormClosed += (s, args) => this.Close();
            frm.Show();
        }

        private void btnBaoCaoLuongNhanVien_Click(object sender, EventArgs e)
        {
            frmBaoCaoLuongNhanVien frm = new frmBaoCaoLuongNhanVien();
            frm.FormClosed += (s, args) => this.Close();
            frm.Show();
        }
    }
}
