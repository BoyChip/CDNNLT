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
    public partial class CapTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        string Query = "";
        public CapTaiKhoan()
        {
            InitializeComponent();
        }

        private void CapTaiKhoan_Load(object sender, EventArgs e)
        {
            Load_data();
            ControlButton(true);
        }

        private void Load_data()
        {
            DangNhapBLL _DangNhap = new DangNhapBLL();
            data_view.DataSource = _DangNhap.getData();

            GiaoVienBLL _GiaoVien = new GiaoVienBLL();
            cb_magiaovien.DataSource = _GiaoVien.getData();
            cb_magiaovien.DisplayMember = "MAGIAOVIEN";
            cb_magiaovien.ValueMember = "MAGIAOVIEN";

            PhanQuyenBLL _PhanQuyen = new PhanQuyenBLL();
            cb_maphanloai.DataSource = _PhanQuyen.getData();
            cb_maphanloai.DisplayMember = "MALOAI";
            cb_maphanloai.ValueMember = "MALOAI";
        }

        private void button_them_Click(object sender, EventArgs e)
        {
            ControlButton(false);
            Query = "add";
            cb_magiaovien.Text = "";
            text_taikhoan.Text = "";
            text_matkhau.Text = "";
            cb_maphanloai.Text = "";

            cb_magiaovien.Enabled = true;
            cb_magiaovien.Focus();
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
            DangNhapBLL _DangNhap = new DangNhapBLL();
            int count = _DangNhap.Count_Data_Rows();

            if (count == 0)
            {

            }
            else
            {
                int index = e.RowIndex;
                cb_magiaovien.Text = data_view["Column1", index].Value.ToString();
                text_taikhoan.Text = data_view["Column2", index].Value.ToString();
                text_matkhau.Text = data_view["Column3", index].Value.ToString();
                cb_maphanloai.Text = data_view["Column4", index].Value.ToString();
            }

        }

        private void Excute(string strQuery)
        {
            if (strQuery == "add")
            {
                try
                {
                    DangNhapEntities obj_DangNhap = new DangNhapEntities();
                    obj_DangNhap.MaGiaoVien = cb_magiaovien.Text.Trim();
                    obj_DangNhap.TenDangNhap = text_taikhoan.Text.Trim();
                    obj_DangNhap.MatKhau = text_matkhau.Text.Trim();
                    obj_DangNhap.MaLoai = cb_maphanloai.Text.Trim();

                    DangNhapBLL _DangNhap = new DangNhapBLL();
                    _DangNhap.Insert(obj_DangNhap);
                    Load_data();
                }
                catch (Exception ex)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Thêm bị lỗi: " + ex.Message.ToString(), "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (strQuery =="edit")
            {
                try
                {
                    DangNhapEntities obj_DangNhap = new DangNhapEntities();
                    obj_DangNhap.MaGiaoVien = cb_magiaovien.Text.Trim();
                    obj_DangNhap.TenDangNhap = text_taikhoan.Text.Trim();
                    obj_DangNhap.MatKhau = text_matkhau.Text.Trim();
                    obj_DangNhap.MaLoai = cb_maphanloai.Text.Trim();

                    DangNhapBLL _DangNhap = new DangNhapBLL();
                    _DangNhap.Update(obj_DangNhap);
                    Load_data();
                }
                catch(Exception ex)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Sửa bị lỗi: " + ex.Message.ToString(), "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (strQuery =="delete")
            {
                try
                {
                    string _maGiaoVien = cb_magiaovien.Text.Trim();
                    DangNhapBLL _DangNhap = new DangNhapBLL();
                    _DangNhap.Delete(_maGiaoVien);
                }
                catch(Exception ex)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Xóa bị lỗi: " + ex.Message.ToString(), "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void ControlButton(bool type)
        {
            this.button_them.Enabled = button_sua.Enabled = type;
            button_luu.Enabled = button_huy.Enabled = !type;
        }

    }
}