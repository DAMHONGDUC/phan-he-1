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
    public partial class Form_GrantPrivileges : Form
    {
        DataTable DT_AllPrivileges = new DataTable(); // bảng chứa dữ liệu tất cả các quyền của 1 user
        String username = "", dbname = "";

        public Form_GrantPrivileges(String un, String dn)
        {
            this.username = un;
            this.dbname = dn;
            InitializeComponent();        
        }

        private void init_Data()
        {
            // set font 
            dgv_privileges.Font = new Font("Segoe UI", 12);

            // tạo các cột
            DataGridViewTextBoxColumn dgvc_TableName = new DataGridViewTextBoxColumn();
            dgvc_TableName.HeaderText = "Table Name";
            dgv_privileges.Columns.Add(dgvc_TableName);

            string[] columnName = new string[] { "Select", "Select (WITH GRANT OPTION)",
                "Insert", "Insert (WITH GRANT OPTION)"
            ,"Update", "Update (WITH GRANT OPTION)"
            ,"Delete", "Delete (WITH GRANT OPTION)" , ""};
            for (int i = 0; i < columnName.Length; i++)
            {
                DataGridViewCheckBoxColumn dgvCmb = new DataGridViewCheckBoxColumn();
                dgvCmb.HeaderText = columnName[i];
                dgv_privileges.Columns.Add(dgvCmb);
            }

            // lấy tên tất cả bảng
            DataTable all_TableName = Functions.GetAll_TableName(dbname);

            // lấy các quyền trên bảng của user này
            DataTable all_privilegesOnTable = Functions.GetPrivilegeOnTable(username);

            for (int i = 0; i < all_TableName.Rows.Count; i++)
            {
                bool select = false, select_withGrantOption = false,
                    insert = false, insert_withGrantOption = false,
                    update = false, update_withGrantOption = false,
                    delete = false, delete_withGrantOption = false;

                //for (int j = 0; j < all_privilegesOnTable.Rows.Count; j++)
                //{
                //    String table_name = all_privilegesOnTable.Rows[j].Field<string>(2);
                //    String privilege = all_privilegesOnTable.Rows[j].Field<string>(4);
                //    if (table_name.Equals(all_TableName.Rows[i].Field<string>(0)))
                //    {
                //        if (privilege == "SELECT")
                //            select = true;
                //        if (privilege == "INSERT")
                //            insert = true;
                //        if (privilege == "UPDATE")
                //            update = true;
                //        if (privilege == "DELETE")
                //            delete = true;
                //    }
                //}


                //MessageBox.Show(all_privilegesOnTable.Rows.Count.ToString());

                foreach (DataRow row in all_privilegesOnTable.Rows)
                {
                    String table_name = row["TABLE_NAME"].ToString();
                    String privilege = row["PRIVILEGE"].ToString();
                    if (table_name.Equals(all_TableName.Rows[i].Field<string>(0)))
                    {
                        if (privilege == "SELECT")
                            select = true;
                        if (privilege == "INSERT")
                            insert = true;
                        if (privilege == "UPDATE")
                            update = true;
                        if (privilege == "DELETE")
                            delete = true;
                    }
                }

                dgv_privileges.Rows.Add(all_TableName.Rows[i].Field<string>(0), select, select_withGrantOption,
                    insert, insert_withGrantOption,
                    update, update_withGrantOption,
                    delete, delete_withGrantOption);
            }

            // set kích thước cột
            dgv_privileges.Columns[0].Width = 200;

            //Không cho người dùng thêm dữ liệu trực tiếp
            dgv_privileges.AllowUserToAddRows = false;

            ////// lấy tên tất cả bảng
            //DataTable all_TableName = Functions.GetAll_TableName(dbname);

            //dgv_privileges.DataSource = all_TableName;

            //// tạo các cột
            //string[] columnName = new string[] { "Select", "Select (WITH GRANT OPTION)",
            //    "Insert", "Insert (WITH GRANT OPTION)"
            //,"Update", "Update (WITH GRANT OPTION)"
            //,"Delete", "Delete (WITH GRANT OPTION)" };

            //for (int i = 0; i < columnName.Length; i++)
            //{
            //    DataGridViewCheckBoxColumn dgvCmb = new DataGridViewCheckBoxColumn();
            //    dgvCmb.ValueType = typeof(bool);

            //    dgvCmb.Name = "Chk";
            //    dgvCmb.HeaderText = columnName[i];

            //    dgv_privileges.Columns.Add(dgvCmb);
            //}

            ////Không cho người dùng thêm dữ liệu trực tiếp
            //dgv_privileges.AllowUserToAddRows = false;
        }

        private void Form_GrantPrivileges_Load(object sender, EventArgs e)
        {          
            init_Data();
        }
    }
}
