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
using System.Threading;


namespace FinalProject.UI
{
    public partial class DangNhap : DevExpress.XtraEditors.XtraForm
    {
        Thread thr;

        public DangNhap()
        {
            InitializeComponent();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            this.text_taikhoan.Text = "admin";
            this.text_matkhau.Text = "admin";
        }

        private void button_dangnhap_Click(object sender, EventArgs e)
        {
            DangNhapEntities obj_DangNhap = new DangNhapEntities();
            DangNhapBLL _DangNhap = new DangNhapBLL();
            string _taiKhoan = text_taikhoan.Text.Trim();
            string _matkhau = text_matkhau.Text.Trim();

            if (this.text_taikhoan.Text.Length == 0 || this.text_matkhau.Text.Length == 0)
            {
                this.label_thongbao_dangnhap.ForeColor = Color.Red;
                this.label_thongbao_dangnhap.Text = "Bạn chưa nhập tài khoản hoặc mật khẩu!";
            }
            else if ((_DangNhap.Check_DangNhap(_taiKhoan, _matkhau)))
            {
                this.Close();
                thr = new Thread(Load_GiaoDienChinh);
                thr.SetApartmentState(ApartmentState.STA);
                thr.Start();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu sai!", "Thông báo!", MessageBoxButtons.OK);
                this.text_taikhoan.Text = "";
                this.text_matkhau.Text = "";
                this.text_taikhoan.Focus();
            }
        }
        private void Load_GiaoDienChinh(object obj)
        {
            Application.Run(new GiaoDienChinh());
        }

        private void button_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
        }
    }
}