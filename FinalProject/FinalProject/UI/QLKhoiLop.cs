using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using FinalProject.Business;
using FinalProject.Entities;

namespace FinalProject.UI
{
    public partial class QLKhoiLop : DevExpress.XtraEditors.XtraForm
    {
        public QLKhoiLop()
        {
            InitializeComponent();
        }

        private void QLKhoiLop_Load(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void Load_Data()
        {
            KhoiLopBLL _KhoiLop = new KhoiLopBLL();
            data_view.DataSource = _KhoiLop.getData();
        }

 
    }
}