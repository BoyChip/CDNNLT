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
            Query = "delete";
            Excute(Query);
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
            int index = e.RowIndex;
            /*
            cb_magiaovien.Text = data_view["Column1", index].Value.ToString();
            cb_mamon.Text = data_view["Column2", index].Value.ToString();
            cb_malop.Text = data_view["Column3", index].Value.ToString();
            cb_hocky.Text = data_view["Column4", index].Value.ToString();
            cb_namhoc.Text = data_view["Column5", index].Value.ToString();
             */ 
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


                    PhanCongGiaoVienBLL _PhanCong = new PhanCongGiaoVienBLL();
                    _PhanCong.Insert(obj_PhanCong);
                    Load_data();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Them bi loi: " + ex.Message.ToString(), "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    MessageBox.Show("Sua bi loi: " + ex.Message.ToString(), "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    MessageBox.Show("Xóa bị lỗi: " + ex.Message.ToString(), "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void ControlButton(bool type)
        {
            this.button_them.Enabled = button_sua.Enabled = button_xoa.Enabled = type;
            button_luu.Enabled = button_huy.Enabled = !type;
        }
    }
}