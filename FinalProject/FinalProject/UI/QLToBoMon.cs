using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using FinalProject.Business;
using FinalProject.Entities;


namespace FinalProject.UI
{
    public partial class QLToBoMon : DevExpress.XtraEditors.XtraForm
    {
        string Query = "";
        public QLToBoMon()
        {
            InitializeComponent();
        }

        private void QLToBoMon_Load(object sender, EventArgs e)
        {
            Load_data();
            ControlButton(true);
        }

        private void Load_data()
        {
            ToBoMonBLL _ToBoMon = new ToBoMonBLL();
            data_view.DataSource = _ToBoMon.getData();
        }

        private void button_them_Click(object sender, EventArgs e)
        {
            Query = "add";

            text_matobomon.Text = "";
            text_tentobomon.Text = "";

            text_matobomon.Enabled = true;
            text_matobomon.Focus();
            ControlButton(false);

        }

        private void button_sua_Click(object sender, EventArgs e)
        {
            Query = "edit";
            text_matobomon.Enabled = false;
            ControlButton(false);
        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
            Query = "delete";
            Excute(Query);
        }

        private void button_luu_Click(object sender, EventArgs e)
        {
            Excute(Query);
            ControlButton(true);
        }

        private void button_huy_Click(object sender, EventArgs e)
        {
            ControlButton(true);
        }

        private void data_view_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            ToBoMonBLL _ToBoMon = new ToBoMonBLL();
            int count = _ToBoMon.Count_Data_Rows();

            if (count == 0)
            {

            }
            else
            {
                int index = e.RowIndex;

                text_matobomon.Text = data_view["Column1", index].Value.ToString();
                text_tentobomon.Text = data_view["Column2", index].Value.ToString();
            }
            
        }

        private void Excute(string strQuery)
        {
            if (strQuery == "add")
            {
                try
                {
                    ToBoMonEntities obj_ToBoMon = new ToBoMonEntities();
                    obj_ToBoMon.MaToBoMon = text_matobomon.Text.Trim();
                    obj_ToBoMon.TenBoMon = text_tentobomon.Text.Trim();

                    ToBoMonBLL _ToBoMon = new ToBoMonBLL();
                    _ToBoMon.Insert(obj_ToBoMon);
                    Load_data();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Them bi loi: " + ex.Message.ToString(), "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (strQuery =="edit")
            {
                try
                {
                    ToBoMonEntities obj_ToBoMon = new ToBoMonEntities();
                    obj_ToBoMon.MaToBoMon = text_matobomon.Text.Trim();
                    obj_ToBoMon.TenBoMon = text_tentobomon.Text.Trim();

                    ToBoMonBLL _ToBoMon = new ToBoMonBLL();
                    _ToBoMon.Update(obj_ToBoMon);
                    Load_data();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sua bi loi: " + ex.Message.ToString(), "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (strQuery == "delete")
            {
                try
                {
                    string _maToBoMon = text_matobomon.Text.Trim();
                    ToBoMonBLL _ToBoMon = new ToBoMonBLL();
                    _ToBoMon.Delete(_maToBoMon);
                    Load_data();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa bị lỗi: " + ex.Message.ToString(), "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void ControlButton(bool type)
        {
            this.button_them.Enabled = button_sua.Enabled = button_xoa.Enabled = type;
            button_luu.Enabled = button_huy.Enabled = !type;
        }
    }
}