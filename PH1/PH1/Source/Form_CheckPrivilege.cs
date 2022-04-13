using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PH1.Source
{
    public partial class Form_CheckPrivilege : Form
    {
        DataTable dtTableName = new DataTable();
        String name;
        public Form_CheckPrivilege()
        {
            InitializeComponent();
        }

        private void LoadData_CheckPrivilegeOnTable()
        {
            name = NameUserOrRole.Text.Trim().ToString();
            string sql = "SELECT * FROM DBA_TAB_PRIVS WHERE GRANTEE =" + "'"+name +"'"+ " AND TYPE = 'TABLE' ORDER BY TABLE_NAME";
            dtTableName = Functions.GetDataToTable(sql);
            dataGridView_CheckPrivilege.DataSource = dtTableName;
            // set Font cho tên cột
            dataGridView_CheckPrivilege.Font = new Font("Time New Roman", 13);
            dataGridView_CheckPrivilege.Columns[0].HeaderText = "GRANTEE";
            dataGridView_CheckPrivilege.Columns[1].HeaderText = "OWNER";
            dataGridView_CheckPrivilege.Columns[2].HeaderText = "TABLE_NAME";
            dataGridView_CheckPrivilege.Columns[3].HeaderText = "GRATOR STATUS";
            dataGridView_CheckPrivilege.Columns[4].HeaderText = "GRANTALE";
            dataGridView_CheckPrivilege.Columns[5].HeaderText = "HIERARCHY";
            dataGridView_CheckPrivilege.Columns[6].HeaderText = "COMMON";
            dataGridView_CheckPrivilege.Columns[7].HeaderText = "TYPE";
            dataGridView_CheckPrivilege.Columns[8].HeaderText = "INHERITED";

            // set Font cho dữ liệu hiển thị trong cột
            dataGridView_CheckPrivilege.DefaultCellStyle.Font = new Font("Time New Roman", 12);

            // set kích thước cột
            dataGridView_CheckPrivilege.Columns[0].Width = 150;
            dataGridView_CheckPrivilege.Columns[1].Width = 150;
            dataGridView_CheckPrivilege.Columns[2].Width = 250;
            dataGridView_CheckPrivilege.Columns[3].Width = 150;
            dataGridView_CheckPrivilege.Columns[4].Width = 150;
            dataGridView_CheckPrivilege.Columns[5].Width = 150;
            dataGridView_CheckPrivilege.Columns[6].Width = 150;
            dataGridView_CheckPrivilege.Columns[7].Width = 150;
            dataGridView_CheckPrivilege.Columns[8].Width = 150;


            //Không cho người dùng thêm dữ liệu trực tiếp
            dataGridView_CheckPrivilege.AllowUserToAddRows = false;
            dataGridView_CheckPrivilege.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void LoadData_CheckPrivilegeOnView()
        {
            name = NameUserOrRole.Text.Trim().ToString();
            string sql = "SELECT * FROM DBA_TAB_PRIVS WHERE GRANTEE =" + "'" + name + "'" + " AND TYPE = 'VIEW' ORDER BY TABLE_NAME";
            dtTableName = Functions.GetDataToTable(sql);
            dataGridView_CheckPrivilege.DataSource = dtTableName;
            // set Font cho tên cột
            dataGridView_CheckPrivilege.Font = new Font("Time New Roman", 13);
            dataGridView_CheckPrivilege.Columns[0].HeaderText = "GRANTEE";
            dataGridView_CheckPrivilege.Columns[1].HeaderText = "OWNER";
            dataGridView_CheckPrivilege.Columns[2].HeaderText = "TABLE_NAME";
            dataGridView_CheckPrivilege.Columns[3].HeaderText = "GRATOR STATUS";
            dataGridView_CheckPrivilege.Columns[4].HeaderText = "GRANTALE";
            dataGridView_CheckPrivilege.Columns[5].HeaderText = "HIERARCHY";
            dataGridView_CheckPrivilege.Columns[6].HeaderText = "COMMON";
            dataGridView_CheckPrivilege.Columns[7].HeaderText = "TYPE";
            dataGridView_CheckPrivilege.Columns[8].HeaderText = "INHERITED";

            // set Font cho dữ liệu hiển thị trong cột
            dataGridView_CheckPrivilege.DefaultCellStyle.Font = new Font("Time New Roman", 12);

            // set kích thước cột
            dataGridView_CheckPrivilege.Columns[0].Width = 150;
            dataGridView_CheckPrivilege.Columns[1].Width = 150;
            dataGridView_CheckPrivilege.Columns[2].Width = 250;
            dataGridView_CheckPrivilege.Columns[3].Width = 150;
            dataGridView_CheckPrivilege.Columns[4].Width = 150;
            dataGridView_CheckPrivilege.Columns[5].Width = 150;
            dataGridView_CheckPrivilege.Columns[6].Width = 150;
            dataGridView_CheckPrivilege.Columns[7].Width = 150;
            dataGridView_CheckPrivilege.Columns[8].Width = 150;


            //Không cho người dùng thêm dữ liệu trực tiếp
            dataGridView_CheckPrivilege.AllowUserToAddRows = false;
            dataGridView_CheckPrivilege.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void button1_LoadDataPrivilegeOntable(object sender, EventArgs e)
        {
            LoadData_CheckPrivilegeOnTable();
        }

        private void button2_LoadDateCheckPrivilegeOnView(object sender, EventArgs e)
        {
            LoadData_CheckPrivilegeOnView();
        }
    }
}
