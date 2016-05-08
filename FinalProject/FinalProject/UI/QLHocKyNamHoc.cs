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
    public partial class QLHocKyNamHoc : DevExpress.XtraEditors.XtraForm
    {
        string Query = "";

        public QLHocKyNamHoc()
        {
            InitializeComponent();
        }

        private void QLHocKyNamHoc_Load(object sender, EventArgs e)
        {
            Load_Data();
            ControlButton(true);
        }
        private void Load_Data()
        {
            HocKyNamHocBLL _HocKyNamHoc = new HocKyNamHocBLL();
            grid_hockynamhoc.DataSource = _HocKyNamHoc.getData();
        }

        private void button_them_Click(object sender, EventArgs e)
        {
            Query = "add";
            
            cb_hocky.Text = "";
            cb_namhoc.Text = "";

            cb_hocky.Enabled = true;
            cb_hocky.Focus();

            ControlButton(false);
        }

        private void button_sua_Click(object sender, EventArgs e)
        {
            Query = "edit";
            cb_hocky.Enabled = true;
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
            cb_hocky.Enabled = true;
            ControlButton(true);
        }

        private void grid_hockynamhoc_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            cb_hocky.Text = grid_hockynamhoc["Column1", index].Value.ToString();
            cb_namhoc.Text = grid_hockynamhoc["Column2", index].Value.ToString();
        }
        private void ControlButton(bool type)
        {
            this.button_them.Enabled = button_sua.Enabled = type;
            button_luu.Enabled = button_huy.Enabled = !type;
        }

        private void Excute(string strQuery)
        {
            if (strQuery == "add")
            {
                try
                {
                    HocKyNamHocEntities obj_HocKyNamHoc = new HocKyNamHocEntities();
                    obj_HocKyNamHoc.HocKy = cb_hocky.Text.Trim();
                    obj_HocKyNamHoc.NamHoc = cb_namhoc.Text.Trim();
                    HocKyNamHocBLL _HocKyNamHoc = new HocKyNamHocBLL();
                    string _HocKy = cb_hocky.Text.Trim();
                    string _NamHoc = cb_namhoc.Text.Trim();
                    if (cb_hocky.Text.Length == 0 || cb_namhoc.Text.Length == 0)
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa nhập học kỳ hoặc năm học!", "Thông báo!", MessageBoxButtons.OK);
                    }
                    else if (!(_HocKyNamHoc.CheckID(_HocKy, _NamHoc)))
                    {
                        _HocKyNamHoc.Insert(obj_HocKyNamHoc);
                        Load_Data();
                    }
                    else
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show("Học kỳ: " + _HocKy + " năm học: " + _NamHoc + " đã tồn tại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    HocKyNamHocEntities obj_HocKyNamHoc = new HocKyNamHocEntities();
                    obj_HocKyNamHoc.HocKy = cb_hocky.Text.Trim();
                    obj_HocKyNamHoc.NamHoc = cb_namhoc.Text.Trim();
                    HocKyNamHocBLL _HocKyNamHoc = new HocKyNamHocBLL();
                    string _HocKy = cb_hocky.Text.Trim();
                    string _NamHoc = cb_namhoc.Text.Trim();
                    _HocKyNamHoc.Update(obj_HocKyNamHoc);
                    Load_Data();
                }
                catch (Exception ex)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Sửa bị lỗi: " + ex.Message.ToString(), "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (strQuery =="delete")
            {
                try
                {
                    string _HocKy = cb_hocky.Text.Trim();
                    string _NamHoc = cb_namhoc.Text.Trim();
                    HocKyNamHocBLL _HocKyNamHoc = new HocKyNamHocBLL();
                    _HocKyNamHoc.Delete(_HocKy, _NamHoc);
                    Load_Data();
                }
                catch (Exception ex)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Xóa bị lỗi: " + ex.Message.ToString(), "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}