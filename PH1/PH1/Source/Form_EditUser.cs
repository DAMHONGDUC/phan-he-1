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
    public partial class Form_EditUser : Form
    {
        string name;
        string pass;
        public Form_EditUser()
        {
            InitializeComponent();
        }

        private void btn_Finish_Click(object sender, EventArgs e)
        {
            if(chk_Unlock.Checked == false && chk_Lock.Checked == false)
            {
                MessageBox.Show("Vui long chon Lock hoac Unlock account!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string sql = "alter session set  \"_ORACLE_SCRIPT\" = true";
            Functions.RunSQL(sql);
            name = txt_UserName.Text.Trim().ToString();
            pass = txt_Password.Text.Trim().ToString();
            if (chk_Lock.Checked == true) 
            sql = "ALTER USER " + name + " IDENTIFIED BY " + pass + " ACCOUNT LOCK";
            if(chk_Unlock.Checked == true)
            sql = "ALTER USER " + name + " IDENTIFIED BY " + pass + " ACCOUNT UNLOCK";


            if (Functions.RunSQLwithResult(sql) == 1)
            {
                MessageBox.Show("Sua User thanh cong!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            name = txt_UserName.Text.Trim().ToString().ToUpper();
            if (Functions.isUserValid(name) == 1)
                MessageBox.Show("User hop le", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("User khong ton tai!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void chk_Lock_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Lock.Checked == true) chk_Unlock.Checked = false;
        }

        private void chk_Unlock_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Unlock.Checked == true) chk_Lock.Checked = false;
        }
    }
}
