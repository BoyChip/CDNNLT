namespace FinalProject.UI
{
    partial class QLPhanCongGiaoVien
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
            this.data_view = new System.Windows.Forms.DataGridView();
            this.button_them = new DevExpress.XtraEditors.SimpleButton();
            this.button_sua = new DevExpress.XtraEditors.SimpleButton();
            this.button_luu = new DevExpress.XtraEditors.SimpleButton();
            this.button_xoa = new DevExpress.XtraEditors.SimpleButton();
            this.button_huy = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cb_magiaovien = new System.Windows.Forms.ComboBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cb_namhoc = new System.Windows.Forms.ComboBox();
            this.cb_hocky = new System.Windows.Forms.ComboBox();
            this.cb_malop = new System.Windows.Forms.ComboBox();
            this.cb_mamon = new System.Windows.Forms.ComboBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.data_view)).BeginInit();
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
            this.Column5});
            this.data_view.Location = new System.Drawing.Point(214, 200);
            this.data_view.Name = "data_view";
            this.data_view.Size = new System.Drawing.Size(310, 150);
            this.data_view.TabIndex = 0;
            this.data_view.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_view_RowEnter);
            // 
            // button_them
            // 
            this.button_them.Location = new System.Drawing.Point(284, 12);
            this.button_them.Name = "button_them";
            this.button_them.Size = new System.Drawing.Size(75, 23);
            this.button_them.TabIndex = 1;
            this.button_them.Text = "Them";
            this.button_them.Click += new System.EventHandler(this.button_them_Click);
            // 
            // button_sua
            // 
            this.button_sua.Location = new System.Drawing.Point(398, 12);
            this.button_sua.Name = "button_sua";
            this.button_sua.Size = new System.Drawing.Size(75, 23);
            this.button_sua.TabIndex = 2;
            this.button_sua.Text = "Sua";
            this.button_sua.Click += new System.EventHandler(this.button_sua_Click);
            // 
            // button_luu
            // 
            this.button_luu.Location = new System.Drawing.Point(427, 109);
            this.button_luu.Name = "button_luu";
            this.button_luu.Size = new System.Drawing.Size(75, 23);
            this.button_luu.TabIndex = 3;
            this.button_luu.Text = "Luu";
            this.button_luu.Click += new System.EventHandler(this.button_luu_Click);
            // 
            // button_xoa
            // 
            this.button_xoa.Location = new System.Drawing.Point(413, 59);
            this.button_xoa.Name = "button_xoa";
            this.button_xoa.Size = new System.Drawing.Size(75, 23);
            this.button_xoa.TabIndex = 4;
            this.button_xoa.Text = "Xoa";
            this.button_xoa.Click += new System.EventHandler(this.button_xoa_Click);
            // 
            // button_huy
            // 
            this.button_huy.Location = new System.Drawing.Point(398, 155);
            this.button_huy.Name = "button_huy";
            this.button_huy.Size = new System.Drawing.Size(75, 23);
            this.button_huy.TabIndex = 5;
            this.button_huy.Text = "Huy";
            this.button_huy.Click += new System.EventHandler(this.button_huy_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 22);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 13);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Ma giao vien";
            // 
            // cb_magiaovien
            // 
            this.cb_magiaovien.FormattingEnabled = true;
            this.cb_magiaovien.Location = new System.Drawing.Point(87, 22);
            this.cb_magiaovien.Name = "cb_magiaovien";
            this.cb_magiaovien.Size = new System.Drawing.Size(121, 21);
            this.cb_magiaovien.TabIndex = 7;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 64);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(37, 13);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Ma mon";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(9, 102);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(31, 13);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "Ma lop";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(9, 200);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(41, 13);
            this.labelControl5.TabIndex = 11;
            this.labelControl5.Text = "Nam hoc";
            // 
            // cb_namhoc
            // 
            this.cb_namhoc.FormattingEnabled = true;
            this.cb_namhoc.Location = new System.Drawing.Point(87, 188);
            this.cb_namhoc.Name = "cb_namhoc";
            this.cb_namhoc.Size = new System.Drawing.Size(121, 21);
            this.cb_namhoc.TabIndex = 13;
            // 
            // cb_hocky
            // 
            this.cb_hocky.FormattingEnabled = true;
            this.cb_hocky.Location = new System.Drawing.Point(87, 137);
            this.cb_hocky.Name = "cb_hocky";
            this.cb_hocky.Size = new System.Drawing.Size(121, 21);
            this.cb_hocky.TabIndex = 14;
            // 
            // cb_malop
            // 
            this.cb_malop.FormattingEnabled = true;
            this.cb_malop.Location = new System.Drawing.Point(87, 99);
            this.cb_malop.Name = "cb_malop";
            this.cb_malop.Size = new System.Drawing.Size(121, 21);
            this.cb_malop.TabIndex = 15;
            // 
            // cb_mamon
            // 
            this.cb_mamon.FormattingEnabled = true;
            this.cb_mamon.Location = new System.Drawing.Point(87, 61);
            this.cb_mamon.Name = "cb_mamon";
            this.cb_mamon.Size = new System.Drawing.Size(121, 21);
            this.cb_mamon.TabIndex = 16;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(9, 145);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(32, 13);
            this.labelControl4.TabIndex = 17;
            this.labelControl4.Text = "Hoc ky";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MAGIAOVIEN";
            this.Column1.HeaderText = "Mã giáo viên";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MAMON";
            this.Column2.HeaderText = "Mã môn";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MALOP";
            this.Column3.HeaderText = "Mã lớp";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "HOCKY";
            this.Column4.HeaderText = "Học kỳ";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "NAMHOC";
            this.Column5.HeaderText = "Năm học";
            this.Column5.Name = "Column5";
            // 
            // QLPhanCongGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 362);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.cb_mamon);
            this.Controls.Add(this.cb_malop);
            this.Controls.Add(this.cb_hocky);
            this.Controls.Add(this.cb_namhoc);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.cb_magiaovien);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.button_huy);
            this.Controls.Add(this.button_xoa);
            this.Controls.Add(this.button_luu);
            this.Controls.Add(this.button_sua);
            this.Controls.Add(this.button_them);
            this.Controls.Add(this.data_view);
            this.Name = "QLPhanCongGiaoVien";
            this.Text = "Phân Công Giáo Viên";
            this.Load += new System.EventHandler(this.QLPhanCongGiaoVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_view;
        private DevExpress.XtraEditors.SimpleButton button_them;
        private DevExpress.XtraEditors.SimpleButton button_sua;
        private DevExpress.XtraEditors.SimpleButton button_luu;
        private DevExpress.XtraEditors.SimpleButton button_xoa;
        private DevExpress.XtraEditors.SimpleButton button_huy;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ComboBox cb_magiaovien;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.ComboBox cb_namhoc;
        private System.Windows.Forms.ComboBox cb_hocky;
        private System.Windows.Forms.ComboBox cb_malop;
        private System.Windows.Forms.ComboBox cb_mamon;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}