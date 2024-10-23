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
    public partial class frmChiaCa : Form
    {
        bool Them;
        DBCaLamViec calam = new DBCaLamViec();
        DBPhanCa calam1 = new DBPhanCa();
        string maCa;
        TimeSpan thoiGianBD, thoiGianKT;
        public frmChiaCa()
        {
            InitializeComponent();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;
           
            // Xóa trống các đối tượng trong Panel 
            this.txtMaNhanVien.ResetText();
            //this.panel.ResetText();
            this.dtpNgay.ResetText();
            this.cboCaLam.ResetText();
            // Cho thao tác trên các nút Lưu  
            this.btnLuu.Enabled = true;
            this.btnHuyBo.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Trở về 
            this.btnThem.Enabled = false;
            this.btnTroVe.Enabled = false;
            this.btnCapNhat.Enabled = false;
            this.btnXoa.Enabled = false;
            this.panel.Enabled = true;
            // Đưa con trỏ đến TextField 
            this.txtMaNhanVien.Focus();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            bool kq = false;
            string err = "";
            try
            {

                // Lấy thứ tự record hiện hành 
                int r = dgvDanhSachCaLam.CurrentCell.RowIndex;
                // Lấy MaNhanVien của record hiện hành 
                string strMaCa =
                dgvDanhSachCaLam.Rows[r].Cells[0].Value.ToString();

                // Hiện thông báo xác nhận việc xóa mẫu tin 
                // Khai báo biến traloi 
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp 
                traloi = MessageBox.Show("Bạn có chắc xóa ca làm này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không? 
                if (traloi == DialogResult.Yes)
                {
                    // Thực hiện câu lệnh SQL 
                    kq = calam.XoaCaLam(ref err, strMaCa);
                    if (kq)
                    {
                        // Cập nhật lại DataGridView 
                        LoadCaLam();
                        // Thông báo 
                        MessageBox.Show("Đã xóa xong!");
                    }
                }
                else
                {

                    // Thông báo 
                    MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!");
            }
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa 
            Them = false;
            // Cho phép thao tác trên Panel 
            this.panel.Enabled = true;
            dgvDanhSachCaLam_CellClick(null, null);
            // Cho thao tác trên các nút Lưu / Hủy / Panel 
            this.btnLuu.Enabled = true;
            this.btnHuyBo.Enabled = true;

            // Không cho thao tác trên các nút Thêm / Xóa / Thoát 
            this.btnThem.Enabled = false;
            this.btnCapNhat.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnTroVe.Enabled = false;
            

            // Đưa con trỏ đến TextField txtMaNV 
           
            
        }
        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong Panel 
            this.txtMaNhanVien.ResetText();
         
            this.panel.ResetText();
            this.dtpNgay.ResetText();
            this.cboCaLam.ResetText();

            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát 
            this.btnThem.Enabled = true;
            this.btnCapNhat.Enabled = true;
            this.btnXoa.Enabled = true;
            this.btnTroVe.Enabled = true;
   

            // Không cho thao tác trên các nút Lưu / Hủy / Panel 
            this.btnLuu.Enabled = false;
            this.btnHuyBo.Enabled = false;
            this.panel.Enabled = false;
            dgvDanhSachCaLam_CellClick(null, null);
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát / Reload
            this.btnThem.Enabled = true;
            this.btnCapNhat.Enabled = true;
            this.btnXoa.Enabled = true;
            this.btnTroVe.Enabled = true;

            // Không cho thao tác trên các nút Lưu / Hủy / Panel 
            this.btnLuu.Enabled = false;
            this.btnHuyBo.Enabled = false;
            this.panel.Enabled = false;

            bool kq = false;
            string err = "";

            // Kiểm tra Mã Nhân Viên và Ca Làm
            if (string.IsNullOrEmpty(txtMaNhanVien.Text))
            {
                MessageBox.Show("Mã nhân viên không được để trống.");
                return;
            }

            if (string.IsNullOrEmpty(cboCaLam.Text) ||
                (cboCaLam.Text != "Sáng" && cboCaLam.Text != "Trưa" && cboCaLam.Text != "Chiều"))
            {
                MessageBox.Show("Vui lòng chọn ca làm hợp lệ.");
                return;
            }

            // Thêm dữ liệu 
            if (cboCaLam.Text == "Sáng")
            {
                maCa = dtpNgay.Value.ToString("yyyyMMdd") + "S" + txtMaNhanVien.Text;
                thoiGianBD = new TimeSpan(7, 0, 0);
                thoiGianKT = new TimeSpan(12, 0, 0);
            }
            else if (cboCaLam.Text == "Trưa")
            {
                maCa = dtpNgay.Value.ToString("yyyyMMdd") + "T" + txtMaNhanVien.Text;
                thoiGianBD = new TimeSpan(12, 0, 0);
                thoiGianKT = new TimeSpan(17, 0, 0);
            }
            else if (cboCaLam.Text == "Chiều")
            {
                maCa = dtpNgay.Value.ToString("yyyyMMdd") + "C" + txtMaNhanVien.Text;
                thoiGianBD = new TimeSpan(17, 0, 0);
                thoiGianKT = new TimeSpan(22, 0, 0);
            }
            if (Them)
            {
                try
                {
                    kq = calam.ThemCaLam(ref err, maCa, txtMaNhanVien.Text, cboCaLam.Text, DateTime.Parse(dtpNgay.Text), thoiGianBD, thoiGianKT);
                    bool kq1 = calam1.ThemCaLam(ref err, maCa, txtMaNhanVien.Text)
                    if (kq)
                    {
                        // Load lại dữ liệu trên DataGridView 
                        LoadCaLam();
                        // Thông báo 
                        MessageBox.Show("Đã thêm xong!");
                    }
                    else
                    {
                        MessageBox.Show("Không thêm được ca làm. Lỗi: " + err);
                    }
                }
                catch (SqlException ex)
                {
                    err = "Không thêm được. Lỗi: " + ex.Message;
                    MessageBox.Show(err);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Định dạng ngày không hợp lệ: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                }
            }
            else
            {
                if (dgvDanhSachCaLam.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn một ca làm để cập nhật.");
                    return;
                }
                int r = dgvDanhSachCaLam.CurrentCell.RowIndex;
                string strmaCa = dgvDanhSachCaLam.Rows[r].Cells[0].Value.ToString();
                try
                {
                    kq = calam.CapNhatCaLam(ref err, strmaCa, txtMaNhanVien.Text, cboCaLam.Text, DateTime.Parse(dtpNgay.Text), thoiGianBD, thoiGianKT);
                    if (kq)
                    {
                        // Load lại dữ liệu trên DataGridView 
                        LoadCaLam();
                        // Thông báo 
                        MessageBox.Show("Đã cập nhật xong!");
                    }
                    else
                    {
                        MessageBox.Show("Không cập nhật được ca làm. Lỗi: " + err);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                }
            }
        }


        private void btnTroVe_Click(object sender, EventArgs e)
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
        private void frmChiaCa_Load(object sender, EventArgs e)
        {
              LoadCaLam();
        }
        private void dgvDanhSachCaLam_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành 
            int r = dgvDanhSachCaLam.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel 
            this.txtMaNhanVien.Text =
                dgvDanhSachCaLam.Rows[r].Cells[1].Value.ToString();            
            this.cboCaLam.Text =
                dgvDanhSachCaLam.Rows[r].Cells[2].Value.ToString();           
            this.dtpNgay.Value = DateTime.Parse
                (dgvDanhSachCaLam.Rows[r].Cells[3].Value.ToString());
       
        }

        void LoadCaLam()
        {
            try
            {
                // Đưa dữ liệu lên DataGridView  
                dgvDanhSachCaLam.DataSource = calam.LayCaLam().Tables[0];
                //dgvDanhSachCaLam.Columns[7].Visible = false;
                // Thay đổi độ rộng cột 
                dgvDanhSachCaLam.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel 
                this.txtMaNhanVien.ResetText();
                this.cboCaLam.ResetText();
                this.dtpNgay.ResetText();
                this.panel.ResetText();
               
                // Không cho thao tác trên các nút Lưu / Hủy 
                this.btnLuu.Enabled = false;
                this.btnHuyBo.Enabled = false;
                this.panel.Enabled = false;
                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát 
                this.btnThem.Enabled = true;
                this.btnCapNhat.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnTroVe.Enabled = true;
                // Radio button             
                // Đặt tên cột
                dgvDanhSachCaLam.Columns[0].HeaderText = "Mã Ca";
                dgvDanhSachCaLam.Columns[1].HeaderText = "Mã Nhân Viên";
                dgvDanhSachCaLam.Columns[2].HeaderText = "Tên Ca";
                dgvDanhSachCaLam.Columns[3].HeaderText = "Ngày";
                dgvDanhSachCaLam.Columns[4].HeaderText = "Thời gian BD";
                dgvDanhSachCaLam.Columns[5].HeaderText = "Thời gian KT";
             
                    
                // Sự kiện click chuột
                dgvDanhSachCaLam_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung ca làm.Đã xảy ra lỗi!");
            }
        }

    }
}
