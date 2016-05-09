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
    public partial class DoiMatKhau : DevExpress.XtraEditors.XtraForm
    {
        public DoiMatKhau()
        {
            InitializeComponent();
        }

        private void DoiMatKhau_Load(object sender, EventArgs e)
        {

        }
        private void Load_data()
        {
            DangNhapBLL _DangNhap = new DangNhapBLL();
            cb_taikhoan.DataSource = _DangNhap.getData();
            cb_taikhoan.DisplayMember = "MAGIAOVIEN";
            cb_taikhoan.ValueMember = "MAGIAOVIEN";

        }

        private void button_xacnhan_Click(object sender, EventArgs e)
        {
            string _maGiaoVien = cb_taikhoan.Text.Trim();
            string _matKhau = text_MauKhauCu.Text.Trim();
            DangNhapBLL _DangNhap = new DangNhapBLL();
            if (_DangNhap.Check_Pass(_maGiaoVien, _matKhau))
            {
                if (text_MatKhauMoi.Text == text_MatKhauMoi2.Text)
                {
                    DangNhapEntities obj_DangNhap = new DangNhapEntities();
                    obj_DangNhap.MaGiaoVien = cb_taikhoan.Text.Trim();
                    obj_DangNhap.MatKhau = text_MatKhauMoi.Text.Trim();

                    _DangNhap.Update_Pass(obj_DangNhap);
                    DevExpress.XtraEditors.XtraMessageBox.Show("Đổi mật khẩu thành công!", "Thông báo!", MessageBoxButtons.OK);
                    cb_taikhoan.Focus();
                    text_MauKhauCu.Text = "";
                    text_MatKhauMoi.Text = "";
                    text_MatKhauMoi2.Text = "";
                }
                else
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Mật khẩu không khớp!", "Thông báo!", MessageBoxButtons.OK);
                }
            }
            else
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Thông báo!", MessageBoxButtons.OK);
            }       
        }

        private void button_thoat_Click(object sender, EventArgs e)
        {
            if ( DevExpress.XtraEditors.XtraMessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }


    }
}