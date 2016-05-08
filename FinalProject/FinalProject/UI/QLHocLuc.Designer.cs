namespace FinalProject.UI
{
    partial class QLHocLuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLHocLuc));
            this.button_sua = new DevExpress.XtraEditors.SimpleButton();
            this.button_luu = new DevExpress.XtraEditors.SimpleButton();
            this.button_huy = new DevExpress.XtraEditors.SimpleButton();
            this.button_xoa = new DevExpress.XtraEditors.SimpleButton();
            this.button_them = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.data_view = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cb_mahocsinh = new System.Windows.Forms.ComboBox();
            this.cb_hocluc = new System.Windows.Forms.ComboBox();
            this.cb_hocky = new System.Windows.Forms.ComboBox();
            this.cb_namhoc = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_view)).BeginInit();
            this.SuspendLayout();
            // 
            // button_sua
            // 
            this.button_sua.Image = ((System.Drawing.Image)(resources.GetObject("button_sua.Image")));
            this.button_sua.Location = new System.Drawing.Point(939, 9);
            this.button_sua.Name = "button_sua";
            this.button_sua.Size = new System.Drawing.Size(80, 40);
            this.button_sua.TabIndex = 1;
            this.button_sua.Text = "Sửa";
            this.button_sua.Click += new System.EventHandler(this.button_sua_Click);
            // 
            // button_luu
            // 
            this.button_luu.Image = ((System.Drawing.Image)(resources.GetObject("button_luu.Image")));
            this.button_luu.Location = new System.Drawing.Point(939, 66);
            this.button_luu.Name = "button_luu";
            this.button_luu.Size = new System.Drawing.Size(80, 40);
            this.button_luu.TabIndex = 2;
            this.button_luu.Text = "Lưu";
            this.button_luu.Click += new System.EventHandler(this.button_luu_Click);
            // 
            // button_huy
            // 
            this.button_huy.Image = ((System.Drawing.Image)(resources.GetObject("button_huy.Image")));
            this.button_huy.Location = new System.Drawing.Point(835, 126);
            this.button_huy.Name = "button_huy";
            this.button_huy.Size = new System.Drawing.Size(80, 40);
            this.button_huy.TabIndex = 3;
            this.button_huy.Text = "Hủy";
            this.button_huy.Click += new System.EventHandler(this.button_huy_Click);
            // 
            // button_xoa
            // 
            this.button_xoa.Image = ((System.Drawing.Image)(resources.GetObject("button_xoa.Image")));
            this.button_xoa.Location = new System.Drawing.Point(835, 66);
            this.button_xoa.Name = "button_xoa";
            this.button_xoa.Size = new System.Drawing.Size(80, 40);
            this.button_xoa.TabIndex = 4;
            this.button_xoa.Text = "Xóa";
            this.button_xoa.Click += new System.EventHandler(this.button_xoa_Click);
            // 
            // button_them
            // 
            this.button_them.Image = ((System.Drawing.Image)(resources.GetObject("button_them.Image")));
            this.button_them.Location = new System.Drawing.Point(835, 9);
            this.button_them.Name = "button_them";
            this.button_them.Size = new System.Drawing.Size(80, 40);
            this.button_them.TabIndex = 5;
            this.button_them.Text = "Thêm";
            this.button_them.Click += new System.EventHandler(this.button_them_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 67);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(56, 13);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "Mã học sinh";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(24, 120);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(35, 13);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Học lực";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(27, 74);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(32, 13);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "Học kỳ";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(18, 36);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(41, 13);
            this.labelControl4.TabIndex = 13;
            this.labelControl4.Text = "Năm học";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cb_mahocsinh);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(0, -1);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(520, 167);
            this.groupControl1.TabIndex = 14;
            this.groupControl1.Text = "Thông Tin Học Sinh";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.cb_hocluc);
            this.groupControl2.Controls.Add(this.cb_hocky);
            this.groupControl2.Controls.Add(this.cb_namhoc);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Location = new System.Drawing.Point(558, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(230, 166);
            this.groupControl2.TabIndex = 15;
            this.groupControl2.Text = "Đánh Giá";
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
            this.data_view.Location = new System.Drawing.Point(0, 172);
            this.data_view.Name = "data_view";
            this.data_view.Size = new System.Drawing.Size(1062, 327);
            this.data_view.TabIndex = 0;
            this.data_view.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_view_RowEnter);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MAHOCSINH";
            this.Column1.HeaderText = "Mã học sinh";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "XEPLOAIHOCLUC";
            this.Column2.HeaderText = "Học lực";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "HOCKY";
            this.Column3.HeaderText = "Học kỳ";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "NAMHOC";
            this.Column4.HeaderText = "Năm học";
            this.Column4.Name = "Column4";
            // 
            // cb_mahocsinh
            // 
            this.cb_mahocsinh.FormattingEnabled = true;
            this.cb_mahocsinh.Location = new System.Drawing.Point(67, 64);
            this.cb_mahocsinh.Name = "cb_mahocsinh";
            this.cb_mahocsinh.Size = new System.Drawing.Size(121, 21);
            this.cb_mahocsinh.TabIndex = 11;
            // 
            // cb_hocluc
            // 
            this.cb_hocluc.FormattingEnabled = true;
            this.cb_hocluc.Items.AddRange(new object[] {
            "Giỏi",
            "Khá",
            "Trung bình",
            "Yếu",
            "Kém"});
            this.cb_hocluc.Location = new System.Drawing.Point(65, 112);
            this.cb_hocluc.Name = "cb_hocluc";
            this.cb_hocluc.Size = new System.Drawing.Size(121, 21);
            this.cb_hocluc.TabIndex = 13;
            // 
            // cb_hocky
            // 
            this.cb_hocky.FormattingEnabled = true;
            this.cb_hocky.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cb_hocky.Location = new System.Drawing.Point(65, 71);
            this.cb_hocky.Name = "cb_hocky";
            this.cb_hocky.Size = new System.Drawing.Size(121, 21);
            this.cb_hocky.TabIndex = 14;
            // 
            // cb_namhoc
            // 
            this.cb_namhoc.BackColor = System.Drawing.SystemColors.Window;
            this.cb_namhoc.FormattingEnabled = true;
            this.cb_namhoc.Location = new System.Drawing.Point(65, 36);
            this.cb_namhoc.Name = "cb_namhoc";
            this.cb_namhoc.Size = new System.Drawing.Size(121, 21);
            this.cb_namhoc.TabIndex = 15;
            // 
            // QLHocLuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 499);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.button_them);
            this.Controls.Add(this.button_xoa);
            this.Controls.Add(this.button_huy);
            this.Controls.Add(this.button_luu);
            this.Controls.Add(this.button_sua);
            this.Controls.Add(this.data_view);
            this.Name = "QLHocLuc";
            this.Text = "Học Lực";
            this.Load += new System.EventHandler(this.QLHocLuc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_view)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton button_sua;
        private DevExpress.XtraEditors.SimpleButton button_luu;
        private DevExpress.XtraEditors.SimpleButton button_huy;
        private DevExpress.XtraEditors.SimpleButton button_xoa;
        private DevExpress.XtraEditors.SimpleButton button_them;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.DataGridView data_view;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.ComboBox cb_mahocsinh;
        private System.Windows.Forms.ComboBox cb_hocluc;
        private System.Windows.Forms.ComboBox cb_hocky;
        private System.Windows.Forms.ComboBox cb_namhoc;
    }
}