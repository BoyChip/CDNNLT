namespace FinalProject.UI
{
    partial class DoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoiMatKhau));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.text_MauKhauCu = new DevExpress.XtraEditors.TextEdit();
            this.text_MatKhauMoi = new DevExpress.XtraEditors.TextEdit();
            this.text_MatKhauMoi2 = new DevExpress.XtraEditors.TextEdit();
            this.button_thoat = new DevExpress.XtraEditors.SimpleButton();
            this.button_xacnhan = new DevExpress.XtraEditors.SimpleButton();
            this.cb_taikhoan = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.text_MauKhauCu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_MatKhauMoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_MatKhauMoi2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài Khoản";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật Khẩu Cũ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật Khẩu Mới";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhập Lại Mật Khẩu Mới";
            // 
            // text_MauKhauCu
            // 
            this.text_MauKhauCu.Location = new System.Drawing.Point(133, 68);
            this.text_MauKhauCu.Name = "text_MauKhauCu";
            this.text_MauKhauCu.Size = new System.Drawing.Size(165, 20);
            this.text_MauKhauCu.TabIndex = 5;
            // 
            // text_MatKhauMoi
            // 
            this.text_MatKhauMoi.Location = new System.Drawing.Point(133, 101);
            this.text_MatKhauMoi.Name = "text_MatKhauMoi";
            this.text_MatKhauMoi.Size = new System.Drawing.Size(165, 20);
            this.text_MatKhauMoi.TabIndex = 6;
            // 
            // text_MatKhauMoi2
            // 
            this.text_MatKhauMoi2.Location = new System.Drawing.Point(133, 134);
            this.text_MatKhauMoi2.Name = "text_MatKhauMoi2";
            this.text_MatKhauMoi2.Size = new System.Drawing.Size(165, 20);
            this.text_MatKhauMoi2.TabIndex = 7;
            // 
            // button_thoat
            // 
            this.button_thoat.Image = ((System.Drawing.Image)(resources.GetObject("button_thoat.Image")));
            this.button_thoat.Location = new System.Drawing.Point(211, 188);
            this.button_thoat.Name = "button_thoat";
            this.button_thoat.Size = new System.Drawing.Size(117, 40);
            this.button_thoat.TabIndex = 9;
            this.button_thoat.Text = "Thoát";
            this.button_thoat.Click += new System.EventHandler(this.button_thoat_Click);
            // 
            // button_xacnhan
            // 
            this.button_xacnhan.Image = ((System.Drawing.Image)(resources.GetObject("button_xacnhan.Image")));
            this.button_xacnhan.Location = new System.Drawing.Point(59, 188);
            this.button_xacnhan.Name = "button_xacnhan";
            this.button_xacnhan.Size = new System.Drawing.Size(113, 40);
            this.button_xacnhan.TabIndex = 8;
            this.button_xacnhan.Text = "Xác Nhận";
            this.button_xacnhan.Click += new System.EventHandler(this.button_xacnhan_Click);
            // 
            // cb_taikhoan
            // 
            this.cb_taikhoan.FormattingEnabled = true;
            this.cb_taikhoan.Location = new System.Drawing.Point(133, 35);
            this.cb_taikhoan.Name = "cb_taikhoan";
            this.cb_taikhoan.Size = new System.Drawing.Size(164, 21);
            this.cb_taikhoan.TabIndex = 10;
            // 
            // DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 261);
            this.Controls.Add(this.cb_taikhoan);
            this.Controls.Add(this.button_thoat);
            this.Controls.Add(this.button_xacnhan);
            this.Controls.Add(this.text_MatKhauMoi2);
            this.Controls.Add(this.text_MatKhauMoi);
            this.Controls.Add(this.text_MauKhauCu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DoiMatKhau";
            this.Text = "ĐỔI MẬT KHẨU";
            this.Load += new System.EventHandler(this.DoiMatKhau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.text_MauKhauCu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_MatKhauMoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_MatKhauMoi2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit text_MauKhauCu;
        private DevExpress.XtraEditors.TextEdit text_MatKhauMoi;
        private DevExpress.XtraEditors.TextEdit text_MatKhauMoi2;
        private DevExpress.XtraEditors.SimpleButton button_xacnhan;
        private DevExpress.XtraEditors.SimpleButton button_thoat;
        private System.Windows.Forms.ComboBox cb_taikhoan;
    }
}