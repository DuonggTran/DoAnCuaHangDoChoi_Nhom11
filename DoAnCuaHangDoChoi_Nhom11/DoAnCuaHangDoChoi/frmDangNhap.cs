using BusinessLogicLayer;
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
    public partial class frmDangNhap : Form
    {
        DBTaiKhoan tk = new DBTaiKhoan();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            lblThongBao.ResetText();
            string err = "Sai tên người dùng hoặc mật khẩu! Vui lòng nhập lại!";
            // Thông tin đăng nhập (Tên người dùng/ Mật khẩu)
            int check = tk.DangNhap(txtTenNguoiDung.Text.Trim(), txtMatKhau.Text.Trim());
            if (check == 1)
            {
                Program.role = "admin";
                frmAdminHome ad = new frmAdminHome();
                ad.ShowDialog();
                txtTenNguoiDung.ResetText();
                txtMatKhau.ResetText();
                txtMatKhau.Focus();              
            }
            else if (check == 2)
            {
                Program.role = "user";
                frmUserHome usr = new frmUserHome();
                usr.ShowDialog();
                txtTenNguoiDung.ResetText();
                txtMatKhau.ResetText();
                txtTenNguoiDung.Focus();           
            }
            else // không đúng thì xuất ra thông báo!
            {
                lblThongBao.Text = err;
                txtTenNguoiDung.Focus();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.txtTenNguoiDung.Clear();
            this.txtMatKhau.Clear();
            this.txtTenNguoiDung.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            txtTenNguoiDung.Clear();
            txtTenNguoiDung.Focus();
            txtMatKhau.Clear();
        }
    }
}
