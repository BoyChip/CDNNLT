
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Entities
{
    class DangNhapEntities
    {
        private string _maGiaoVien;

        public string MaGiaoVien
        {
            get { return _maGiaoVien; }
            set { _maGiaoVien = value; }
        }
        private string _tenDangNhap;

        public string TenDangNhap
        {
            get { return _tenDangNhap; }
            set { _tenDangNhap = value; }
        }
        private string _matKhau;

        public string MatKhau
        {
            get { return _matKhau; }
            set { _matKhau = value; }
        }
        private string _maLoai;

        public string MaLoai
        {
            get { return _maLoai; }
            set { _maLoai = value; }
        }

    }
}
