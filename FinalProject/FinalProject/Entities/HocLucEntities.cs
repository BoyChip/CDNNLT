using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Entities
{
    class HocLucEntities
    {
        private string _maHocSinh;

        public string MaHocSinh
        {
            get { return _maHocSinh; }
            set { _maHocSinh = value; }
        }
        private string _xepLoaiHocLuc;

        public string XepLoaiHocLuc
        {
            get { return _xepLoaiHocLuc; }
            set { _xepLoaiHocLuc = value; }
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
