namespace FinalProject.UI
{
    partial class QLPhanLop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLPhanLop));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.data_view = new System.Windows.Forms.DataGridView();
            this.button_chuyenlop = new DevExpress.XtraEditors.SimpleButton();
            this.cb_khoilop = new System.Windows.Forms.ComboBox();
            this.cb_lop = new System.Windows.Forms.ComboBox();
            this.cb_mahocsinh = new System.Windows.Forms.ComboBox();
            this.cb_khoilop_chuyen = new System.Windows.Forms.ComboBox();
            this.cb_lop_chuyen = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_view)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cb_mahocsinh);
            this.groupControl1.Controls.Add(this.cb_lop);
            this.groupControl1.Controls.Add(this.cb_khoilop);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(1, 1);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(392, 194);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông Tin Học Sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã học sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lớp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Khối";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.cb_lop_chuyen);
            this.groupControl2.Controls.Add(this.cb_khoilop_chuyen);
            this.groupControl2.Controls.Add(this.label7);
            this.groupControl2.Controls.Add(this.label6);
            this.groupControl2.Location = new System.Drawing.Point(1, 201);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(391, 78);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Thông Tin Lớp Chuyển đến";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(235, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Lớp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Khối";
            // 
            // data_view
            // 
            this.data_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_view.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.data_view.Location = new System.Drawing.Point(0, 319);
            this.data_view.Name = "data_view";
            this.data_view.Size = new System.Drawing.Size(771, 152);
            this.data_view.TabIndex = 2;
            // 
            // button_chuyenlop
            // 
            this.button_chuyenlop.Image = ((System.Drawing.Image)(resources.GetObject("button_chuyenlop.Image")));
            this.button_chuyenlop.Location = new System.Drawing.Point(431, 12);
            this.button_chuyenlop.Name = "button_chuyenlop";
            this.button_chuyenlop.Size = new System.Drawing.Size(104, 40);
            this.button_chuyenlop.TabIndex = 8;
            this.button_chuyenlop.Text = "Chuyển Lớp";
            this.button_chuyenlop.Click += new System.EventHandler(this.button_chuyenlop_Click);
            // 
            // cb_khoilop
            // 
            this.cb_khoilop.FormattingEnabled = true;
            this.cb_khoilop.Location = new System.Drawing.Point(75, 36);
            this.cb_khoilop.Name = "cb_khoilop";
            this.cb_khoilop.Size = new System.Drawing.Size(121, 21);
            this.cb_khoilop.TabIndex = 9;
            // 
            // cb_lop
            // 
            this.cb_lop.FormattingEnabled = true;
            this.cb_lop.Location = new System.Drawing.Point(248, 36);
            this.cb_lop.Name = "cb_lop";
            this.cb_lop.Size = new System.Drawing.Size(121, 21);
            this.cb_lop.TabIndex = 10;
            // 
            // cb_mahocsinh
            // 
            this.cb_mahocsinh.FormattingEnabled = true;
            this.cb_mahocsinh.Location = new System.Drawing.Point(73, 77);
            this.cb_mahocsinh.Name = "cb_mahocsinh";
            this.cb_mahocsinh.Size = new System.Drawing.Size(121, 21);
            this.cb_mahocsinh.TabIndex = 11;
            // 
            // cb_khoilop_chuyen
            // 
            this.cb_khoilop_chuyen.FormattingEnabled = true;
            this.cb_khoilop_chuyen.Location = new System.Drawing.Point(73, 38);
            this.cb_khoilop_chuyen.Name = "cb_khoilop_chuyen";
            this.cb_khoilop_chuyen.Size = new System.Drawing.Size(121, 21);
            this.cb_khoilop_chuyen.TabIndex = 10;
            // 
            // cb_lop_chuyen
            // 
            this.cb_lop_chuyen.FormattingEnabled = true;
            this.cb_lop_chuyen.Location = new System.Drawing.Point(265, 38);
            this.cb_lop_chuyen.Name = "cb_lop_chuyen";
            this.cb_lop_chuyen.Size = new System.Drawing.Size(121, 21);
            this.cb_lop_chuyen.TabIndex = 11;
            // 
            // QLPhanLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 471);
            this.Controls.Add(this.button_chuyenlop);
            this.Controls.Add(this.data_view);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QLPhanLop";
            this.Text = "Phân Lớp";
            this.Load += new System.EventHandler(this.QLPhanLop_Load);
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

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView data_view;
        private DevExpress.XtraEditors.SimpleButton button_chuyenlop;
        private System.Windows.Forms.ComboBox cb_mahocsinh;
        private System.Windows.Forms.ComboBox cb_lop;
        private System.Windows.Forms.ComboBox cb_khoilop;
        private System.Windows.Forms.ComboBox cb_lop_chuyen;
        private System.Windows.Forms.ComboBox cb_khoilop_chuyen;
    }
}