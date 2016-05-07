using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Entities
{
    class KhoiLopEntities
    {
        private string _maKhoi;

        public string MaKhoi
        {
            get { return _maKhoi; }
            set { _maKhoi = value; }
        }
        private string _tenKhoi;

        public string TenKhoi
        {
            get { return _tenKhoi; }
            set { _tenKhoi = value; }
        }

    }
}
