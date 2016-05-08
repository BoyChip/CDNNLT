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
            string strQuery = "insert into dbo.tongket_ketqua (MAHOCSINH , KETQUA, HOCKY, NAMHOC) values ('" + obj.MaHocSinh + "', N'" + obj.KetQua + "', '" + obj.HocKy + "', '" + obj.NamHoc + "')";
            DataConfig config = new DataConfig();
            result = config.executeNoneQuery(strQuery);
            return result;
        }

        // check ID 
        public bool CheckID(string _maHocSinh, string _hocKy, string _namHoc)
        {
            DataConfig config = new DataConfig();
            string strQuery = "select * from dbo.tongket_ketqua where mahocsinh = '" + _maHocSinh + "' and hocky = '"+_hocKy+"' and namhoc ='"+_namHoc+"'";
            DataTable dt = new DataTable();
            dt = config.GetDataTable(strQuery);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }

        // diem so luong phan tu co trong csdl 
        public int Count_Data_Rows()
        {
            int result = 0;
            DataConfig config = new DataConfig();
            string strQuery = "select * from dbo.tongket_ketqua";
            DataTable dt = new DataTable();
            dt = config.GetDataTable(strQuery);
            result = dt.Rows.Count;  
            return result;
        }

        // cau lenh update
        public int Update(TongKetKetQuaEntities obj)
        {
            int result = 0;
            string strQuery = "update dbo.tongket_ketqua set ketqua = N'" + obj.KetQua + "', hocky = '" + obj.HocKy + "', namhoc = '" + obj.NamHoc + "' where  mahocsinh = '" + obj.MaHocSinh + "'";
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
