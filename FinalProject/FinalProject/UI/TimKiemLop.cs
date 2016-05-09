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
    public partial class TimKiemLop : DevExpress.XtraEditors.XtraForm
    {
        public TimKiemLop()
        {
            InitializeComponent();
        }

        private void TimKiemLop_Load(object sender, EventArgs e)
        {
            Load_data();
        }

        private void Load_data()
        {
            LopBLL _Lop = new LopBLL();
            data_view.DataSource = _Lop.getData();
        }

        private void text_finditem_TextChanged(object sender, EventArgs e)
        {
            string _item = text_finditem.Text.Trim();
            LopBLL _Lop = new LopBLL();
            data_view.DataSource = _Lop.FindItem(_item);
        }

        private void button_timkiem_Click(object sender, EventArgs e)
        {
            string _item = text_finditem.Text.Trim();
            LopBLL _Lop = new LopBLL();
            data_view.DataSource = _Lop.FindItem(_item);
        }

 
    }
}