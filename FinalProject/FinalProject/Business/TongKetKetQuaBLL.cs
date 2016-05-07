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
    class TongKetKetQuaBLL
    {
        // lay co so du lieu 
        public DataTable getData()
        {
            DataTable dtResult = new DataTable();
            DataConfig config = new DataConfig();
            string strQuery = "select * from dbo.tongket_ketqua";
            dtResult = config.GetDataTable(strQuery);
            return dtResult;
        }

        // them co so du lieu
        public int Insert(TongKetKetQuaEntities obj)
        {
            int result = 0;
            string strQuery = "insert into dbo.tongket_ketqua (MAHOCSINH , KETQUA, HOCKY, NAMHOC) values ('" + obj.MaHocSinh + "', '" + obj.KetQua + "', '" + obj.HocKy + "', '" + obj.NamHoc + "')";
            DataConfig config = new DataConfig();
            result = config.executeNoneQuery(strQuery);
            return result;
        }
        // check ID 
        public bool CheckID(string _maHocSinh)
        {
            DataConfig config = new DataConfig();
            string strQuery = "select * from dbo.tongket_ketqua where mahocsinh = '" + _maHocSinh + "'";
            DataTable dt = new DataTable();
            dt = config.GetDataTable(strQuery);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }

        // cau lenh update
        public int Update(TongKetKetQuaEntities obj)
        {
            int result = 0;
            string strQuery = "update dbo.tongket_ketqua set mahocsinh = '" + obj.MaHocSinh + "', ketqua = '" + obj.KetQua + "', hocky = '" + obj.HocKy + "', namhoc = '" + obj.NamHoc + "'";
            DataConfig config = new DataConfig();
            result = config.executeNoneQuery(strQuery);
            return result;
        }
        // cau lenh xoa 
        public int Delete(string _maHocSinh)
        {
            int result = 0;
            string strQuey = "delete from dbo.tongket_ketqua where mahocsinh = '" + _maHocSinh + "'";
            DataConfig config = new DataConfig();
            result = config.executeNoneQuery(strQuey);
            return result;
        }
    }
}
