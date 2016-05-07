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
    class HocLucBLL
    {
        // lay co so du lieu 
        public DataTable getData()
        {
            DataTable dtResult = new DataTable();
            DataConfig config = new DataConfig();
            string strQuery = "select * from dbo.hocluc";
            dtResult = config.GetDataTable(strQuery);
            return dtResult;
        }

        // them co so du lieu
        public int Insert(HocLucEntities obj)
        {
            int result = 0;
            string strQuery = "insert into dbo.hocluc (MAHOCSINH , XEPLOAIHOCLUC, HOCKY, NAMHOC) values ('" + obj.MaHocSinh + "', '" + obj.XepLoaiHocLuc + "', '" + obj.HocKy + "', '" + obj.NamHoc + "')";
            DataConfig config = new DataConfig();
            result = config.executeNoneQuery(strQuery);
            return result;
        }
        // check ID 
        public bool CheckID(string _maHocSinh)
        {
            DataConfig config = new DataConfig();
            string strQuery = "select * from dbo.hocluc where mahocsinh = '" + _maHocSinh + "'";
            DataTable dt = new DataTable();
            dt = config.GetDataTable(strQuery);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }

        // cau lenh update
        public int Update(HocLucEntities obj)
        {
            int result = 0;
            string strQuery = "update dbo.hocluc set mahocsinh = '" + obj.MaHocSinh + "', xeploaihocluc = '" + obj.XepLoaiHocLuc + "', hocky = '" + obj.HocKy + "', namhoc = '" + obj.NamHoc + "'";
            DataConfig config = new DataConfig();
            result = config.executeNoneQuery(strQuery);
            return result;
        }
        // cau lenh xoa 
        public int Delete(string _maHocSinh)
        {
            int result = 0;
            string strQuey = "delete from dbo.hocluc where mahocsinh = '" + _maHocSinh + "'";
            DataConfig config = new DataConfig();
            result = config.executeNoneQuery(strQuey);
            return result;
        }
    }
}
