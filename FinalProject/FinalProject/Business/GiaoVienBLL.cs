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
            string strQuery = "insert into dbo.giaovien (MAGIAOVIEN, HOGIAOVIEN, TENGIAOVIEN, NGAYSINH, GIOITINH, DANTOC, DIACHI_SONHA, DIACHI_XA_PHUONG, DIACHI_QUAN_HUYEN, DIACHI_TINH_THANHPHO, DIENTHOAI, CHUCVU, CHUYENMON, MATOBOMON) values ('" + obj.MaGiaoVien + "', '" + obj.HoGiaoVien + "', '"+obj.TenGiaoVien+"', '"+obj.NgaySinh+"', '"+obj.DanToc+"','"+obj.DiaChi_SoNha+"','"+obj.DiaChi_Xa_Phuong+"', '"+obj.DiaChi_Quan_Huyen+"', '"+obj.DiaChi_Tinh_ThanhPho+"', '"+obj.SoDienThoai+"', '"+obj.ChucVu+"', '"+obj.ChuyenMon+"', '"+obj.MaToBoMon+"')";
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

        // cau lenh update
        public int Update(GiaoVienEntities obj)
        {
            int result = 0;
            string strQuery = "update dbo.giaovien set magiaovien = '"+obj.MaGiaoVien+"', hogiaovien = '"+obj.HoGiaoVien+"', tengiaovien = '"+obj.TenGiaoVien+"', ngaysinh = '"+obj.NgaySinh+"', gioitinh = '"+obj.GioiTinh+"', dantoc = '"+obj.DanToc+"', diachi_sonha = '"+obj.DiaChi_SoNha+"', diachi_quan_huyen = '"+obj.DiaChi_Quan_Huyen+"', diachi_tinh_thanhpho = '"+obj.DiaChi_Tinh_ThanhPho+"', dienthoai = '"+obj.SoDienThoai+"', chucvu = '"+obj.ChucVu+"', chuyenmon = '"+obj.ChuyenMon+"', matobomon = '"+obj.MaToBoMon+"' ";
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
