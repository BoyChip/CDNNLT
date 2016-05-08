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
    class MonHocBLL
    {
        // lay co so du lieu 
        public DataTable getData()
        {
            DataTable dtResult = new DataTable();
            DataConfig config = new DataConfig();
            string strQuery = "select * from dbo.monhoc";
            dtResult = config.GetDataTable(strQuery);
            return dtResult;
        }

        // them co so du lieu
        public int Insert(MonHocEntities obj)
        {
            int result = 0;
            string strQuery = "insert into dbo.monhoc (MAMON , TENMON, SOTIET, HESO) values ('" + obj.MaMon + "', N'" + obj.TenMon + "', '" + obj.SoTiet + "', '" + obj.HeSo + "')";
            DataConfig config = new DataConfig();
            result = config.executeNoneQuery(strQuery);
            return result;
        }
        // check ID 
        public bool CheckID(string _maMonHoc)
        {
            DataConfig config = new DataConfig();
            string strQuery = "select * from dbo.monhoc where mamon = '" + _maMonHoc + "'";
            DataTable dt = new DataTable();
            dt = config.GetDataTable(strQuery);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }

        // cau lenh update
        public int Update(MonHocEntities obj)
        {
            int result = 0;
            string strQuery = "update dbo.monhoc set  tenmon = '" + obj.TenMon + "', sotiet = '" + obj.SoTiet + "', heso = '" + obj.HeSo + "' where mamon = '" + obj.MaMon + "'";
            DataConfig config = new DataConfig();
            result = config.executeNoneQuery(strQuery);
            return result;
        }
        // cau lenh xoa 
        public int Delete(string _maMonHoc)
        {
            int result = 0;
            string strQuey = "delete from dbo.monhoc where mamon = '" + _maMonHoc + "'";
            DataConfig config = new DataConfig();
            result = config.executeNoneQuery(strQuey);
            return result;
        }


    }
}
