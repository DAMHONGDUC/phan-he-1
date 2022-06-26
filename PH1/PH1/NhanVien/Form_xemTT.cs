using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PH1.NhanVien
{
    public partial class Form_xemTT : Form
    {
        DataTable tbl_1;
        DataTable tbl_2;
        String owner = "U_AD";
        public Form_xemTT()
        {
            InitializeComponent();
        }

        private void Load_1(String table)
        {
            string sql = "SELECT * FROM "+owner+"." + table;
            tbl_1 = Functions.GetDataToTable(sql);

            dGV_1.DataSource = tbl_1;
        }

        private void Load_2(String table)
        {
            string sql = "SELECT * FROM " + owner + "." + table;
            tbl_2 = Functions.GetDataToTable(sql);

            dGV_2.DataSource = tbl_2;
        }

        private void btn_xem1_Click(object sender, EventArgs e)
        {
            if (cbox_bang1.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng chọn bảng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Load_1(cbox_bang1.Text.Trim().ToString());
        }

        private void btn_xem2_Click(object sender, EventArgs e)
        {
            if (cbox_bang2.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng chọn bảng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Load_2(cbox_bang2.Text.Trim().ToString());
        }

        
    }
}
