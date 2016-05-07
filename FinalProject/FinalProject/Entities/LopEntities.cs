using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Entities
{
    class LopEntities
    {
        private string _maLop;

        public string MaLop
        {
            get { return _maLop; }
            set { _maLop = value; }
        }
        private string _maKhoi;

        public string MaKhoi
        {
            get { return _maKhoi; }
            set { _maKhoi = value; }
        }
        private string _tenLop;

        public string TenLop
        {
            get { return _tenLop; }
            set { _tenLop = value; }
        }
        private string _maGiaoVien;

        public string MaGiaoVien
        {
            get { return _maGiaoVien; }
            set { _maGiaoVien = value; }
        }
        private int _siSo;

        public int SiSo
        {
            get { return _siSo; }
            set { _siSo = value; }
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
