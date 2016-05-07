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
    class DangNhapBLL
    {
        // lay co so du lieu 
        public DataTable getData()
        {
            DataTable dtResult = new DataTable();
            DataConfig config = new DataConfig();
            string strQuery = "select * from dbo.dangnhap";
            dtResult = config.GetDataTable(strQuery);
            return dtResult;
        }

        // them co so du lieu
        public int Insert(DangNhapEntities obj)
        {
            int result = 0;
            string strQuery = "insert into dbo.dangnhap (MAGIAOVIEN , TENDANGNHAP, MATKHAU, MALOAI) values ('" + obj.MaGiaoVien + "', '" + obj.TenDangNhap + "', '" + obj.MatKhau + "', '" + obj.MaLoai + "')";
            DataConfig config = new DataConfig();
            result = config.executeNoneQuery(strQuery);
            return result;
        }
        // check ID 
        public bool CheckID(string _maGiaoVien)
        {
            DataConfig config = new DataConfig();
            string strQuery = "select * from dbo.dangnhap where magiaovien = '" + _maGiaoVien + "'";
            DataTable dt = new DataTable();
            dt = config.GetDataTable(strQuery);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }
        // check Dang nhap
        public bool Check_DangNhap(string _tenDangNhap, string _matKhau)
        {
            DataConfig config = new DataConfig();
            string strQuery = "select * from dbo.dangnhap where tendangnhap = '" + _tenDangNhap + "' and matkhau = '"+_matKhau+"'";
            DataTable dt = new DataTable();
            dt = config.GetDataTable(strQuery);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }

        // cau lenh update
        public int Update(DangNhapEntities obj)
        {
            int result = 0;
            string strQuery = "update dbo.dangnhap set magiaovien = '" + obj.MaGiaoVien + "', tendangnhap = '" + obj.TenDangNhap + "', malop = '" + obj.MatKhau + "', hocky = '" + obj.MaLoai + "'";
            DataConfig config = new DataConfig();
            result = config.executeNoneQuery(strQuery);
            return result;
        }
        // cau lenh xoa 
        public int Delete(string _maGiaoVien)
        {
            int result = 0;
            string strQuey = "delete from dbo.dangnhap where magiaovien = '" + _maGiaoVien + "'";
            DataConfig config = new DataConfig();
            result = config.executeNoneQuery(strQuey);
            return result;
        }
    }
}
