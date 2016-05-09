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
    class GiaoVienBLL
    {
        // lay co so du lieu 
        public DataTable getData()
        {
            DataTable dtResult = new DataTable();
            DataConfig config = new DataConfig();
            string strQuery = "select * from dbo.giaovien";
            dtResult = config.GetDataTable(strQuery);
            return dtResult;
        }

        // them co so du lieu
        public int Insert(GiaoVienEntities obj)
        {
            int result = 0;
            string strQuery = "insert into dbo.giaovien (MAGIAOVIEN, HOGIAOVIEN, TENGIAOVIEN, NGAYSINH, GIOITINH, DANTOC, DIACHI_SONHA, DIACHI_XA_PHUONG, DIACHI_QUAN_HUYEN, DIACHI_TINH_THANHPHO, DIENTHOAI, CHUCVU, CHUYENMON, MATOBOMON) values ('" + obj.MaGiaoVien + "', N'" + obj.HoGiaoVien + "', N'"+obj.TenGiaoVien+"', '"+obj.NgaySinh+"','"+obj.GioiTinh+"', N'"+obj.DanToc+"',N'"+obj.DiaChi_SoNha+"',N'"+obj.DiaChi_Xa_Phuong+"', N'"+obj.DiaChi_Quan_Huyen+"', N'"+obj.DiaChi_Tinh_ThanhPho+"', N'"+obj.SoDienThoai+"', N'"+obj.ChucVu+"', N'"+obj.ChuyenMon+"', N'"+obj.MaToBoMon+"')";
            DataConfig config = new DataConfig();
            result = config.executeNoneQuery(strQuery);
            return result;
        }
        // check ID 
        public bool CheckID(string _maGiaoVien)
        {
            DataConfig config = new DataConfig();
            string strQuery = "select * from dbo.giaovien where magiaovien = '"+_maGiaoVien+"'";
            DataTable dt = new DataTable();
            dt = config.GetDataTable(strQuery);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }

        // cau lenh tim kiem
        public DataTable FindItem(string item)
        {
            DataTable result = new DataTable();
            DataConfig config = new DataConfig();
            string strQuery = "select * from dbo.giaovien where MAGIAOVIEN like '%" + item + "%' or HOGIAOVIEN = '" + item + "' or TENGIAOVIEN = '" + item + "' or GIOITINH = '" + item + "'";
            result = config.GetDataTable(strQuery);
            return result;
        }

        // diem tat ca so dong co trong csdl
        public int  Count_Data_Rows()
        {
            int result = 0;
            DataConfig config = new DataConfig();
            string strQuery = "select * from dbo.giaovien ";
            DataTable dt = new DataTable();
            dt = config.GetDataTable(strQuery);
            result = dt.Rows.Count;
           
            return result;
        }

        // cau lenh update
        public int Update(GiaoVienEntities obj)
        {
            int result = 0;
            string strQuery = "update dbo.giaovien set  hogiaovien = N'" + obj.HoGiaoVien + "', tengiaovien = N'" + obj.TenGiaoVien + "', ngaysinh = '" + obj.NgaySinh + "', gioitinh = N'" + obj.GioiTinh + "', dantoc = N'" + obj.DanToc + "', diachi_sonha = N'" + obj.DiaChi_SoNha + "', diachi_quan_huyen = N'" + obj.DiaChi_Quan_Huyen + "', diachi_tinh_thanhpho = N'" + obj.DiaChi_Tinh_ThanhPho + "', dienthoai = '" + obj.SoDienThoai + "', chucvu = N'" + obj.ChucVu + "', chuyenmon = N'" + obj.ChuyenMon + "', matobomon = '" + obj.MaToBoMon + "' where magiaovien = '" + obj.MaGiaoVien + "'";
            DataConfig config = new DataConfig();
            result = config.executeNoneQuery(strQuery);
            return result;
        }
        // cau lenh xoa 
        public int Delete(string _maGiaoVien)
        {
            int result = 0;
            string strQuey = "delete from dbo.giaovien where magiaovien = '"+_maGiaoVien+"'";
            DataConfig config = new DataConfig();
            result = config.executeNoneQuery(strQuey);
            return result;
        }
    }
}
