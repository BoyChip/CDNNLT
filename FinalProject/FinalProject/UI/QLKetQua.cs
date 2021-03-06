﻿using System;
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

            HocKyNamHocBLL _HocKy_NamHoc = new HocKyNamHocBLL();
            cb_namhoc.DataSource = _HocKy_NamHoc.getData();
            cb_namhoc.DisplayMember = "NAMHOC";
            cb_namhoc.ValueMember = "NAMHOC";

            HocSinhBLL _HocSinh = new HocSinhBLL();
            cb_mahocsinh.DataSource = _HocSinh.getData();
            cb_mahocsinh.DisplayMember = "MAHOCSINH";
            cb_mahocsinh.ValueMember = "MAHOCSINH";
        }

        private void button_them_Click(object sender, EventArgs e)
        {
            ControlButton(false);
            Query = "add";

            cb_mahocsinh.Text = "";
            cb_ketqua.Text = "";
            cb_hocky.Text = "";
            cb_namhoc.Text = "";

            cb_mahocsinh.Enabled = true;
            cb_mahocsinh.Focus();

        }

        private void button_sua_Click(object sender, EventArgs e)
        {
            Query = "edit";
            cb_mahocsinh.Enabled = false;
            ControlButton(false);
        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
            if (DevExpress.XtraEditors.XtraMessageBox.Show("Bạn có chắc chắn muốn xóa? Bạn sẽ không thể phục hồi dữ liệu đã bị xóa!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Query = "delete";
                Excute(Query);
                cb_mahocsinh.Text = "";
                cb_ketqua.Text = "";
                cb_hocky.Text = "";
                cb_namhoc.Text = "";
                Load_data();
            }

        }

        private void button_luu_Click(object sender, EventArgs e)
        {
            Excute(Query);
            ControlButton(true);
        }

        private void button_huy_Click(object sender, EventArgs e)
        {
            Load_data();
            ControlButton(true);
        }

        private void data_view_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            TongKetKetQuaBLL _KetQua = new TongKetKetQuaBLL();
            int count = _KetQua.Count_Data_Rows();
            if (count == 0)
            {
                cb_mahocsinh.Focus();
            }
            else
            {
                int index = e.RowIndex;

                cb_mahocsinh.Text = data_view["Column1", index].Value.ToString();
                cb_ketqua.Text = data_view["Column2", index].Value.ToString();
                cb_hocky.Text = data_view["Column3", index].Value.ToString();
                cb_namhoc.Text = data_view["Column4", index].Value.ToString();
            }
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

                    string _maHocSinh = cb_mahocsinh.Text.Trim();
                    string _hocKy = cb_hocky.Text.Trim();
                    string _namHoc = cb_namhoc.Text.Trim();
                    TongKetKetQuaBLL _KetQua = new TongKetKetQuaBLL();

                    if (cb_hocky.Text.Length == 0 || cb_namhoc.Text.Length == 0)
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show("Chưa nhập học kỳ hoặc năm học!", "Thông báo!", MessageBoxButtons.OK);
                    }
                    else if (cb_mahocsinh.Text.Length == 0)
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show("Chưa nhập mã học sinh!", "Thông báo!", MessageBoxButtons.OK);
                    }
                    else if (cb_ketqua.Text.Length == 0)
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show("Chưa đánh giá xếp loại học sinh!", "Thông báo!", MessageBoxButtons.OK);
                    }
                    else if (!(_KetQua.CheckID(_maHocSinh, _hocKy, _namHoc)))
                    {
                        _KetQua.Insert(obj_KetQua);
                        Load_data();
                    }
                    else
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show("Học sinh đã được đánh giá trong học kỳ này!", "Thông báo!", MessageBoxButtons.OK);
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
                    DevExpress.XtraEditors.XtraMessageBox.Show("Sửa bị lỗi: " + ex.Message.ToString(), "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    DevExpress.XtraEditors.XtraMessageBox.Show("Xóa bị lỗi: " + ex.Message.ToString(), "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void ControlButton(bool type)
        {
            this.button_them.Enabled = button_sua.Enabled = button_xoa.Enabled = type;
            button_luu.Enabled = button_huy.Enabled = group_thongtin.Enabled = group_danhgia.Enabled = !type;
        }

    }
}