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
    public partial class QLLop : DevExpress.XtraEditors.XtraForm
    {
        string Query = "";

        public QLLop()
        {
            InitializeComponent();
        }

        private void QLLop_Load(object sender, EventArgs e)
        {
            Load_Data();
            ControlButton(true);
        }

        private void Load_Data()
        {
            LopBLL _Lop = new LopBLL();
            data_view.DataSource = _Lop.getData();

            GiaoVienBLL _GiaoVien = new GiaoVienBLL();
            cb_magiaovien.DataSource = _GiaoVien.getData();
            cb_magiaovien.DisplayMember = "MAGIAOVIEN";
            cb_magiaovien.ValueMember = "MAGIAOVIEN";

            HocKyNamHocBLL _HocKy_NamHoc = new HocKyNamHocBLL();
            cb_namhoc.DataSource = _HocKy_NamHoc.getData();
            cb_namhoc.DisplayMember = "NAMHOC";
            cb_namhoc.ValueMember = "NAMHOC";

            KhoiLopBLL _Khoi = new KhoiLopBLL();
            cb_makhoi.DataSource = _Khoi.getData();
            cb_makhoi.DisplayMember = "MAKHOI";
            cb_makhoi.ValueMember = "MAKHOI";

        }

        private void button_them_Click(object sender, EventArgs e)
        {
            Query = "add";
            text_malop.Text = "";
            cb_makhoi.Text = "";
            text_tenlop.Text = "";
            cb_magiaovien.Text = "";
            text_siso.Text = "0";
            cb_hocky.Text = "";
            cb_namhoc.Text = "";

            text_malop.Enabled = true;
            text_malop.Focus();
            ControlButton(false); 
        }

        private void button_sua_Click(object sender, EventArgs e)
        {
            Query = "edit";

            text_malop.Enabled = false;
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
            text_malop.Text = data_view["Column1", index].Value.ToString();
            cb_makhoi.Text = data_view["Column2", index].Value.ToString();
            text_tenlop.Text = data_view["Column3", index].Value.ToString();
            cb_magiaovien.Text = data_view["Column4", index].Value.ToString();
            text_siso.Text = data_view["Column5", index].Value.ToString();
            cb_hocky.Text = data_view["Column6", index].Value.ToString();
            cb_namhoc.Text = data_view["Column7", index].Value.ToString();
        }

        private void Excute(string strQuery)
        {
            if (strQuery =="add")
            {
                try
                {
                    LopEntities obj_Lop = new LopEntities();
                    obj_Lop.MaLop = text_malop.Text.Trim();
                    obj_Lop.MaKhoi = cb_makhoi.Text.Trim();
                    obj_Lop.TenLop = text_tenlop.Text.Trim();
                    obj_Lop.MaGiaoVien = cb_magiaovien.Text.Trim();
                    obj_Lop.SiSo = Convert.ToInt32(text_siso.Text);
                    obj_Lop.HocKy = cb_hocky.Text.Trim();
                    obj_Lop.NamHoc = cb_namhoc.Text.Trim();

                    if (cb_makhoi.Text.Length == 0 || cb_hocky.Text.Length == 0 || cb_namhoc.Text.Length == 0)
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show("Mã khối, học kỳ - năm học không được bõ trống!", "Thông báo!", MessageBoxButtons.OK);
                    }
                    else {
                        LopBLL _Lop = new LopBLL();
                        _Lop.Insert(obj_Lop);
                        Load_Data();
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
                    LopEntities obj_Lop = new LopEntities();
                    obj_Lop.MaLop = text_malop.Text.Trim();
                    obj_Lop.MaKhoi = cb_makhoi.Text.Trim();
                    obj_Lop.TenLop = text_tenlop.Text.Trim();
                    obj_Lop.MaGiaoVien = cb_magiaovien.Text.Trim();
                    obj_Lop.SiSo = Convert.ToInt32(text_siso.Text);
                    obj_Lop.HocKy = cb_hocky.Text.Trim();
                    obj_Lop.NamHoc = cb_namhoc.Text.Trim();

                    LopBLL _Lop = new LopBLL();
                    _Lop.Update(obj_Lop);
                    Load_Data();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Sua bi loi: " + ex.Message.ToString(), "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            if (strQuery == "delete")
            {
                try
                {
                    string _maLop = text_malop.Text.Trim();
                    LopBLL _Lop = new LopBLL();

                    HocSinhBLL _HocSinh = new HocSinhBLL();
                    int count  = _HocSinh.TimLopCuaHocSinh(_maLop);
                    if ( count > 0 )
                    {
                        MessageBox.Show("Lop da co hoc sinh", "Thong bao", MessageBoxButtons.OK);
                    }
                    else if (count == 0)
                    {
                        _Lop.Delete(_maLop);
                        Load_Data();
                    }
                }
                catch(Exception ex)
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