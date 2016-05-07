using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Entities
{
    class HanhKiemEntities
    {
        private string _maHocSinh;

        public string MaHocSinh
        {
            get { return _maHocSinh; }
            set { _maHocSinh = value; }
        }
        private string _xepLoaiHanhKiem;

        public string XepLoaiHanhKiem
        {
            get { return _xepLoaiHanhKiem; }
            set { _xepLoaiHanhKiem = value; }
        }
        private string _HocKy;

        public string HocKy
        {
            get { return _HocKy; }
            set { _HocKy = value; }
        }
        private string _NamHoc;

        public string NamHoc
        {
            get { return _NamHoc; }
            set { _NamHoc = value; }
        }
    }
}
