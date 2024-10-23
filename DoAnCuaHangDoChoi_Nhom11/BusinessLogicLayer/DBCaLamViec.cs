using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class DBCaLamViec
    {
        DAL db = null;
        public DBCaLamViec()
        {
            db = new DAL();
        }
        public DataSet LayCaLam()
        {
            return db.ExecuteQueryDataSet("USP_LayCaLam", CommandType.StoredProcedure);
        }   
        public bool ThemCaLam(ref string err, string MaCa, string MaNhanVien, string TenCa, DateTime Ngay, TimeSpan ThoiGianBD, TimeSpan ThoiGianKT)
        {
            return db.MyExecuteNonQuery("USP_ThemCaLam", CommandType.StoredProcedure, ref err,
                new SqlParameter("@maca", MaCa),
                new SqlParameter("@manhanvien", MaNhanVien),
                new SqlParameter("@tenca", TenCa),
                new SqlParameter("@ngay", Ngay),
                new SqlParameter("@thoigianbd", ThoiGianBD),
                new SqlParameter("@thoigiankt", ThoiGianKT));
        }
        public bool XoaCaLam(ref string err, string MaCa)
        {
            return db.MyExecuteNonQuery("USP_XoaCaLam", CommandType.StoredProcedure, ref err,
                new SqlParameter("@maca", MaCa));
        }
        public bool CapNhatCaLam(ref string err, string MaCa, string MaNhanVien, string TenCa, DateTime Ngay, TimeSpan ThoiGianBD, TimeSpan ThoiGianKT)
        {
            return db.MyExecuteNonQuery("USP_CapNhatCaLam", CommandType.StoredProcedure, ref err,
                new SqlParameter("@maca", MaCa),
                new SqlParameter("@manhanvien", MaNhanVien),
                new SqlParameter("@tenca", TenCa),
                new SqlParameter("@ngay", Ngay),
                new SqlParameter("@thoigianbd", ThoiGianBD),
                new SqlParameter("@thoigiankt", ThoiGianKT));
        }
    }
}
