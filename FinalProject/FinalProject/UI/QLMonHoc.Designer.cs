namespace FinalProject.UI
{
    partial class QLMonHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLMonHoc));
            this.data_view = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.text_mamon = new DevExpress.XtraEditors.TextEdit();
            this.text_tenmon = new DevExpress.XtraEditors.TextEdit();
            this.text_sotiet = new DevExpress.XtraEditors.TextEdit();
            this.text_hesomon = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.group_thongtin = new DevExpress.XtraEditors.GroupControl();
            this.button_xoa = new DevExpress.XtraEditors.SimpleButton();
            this.button_luu = new DevExpress.XtraEditors.SimpleButton();
            this.button_them = new DevExpress.XtraEditors.SimpleButton();
            this.button_huy = new DevExpress.XtraEditors.SimpleButton();
            this.button_sua = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.data_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_mamon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_tenmon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_sotiet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_hesomon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.group_thongtin)).BeginInit();
            this.group_thongtin.SuspendLayout();
            this.SuspendLayout();
            // 
            // data_view
            // 
            this.data_view.AllowUserToAddRows = false;
            this.data_view.AllowUserToDeleteRows = false;
            this.data_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.data_view.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.data_view.Location = new System.Drawing.Point(0, 150);
            this.data_view.Name = "data_view";
            this.data_view.Size = new System.Drawing.Size(698, 229);
            this.data_view.TabIndex = 0;
            this.data_view.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_view_RowEnter);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MAMON";
            this.Column1.HeaderText = "Mã môn";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TENMON";
            this.Column2.HeaderText = "Tên môn";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SOTIET";
            this.Column3.HeaderText = "Số tiết";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "HESO";
            this.Column4.HeaderText = "Hệ số môn";
            this.Column4.Name = "Column4";
            // 
            // text_mamon
            // 
            this.text_mamon.Location = new System.Drawing.Point(82, 31);
            this.text_mamon.Name = "text_mamon";
            this.text_mamon.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_mamon.Properties.Appearance.Options.UseFont = true;
            this.text_mamon.Size = new System.Drawing.Size(203, 22);
            this.text_mamon.TabIndex = 6;
            // 
            // text_tenmon
            // 
            this.text_tenmon.Location = new System.Drawing.Point(82, 57);
            this.text_tenmon.Name = "text_tenmon";
            this.text_tenmon.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_tenmon.Properties.Appearance.Options.UseFont = true;
            this.text_tenmon.Size = new System.Drawing.Size(203, 22);
            this.text_tenmon.TabIndex = 7;
            // 
            // text_sotiet
            // 
            this.text_sotiet.Location = new System.Drawing.Point(82, 86);
            this.text_sotiet.Name = "text_sotiet";
            this.text_sotiet.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sotiet.Properties.Appearance.Options.UseFont = true;
            this.text_sotiet.Size = new System.Drawing.Size(203, 22);
            this.text_sotiet.TabIndex = 8;
            // 
            // text_hesomon
            // 
            this.text_hesomon.Location = new System.Drawing.Point(82, 114);
            this.text_hesomon.Name = "text_hesomon";
            this.text_hesomon.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_hesomon.Properties.Appearance.Options.UseFont = true;
            this.text_hesomon.Size = new System.Drawing.Size(203, 22);
            this.text_hesomon.TabIndex = 9;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(23, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(46, 16);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "Mã môn";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(18, 60);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(51, 16);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Tên môn";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(32, 89);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(37, 16);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "Số tiết";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(8, 117);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(61, 16);
            this.labelControl4.TabIndex = 13;
            this.labelControl4.Text = "Hệ số môn";
            // 
            // group_thongtin
            // 
            this.group_thongtin.Controls.Add(this.labelControl4);
            this.group_thongtin.Controls.Add(this.labelControl3);
            this.group_thongtin.Controls.Add(this.labelControl2);
            this.group_thongtin.Controls.Add(this.labelControl1);
            this.group_thongtin.Controls.Add(this.text_hesomon);
            this.group_thongtin.Controls.Add(this.text_sotiet);
            this.group_thongtin.Controls.Add(this.text_tenmon);
            this.group_thongtin.Controls.Add(this.text_mamon);
            this.group_thongtin.Location = new System.Drawing.Point(0, 4);
            this.group_thongtin.Name = "group_thongtin";
            this.group_thongtin.Size = new System.Drawing.Size(301, 140);
            this.group_thongtin.TabIndex = 14;
            this.group_thongtin.Text = "Thông Tin Môn Học";
            // 
            // button_xoa
            // 
            this.button_xoa.Image = ((System.Drawing.Image)(resources.GetObject("button_xoa.Image")));
            this.button_xoa.Location = new System.Drawing.Point(387, 74);
            this.button_xoa.Name = "button_xoa";
            this.button_xoa.Size = new System.Drawing.Size(80, 40);
            this.button_xoa.TabIndex = 5;
            this.button_xoa.Text = "Xóa";
            this.button_xoa.Click += new System.EventHandler(this.button_xoa_Click);
            // 
            // button_luu
            // 
            this.button_luu.Image = ((System.Drawing.Image)(resources.GetObject("button_luu.Image")));
            this.button_luu.Location = new System.Drawing.Point(496, 74);
            this.button_luu.Name = "button_luu";
            this.button_luu.Size = new System.Drawing.Size(80, 40);
            this.button_luu.TabIndex = 4;
            this.button_luu.Text = "Lưu";
            this.button_luu.Click += new System.EventHandler(this.button_luu_Click);
            // 
            // button_them
            // 
            this.button_them.Image = ((System.Drawing.Image)(resources.GetObject("button_them.Image")));
            this.button_them.Location = new System.Drawing.Point(387, 18);
            this.button_them.Name = "button_them";
            this.button_them.Size = new System.Drawing.Size(80, 40);
            this.button_them.TabIndex = 3;
            this.button_them.Text = "Thêm";
            this.button_them.Click += new System.EventHandler(this.button_them_Click);
            // 
            // button_huy
            // 
            this.button_huy.Image = ((System.Drawing.Image)(resources.GetObject("button_huy.Image")));
            this.button_huy.Location = new System.Drawing.Point(605, 17);
            this.button_huy.Name = "button_huy";
            this.button_huy.Size = new System.Drawing.Size(80, 40);
            this.button_huy.TabIndex = 2;
            this.button_huy.Text = "Hủy";
            this.button_huy.Click += new System.EventHandler(this.button_huy_Click);
            // 
            // button_sua
            // 
            this.button_sua.Image = ((System.Drawing.Image)(resources.GetObject("button_sua.Image")));
            this.button_sua.Location = new System.Drawing.Point(496, 18);
            this.button_sua.Name = "button_sua";
            this.button_sua.Size = new System.Drawing.Size(80, 40);
            this.button_sua.TabIndex = 1;
            this.button_sua.Text = "Sửa";
            this.button_sua.Click += new System.EventHandler(this.button_sua_Click);
            // 
            // QLMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 379);
            this.Controls.Add(this.group_thongtin);
            this.Controls.Add(this.button_xoa);
            this.Controls.Add(this.button_luu);
            this.Controls.Add(this.button_them);
            this.Controls.Add(this.button_huy);
            this.Controls.Add(this.button_sua);
            this.Controls.Add(this.data_view);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QLMonHoc";
            this.Text = "Môn Học";
            this.Load += new System.EventHandler(this.QLMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_mamon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_tenmon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_sotiet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_hesomon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.group_thongtin)).EndInit();
            this.group_thongtin.ResumeLayout(false);
            this.group_thongtin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView data_view;
        private DevExpress.XtraEditors.SimpleButton button_sua;
        private DevExpress.XtraEditors.SimpleButton button_huy;
        private DevExpress.XtraEditors.SimpleButton button_them;
        private DevExpress.XtraEditors.SimpleButton button_luu;
        private DevExpress.XtraEditors.SimpleButton button_xoa;
        private DevExpress.XtraEditors.TextEdit text_mamon;
        private DevExpress.XtraEditors.TextEdit text_tenmon;
        private DevExpress.XtraEditors.TextEdit text_sotiet;
        private DevExpress.XtraEditors.TextEdit text_hesomon;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.GroupControl group_thongtin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}