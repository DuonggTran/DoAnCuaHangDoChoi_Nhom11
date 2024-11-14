﻿using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class DBHoaDonBan
    {
        DAL db = null;
        public DBHoaDonBan()
        {
            db = new DAL();
        }
        //load ds hóa đơn bán 
        public DataSet LayHoaDonBan()
        {
            return db.ExecuteQueryDataSet("SELECT * FROM UDF_LayHoaDonBan()", CommandType.Text);
        }
        //Thêm hóa đơn bán 
        public bool ThemHoaDonBan(ref string err, string mahoadonban, string ngayBan, string manhanvien)
        {
            return db.MyExecuteNonQuery("USP_ThemHoaDonBan", CommandType.StoredProcedure, ref err,
                new SqlParameter("@mahoadonban", mahoadonban),
                new SqlParameter("@ngayban", ngayBan),
                new SqlParameter("@manhanvien", manhanvien));
        }
        //Cập nhật hoá đơn bán
        public bool CapNhatHoaDonBan(ref string err, string mahoadonban, string ngayBan, string manhanvien)
        {
            return db.MyExecuteNonQuery("USP_CapNhatHoaDonBan", CommandType.StoredProcedure, ref err,
                new SqlParameter("@mahoadonban", mahoadonban),
                new SqlParameter("@ngayban", ngayBan),
                new SqlParameter("@manhanvien", manhanvien));
        }
        //Xoá hoá đơn bán
        public bool XoaHoaDonBan(ref string err, string mahoadonban)
        {
            return db.MyExecuteNonQuery("USP_XoaHoaDonBan", CommandType.StoredProcedure, ref err,
                new SqlParameter("@mahoadonban", mahoadonban));
        }

        // Tìm kiếm hoá đơn bán: UDF_TimHoaDonBan
        public DataSet TimHoaDonBan(string mahoadonban)
        {
            return db.ExecuteQueryDataSet("SELECT * FROM UDF_TimHoaDonBan(@mahoadonban)", CommandType.Text);
        }
        
    }
}
