namespace FinalProject.UI
{
    partial class DangNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.text_taikhoan = new DevExpress.XtraEditors.TextEdit();
            this.button_dangnhap = new DevExpress.XtraEditors.SimpleButton();
            this.button_thoat = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.text_matkhau = new System.Windows.Forms.TextBox();
            this.label_thongbao_dangnhap = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.text_taikhoan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // text_taikhoan
            // 
            this.text_taikhoan.Location = new System.Drawing.Point(135, 32);
            this.text_taikhoan.Name = "text_taikhoan";
            this.text_taikhoan.Size = new System.Drawing.Size(193, 20);
            this.text_taikhoan.TabIndex = 0;
            // 
            // button_dangnhap
            // 
            this.button_dangnhap.Location = new System.Drawing.Point(86, 134);
            this.button_dangnhap.Name = "button_dangnhap";
            this.button_dangnhap.Size = new System.Drawing.Size(80, 40);
            this.button_dangnhap.TabIndex = 2;
            this.button_dangnhap.Text = "Đăng Nhập";
            this.button_dangnhap.Click += new System.EventHandler(this.button_dangnhap_Click);
            // 
            // button_thoat
            // 
            this.button_thoat.Location = new System.Drawing.Point(212, 134);
            this.button_thoat.Name = "button_thoat";
            this.button_thoat.Size = new System.Drawing.Size(80, 40);
            this.button_thoat.TabIndex = 3;
            this.button_thoat.Text = "Thoát";
            this.button_thoat.Click += new System.EventHandler(this.button_thoat_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(30, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(47, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Tài Khoản";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(32, 78);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(45, 13);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Mật Khẩu";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.text_matkhau);
            this.groupControl1.Controls.Add(this.button_thoat);
            this.groupControl1.Controls.Add(this.label_thongbao_dangnhap);
            this.groupControl1.Controls.Add(this.button_dangnhap);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.text_taikhoan);
            this.groupControl1.Location = new System.Drawing.Point(12, 106);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(390, 194);
            this.groupControl1.TabIndex = 7;
            this.groupControl1.Text = "Thông Tin Đăng Nhập";
            // 
            // text_matkhau
            // 
            this.text_matkhau.Location = new System.Drawing.Point(135, 78);
            this.text_matkhau.Name = "text_matkhau";
            this.text_matkhau.PasswordChar = '*';
            this.text_matkhau.Size = new System.Drawing.Size(193, 21);
            this.text_matkhau.TabIndex = 8;
            // 
            // label_thongbao_dangnhap
            // 
            this.label_thongbao_dangnhap.Location = new System.Drawing.Point(32, 117);
            this.label_thongbao_dangnhap.Name = "label_thongbao_dangnhap";
            this.label_thongbao_dangnhap.Size = new System.Drawing.Size(0, 13);
            this.label_thongbao_dangnhap.TabIndex = 7;
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 411);
            this.Controls.Add(this.groupControl1);
            this.Name = "DangNhap";
            this.Text = "ĐĂNG NHẬP";
            this.Load += new System.EventHandler(this.DangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.text_taikhoan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit text_taikhoan;
        private DevExpress.XtraEditors.SimpleButton button_dangnhap;
        private DevExpress.XtraEditors.SimpleButton button_thoat;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl label_thongbao_dangnhap;
        private System.Windows.Forms.TextBox text_matkhau;
    }
}