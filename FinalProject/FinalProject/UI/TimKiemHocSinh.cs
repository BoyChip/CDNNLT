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
    public partial class TimKiemHocSinh : DevExpress.XtraEditors.XtraForm
    {
        public TimKiemHocSinh()
        {
            InitializeComponent();
        }

        private void TimKiemHocSinh_Load(object sender, EventArgs e)
        {
            Load_data();
        }

        private void Load_data()
        {
            HocSinhBLL _HocSinh = new HocSinhBLL();
            data_view.DataSource = _HocSinh.getData();
        }

        private void text_item_TextChanged(object sender, EventArgs e)
        {
            string _item = text_item.Text.Trim();
            HocSinhBLL _HocSinh = new HocSinhBLL();
            data_view.DataSource = _HocSinh.FindItem(_item);
        }

        private void button_timkiem_Click(object sender, EventArgs e)
        {
            string _item = text_item.Text.Trim();
            HocSinhBLL _HocSinh = new HocSinhBLL();
            data_view.DataSource = _HocSinh.FindItem(_item);
        }


    }
}