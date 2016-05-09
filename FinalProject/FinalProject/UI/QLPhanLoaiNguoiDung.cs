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
    public partial class QLPhanLoaiNguoiDung : DevExpress.XtraEditors.XtraForm
    {
        public QLPhanLoaiNguoiDung()
        {
            InitializeComponent();
        }

        private void QLPhanLoaiNguoiDung_Load(object sender, EventArgs e)
        {
            Load_data();
        }

        private void Load_data()
        {
            PhanQuyenBLL _PhanQuyen = new PhanQuyenBLL();
            data_view.DataSource = _PhanQuyen.getData();
        }

        private void data_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}