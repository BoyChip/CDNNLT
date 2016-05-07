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
    public partial class QLKetQua : DevExpress.XtraEditors.XtraForm
    {
        string Query = "";
        public QLKetQua()
        {
            InitializeComponent();
        }

        private void QLKetQua_Load(object sender, EventArgs e)
        {
            Load_data();
            ControlButton(true);
        }

        private void Load_data()
        {
            TongKetKetQuaBLL _KetQua = new TongKetKetQuaBLL();
            data_view.DataSource = _KetQua.getData();
        }

        private void button_them_Click(object sender, EventArgs e)
        {
            Query = "add";

            cb_mahocsinh.Text = "";
            cb_ketqua.Text = "";
            cb_hocky.Text = "";
            cb_namhoc.Text = "";

            cb_mahocsinh.Enabled = true;
            cb_mahocsinh.Focus();
            ControlButton(false);
        }

        private void button_sua_Click(object sender, EventArgs e)
        {
            Query = "edit";
            cb_mahocsinh.Enabled = false;
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
            cb_mahocsinh.Text = data_view["Column1", index].Value.ToString();
            cb_ketqua.Text = data_view["Column2", index].Value.ToString();
            cb_hocky.Text = data_view["Column3", index].Value.ToString();
            cb_namhoc.Text = data_view["Column4", index].Value.ToString();
             */  
        }

        private void Excute(string strQuery)
        {
            if (strQuery == "add")
            {
                try
                {
                    TongKetKetQuaEntities obj_KetQua = new TongKetKetQuaEntities();
                    obj_KetQua.MaHocSinh = cb_mahocsinh.Text.Trim();
                    obj_KetQua.KetQua = cb_ketqua.Text.Trim();
                    obj_KetQua.HocKy = cb_hocky.Text.Trim();
                    obj_KetQua.NamHoc = cb_namhoc.Text.Trim();

                    TongKetKetQuaBLL _KetQua = new TongKetKetQuaBLL();
                    _KetQua.Insert(obj_KetQua);
                    Load_data();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Them bi loi: " + ex.Message.ToString(), "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (strQuery =="edit")
            {
                try
                {
                    TongKetKetQuaEntities obj_KetQua = new TongKetKetQuaEntities();
                    obj_KetQua.MaHocSinh = cb_mahocsinh.Text.Trim();
                    obj_KetQua.KetQua = cb_ketqua.Text.Trim();
                    obj_KetQua.HocKy = cb_hocky.Text.Trim();
                    obj_KetQua.NamHoc = cb_namhoc.Text.Trim();

                    TongKetKetQuaBLL _KetQua = new TongKetKetQuaBLL();
                    _KetQua.Update(obj_KetQua);
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
                    string _maHocSinh = cb_mahocsinh.Text.Trim();
                    TongKetKetQuaBLL _KetQua = new TongKetKetQuaBLL();
                    _KetQua.Delete(_maHocSinh);
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