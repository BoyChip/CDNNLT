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
            text_namhoc.Text = "";
            cb_hocky.Focus();

            ControlButton(false);
        }

        private void button_sua_Click(object sender, EventArgs e)
        {
            Query = "edit";
            cb_hocky.Enabled = false;
            text_namhoc.Text = "";
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

        private void grid_hockynamhoc_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            cb_hocky.Text = grid_hockynamhoc["Column1", index].Value.ToString();
            text_namhoc.Text = grid_hockynamhoc["Column2", index].Value.ToString();
        }
        private void ControlButton(bool type)
        {
            this.button_them.Enabled = button_sua.Enabled = button_xoa.Enabled = type;
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
                    obj_HocKyNamHoc.NamHoc = text_namhoc.Text.Trim();
                    HocKyNamHocBLL _HocKyNamHoc = new HocKyNamHocBLL();
                    string _HocKy = cb_hocky.Text.Trim();
                    string _NamHoc = text_namhoc.Text.Trim();
                    if (!(_HocKyNamHoc.CheckID(_HocKy, _NamHoc)))
                    {
                        _HocKyNamHoc.Insert(obj_HocKyNamHoc);
                        Load_Data();
                    }
                    else
                    {
                        MessageBox.Show("Hoc ky: " + _HocKy + " nam hoc: " + _NamHoc + " da ton tai!", "Thong bao!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

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
                    HocKyNamHocEntities obj_HocKyNamHoc = new HocKyNamHocEntities();
                    obj_HocKyNamHoc.HocKy = cb_hocky.Text.Trim();
                    obj_HocKyNamHoc.NamHoc = text_namhoc.Text.Trim();
                    HocKyNamHocBLL _HocKyNamHoc = new HocKyNamHocBLL();
                    string _HocKy = cb_hocky.Text.Trim();
                    string _NamHoc = text_namhoc.Text.Trim();
                    _HocKyNamHoc.Update(obj_HocKyNamHoc);
                    Load_Data();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sua bi loi: " + ex.Message.ToString(), "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (strQuery =="delete")
            {
                try
                {
                    string _HocKy = cb_hocky.Text.Trim();
                    string _NamHoc = text_namhoc.Text.Trim();
                    HocKyNamHocBLL _HocKyNamHoc = new HocKyNamHocBLL();
                    _HocKyNamHoc.Delete(_HocKy, _NamHoc);
                    Load_Data();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa bị lỗi: " + ex.Message.ToString(), "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}