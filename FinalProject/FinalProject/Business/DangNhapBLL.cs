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
        /// <summary>
        /// Hàm này có tác dụng lấy dữ liệu từ bảng tương ứng có trong cơ sở dữ liệu
        /// </summary>
        /// <returns>Bảng dữ liệu có đầu đủ thuộc tính của bảng</returns>
        public DataTable getData()
        {
            DataTable dtResult = new DataTable();
            DataConfig config = new DataConfig();
            string strQuery = "select * from dbo.dangnhap";
            dtResult = config.GetDataTable(strQuery);
            return dtResult;
        }

        /// <summary>
        /// Hàm này có tác dụng thêm cơ sở dữ liệu vào bảng dữ liệu tương ứng. Đầu vào là một thực thể entities bao gồm các thuộc tính cần thêm. Trả về 1 dòng giá trị sau khi thực hiện thêm.
        /// </summary>
        /// <param name="obj">Thực thể tương ứng với hàm. Vd: ở đây là thực thể DangNhapEntities bao gồm các thuộc tính tương ứng của thực thể đó.</param>
        /// <returns></returns>
        public int Insert(DangNhapEntities obj)
        {
            int result = 0;
            string strQuery = "insert into dbo.dangnhap (MAGIAOVIEN , TENDANGNHAP, MATKHAU, MALOAI) values ('" + obj.MaGiaoVien + "', '" + obj.TenDangNhap + "', '" + obj.MatKhau + "', '" + obj.MaLoai + "')";
            DataConfig config = new DataConfig();
            result = config.executeNoneQuery(strQuery);
            return result;
        }
        /// <summary>
        /// Hàm này có tác dụng kiểm tra xem đã có dữ liệu trong cơ sở dữ liệu bằng cách kiểm tra khóa chính hoặc các thuộc tính cần kiểm tra. Hàm trả về kết quả đúng hay sai. Nếu đúng nghĩa là đã có dữ liệu tương ứng trong cơ sở dữ liệu, sai thì ngược lại. 
        /// </summary>
        /// <param name="_maGiaoVien">Nhận vào thuộc tính kiểm tra là Mã giáo viên.</param>
        /// <returns>Trả về đúng hoặc sai.</returns>
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

        /// <summary>
        /// Hàm này kiểm tra tài khoản đã được cấp hay chưa. Nằm trong mục cấp tài khoản, cấp tài khoản phục vụ việc đăng nhập trong phần mềm. Nếu chưa có tài khoản đăng nhập thì phải tạo mới tài khoản.
        /// Hàm này thực hiện trong form Cấp tài khoản. Và hàm đổi mật khẩu tài khoản.
        /// </summary>
        /// <param name="_maGiaoVien">Nhận vào thuộc tính mã giáo viên.</param>
        /// <param name="_matKhau">Nhận vào thuộc tính mật khẩu tương ứng.</param>
        /// <returns>Trả về đúng hoặc sai.</returns>
        public bool Check_Pass(string _maGiaoVien, string _matKhau)
        {
            DataConfig config = new DataConfig();
            string strQuery = "select * from dbo.dangnhap where magiaovien = '" + _maGiaoVien + "' and matkhau = '"+_matKhau+"'";
            DataTable dt = new DataTable();
            dt = config.GetDataTable(strQuery);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }

        /// <summary>
        /// Hàm này có tác dụng điếm tất cả dòng có trong bảng tương ứng khi nhận vào. 
        /// </summary>
        /// <returns>Trả về 1 giá trị tương ứng với thực thể đầu vào.</returns>
        public int  Count_Data_Rows()
        {
            int result = 0;
            DataConfig config = new DataConfig();
            string strQuery = "select * from dbo.dangnhap";
            DataTable dt = new DataTable();
            dt = config.GetDataTable(strQuery);
            result = dt.Rows.Count;         
            return result;
        }
       /// <summary>
       /// Hàm này kiểm tra tên đăng nhập và mật khẩu của người dùng. Trả về kết quả đúng hoặc sai. Đúng thì đăng nhập thành công, sai thì không thể đăng nhập.
       /// </summary>
       /// <param name="_tenDangNhap">Nhận vào tên đăng nhập.</param>
       /// <param name="_matKhau">Nhận vào mật khẩu.</param>
       /// <returns>Trả về kết quả đúng hoặc sai.</returns>
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

        /// <summary>
        /// Hàm này có phép thực hiện cập nhật lại thông tin của dòng dữ liệu tương ứng với thực thể nhận vào.
        /// </summary>
        /// <param name="obj">Thực thể tương ứng.</param>
        /// <returns>Trả về dòng dữ liệu đã được cập nhật.</returns>
        public int Update(DangNhapEntities obj)
        {
            int result = 0;
            string strQuery = "update dbo.dangnhap set  tendangnhap = '" + obj.TenDangNhap + "', matkhau = '" + obj.MatKhau + "', maloai = '" + obj.MaLoai + "' where magiaovien = '" + obj.MaGiaoVien + "'";
            DataConfig config = new DataConfig();
            result = config.executeNoneQuery(strQuery);
            return result;
        }

        /// <summary>
        /// Hàm này có tác dụng cập nhật lại mật khẩu của người dùng khi sử dụng phần mềm.
        /// </summary>
        /// <param name="obj">Nhận vào thuộc tính mã giáo viên và mật khẩu của thực thể tương ứng.</param>
        /// <returns>Trả về mật khẩu mới tương ứng.</returns>
 
        public int Update_Pass(DangNhapEntities obj)
        {
            int result = 0;
            string strQuery = "update dbo.dangnhap set   matkhau = '" + obj.MatKhau + "' where magiaovien = '" + obj.MaGiaoVien + "'";
            DataConfig config = new DataConfig();
            result = config.executeNoneQuery(strQuery);
            return result;
        }
        /// <summary>
        /// Xóa người dùng tương ứng.
        /// </summary>
        /// <param name="_maGiaoVien">Nhận vào mã giáo viên.</param>
        /// <returns>Xóa người dùng giáo viên tương ứng nhận vào.</returns>
 
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
