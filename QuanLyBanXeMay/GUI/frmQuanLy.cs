using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanXeMay.GUI
{
    public partial class frmQuanLy : Form
    {
        public frmQuanLy()
        {
            InitializeComponent();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanVien frmNhanVien = new frmNhanVien();
            frmNhanVien.ShowDialog();   
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachHang frmKhachHang = new frmKhachHang();
            frmKhachHang.ShowDialog();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhaCungCap frmNhaCungCap = new frmNhaCungCap();  
            frmNhaCungCap.ShowDialog();
        }

        private void xeMáyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmXe frmXe = new frmXe();
            frmXe.ShowDialog();
        }

        private void tìmKiếmXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimKiemXe frmTimKiemXe = new frmTimKiemXe();
            frmTimKiemXe.ShowDialog();
        }

        private void tìmKiếmKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimKiemKhachHang frmTimKiemKhachHang = new frmTimKiemKhachHang();
            frmTimKiemKhachHang.ShowDialog();
        }

        private void tìmKiếmNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimKiemNhanVien frmTimKiemNhanVien = new frmTimKiemNhanVien();
            frmTimKiemNhanVien.ShowDialog();
        }

        private void lậpHóaĐơnNhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDonNhapHang frmHoaDonNhapHang = new frmHoaDonNhapHang();
            frmHoaDonNhapHang.ShowDialog();
        }

        private void frmQuanLy_Load(object sender, EventArgs e)
        {

        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
