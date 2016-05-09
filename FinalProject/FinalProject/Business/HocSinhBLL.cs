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
    class HocSinhBLL
    {
        // lay co so du lieu 
        public DataTable getData()
        {
            DataTable dtResult = new DataTable();
            DataConfig config = new DataConfig();
            string strQuery = "select * from dbo.hocsinh";
            dtResult = config.GetDataTable(strQuery);
            return dtResult;
        }

        // them co so du lieu
        public int Insert(HocSinhEntities obj)
        {
            int result = 0;
            string strQery = "insert into dbo.hocsinh (MAHOCSINH, MALOP, HOHOCSINH, TENHOCSINH, GIOITINH, NGAYSINH, NOISINH, DANTOC, DIACHI_SONHA, DIACHI_XA_PHUONG, DIACHI_QUAN_HUYEN, DIACHI_TINH_THANHPHO, HOTENCHA, HOTENME, NGHENGHIEPCHA, NGHENGHIEPME, DIENTHOAI, GHICHU) values (N'"+obj.MaHocSinh+"',N'"+obj.MaLopHocSinh+"',N'"+obj.HoHocSinh+"',N'"+obj.TenHocSinh+"',N'"+obj.GioiTinhHocSinh+"','"+obj.NgaySinhHocSinh+"',N'"+obj.NoiSinhHocSinh+"',N'"+obj.DanTocHocSinh+"',N'"+obj.DiaChi_SoNha_HocSinh+"',N'"+obj.DiaChi_Xa_Phuong_HocSinh+"',N'"+obj.DiaChi_Quan_Huyen_HocSinh+"',N'"+obj.DiaChi_Tinh_ThanhPho_HocSinh+"',N'"+obj.HoTenChaHocSinh+"',N'"+obj.HoTenMeHocSinh+"',N'"+obj.NgheNghiepCha+"',N'"+obj.NgheNghiepMe+"',N'"+obj.DienThoaiHocSinh+"',N'"+obj.GhiChuHocSinh+"')";
            DataConfig config = new DataConfig();
            result = config.executeNoneQuery(strQery);
            return result;
        }
        // check ID
        public bool CheckID(string _MaHocSinh)
        {
            DataConfig config = new DataConfig();
            string strQuery = "select * from dbo.hocsinh where MAHOCSINH = '"+_MaHocSinh+"'";
            DataTable dt = new DataTable();
            dt = config.GetDataTable(strQuery);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }

        //diem so luong phan tu co trong csdl 
        public int Count_Data_Rows()
        {
            int result = 0;
            DataConfig config = new DataConfig();
            string strQuery = "select * from dbo.hocsinh ";
            DataTable dt = new DataTable();
            dt = config.GetDataTable(strQuery);
            result = dt.Rows.Count;         
            return result;
        }

        //tim kiem hoc sinh trong lop
        public int TimLopCuaHocSinh(string _maLop)
        {
            int result = 0;
            DataConfig config = new DataConfig();
            string strQuery = "select * from dbo.hocsinh where malop = '" + _maLop + "'";
            DataTable dt = new DataTable();
            dt = config.GetDataTable(strQuery);
            result = dt.Rows.Count;
            return result;
        }
        // cau lenh tim kiem
        public DataTable FindItem(string item)
        {
            DataTable result = new DataTable();
            DataConfig config = new DataConfig();
            string strQuery = "select * from dbo.hocsinh where MAHOCSINH like '%" + item + "%' or HOHOCSINH = '"+item+"' or TENHOCSINH = '"+item+"' or GIOITINH = '"+item+"' or NOISINH = '"+item+"'";
            result = config.GetDataTable(strQuery);
            return result;
        }
        
        // cau lenh update
        public int Update(HocSinhEntities obj)
        {
            int result = 0;
            string strQery = "update dbo.hocsinh set MALOP = N'"+obj.MaLopHocSinh+"', HOHOCSINH = N'"+obj.HoHocSinh+"', TENHOCSINH = N'"+obj.TenHocSinh+"', GIOITINH = N'"+obj.GioiTinhHocSinh+"', NGAYSINH = '"+obj.NgaySinhHocSinh+"', NOISINH = N'"+obj.NoiSinhHocSinh+"', DANTOC = N'"+obj.DanTocHocSinh+"',DIACHI_SONHA = N'"+obj.DiaChi_SoNha_HocSinh+"', DIACHI_XA_PHUONG = N'"+obj.DiaChi_Xa_Phuong_HocSinh+"', DIACHI_QUAN_HUYEN = N'"+obj.DiaChi_Quan_Huyen_HocSinh+"', DIACHI_TINH_THANHPHO = N'"+obj.DiaChi_Tinh_ThanhPho_HocSinh+"', HOTENCHA = N'"+obj.HoTenChaHocSinh+"', HOTENME =N'"+obj.HoTenMeHocSinh+"', NGHENGHIEPCHA = N'"+obj.NgheNghiepCha+"', NGHENGHIEPME = N'"+obj.NgheNghiepMe+"', DIENTHOAI = N'"+obj.DienThoaiHocSinh+"', GHICHU = N'"+obj.GhiChuHocSinh+"' where MAHOCSINH = '"+obj.MaHocSinh+"'";
            DataConfig config = new DataConfig();
            result = config.executeNoneQuery(strQery);
            return result;
        }
        // cau lenh xoa
        public int Delete(string _MaHocSinh)
        {
            int result = 0;
            string strQery = "delete from dbo.hocsinh where MAHOCSINH = '"+_MaHocSinh+"'";
            DataConfig config = new DataConfig();
            result = config.executeNoneQuery(strQery);
            return result;
        }
    }
}
