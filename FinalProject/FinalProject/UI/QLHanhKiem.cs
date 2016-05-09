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
    public partial class QLHanhKiem : DevExpress.XtraEditors.XtraForm
    {
        string Query = "";

        public QLHanhKiem()
        {
            InitializeComponent();
        }

        private void QLHanhKiem_Load(object sender, EventArgs e)
        {
            Load_data();
            ControlButton(true);
        }

        private void Load_data()
        {
            HanhKiemBLL _HanhKiem = new HanhKiemBLL();
            data_view.DataSource = _HanhKiem.getData();

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
            cb_hocky.Text = "";
            cb_namhoc.Text = "";
            cb_hanhkiem.Text = "";

            cb_mahocsinh.Enabled = true;
            cb_mahocsinh.Focus();
        }

        private void button_sua_Click(object sender, EventArgs e)
        {
            ControlButton(false);
            Query = "edit";

            cb_mahocsinh.Enabled = false;
            
        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
            if (DevExpress.XtraEditors.XtraMessageBox.Show("Bạn có chắc chắn muốn xóa? Bạn sẽ không thể phục hồi dữ liệu đã bị xóa!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Query = "delete";
                Excute(Query);
                cb_mahocsinh.Text = "";
                cb_hocky.Text = "";
                cb_namhoc.Text = "";
                cb_hanhkiem.Text = "";
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
            HanhKiemBLL _HanhKiem = new HanhKiemBLL();
            int count = _HanhKiem.Count_Data_Rows();
            if (count == 0)
            {

            }
            else
            {
                int index = e.RowIndex;

                cb_mahocsinh.Text = data_view["Column1", index].Value.ToString();
                cb_hocky.Text = data_view["Column3", index].Value.ToString();
                cb_namhoc.Text = data_view["Column4", index].Value.ToString();
                cb_hanhkiem.Text = data_view["Column2", index].Value.ToString();

            }          
        }

        private void Excute(string strQuery)
        {
            if (strQuery == "add")
            {
                try
                {
                    HanhKiemEntities obj_HanhKiem = new HanhKiemEntities();
                    obj_HanhKiem.MaHocSinh = cb_mahocsinh.Text.Trim();
                    obj_HanhKiem.XepLoaiHanhKiem = cb_hanhkiem.Text.Trim();
                    obj_HanhKiem.HocKy = cb_hocky.Text.Trim();
                    obj_HanhKiem.NamHoc = cb_namhoc.Text.Trim();

                    string _maHocSinh = cb_mahocsinh.Text.Trim();
                    string _hocKy = cb_hocky.Text.Trim();
                    string _namHoc = cb_namhoc.Text.Trim();

                    HanhKiemBLL _HanhKiem = new HanhKiemBLL();


                    if (cb_hocky.Text.Length == 0 || cb_namhoc.Text.Length == 0)
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show("Chưa nhập học kỳ hoặc năm học!", "Thông báo!", MessageBoxButtons.OK);
                    }

                    else if (cb_mahocsinh.Text.Length == 0)
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show("Chưa nhập mã học sinh!", "Thông báo!", MessageBoxButtons.OK);
                    }
                    else if (cb_hanhkiem.Text.Length == 0)
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show("Chưa nhập thông tin hạnh kiểm!", "Thông báo!", MessageBoxButtons.OK);
                    }
                    else if (!(_HanhKiem.CheckID(_maHocSinh, _hocKy,_namHoc)))
                    {
                        _HanhKiem.Insert(obj_HanhKiem);
                        Load_data();
                    }
                    else
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show("Học sinh này đã được xếp loại!", "Thông báo!", MessageBoxButtons.OK);
                    }
                }
                catch (Exception  ex)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Thêm bị lỗi:  " + ex.Message.ToString(), "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (strQuery == "edit")
            {
                try
                {
                    HanhKiemEntities obj_HanhKiem = new HanhKiemEntities();
                    obj_HanhKiem.MaHocSinh = cb_mahocsinh.Text.Trim();
                    obj_HanhKiem.XepLoaiHanhKiem = cb_hanhkiem.Text.Trim();
                    obj_HanhKiem.HocKy = cb_hocky.Text.Trim();
                    obj_HanhKiem.NamHoc = cb_namhoc.Text.Trim();

                    HanhKiemBLL _HanhKiem = new HanhKiemBLL();
                    _HanhKiem.Update(obj_HanhKiem);
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
                    HanhKiemBLL _HanhKiem = new HanhKiemBLL();
                    _HanhKiem.Delete(_maHocSinh);
                    Load_data();
                }
                catch (Exception ex)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Xóa bị lỗi: " + ex.Message.ToString(), "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void ControlButton(bool type)
        {
            this.button_them.Enabled = button_sua.Enabled = button_xoa.Enabled = type;
            button_luu.Enabled = button_huy.Enabled = group_thongtin.Enabled= group_danhgia.Enabled= !type;
        }
    }
}