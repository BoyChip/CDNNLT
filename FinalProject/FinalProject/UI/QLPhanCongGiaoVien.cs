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
    public partial class QLPhanCongGiaoVien : DevExpress.XtraEditors.XtraForm
    {
        string Query = "";
        public QLPhanCongGiaoVien()
        {
            InitializeComponent();
        }

        private void QLPhanCongGiaoVien_Load(object sender, EventArgs e)
        {
            Load_data();
            ControlButton(true);
        }

        private void Load_data()
        {
            PhanCongGiaoVienBLL _PhanCong = new PhanCongGiaoVienBLL();
            data_view.DataSource = _PhanCong.getData();

            GiaoVienBLL _GiaoVien = new GiaoVienBLL();
            cb_magiaovien.DataSource = _GiaoVien.getData();
            cb_magiaovien.DisplayMember = "MAGIAOVIEN";
            cb_magiaovien.ValueMember = "MAGIAOVIEN";

            MonHocBLL _MonHoc = new MonHocBLL();
            cb_mamon.DataSource = _MonHoc.getData();
            cb_mamon.DisplayMember = "MAMON";
            cb_mamon.ValueMember = "MAMON";

            LopBLL _Lop = new LopBLL();
            cb_malop.DataSource = _Lop.getData();
            cb_malop.DisplayMember = "MALOP";
            cb_malop.ValueMember = "MALOP";

            HocKyNamHocBLL _HocKy_NamHoc = new HocKyNamHocBLL();
            cb_namhoc.DataSource = _HocKy_NamHoc.getData();
            cb_namhoc.DisplayMember = "NAMHOC";
            cb_namhoc.ValueMember = "NAMHOC";
        }

        private void button_them_Click(object sender, EventArgs e)
        {
            Query = "add";
            cb_magiaovien.Text = "";
            cb_mamon.Text = "";
            cb_malop.Text = "";
            cb_hocky.Text = "";
            cb_namhoc.Text = "";

            cb_magiaovien.Enabled = true;
            cb_magiaovien.Focus();
            ControlButton(false);
        }

        private void button_sua_Click(object sender, EventArgs e)
        {
            Query = "edit";
            cb_magiaovien.Enabled = false;
            ControlButton(false);
        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
            if (DevExpress.XtraEditors.XtraMessageBox.Show("Bạn có chắc chắn muốn xóa? Bạn sẽ không thể phục hồi dữ liệu đã bị xóa!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Query = "delete";
                Excute(Query);
            }
        }

        private void button_luu_Click(object sender, EventArgs e)
        {
            Excute(Query);
            ControlButton(true);
        }

        private void button_huy_Click(object sender, EventArgs e)
        {
            ControlButton(true);
        }

        private void data_view_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            PhanCongGiaoVienBLL _PhanCong = new PhanCongGiaoVienBLL();
            int count = _PhanCong.Count_Data_Rows();
            if (count == 0)
            {

            }
            else
            {
                int index = e.RowIndex;

                cb_magiaovien.Text = data_view["Column1", index].Value.ToString();
                cb_mamon.Text = data_view["Column2", index].Value.ToString();
                cb_malop.Text = data_view["Column3", index].Value.ToString();
                cb_hocky.Text = data_view["Column4", index].Value.ToString();
                cb_namhoc.Text = data_view["Column5", index].Value.ToString();

            }
        }

        private void Excute(string strQuery)
        {
            if (strQuery == "add")
            {
                try
                {
                    PhanCongGiaoVienEntities obj_PhanCong = new PhanCongGiaoVienEntities();
                    obj_PhanCong.MaGiaoVien = cb_magiaovien.Text.Trim();
                    obj_PhanCong.MaMon = cb_mamon.Text.Trim();
                    obj_PhanCong.MaLop = cb_malop.Text.Trim();
                    obj_PhanCong.HocKy = cb_hocky.Text.Trim();
                    obj_PhanCong.NamHoc = cb_namhoc.Text.Trim();


                    string _maGiaoVien = cb_magiaovien.Text.Trim();
                    string _maLop = cb_malop.Text.Trim();
                    string _maMon = cb_mamon.Text.Trim();
                    string _hocKy = cb_hocky.Text.Trim();
                    string _namHoc = cb_namhoc.Text.Trim();

                    PhanCongGiaoVienBLL _PhanCong = new PhanCongGiaoVienBLL();
                    if (cb_magiaovien.Text.Length == 0)
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show("Chưa nhập mã giáo viên!", "Thông báo!", MessageBoxButtons.OK);
                    }
                    else if (cb_malop.Text.Length == 0)
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show("Chưa nhập mã lớp!", "Thông báo!", MessageBoxButtons.OK);
                    }
                    else if (cb_mamon.Text.Length == 0)
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show("Chưa nhập mã môn!", "Thông báo!", MessageBoxButtons.OK);
                    }
                    else if (cb_hocky.Text.Length == 0 || cb_namhoc.Text.Length == 0)
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show("Chưa nhập học kỳ - năm học!", "Thông báo!", MessageBoxButtons.OK);
                    }
                    else if (!(_PhanCong.CheckID(_maGiaoVien, _maLop, _maMon, _hocKy, _namHoc)))
                    {
                        _PhanCong.Insert(obj_PhanCong);
                        Load_data();
                    }
                    else
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show("Thông tin đã tồn tại!", "Thông báo!", MessageBoxButtons.OK);
                    }

                }
                catch (Exception ex)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Thêm bị lỗi: " + ex.Message.ToString(), "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (strQuery == "edit")
            {
                try
                {
                    PhanCongGiaoVienEntities obj_PhanCong = new PhanCongGiaoVienEntities();
                    obj_PhanCong.MaGiaoVien = cb_magiaovien.Text.Trim();
                    obj_PhanCong.MaMon = cb_mamon.Text.Trim();
                    obj_PhanCong.MaLop = cb_malop.Text.Trim();
                    obj_PhanCong.HocKy = cb_hocky.Text.Trim();
                    obj_PhanCong.NamHoc = cb_namhoc.Text.Trim();

                    PhanCongGiaoVienBLL _PhanCong = new PhanCongGiaoVienBLL();
                    _PhanCong.Update(obj_PhanCong);
                    Load_data();

                }
                catch (Exception ex)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Sửa bị lỗi: " + ex.Message.ToString(), "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (strQuery == "delete")
            {
                try
                {
                    string _maGiaoVien = cb_magiaovien.Text.Trim();
                    PhanCongGiaoVienBLL _PhanCong = new PhanCongGiaoVienBLL();
                    _PhanCong.Delete(_maGiaoVien);
                    Load_data();
                }
                catch (Exception ex)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Xóa bị lỗi: " + ex.Message.ToString(), "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void ControlButton(bool type)
        {
            this.button_them.Enabled = button_sua.Enabled = button_xoa.Enabled = type;
            button_luu.Enabled = button_huy.Enabled = group_thongtin.Enabled = group_phanlop.Enabled = !type;
        }
    }
}