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
using System.Globalization;


namespace FinalProject.UI
{
    public partial class QLDiem : DevExpress.XtraEditors.XtraForm
    {
        string Query = "";

        public QLDiem()
        {
            InitializeComponent();
        }

        private void QLDiem_Load(object sender, EventArgs e)
        {
            Load_data();
            ControlButton(true);
        }

        private void Load_data()
        {
            DiemBLL _Diem = new DiemBLL();
            data_view.DataSource = _Diem.getData();

            HocSinhBLL _HocSinh = new HocSinhBLL();
            cb_mahocsinh.DataSource = _HocSinh.getData();
            cb_mahocsinh.DisplayMember = "MAHOCSINH";
            cb_mahocsinh.ValueMember = "MAHOCSINH";

            HocKyNamHocBLL _HocKy_NamHoc = new HocKyNamHocBLL();
            cb_namhoc.DataSource = _HocKy_NamHoc.getData();
            cb_namhoc.DisplayMember = "NAMHOC";
            cb_namhoc.ValueMember = "NAMHOC";

            MonHocBLL _MonHoc = new MonHocBLL();
            cb_mamon.DataSource = _MonHoc.getData();
            cb_mamon.DisplayMember = "MAMON";
            cb_mamon.ValueMember = "MAMON";
        }

        private void button_them_Click(object sender, EventArgs e)
        {
            ControlButton(false);
            Query = "add";

            cb_mahocsinh.Text = "";
            cb_mamon.Text = "";
            cb_hocky.Text = "";
            cb_namhoc.Text = "";
            text_diemso.Text = "0";
            cb_hesodiem.Text = "0";

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
                cb_mamon.Text = "";
                cb_hocky.Text = "";
                cb_namhoc.Text = "";
                text_diemso.Text = "0";
                cb_hesodiem.Text = "0";
                Load_data();
            }
        }

        private void button_luu_Click(object sender, EventArgs e)
        {
            Excute(Query);
            cb_mahocsinh.Text = "";
            cb_mamon.Text = "";
            cb_hocky.Text = "";
            cb_namhoc.Text = "";
            text_diemso.Text = "0";
            cb_hesodiem.Text = "0";
            Load_data();
            ControlButton(true);
            
        }

        private void button_huy_Click(object sender, EventArgs e)
        {
            Load_data();
            ControlButton(true);
        }

        private void data_view_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DiemBLL _Diem = new DiemBLL();
            int count = _Diem.Count_Data_Rows();
            if (count == 0)
            {

            }
            else
            {
                int index = e.RowIndex;

                cb_mahocsinh.Text = data_view["Column1", index].Value.ToString();
                cb_mamon.Text = data_view["Column2", index].Value.ToString();
                cb_hocky.Text = data_view["Column3", index].Value.ToString();
                cb_namhoc.Text = data_view["Column4", index].Value.ToString();
                text_diemso.Text = data_view["Column5", index].Value.ToString();
                cb_hesodiem.Text = data_view["Column6", index].Value.ToString();
            }

        }

        private void Excute(string strQuery)
        {
            if (strQuery == "add")
            {
                try
                {
                    DiemEntities obj_Diem = new DiemEntities();
                    obj_Diem.MaHocSinh = cb_mahocsinh.Text.Trim();
                    obj_Diem.MaMonHoc = cb_mamon.Text.Trim();
                    obj_Diem.HocKy = cb_hocky.Text.Trim();
                    obj_Diem.NamHoc = cb_namhoc.Text.Trim();
                    obj_Diem.DiemMon = float.Parse(text_diemso.Text, CultureInfo.InvariantCulture.NumberFormat);
                    obj_Diem.HeSoDiem = Convert.ToInt32(cb_hesodiem.Text);

                    string _maHocSinh = cb_mahocsinh.Text.Trim();
                    float _diemso = float.Parse(text_diemso.Text, CultureInfo.InvariantCulture.NumberFormat);
                    float _heso = Convert.ToInt32(cb_hesodiem.Text);

                    DiemBLL _Diem = new DiemBLL();

                    if (cb_hocky.Text.Length == 0 || cb_namhoc.Text.Length == 0)
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show("Chưa nhập học kỳ hoặc năm học!", "Thông báo!", MessageBoxButtons.OK);
                    }
                    else if (cb_mamon.Text.Length == 0)
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show("Chưa nhập môn học!", "Thông báo!", MessageBoxButtons.OK);
                    }
                    else if (cb_mahocsinh.Text.Length == 0)
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show("Chưa nhập mã học sinh!", "Thông báo!", MessageBoxButtons.OK);
                    }
                    else
                        if (_diemso < 0 || _diemso > 10 || _heso <= 0 || _heso > 3)
                        {
                            DevExpress.XtraEditors.XtraMessageBox.Show("Thông tin về điểm số và hệ số không phù hợp!", "Thông báo!", MessageBoxButtons.OK);
                        }
                        else

                            if ((_Diem.CheckID(_maHocSinh)))
                            {
                                _Diem.Insert(obj_Diem);
                                Load_data();
                            }
                            else
                            {
                                DevExpress.XtraEditors.XtraMessageBox.Show("Không có học sinh này!", "Thông báo!", MessageBoxButtons.OK);
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
                    DiemEntities obj_Diem = new DiemEntities();
                    obj_Diem.MaHocSinh = cb_mahocsinh.Text.Trim();
                    obj_Diem.MaMonHoc = cb_mamon.Text.Trim();
                    obj_Diem.HocKy = cb_hocky.Text.Trim();
                    obj_Diem.NamHoc = cb_namhoc.Text.Trim();
                    obj_Diem.DiemMon = Convert.ToInt32(text_diemso.Text);
                    obj_Diem.HeSoDiem = Convert.ToInt32(cb_hesodiem.Text);

                    DiemBLL _Diem = new DiemBLL();
                    _Diem.Update(obj_Diem);
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
                    DiemBLL _Diem = new DiemBLL();
                    _Diem.Delete(_maHocSinh);
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
            button_luu.Enabled = button_huy.Enabled = group_thongtin.Enabled = group_themdiem.Enabled= !type;
        }
    }
}