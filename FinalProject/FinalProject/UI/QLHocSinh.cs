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
    public partial class QLHocSinh : DevExpress.XtraEditors.XtraForm
    {
        string Query = "";

        public QLHocSinh()
        {
            InitializeComponent();
        }

        private void QLHocSinh_Load(object sender, EventArgs e)
        {
            Load_data();
            ControlButton(true);
        }

        private void Load_data()
        {
            HocSinhBLL _HocSinh = new HocSinhBLL();
            data_view.DataSource = _HocSinh.getData();

            //load ma lop len combobox
            LopBLL _Lop = new LopBLL();
            cb_malop.DataSource = _Lop.getData();
            cb_malop.DisplayMember = "TENLOP";
            cb_malop.ValueMember = "MALOP";
            
        }

        private void button_them_Click(object sender, EventArgs e)
        {
            Query = "add";

            text_mahocsinh.Text = "";
            cb_malop.Text = "";
            text_hohocsinh.Text = "";
            text_tenhocsinh.Text = "";
            cb_gioitinh.Text = "";
            date_ngaysinh.Text = "";
            cb_noisinh.Text = "";
            text_dantoc.Text = "";
            text_sonha.Text = "";
            cb_xa_phuong.Text = "";
            cb_quan_huyen.Text = "";
            cb_tinh_thanhpho.Text = "";
            text_hotencha.Text = "";
            text_hotenme.Text = "";
            text_nghenghiepcha.Text = "";
            text_nghenghiepme.Text = "";
            text_dienthoai.Text = "";
            text_ghichu.Text = "";

            text_mahocsinh.Enabled = true;
            text_mahocsinh.Focus();

            ControlButton(false);

        }

        private void button_sua_Click(object sender, EventArgs e)
        {
            Query = "edit";

            text_mahocsinh.Enabled = false;
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

            text_mahocsinh.Text = data_view["Column1", index].Value.ToString();
            cb_malop.Text = data_view["Column2", index].Value.ToString();
            text_hohocsinh.Text = data_view["Column3", index].Value.ToString();
            text_tenhocsinh.Text = data_view["Column4", index].Value.ToString();
            cb_gioitinh.Text = data_view["Column5", index].Value.ToString();
            date_ngaysinh.Text = data_view["Column6", index].Value.ToString();
            cb_noisinh.Text = data_view["Column7", index].Value.ToString();
            text_dantoc.Text = data_view["Column8", index].Value.ToString();
            text_sonha.Text = data_view["Column9", index].Value.ToString();
            cb_xa_phuong.Text = data_view["Column10", index].Value.ToString();
            cb_quan_huyen.Text = data_view["Column11", index].Value.ToString();
            cb_tinh_thanhpho.Text = data_view["Column12", index].Value.ToString();
            text_hotencha.Text = data_view["Column13", index].Value.ToString();
            text_hotenme.Text = data_view["Column14", index].Value.ToString();
            text_nghenghiepcha.Text = data_view["Column15", index].Value.ToString();
            text_nghenghiepme.Text = data_view["Column16", index].Value.ToString();
            text_dienthoai.Text = data_view["Column17", index].Value.ToString();
            text_ghichu.Text = data_view["Column18", index].Value.ToString();
        }

        private void Excute(string strQuery)
        {
            if (strQuery == "add")
            {
                try
                {
                    HocSinhEntities obj_HocSinh = new HocSinhEntities();
                    obj_HocSinh.MaHocSinh = text_mahocsinh.Text.Trim();
                    obj_HocSinh.MaLopHocSinh = cb_malop.Text.Trim();
                    obj_HocSinh.HoHocSinh = text_hohocsinh.Text;
                    obj_HocSinh.TenHocSinh = text_tenhocsinh.Text;
                    obj_HocSinh.GioiTinhHocSinh = cb_gioitinh.Text.Trim();
                    obj_HocSinh.NgaySinhHocSinh = date_ngaysinh.DateTime;
                    obj_HocSinh.NoiSinhHocSinh = cb_noisinh.Text.Trim();
                    obj_HocSinh.DanTocHocSinh = text_dantoc.Text.Trim();
                    obj_HocSinh.DiaChi_SoNha_HocSinh = text_sonha.Text.Trim();
                    obj_HocSinh.DiaChi_Xa_Phuong_HocSinh = cb_xa_phuong.Text.Trim();
                    obj_HocSinh.DiaChi_Quan_Huyen_HocSinh = cb_quan_huyen.Text.Trim();
                    obj_HocSinh.DiaChi_Tinh_ThanhPho_HocSinh = cb_tinh_thanhpho.Text.Trim();
                    obj_HocSinh.HoTenChaHocSinh = text_hotencha.Text.Trim();
                    obj_HocSinh.HoTenMeHocSinh = text_hotenme.Text.Trim();
                    obj_HocSinh.NgheNghiepCha = text_nghenghiepcha.Text.Trim();
                    obj_HocSinh.NgheNghiepMe = text_nghenghiepme.Text.Trim();
                    obj_HocSinh.DienThoaiHocSinh = text_dienthoai.Text.Trim();
                    obj_HocSinh.GhiChuHocSinh = text_ghichu.Text.Trim();

                    HocSinhBLL _HocSinh = new HocSinhBLL();
                    _HocSinh.Insert(obj_HocSinh);
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
                    HocSinhEntities obj_HocSinh = new HocSinhEntities();
                    obj_HocSinh.MaHocSinh = text_mahocsinh.Text.Trim();
                    obj_HocSinh.MaLopHocSinh = cb_malop.Text.Trim();
                    obj_HocSinh.HoHocSinh = text_hohocsinh.Text.Trim();
                    obj_HocSinh.TenHocSinh = text_tenhocsinh.Text.Trim();
                    obj_HocSinh.GioiTinhHocSinh = cb_gioitinh.Text.Trim();
                    obj_HocSinh.NgaySinhHocSinh = date_ngaysinh.DateTime;
                    obj_HocSinh.NoiSinhHocSinh = cb_noisinh.Text.Trim();
                    obj_HocSinh.DanTocHocSinh = text_dantoc.Text.Trim();
                    obj_HocSinh.DiaChi_SoNha_HocSinh = text_sonha.Text.Trim();
                    obj_HocSinh.DiaChi_Xa_Phuong_HocSinh = cb_xa_phuong.Text.Trim();
                    obj_HocSinh.DiaChi_Quan_Huyen_HocSinh = cb_quan_huyen.Text.Trim();
                    obj_HocSinh.DiaChi_Tinh_ThanhPho_HocSinh = cb_tinh_thanhpho.Text.Trim();
                    obj_HocSinh.HoTenChaHocSinh = text_hotencha.Text.Trim();
                    obj_HocSinh.HoTenMeHocSinh = text_hotenme.Text.Trim();
                    obj_HocSinh.NgheNghiepCha = text_nghenghiepcha.Text.Trim();
                    obj_HocSinh.NgheNghiepMe = text_nghenghiepme.Text.Trim();
                    obj_HocSinh.DienThoaiHocSinh = text_dienthoai.Text.Trim();
                    obj_HocSinh.GhiChuHocSinh = text_ghichu.Text.Trim();

                    HocSinhBLL _HocSinh = new HocSinhBLL();
                    _HocSinh.Update(obj_HocSinh);
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
                    string _maHocSinh = text_mahocsinh.Text.Trim();
                    HocSinhBLL _HocSinh = new HocSinhBLL();
                    _HocSinh.Delete(_maHocSinh);
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