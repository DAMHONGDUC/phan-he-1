using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PH1
{
    public partial class Form_DeleteRole : Form
    {
        string username;
        public Form_DeleteRole()
        {
            InitializeComponent();
        }

        private void btn_XoaUser_Click(object sender, EventArgs e)
        {
            string sql = "alter session set  \"_ORACLE_SCRIPT\" = true";
            Functions.RunSQL(sql);
            username = txt_UserName.Text.Trim().ToString();

            sql = "DROP ROLE " + username;


            if (Functions.RunSQLwithResult(sql) == 1)
            {
                //sql = "grant create role to " + name + " container=all";
                // Functions.RunSQL(sql);
                MessageBox.Show("Xoa Role thanh cong!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return;
        }
    }
}
