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
    public partial class Form_DeleteUser : Form
    {
        string username;
        public Form_DeleteUser()
        {
            InitializeComponent();
        }

        private void btn_XoaUser_Click(object sender, EventArgs e)
        {
            string sql = "alter session set  \"_ORACLE_SCRIPT\" = true";
            Functions.RunSQL(sql);
            username = txt_UserName.Text.Trim().ToString();

            sql = "DROP USER " + username + " CASCADE";

            sql = "DROP USER " + username;

            if (Functions.RunSQLwithResult(sql) == 1)
            {
                //sql = "grant create role to " + name + " container=all";
                // Functions.RunSQL(sql);
                MessageBox.Show("Xoa User thanh cong!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return;
        }
    }
}
