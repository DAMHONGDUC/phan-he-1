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
    public partial class Form_AddUser : Form
    {
        string name;
        string pass;
        string dbName;
        public Form_AddUser(string dbname)
        {
            dbName = dbname;
            InitializeComponent();
        }

        private void btn_AddUser_Click(object sender, EventArgs e)
        {
            name = txt_UserName.Text.Trim().ToString().ToUpper();
            if (Functions.isUserValid(name) == 1)
            {
                MessageBox.Show("Ten user da duoc su dung!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string sql = "alter session set  \"_ORACLE_SCRIPT\" = true";
            Functions.RunSQL(sql);
            name = txt_UserName.Text.Trim().ToString();
            pass = txt_Password.Text.Trim().ToString();

            //sql = "CREATE USER " + name + " IDENTIFIED BY " + pass;

            //if (Functions.RunSQLwithResult(sql) == 1)
            //{
            //    sql = "GRANT ALL PRIVILEGES TO " + name + " with ADMIN OPTION";
            //    Functions.RunSQL(sql);
            //    sql = "grant select on dba_users TO " + name + " with GRANT OPTION";
            //    Functions.RunSQL(sql);
            //    sql = "GRANT SELECT ON DBA_TAB_PRIVS TO " + name + " with GRANT OPTION";
            //    Functions.RunSQL(sql);
            //    sql = "GRANT SELECT ON DBA_TABLES TO " + name + " with GRANT OPTION";
            //    Functions.RunSQL(sql);
            //    sql = "GRANT SELECT ON USER_ROLE_PRIVS TO " + name + " with GRANT OPTION";
            //    Functions.RunSQL(sql);
            //    sql = "GRANT SELECT ON DBA_ROLES TO " + name + " with GRANT OPTION";
            //    Functions.RunSQL(sql);

            //    MessageBox.Show("Them User thanh cong!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //return;
        }
    }
}
