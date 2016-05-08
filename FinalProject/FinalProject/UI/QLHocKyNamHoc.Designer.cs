namespace FinalProject.UI
{
    partial class QLHocKyNamHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLHocKyNamHoc));
            this.button_them = new DevExpress.XtraEditors.SimpleButton();
            this.button_sua = new DevExpress.XtraEditors.SimpleButton();
            this.button_luu = new DevExpress.XtraEditors.SimpleButton();
            this.button_huy = new DevExpress.XtraEditors.SimpleButton();
            this.grid_hockynamhoc = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_namhoc = new System.Windows.Forms.ComboBox();
            this.cb_hocky = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid_hockynamhoc)).BeginInit();
            this.SuspendLayout();
            // 
            // button_them
            // 
            this.button_them.Image = ((System.Drawing.Image)(resources.GetObject("button_them.Image")));
            this.button_them.Location = new System.Drawing.Point(413, 25);
            this.button_them.Name = "button_them";
            this.button_them.Size = new System.Drawing.Size(80, 40);
            this.button_them.TabIndex = 2;
            this.button_them.Text = "Thêm";
            this.button_them.Click += new System.EventHandler(this.button_them_Click);
            // 
            // button_sua
            // 
            this.button_sua.Image = ((System.Drawing.Image)(resources.GetObject("button_sua.Image")));
            this.button_sua.Location = new System.Drawing.Point(522, 25);
            this.button_sua.Name = "button_sua";
            this.button_sua.Size = new System.Drawing.Size(80, 40);
            this.button_sua.TabIndex = 3;
            this.button_sua.Text = "Sửa";
            this.button_sua.Click += new System.EventHandler(this.button_sua_Click);
            // 
            // button_luu
            // 
            this.button_luu.Image = ((System.Drawing.Image)(resources.GetObject("button_luu.Image")));
            this.button_luu.Location = new System.Drawing.Point(413, 92);
            this.button_luu.Name = "button_luu";
            this.button_luu.Size = new System.Drawing.Size(80, 40);
            this.button_luu.TabIndex = 5;
            this.button_luu.Text = "Lưu";
            this.button_luu.Click += new System.EventHandler(this.button_luu_Click);
            // 
            // button_huy
            // 
            this.button_huy.Image = ((System.Drawing.Image)(resources.GetObject("button_huy.Image")));
            this.button_huy.Location = new System.Drawing.Point(636, 25);
            this.button_huy.Name = "button_huy";
            this.button_huy.Size = new System.Drawing.Size(80, 40);
            this.button_huy.TabIndex = 6;
            this.button_huy.Text = "Hủy";
            this.button_huy.Click += new System.EventHandler(this.button_huy_Click);
            // 
            // grid_hockynamhoc
            // 
            this.grid_hockynamhoc.AllowUserToAddRows = false;
            this.grid_hockynamhoc.AllowUserToDeleteRows = false;
            this.grid_hockynamhoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_hockynamhoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.grid_hockynamhoc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grid_hockynamhoc.Location = new System.Drawing.Point(0, 162);
            this.grid_hockynamhoc.Name = "grid_hockynamhoc";
            this.grid_hockynamhoc.ReadOnly = true;
            this.grid_hockynamhoc.Size = new System.Drawing.Size(802, 335);
            this.grid_hockynamhoc.TabIndex = 7;
            this.grid_hockynamhoc.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_hockynamhoc_RowEnter);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "HOCKY";
            this.Column1.HeaderText = "Học Kỳ";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "NAMHOC";
            this.Column2.HeaderText = "Năm Học";
            this.Column2.Name = "Column2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Học Kỳ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Năm Học";
            // 
            // cb_namhoc
            // 
            this.cb_namhoc.FormattingEnabled = true;
            this.cb_namhoc.Items.AddRange(new object[] {
            "2015-2016",
            "2016-2017",
            "2017-2018",
            "2018-2019",
            "2019-2020",
            "2020-2021",
            "2021-2022",
            "2022-2023"});
            this.cb_namhoc.Location = new System.Drawing.Point(115, 24);
            this.cb_namhoc.Name = "cb_namhoc";
            this.cb_namhoc.Size = new System.Drawing.Size(121, 21);
            this.cb_namhoc.TabIndex = 11;
            // 
            // cb_hocky
            // 
            this.cb_hocky.FormattingEnabled = true;
            this.cb_hocky.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cb_hocky.Location = new System.Drawing.Point(115, 82);
            this.cb_hocky.Name = "cb_hocky";
            this.cb_hocky.Size = new System.Drawing.Size(121, 21);
            this.cb_hocky.TabIndex = 12;
            // 
            // QLHocKyNamHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 497);
            this.Controls.Add(this.cb_hocky);
            this.Controls.Add(this.cb_namhoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grid_hockynamhoc);
            this.Controls.Add(this.button_huy);
            this.Controls.Add(this.button_luu);
            this.Controls.Add(this.button_sua);
            this.Controls.Add(this.button_them);
            this.Name = "QLHocKyNamHoc";
            this.Text = "Học Kỳ - Năm Học";
            this.Load += new System.EventHandler(this.QLHocKyNamHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_hockynamhoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton button_them;
        private DevExpress.XtraEditors.SimpleButton button_sua;
        private DevExpress.XtraEditors.SimpleButton button_luu;
        private DevExpress.XtraEditors.SimpleButton button_huy;
        private System.Windows.Forms.DataGridView grid_hockynamhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_namhoc;
        private System.Windows.Forms.ComboBox cb_hocky;
    }
}