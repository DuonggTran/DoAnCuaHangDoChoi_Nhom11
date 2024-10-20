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
    public partial class frmDoChoi : Form
    {

        DBDoChoi dcbusiness = new DBDoChoi();
        public frmDoChoi()
        {
            InitializeComponent();
        }

        private void frmDoChoi_Load(object sender, EventArgs e)
        {

        }
    }
}
