using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Entities
{
    class PhanCongGiaoVienEntities
    {
        private string _maGiaoVien;

        public string MaGiaoVien
        {
            get { return _maGiaoVien; }
            set { _maGiaoVien = value; }
        }
        private string _maMon;

        public string MaMon
        {
            get { return _maMon; }
            set { _maMon = value; }
        }
        private string _maLop;

        public string MaLop
        {
            get { return _maLop; }
            set { _maLop = value; }
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
