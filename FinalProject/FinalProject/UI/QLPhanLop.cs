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
    public partial class QLPhanLop : DevExpress.XtraEditors.XtraForm
    {
        public QLPhanLop()
        {
            InitializeComponent();
        }

        private void QLPhanLop_Load(object sender, EventArgs e)
        {
            Load_data();
        }

        private void Load_data()
        {
            HocSinhBLL _HocSinh = new HocSinhBLL();
            data_view.DataSource = _HocSinh.getData();

            cb_mahocsinh.DataSource = _HocSinh.getData();
            cb_mahocsinh.DisplayMember = "MAHOCSINH";
            cb_mahocsinh.ValueMember = "MAHOCSINH";

            KhoiLopBLL _KhoiLop = new KhoiLopBLL();
            cb_khoilop.DataSource = _KhoiLop.getData();
            cb_khoilop.DisplayMember = "MAKHOI";
            cb_khoilop.ValueMember = "MAKHOI";

            cb_khoilop_chuyen.DataSource = _KhoiLop.getData();
            cb_khoilop_chuyen.DisplayMember = "MAKHOI";
            cb_khoilop_chuyen.ValueMember = "MAKHOI";

            LopBLL _Lop = new LopBLL();
            cb_lop.DataSource = _Lop.getData();
            cb_lop.DisplayMember = "MALOP";
            cb_lop.ValueMember = "MALOP";


            cb_lop_chuyen.DataSource = _Lop.getData();
            cb_lop_chuyen.DisplayMember = "MALOP";
            cb_lop_chuyen.ValueMember = "MALOP";
           
        }

        private void button_chuyenlop_Click(object sender, EventArgs e)
        {
            string _maHocSinh = cb_mahocsinh.Text.Trim();
            string _maLop = cb_lop_chuyen.Text.Trim();

            HocSinhEntities obj_HocSinh = new HocSinhEntities();
            obj_HocSinh.MaHocSinh = cb_mahocsinh.Text.Trim();
            obj_HocSinh.MaLopHocSinh = cb_lop_chuyen.Text.Trim();
            HocSinhBLL _HocSinh = new HocSinhBLL();
            _HocSinh.Update_Class(obj_HocSinh);
            DevExpress.XtraEditors.XtraMessageBox.Show("Chuyển lớp thành công!", "Thông báo!", MessageBoxButtons.OK);
            cb_mahocsinh.Focus();

        }
    }
}