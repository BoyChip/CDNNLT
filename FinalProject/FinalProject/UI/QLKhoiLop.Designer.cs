namespace FinalProject.UI
{
    partial class QLKhoiLop
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
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.data_view)).BeginInit();
            this.SuspendLayout();
            // 
            // data_view
            // 
            this.data_view.AllowUserToAddRows = false;
            this.data_view.AllowUserToDeleteRows = false;
            this.data_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.data_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_view.Location = new System.Drawing.Point(0, 0);
            this.data_view.Name = "data_view";
            this.data_view.Size = new System.Drawing.Size(244, 159);
            this.data_view.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MAKHOI";
            this.Column1.HeaderText = "Mã khối";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TENKHOI";
            this.Column2.HeaderText = "Tên khối";
            this.Column2.Name = "Column2";
            // 
            // QLKhoiLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 159);
            this.Controls.Add(this.data_view);
            this.Name = "QLKhoiLop";
            this.Text = "Khối Lớp";
            this.Load += new System.EventHandler(this.QLKhoiLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_view)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView data_view;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}