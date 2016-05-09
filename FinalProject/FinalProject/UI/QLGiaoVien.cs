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
    public partial class QLGiaoVien : DevExpress.XtraEditors.XtraForm
    {
        string Query = "";

        public QLGiaoVien()
        {
            InitializeComponent();
        }

        private void QLGiaoVien_Load(object sender, EventArgs e)
        {
            Load_Data();
            ControlButton(true);
        }

        private void Load_Data()
        {
            GiaoVienBLL _GiaoVien = new GiaoVienBLL();
            data_view.DataSource = _GiaoVien.getData();

            ToBoMonBLL _ToBoMon = new ToBoMonBLL();
            cb_tobomon.DataSource = _ToBoMon.getData();
            cb_tobomon.DisplayMember = "MATOBOMON";
            cb_tobomon.ValueMember = "MATOBOMON";
        }

        private void button_them_Click(object sender, EventArgs e)
        {
            Query = "add";

            text_magiaovien.Text = "";
            text_hogiaovien.Text = "";
            text_tengiaovien.Text = "";
            date_ngaysinh.Text = "";
            cb_gioitinh.Text = "";
            text_dantoc.Text = "";
            text_sonha.Text = "";
            cb_xa_phuong.Text = "";
            cb_quan_huyen.Text = "";
            cb_tinh_thanhpho.Text = "";
            text_dienthoai.Text = "";
            cb_chucvu.Text = "";
            cb_chuyenmon.Text = "";
            cb_tobomon.Text = "";

            text_magiaovien.Enabled = true;
            text_magiaovien.Focus();
            ControlButton(false);
        }

        private void button_sua_Click(object sender, EventArgs e)
        {
            Query = "edit";

            text_magiaovien.Enabled = false;
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
            GiaoVienBLL _GiaoVien = new GiaoVienBLL();
            int count = _GiaoVien.Count_Data_Rows();
            if (count == 0)
            {

            }
            else
            {
                int index = e.RowIndex;

                text_magiaovien.Text = data_view["Column1", index].Value.ToString();
                text_hogiaovien.Text = data_view["Column2", index].Value.ToString();
                text_tengiaovien.Text = data_view["Column3", index].Value.ToString();
                date_ngaysinh.Text = data_view["Column4", index].Value.ToString();
                cb_gioitinh.Text = data_view["Column5", index].Value.ToString();
                text_dantoc.Text = data_view["Column6", index].Value.ToString();
                text_sonha.Text = data_view["Column7", index].Value.ToString();
                cb_xa_phuong.Text = data_view["Column8", index].Value.ToString();
                cb_quan_huyen.Text = data_view["Column9", index].Value.ToString();
                cb_tinh_thanhpho.Text = data_view["Column10", index].Value.ToString();
                text_dienthoai.Text = data_view["Column11", index].Value.ToString();
                cb_chucvu.Text = data_view["Column12", index].Value.ToString();
                cb_chuyenmon.Text = data_view["Column13", index].Value.ToString();
                cb_tobomon.Text = data_view["Column14", index].Value.ToString();
            }
        }

        private void Excute(string strQuery)
        {
            if (strQuery == "add")
            {
                try
                {
                    GiaoVienEntities obj_GiaoVien = new GiaoVienEntities();
                    obj_GiaoVien.MaGiaoVien = text_magiaovien.Text.Trim();
                    obj_GiaoVien.HoGiaoVien = text_hogiaovien.Text.Trim();
                    obj_GiaoVien.TenGiaoVien = text_tengiaovien.Text.Trim();
                    obj_GiaoVien.NgaySinh = date_ngaysinh.DateTime;
                    obj_GiaoVien.GioiTinh = cb_gioitinh.Text.Trim();
                    obj_GiaoVien.DanToc = text_dantoc.Text.Trim();
                    obj_GiaoVien.DiaChi_SoNha = text_sonha.Text.Trim();
                    obj_GiaoVien.DiaChi_Xa_Phuong = cb_xa_phuong.Text.Trim();
                    obj_GiaoVien.DiaChi_Quan_Huyen = cb_quan_huyen.Text.Trim();
                    obj_GiaoVien.DiaChi_Tinh_ThanhPho = cb_tinh_thanhpho.Text.Trim();
                    obj_GiaoVien.SoDienThoai = text_dienthoai.Text.Trim();
                    obj_GiaoVien.ChucVu = cb_chucvu.Text.Trim();
                    obj_GiaoVien.ChuyenMon = cb_chuyenmon.Text.Trim();
                    obj_GiaoVien.MaToBoMon = cb_tobomon.Text.Trim();

                    string _maGiaoVien = text_magiaovien.Text.Trim();

                    GiaoVienBLL _GiaoVien = new GiaoVienBLL();

                    if (text_magiaovien.Text.Length == 0)
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show("Chưa nhập mã giáo viên!", "Thông báo!", MessageBoxButtons.OK);
                    }
                    else
                    if (!(_GiaoVien.CheckID(_maGiaoVien)))
                    {
                        _GiaoVien.Insert(obj_GiaoVien);
                        Load_Data();
                    }
                    else
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show("Mã giáo viên đã tồn tại!", "Thông báo!", MessageBoxButtons.OK);
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
                    GiaoVienEntities obj_GiaoVien = new GiaoVienEntities();
                    obj_GiaoVien.MaGiaoVien = text_magiaovien.Text.Trim();
                    obj_GiaoVien.HoGiaoVien = text_hogiaovien.Text.Trim();
                    obj_GiaoVien.TenGiaoVien = text_tengiaovien.Text.Trim();
                    obj_GiaoVien.NgaySinh = date_ngaysinh.DateTime;
                    obj_GiaoVien.GioiTinh = cb_gioitinh.Text.Trim();
                    obj_GiaoVien.DanToc = text_dantoc.Text.Trim();
                    obj_GiaoVien.DiaChi_SoNha = text_sonha.Text.Trim();
                    obj_GiaoVien.DiaChi_Xa_Phuong = cb_xa_phuong.Text.Trim();
                    obj_GiaoVien.DiaChi_Quan_Huyen = cb_quan_huyen.Text.Trim();
                    obj_GiaoVien.DiaChi_Tinh_ThanhPho = cb_tinh_thanhpho.Text.Trim();
                    obj_GiaoVien.SoDienThoai = text_dienthoai.Text.Trim();
                    obj_GiaoVien.ChucVu = cb_chucvu.Text.Trim();
                    obj_GiaoVien.ChuyenMon = cb_chuyenmon.Text.Trim();
                    obj_GiaoVien.MaToBoMon = cb_tobomon.Text.Trim();


                    GiaoVienBLL _GiaoVien = new GiaoVienBLL();
                    _GiaoVien.Update(obj_GiaoVien);
                    Load_Data();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sửa bị lỗi:  " + ex.Message.ToString(), "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (strQuery == "delete")
            {
                try
                {
                    string _maGiaoVien = text_magiaovien.Text.Trim();
                    GiaoVienBLL _GiaoVien = new GiaoVienBLL();
                    _GiaoVien.Delete(_maGiaoVien);
                    Load_Data();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa bị lỗi: " + ex.Message.ToString(), "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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