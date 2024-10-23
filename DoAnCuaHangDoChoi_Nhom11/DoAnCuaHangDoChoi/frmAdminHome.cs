using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuaHangDoChoi
{
    public partial class frmAdminHome : Form
    {
        public frmAdminHome()
        {
            InitializeComponent();
        }
        private void frmAdminHome_Load(object sender, EventArgs e)
        {          
        }
        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien nv = new frmNhanVien();
            nv.ShowDialog();
        }
        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            frmDanhMucDoChoi dmdc = new frmDanhMucDoChoi();
            dmdc.ShowDialog();
        }
        private void btnDoChoi_Click(object sender, EventArgs e)
        {
            frmDoChoi dc = new frmDoChoi();
            dc.ShowDialog();
        }
        private void btnNganKe_Click(object sender, EventArgs e)
        {
            frmNganKe nk = new frmNganKe();
            nk.ShowDialog();
        }
        private void btnNhaSanXuat_Click(object sender, EventArgs e)
        {
            frmNhaSanXuat nsx = new frmNhaSanXuat();
            nsx.ShowDialog();
        }
        private void btnHoaDonNhap_Click(object sender, EventArgs e)
        {
            frmHoaDonNhap n = new frmHoaDonNhap();
            n.ShowDialog();
        }
        private void btnHoaDonBan_Click(object sender, EventArgs e)
        {
            frmHoaDonBan b = new frmHoaDonBan();
            b.ShowDialog();
        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            frmThongKe tk = new frmThongKe();
            tk.ShowDialog();
        }
        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            frmTaiKhoan tk = new frmTaiKhoan();
            tk.ShowDialog();
        }
        private void btnCaLam_Click(object sender, EventArgs e)
        {
            frmLich lich = new frmLich();
            lich.TopLevel = false;
            lich.FormBorderStyle = FormBorderStyle.None;
            lich.Dock = DockStyle.Fill;
            lich.Size = panel2.Size;
            panel2.Controls.Add(lich);
            lich.Show();
        }
    }
}
