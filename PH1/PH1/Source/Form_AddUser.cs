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

        //private void grant_role(String usname,int index )
        //{
        //    String sql2 = "";
        //    switch(index)
        //    {
        //        case 0:
        //            sql2 = "GRANT ROLE_NHANVIEN TO " + usname;
        //            Functions.RunSQL(sql2);
        //            sql2 = "GRANT ROLE_THANHTRA TO " + usname;
        //            Functions.RunSQL(sql2);
        //            break;
        //        case 5:
        //            sql2 = "GRANT ROLE_NHANVIEN TO " + usname;
        //            Functions.RunSQL(sql2);
        //            break;
        //        case 2:
        //            sql2 = "GRANT ROLE_YBACSI TO " + usname;
        //            Functions.RunSQL(sql2);
        //            break;
        //    }
           
        //}

        private void btn_AddUser_Click(object sender, EventArgs e)
        {
           if (txt_UserName.Text.Trim().Length == 0 ||
                txt_Password.Text.Trim().Length == 0 ||
                cbBox_vaitro.Text.Trim().Length == 0 )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


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
            String vaitro = (cbBox_vaitro.SelectedIndex + 1).ToString();

            //if (cbBox_vaitro.SelectedIndex == 4) // benh nhan
            //sql = "CALL createUser('"+ name + "','"+ pass + "',1,1)";
            //else sql = "CALL createUser('" + name + "','" + pass + "',0,"+ vaitro + ")";
            sql = "CALL createUser('" + name + "','" + pass + "',"+ (cbBox_vaitro.SelectedIndex +1).ToString()+ "," + vaitro + ")";

            Functions.RunSQL(sql);
            //grant_role(name, cbBox_vaitro.SelectedIndex);
            MessageBox.Show("Them User thanh cong!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txt_UserName.Text = "";
            txt_Password.Text = "";
            cbBox_vaitro.Text = "";

            
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
