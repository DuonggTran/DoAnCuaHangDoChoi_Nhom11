using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class DBPhanCa
    {
        DAL db = null;
        public DBPhanCa()
        {
            db = new DAL();
        }
        public DataSet LoadCaLam()
        {
            return db.ExecuteQueryDataSet("USP_LoadCaLam", CommandType.StoredProcedure);
        }
        public DataSet Loc()
        {
            return db.ExecuteQueryDataSet("USP_LoadCaLam_TheoNgay", CommandType.StoredProcedure);
        }
        public bool ThemCaLam(ref string err, string MaCa, string MaNhanVien)
        {
            return db.MyExecuteNonQuery("USP_ThemCaLamNhanVien", CommandType.StoredProcedure, ref err,
                new SqlParameter("@maca", MaCa),
                new SqlParameter("@manhanvien", MaNhanVien));              
        }
    }
}
