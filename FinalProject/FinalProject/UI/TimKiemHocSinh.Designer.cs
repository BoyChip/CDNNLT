namespace FinalProject.UI
{
    partial class TimKiemHocSinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimKiemHocSinh));
            this.data_view = new System.Windows.Forms.DataGridView();
            this.text_item = new DevExpress.XtraEditors.TextEdit();
            this.button_timkiem = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.data_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_item.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // data_view
            // 
            this.data_view.AllowUserToAddRows = false;
            this.data_view.AllowUserToDeleteRows = false;
            this.data_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_view.Location = new System.Drawing.Point(12, 35);
            this.data_view.MultiSelect = false;
            this.data_view.Name = "data_view";
            this.data_view.ReadOnly = true;
            this.data_view.Size = new System.Drawing.Size(1036, 214);
            this.data_view.TabIndex = 0;
            // 
            // text_item
            // 
            this.text_item.Location = new System.Drawing.Point(139, 9);
            this.text_item.Name = "text_item";
            this.text_item.Size = new System.Drawing.Size(113, 20);
            this.text_item.TabIndex = 1;
            this.text_item.TextChanged += new System.EventHandler(this.text_item_TextChanged);
            // 
            // button_timkiem
            // 
            this.button_timkiem.Location = new System.Drawing.Point(270, 6);
            this.button_timkiem.Name = "button_timkiem";
            this.button_timkiem.Size = new System.Drawing.Size(75, 23);
            this.button_timkiem.TabIndex = 2;
            this.button_timkiem.Text = "Tìm";
            this.button_timkiem.Click += new System.EventHandler(this.button_timkiem_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(108, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Nhập thông tin cần tìm";
            // 
            // TimKiemHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 261);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.button_timkiem);
            this.Controls.Add(this.text_item);
            this.Controls.Add(this.data_view);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TimKiemHocSinh";
            this.Text = "Tìm kiếm học sinh";
            this.Load += new System.EventHandler(this.TimKiemHocSinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_item.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_view;
        private DevExpress.XtraEditors.TextEdit text_item;
        private DevExpress.XtraEditors.SimpleButton button_timkiem;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}