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
    class DiemBLL
    {
        // lay co so du lieu 
        public DataTable getData()
        {
            DataTable dtResult = new DataTable();
            DataConfig config = new DataConfig();
            string strQuery = "select * from dbo.diem";
            dtResult = config.GetDataTable(strQuery);
            return dtResult;
        }

        // them co so du lieu
        public int Insert(DiemEntities obj)
        {
            int result = 0;
            string strQuery = "insert into dbo.diem (MAHOCSINH , MAMON, HOCKY, NAMHOC, DIEMMON, HESO) values ('" + obj.MaHocSinh + "', '" + obj.MaMonHoc + "', '"+obj.HocKy+"', '"+obj.NamHoc+"', '"+obj.DiemMon+"', '"+obj.HeSoDiem+"')";
            DataConfig config = new DataConfig();
            result = config.executeNoneQuery(strQuery);
            return result;
        }
        // check ID 
        public bool CheckID(string _maHocSinh)
        {
            DataConfig config = new DataConfig();
            string strQuery = "select * from dbo.hocsinh where mahocsinh = '" + _maHocSinh + "'";
            DataTable dt = new DataTable();
            dt = config.GetDataTable(strQuery);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }

        //kiem tra so luong dong co trong co so du lieu 
        public int Count_Data_Rows()
        {
            int result = 0;
            DataConfig config = new DataConfig();
            string strQuery = "select * from dbo.diem ";
            DataTable dt = new DataTable();
            dt = config.GetDataTable(strQuery);
            result = dt.Rows.Count;
            return result;
        }

        // cau lenh update
        public int Update(DiemEntities obj)
        {
            int result = 0;
            string strQuery = "update dbo.diem set  mamonhoc = '" + obj.MaMonHoc + "', hocky = '" + obj.HocKy + "', namhoc = '" + obj.NamHoc + "', diemmon = '" + obj.DiemMon + "', heso = '" + obj.HeSoDiem + "' where mahocsinh = '" + obj.MaHocSinh + "'";
            DataConfig config = new DataConfig();
            result = config.executeNoneQuery(strQuery);
            return result;
        }
        // cau lenh xoa 
        public int Delete(string _maHocSinh)
        {
            int result = 0;
            string strQuey = "delete from dbo.diem where mahocsinh = '" + _maHocSinh + "'";
            DataConfig config = new DataConfig();
            result = config.executeNoneQuery(strQuey);
            return result;
        }
    }
}
