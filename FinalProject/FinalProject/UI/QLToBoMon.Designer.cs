namespace FinalProject.UI
{
    partial class QLToBoMon
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
            this.button_luu = new DevExpress.XtraEditors.SimpleButton();
            this.button_huy = new DevExpress.XtraEditors.SimpleButton();
            this.button_xoa = new DevExpress.XtraEditors.SimpleButton();
            this.button_them = new DevExpress.XtraEditors.SimpleButton();
            this.button_sua = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.text_matobomon = new DevExpress.XtraEditors.TextEdit();
            this.text_tentobomon = new DevExpress.XtraEditors.TextEdit();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.data_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_matobomon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_tentobomon.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // data_view
            // 
            this.data_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.data_view.Location = new System.Drawing.Point(131, 92);
            this.data_view.Name = "data_view";
            this.data_view.Size = new System.Drawing.Size(240, 150);
            this.data_view.TabIndex = 0;
            this.data_view.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_view_RowEnter);
            // 
            // button_luu
            // 
            this.button_luu.Location = new System.Drawing.Point(513, 32);
            this.button_luu.Name = "button_luu";
            this.button_luu.Size = new System.Drawing.Size(75, 23);
            this.button_luu.TabIndex = 1;
            this.button_luu.Text = "Luu";
            this.button_luu.Click += new System.EventHandler(this.button_luu_Click);
            // 
            // button_huy
            // 
            this.button_huy.Location = new System.Drawing.Point(594, 32);
            this.button_huy.Name = "button_huy";
            this.button_huy.Size = new System.Drawing.Size(75, 23);
            this.button_huy.TabIndex = 2;
            this.button_huy.Text = "Huy";
            this.button_huy.Click += new System.EventHandler(this.button_huy_Click);
            // 
            // button_xoa
            // 
            this.button_xoa.Location = new System.Drawing.Point(432, 32);
            this.button_xoa.Name = "button_xoa";
            this.button_xoa.Size = new System.Drawing.Size(75, 23);
            this.button_xoa.TabIndex = 3;
            this.button_xoa.Text = "Xoa";
            this.button_xoa.Click += new System.EventHandler(this.button_xoa_Click);
            // 
            // button_them
            // 
            this.button_them.Location = new System.Drawing.Point(270, 32);
            this.button_them.Name = "button_them";
            this.button_them.Size = new System.Drawing.Size(75, 23);
            this.button_them.TabIndex = 4;
            this.button_them.Text = "Them";
            this.button_them.Click += new System.EventHandler(this.button_them_Click);
            // 
            // button_sua
            // 
            this.button_sua.Location = new System.Drawing.Point(351, 32);
            this.button_sua.Name = "button_sua";
            this.button_sua.Size = new System.Drawing.Size(75, 23);
            this.button_sua.TabIndex = 5;
            this.button_sua.Text = "Sua";
            this.button_sua.Click += new System.EventHandler(this.button_sua_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(23, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 13);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Ma to bo mon";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(23, 42);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(69, 13);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Ten to bo mon";
            // 
            // text_matobomon
            // 
            this.text_matobomon.Location = new System.Drawing.Point(111, 9);
            this.text_matobomon.Name = "text_matobomon";
            this.text_matobomon.Size = new System.Drawing.Size(100, 20);
            this.text_matobomon.TabIndex = 11;
            // 
            // text_tentobomon
            // 
            this.text_tentobomon.Location = new System.Drawing.Point(111, 35);
            this.text_tentobomon.Name = "text_tentobomon";
            this.text_tentobomon.Size = new System.Drawing.Size(100, 20);
            this.text_tentobomon.TabIndex = 12;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MATOBOMON";
            this.Column1.HeaderText = "Mã tổ bộ môn";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TENTOBOMON";
            this.Column2.HeaderText = "Tên tổ bộ môn";
            this.Column2.Name = "Column2";
            // 
            // QLToBoMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 254);
            this.Controls.Add(this.text_tentobomon);
            this.Controls.Add(this.text_matobomon);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.button_sua);
            this.Controls.Add(this.button_them);
            this.Controls.Add(this.button_xoa);
            this.Controls.Add(this.button_huy);
            this.Controls.Add(this.button_luu);
            this.Controls.Add(this.data_view);
            this.Name = "QLToBoMon";
            this.Text = "Tổ Bộ Môn";
            this.Load += new System.EventHandler(this.QLToBoMon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_matobomon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_tentobomon.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_view;
        private DevExpress.XtraEditors.SimpleButton button_luu;
        private DevExpress.XtraEditors.SimpleButton button_huy;
        private DevExpress.XtraEditors.SimpleButton button_xoa;
        private DevExpress.XtraEditors.SimpleButton button_them;
        private DevExpress.XtraEditors.SimpleButton button_sua;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit text_matobomon;
        private DevExpress.XtraEditors.TextEdit text_tentobomon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}