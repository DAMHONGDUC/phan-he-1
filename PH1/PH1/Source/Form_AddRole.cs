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
    public partial class Form_AddRole : Form
    {
        string name;
        public Form_AddRole()
        {
            InitializeComponent();
        }

        private void btn_AddRole_Click(object sender, EventArgs e)
        {
            name = txt_AddRoleName.Text.Trim().ToString().ToUpper();
            if (Functions.isRoleValid(name) == 1 || Functions.isUserValid(name) == 1)
            {
                MessageBox.Show("Ten role da duoc su dung!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string sql = "alter session set  \"_ORACLE_SCRIPT\" = true";
            Functions.RunSQL(sql);
            name = txt_AddRoleName.Text.Trim().ToString();
            sql = "CREATE ROLE "  + name;

            if (Functions.RunSQLwithResult(sql) == 1) {
                //sql = "grant create role to " + name + " container=all";
               // Functions.RunSQL(sql);
                MessageBox.Show("Them Role thanh cong!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return;
        }
    }
}
