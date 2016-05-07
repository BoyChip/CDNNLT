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
    class HocKyNamHocBLL
    {
        // lay co so du lieu
        public DataTable getData()
        {
            DataTable dtResult = new DataTable();
            DataConfig config = new DataConfig();
            string strQuery = "select * from dbo.hocky_namhoc";
            dtResult = config.GetDataTable(strQuery);
            return dtResult;
        }

        // them co so du lieu
        public int Insert(HocKyNamHocEntities obj)
        {
            int result = 0;
            string strQuery = "insert into dbo.hocky_namhoc (HOCKY, NAMHOC) values ('" + obj.HocKy + "', '" + obj.NamHoc + "')";
            DataConfig config = new DataConfig();
            result = config.executeNoneQuery(strQuery);
            return result;
        }
        // check ID 
        public bool CheckID(string _HocKy, string _NamHoc)
        {
            DataConfig config = new DataConfig();
            string strQuery = "select * from dbo.hocky_namhoc where hocky= '"+_HocKy+"' and namhoc ='"+_NamHoc+"'";
            DataTable dt = new DataTable();
            dt = config.GetDataTable(strQuery);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }

        // cau lenh update
        public int Update(HocKyNamHocEntities obj)
        {
            int result = 0;
            string strQuery = "update dbo.hocky_namhoc set hocky = '" + obj.HocKy + "', namhoc = '" + obj.NamHoc + "'";
            DataConfig config = new DataConfig();
            result = config.executeNoneQuery(strQuery);
            return result;
        }
        // cau lenh xoa 
        public int Delete(string _hocKy, string _namHoc)
        {
            int result = 0;
            string strQuey = "delete from dbo.hocky_namhoc where HOCKY ='" + _hocKy + "' and NAMHOC = '" + _namHoc + "'";
            DataConfig config = new DataConfig();
            result = config.executeNoneQuery(strQuey);
            return result;
        }
         
    }
}
