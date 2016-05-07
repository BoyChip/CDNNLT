using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using FinalProject.DataAccess;
using FinalProject.Entities;


namespace FinalProject.Business
{
    class LopBLL
    {
        // lay co so du lieu 
        public DataTable getData()
        {
            DataTable dtResult = new DataTable();
            DataConfig config = new DataConfig();
            string strQuery = "select * from dbo.lop";
            dtResult = config.GetDataTable(strQuery);
            return dtResult;
        }
        
        // them co so du lieu
        public int Insert(LopEntities obj)
        {
            int result = 0;
            string strQuery = "insert into dbo.lop (MALOP, KHOILOP, TENLOP, MAGIAOVIEN, SISO, HOCKY, NAMHOC) values ('" + obj.MaLop + "', '" + obj.MaKhoi + "', '"+obj.TenLop+"', '"+obj.MaGiaoVien+"', '"+obj.SiSo+"', '"+obj.HocKy+"','"+obj.NamHoc+"')";
            DataConfig config = new DataConfig();
            result = config.executeNoneQuery(strQuery);
            return result;
        }
        // check ID 
        public bool CheckID(string _maLop)
        {
            DataConfig config = new DataConfig();
            string strQuery = "select * from dbo.lop where malop= '" + _maLop + "'";
            DataTable dt = new DataTable();
            dt = config.GetDataTable(strQuery);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }

        // cau lenh update
        public int Update(LopEntities obj)
        {
            int result = 0;
            string strQuery = "update dbo.lop set malop = '"+obj.MaLop+"', makhoi = '"+obj.MaKhoi+"', tenlop = '"+obj.TenLop+"', magiaovien = '"+obj.MaGiaoVien+"', siso = '"+obj.SiSo+"', hocky = '"+obj.HocKy+"', namhoc = '"+obj.NamHoc+"'";
            DataConfig config = new DataConfig();
            result = config.executeNoneQuery(strQuery);
            return result;
        }

        // cau lenh xoa
        public int Delete(string _maLop)
        {
            int result = 0;
            string strQuey = "delete from dbo.hocky_namhoc where malop = '"+_maLop+"'";
            DataConfig config = new DataConfig();
            result = config.executeNoneQuery(strQuey);
            return result;
        }
    }
}
