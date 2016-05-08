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

namespace FinalProject.UI
{
    public partial class GiaoDienChinh : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public GiaoDienChinh()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            QLHocSinh _HocSinh = new QLHocSinh();
            _HocSinh.MdiParent = this;
            _HocSinh.Show();
        }

        private void button_qlPhanLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            QLPhanLop _PhanLop = new QLPhanLop();
            _PhanLop.Show();
        }

        private void button_qlGiaoVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            QLGiaoVien _GiaoVien = new QLGiaoVien();
            _GiaoVien.MdiParent = this;
            _GiaoVien.Show();
        }

        private void button_qlToBoMon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            QLToBoMon _ToBoMon = new QLToBoMon();
            _ToBoMon.Show();
        }

        private void button_qlPhanCong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            QLPhanCongGiaoVien _PhanCong = new QLPhanCongGiaoVien();
            _PhanCong.Show();
        }

        private void button_qlMonHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            QLMonHoc _MonHoc = new QLMonHoc();
            _MonHoc.Show();
        }

        private void button_qlDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            QLDiem _Diem = new QLDiem();
            _Diem.Show();
        }

        private void button_qlKhoiLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            QLKhoiLop _KhoiLop = new QLKhoiLop();
            _KhoiLop.Show();
        }

        private void button_qlLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            QLLop _Lop = new QLLop();
            _Lop.Show();
        }

        private void button_qlHocKyNamHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            QLHocKyNamHoc _HocKy_NamHoc = new QLHocKyNamHoc();
            _HocKy_NamHoc.Show();
        }

        private void button_qlHocLuc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            QLHocLuc _HocLuc = new QLHocLuc();
            _HocLuc.MdiParent = this;
            _HocLuc.Show();
        }

        private void button_qlHanhKiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            QLHanhKiem _HanhKiem = new QLHanhKiem();
            _HanhKiem.MdiParent = this;
            _HanhKiem.Show();

        }

        private void button_qlTongKet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            QLKetQua _KetQua = new QLKetQua();
            _KetQua.MdiParent = this;
            _KetQua.Show();
        }

    }
}