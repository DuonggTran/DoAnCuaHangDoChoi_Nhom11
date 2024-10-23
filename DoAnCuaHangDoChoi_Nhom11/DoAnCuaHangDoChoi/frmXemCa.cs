using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuaHangDoChoi
{
    public partial class frmXemCa : Form
    {
        DBPhanCa calam = new DBPhanCa();
        public frmXemCa()
        {
            InitializeComponent();
        }
        void LoadXemCa()
        {
            try
            {
                // Đưa dữ liệu lên DataGridView  
                dgvDanhSachXemCa.DataSource = calam.LoadCaLam().Tables[0];
                // Thay đổi độ rộng cột 
                dgvDanhSachXemCa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                //dgvDanhSachXemCa.AutoResizeColumns();
                dgvDanhSachXemCa.Columns[0].HeaderText = "Mã Ca";
                dgvDanhSachXemCa.Columns[1].HeaderText = "Tên Nhân Viên";
                dgvDanhSachXemCa.Columns[2].HeaderText = "Tên Ca";
                dgvDanhSachXemCa.Columns[3].HeaderText = "Ngày";
                dgvDanhSachXemCa.Columns[4].HeaderText = "Thời gian BD";
                dgvDanhSachXemCa.Columns[5].HeaderText = "Thời gian KT";


                // Sự kiện click chuột
                dgvDanhSachXemCa_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung ca làm.Đã xảy ra lỗi!");
            }
        }

        private void frmXemCa_Load(object sender, EventArgs e)
        {
            LoadXemCa();
        }

        private void dgvDanhSachXemCa_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            LoadXemCa();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            // Khai báo biến traloi 
            DialogResult traloi;
            // Hiện hộp thoại hỏi đáp 
            traloi = MessageBox.Show("Bạn có muốn trở về trang chủ?", "Trả lời",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            // Kiểm tra có nhắp chọn nút Ok không? 
            if (traloi == DialogResult.OK)
                this.Close();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            dgvDanhSachXemCa.DataSource = calam.Loc().Tables[0];
        }
    }
}
