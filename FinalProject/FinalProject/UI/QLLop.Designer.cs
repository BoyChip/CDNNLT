namespace FinalProject.UI
{
    partial class QLLop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLLop));
            this.data_view = new System.Windows.Forms.DataGridView();
            this.button_luu = new DevExpress.XtraEditors.SimpleButton();
            this.button_sua = new DevExpress.XtraEditors.SimpleButton();
            this.button_them = new DevExpress.XtraEditors.SimpleButton();
            this.button_xoa = new DevExpress.XtraEditors.SimpleButton();
            this.button_huy = new DevExpress.XtraEditors.SimpleButton();
            this.text_siso = new DevExpress.XtraEditors.TextEdit();
            this.text_malop = new DevExpress.XtraEditors.TextEdit();
            this.text_tenlop = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cb_namhoc = new System.Windows.Forms.ComboBox();
            this.cb_hocky = new System.Windows.Forms.ComboBox();
            this.cb_makhoi = new System.Windows.Forms.ComboBox();
            this.cb_magiaovien = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.data_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_siso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_malop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_tenlop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // data_view
            // 
            this.data_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.data_view.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.data_view.Location = new System.Drawing.Point(0, 158);
            this.data_view.Name = "data_view";
            this.data_view.Size = new System.Drawing.Size(933, 274);
            this.data_view.TabIndex = 0;
            this.data_view.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_view_RowEnter);
            // 
            // button_luu
            // 
            this.button_luu.Image = ((System.Drawing.Image)(resources.GetObject("button_luu.Image")));
            this.button_luu.Location = new System.Drawing.Point(814, 65);
            this.button_luu.Name = "button_luu";
            this.button_luu.Size = new System.Drawing.Size(80, 40);
            this.button_luu.TabIndex = 1;
            this.button_luu.Text = "Lưu ";
            this.button_luu.Click += new System.EventHandler(this.button_luu_Click);
            // 
            // button_sua
            // 
            this.button_sua.Image = ((System.Drawing.Image)(resources.GetObject("button_sua.Image")));
            this.button_sua.Location = new System.Drawing.Point(814, 12);
            this.button_sua.Name = "button_sua";
            this.button_sua.Size = new System.Drawing.Size(80, 40);
            this.button_sua.TabIndex = 2;
            this.button_sua.Text = "Sửa";
            this.button_sua.Click += new System.EventHandler(this.button_sua_Click);
            // 
            // button_them
            // 
            this.button_them.Image = ((System.Drawing.Image)(resources.GetObject("button_them.Image")));
            this.button_them.Location = new System.Drawing.Point(697, 12);
            this.button_them.Name = "button_them";
            this.button_them.Size = new System.Drawing.Size(80, 40);
            this.button_them.TabIndex = 3;
            this.button_them.Text = "Thêm";
            this.button_them.Click += new System.EventHandler(this.button_them_Click);
            // 
            // button_xoa
            // 
            this.button_xoa.Image = ((System.Drawing.Image)(resources.GetObject("button_xoa.Image")));
            this.button_xoa.Location = new System.Drawing.Point(697, 65);
            this.button_xoa.Name = "button_xoa";
            this.button_xoa.Size = new System.Drawing.Size(80, 40);
            this.button_xoa.TabIndex = 4;
            this.button_xoa.Text = "Xóa";
            this.button_xoa.Click += new System.EventHandler(this.button_xoa_Click);
            // 
            // button_huy
            // 
            this.button_huy.Image = ((System.Drawing.Image)(resources.GetObject("button_huy.Image")));
            this.button_huy.Location = new System.Drawing.Point(697, 112);
            this.button_huy.Name = "button_huy";
            this.button_huy.Size = new System.Drawing.Size(80, 40);
            this.button_huy.TabIndex = 5;
            this.button_huy.Text = "Hủy";
            this.button_huy.Click += new System.EventHandler(this.button_huy_Click);
            // 
            // text_siso
            // 
            this.text_siso.Location = new System.Drawing.Point(231, 69);
            this.text_siso.Name = "text_siso";
            this.text_siso.Size = new System.Drawing.Size(100, 20);
            this.text_siso.TabIndex = 6;
            // 
            // text_malop
            // 
            this.text_malop.Location = new System.Drawing.Point(231, 28);
            this.text_malop.Name = "text_malop";
            this.text_malop.Size = new System.Drawing.Size(111, 20);
            this.text_malop.TabIndex = 7;
            // 
            // text_tenlop
            // 
            this.text_tenlop.Location = new System.Drawing.Point(71, 70);
            this.text_tenlop.Name = "text_tenlop";
            this.text_tenlop.Size = new System.Drawing.Size(100, 20);
            this.text_tenlop.TabIndex = 11;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(194, 31);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(31, 13);
            this.labelControl1.TabIndex = 13;
            this.labelControl1.Text = "Mã lớp";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(14, 35);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 13);
            this.labelControl2.TabIndex = 14;
            this.labelControl2.Text = "Mã khối";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(5, 115);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 13);
            this.labelControl3.TabIndex = 16;
            this.labelControl3.Text = "Mã giáo viên";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(15, 76);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(35, 13);
            this.labelControl4.TabIndex = 15;
            this.labelControl4.Text = "Tên lớp";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(14, 47);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(41, 13);
            this.labelControl5.TabIndex = 20;
            this.labelControl5.Text = "Năm học";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(23, 92);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(32, 13);
            this.labelControl6.TabIndex = 19;
            this.labelControl6.Text = "Học kỳ";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(203, 72);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(22, 13);
            this.labelControl7.TabIndex = 18;
            this.labelControl7.Text = "Sĩ số";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cb_hocky);
            this.groupControl1.Controls.Add(this.cb_namhoc);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(216, 152);
            this.groupControl1.TabIndex = 21;
            this.groupControl1.Text = "Năm- Học Kỳ";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.cb_magiaovien);
            this.groupControl2.Controls.Add(this.cb_makhoi);
            this.groupControl2.Controls.Add(this.labelControl7);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Controls.Add(this.text_tenlop);
            this.groupControl2.Controls.Add(this.text_malop);
            this.groupControl2.Controls.Add(this.text_siso);
            this.groupControl2.Location = new System.Drawing.Point(266, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(363, 152);
            this.groupControl2.TabIndex = 22;
            this.groupControl2.Text = "Thông Tin Lớp";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MALOP";
            this.Column1.HeaderText = "Mã lớp";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MAKHOI";
            this.Column2.HeaderText = "Mã khối";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TENLOP";
            this.Column3.HeaderText = "Tên lớp";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "MAGIAOVIEN";
            this.Column4.HeaderText = "Mã giáo viên";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "SISO";
            this.Column5.HeaderText = "Sỉ số";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "HOCKY";
            this.Column6.HeaderText = "Học kỳ";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "NAMHOC";
            this.Column7.HeaderText = "Năm học";
            this.Column7.Name = "Column7";
            // 
            // cb_namhoc
            // 
            this.cb_namhoc.FormattingEnabled = true;
            this.cb_namhoc.Location = new System.Drawing.Point(80, 39);
            this.cb_namhoc.Name = "cb_namhoc";
            this.cb_namhoc.Size = new System.Drawing.Size(121, 21);
            this.cb_namhoc.TabIndex = 21;
            // 
            // cb_hocky
            // 
            this.cb_hocky.FormattingEnabled = true;
            this.cb_hocky.Location = new System.Drawing.Point(80, 84);
            this.cb_hocky.Name = "cb_hocky";
            this.cb_hocky.Size = new System.Drawing.Size(121, 21);
            this.cb_hocky.TabIndex = 22;
            // 
            // cb_makhoi
            // 
            this.cb_makhoi.FormattingEnabled = true;
            this.cb_makhoi.Location = new System.Drawing.Point(56, 31);
            this.cb_makhoi.Name = "cb_makhoi";
            this.cb_makhoi.Size = new System.Drawing.Size(121, 21);
            this.cb_makhoi.TabIndex = 22;
            // 
            // cb_magiaovien
            // 
            this.cb_magiaovien.FormattingEnabled = true;
            this.cb_magiaovien.Location = new System.Drawing.Point(81, 107);
            this.cb_magiaovien.Name = "cb_magiaovien";
            this.cb_magiaovien.Size = new System.Drawing.Size(121, 21);
            this.cb_magiaovien.TabIndex = 23;
            // 
            // QLLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 432);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.button_huy);
            this.Controls.Add(this.button_xoa);
            this.Controls.Add(this.button_them);
            this.Controls.Add(this.button_sua);
            this.Controls.Add(this.button_luu);
            this.Controls.Add(this.data_view);
            this.Name = "QLLop";
            this.Text = "Thông Tin Lớp";
            this.Load += new System.EventHandler(this.QLLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_siso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_malop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_tenlop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView data_view;
        private DevExpress.XtraEditors.SimpleButton button_luu;
        private DevExpress.XtraEditors.SimpleButton button_sua;
        private DevExpress.XtraEditors.SimpleButton button_them;
        private DevExpress.XtraEditors.SimpleButton button_xoa;
        private DevExpress.XtraEditors.SimpleButton button_huy;
        private DevExpress.XtraEditors.TextEdit text_siso;
        private DevExpress.XtraEditors.TextEdit text_malop;
        private DevExpress.XtraEditors.TextEdit text_tenlop;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.ComboBox cb_hocky;
        private System.Windows.Forms.ComboBox cb_namhoc;
        private System.Windows.Forms.ComboBox cb_magiaovien;
        private System.Windows.Forms.ComboBox cb_makhoi;
    }
}