using BusinessLogicLayer;
using FastReport.DataVisualization.Charting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastReport;
using FastReport.DataVisualization;
namespace DoAnCuaHangDoChoi
{
    public partial class frmThongKe : Form
    {
        DBThongKe tk = new DBThongKe();
        public frmThongKe()
        {
            InitializeComponent();
        }

        private void pnTongQuan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            LoadForm();
        }
        void LoadForm()
        {

           
        }
    }
}
