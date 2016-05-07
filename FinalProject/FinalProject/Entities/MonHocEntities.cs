using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Entities
{
    class MonHocEntities
    {
        private string _maMon;

        public string MaMon
        {
            get { return _maMon; }
            set { _maMon = value; }
        }
        private string _tenMon;

        public string TenMon
        {
            get { return _tenMon; }
            set { _tenMon = value; }
        }
        private int _soTiet;

        public int SoTiet
        {
            get { return _soTiet; }
            set { _soTiet = value; }
        }
        private int _heSo;

        public int HeSo
        {
            get { return _heSo; }
            set { _heSo = value; }
        }

    }
}
