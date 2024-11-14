using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataAccessLayer;
namespace BusinessLogicLayer
{
    public class DBDoChoi
    {
     DAL db = null;
        public DBDoChoi()
        {
            db = new DAL();
        }

        public DataSet LayDoChoi()
        {
            return db.ExecuteQueryDataSet("USP_LayDoChoi", CommandType.StoredProcedure);
        }
        public DataSet LayDoChoiVaDanhMuc()
        {
            return db.ExecuteQueryDataSet("USP_LayDoChoiVaDanhMuc", CommandType.StoredProcedure);

        }

        public DataSet DoChoiDaBan()
        {
            return db.ExecuteQueryDataSet("USP_DoChoiDaBan", CommandType.StoredProcedure);
        }

        public DataSet DoChoiChuaBan()
        {
            return db.ExecuteQueryDataSet("USP_DoChoiChuaBan", CommandType.StoredProcedure);
        }

        public bool ThemDoChoi(ref string err, string MaDoChoi, string TenDoChoi, string GiaTien, string MaLoaiDoChoi, string MaNSX, string MaNganKe)
        {
            return db.MyExecuteNonQuery("USP_ThemDoChoi", CommandType.StoredProcedure, ref err,
                new SqlParameter("@ma_do_choi", MaDoChoi),
                new SqlParameter("@ten_do_choi", TenDoChoi),
                new SqlParameter("@gia_tien", GiaTien),
                new SqlParameter("@ma_loai_do_choi", MaLoaiDoChoi),
                new SqlParameter("@ma_nsx", MaNSX),
                new SqlParameter("@ma_ngan_ke", MaNganKe));
        }

        public bool XoaDoChoi(ref string err, string MaDoChoi)
        {
            return db.MyExecuteNonQuery("USP_XoaDoChoi", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaDoChoi", MaDoChoi));
        }

        public bool CapNhatDoChoi(ref string err, string MaDoChoi, string TenDoChoi, int GiaTien, string MaLoaiDoChoi, string MaNSX, string MaNganKe)
        {
            return db.MyExecuteNonQuery("USP_CapNhatDoChoi", CommandType.StoredProcedure, ref err,
                new SqlParameter("@madochoi", MaDoChoi),
                new SqlParameter("@tendochoi", TenDoChoi),
                new SqlParameter("@giatien", GiaTien),
                new SqlParameter("@maloaidochoi", MaLoaiDoChoi),
                new SqlParameter("@maNSX", MaNSX),
                new SqlParameter("@manganke", MaNganKe));
        }
        public DataSet TimDoChoiTheoMa(string madochoi)
        {
            return db.ExecuteQueryDataSet($"SELECT * FROM UDF_TimDoChoiTheoMa('{madochoi}')", CommandType.Text);
        }

        // Tìm kiếm đồ chơi theo tên: UDF_TimDoChoiTheoTen 
        public DataSet TimDoChoiTheoTen(string tendochoi)
        {
            return db.ExecuteQueryDataSet($"SELECT * FROM UDF_TimDoChoiTheoTen('{tendochoi}')", CommandType.Text);
        }
    }
}
