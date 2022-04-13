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
    public partial class Form_ShowUsers : Form
    {
        DataTable dtTableName = new DataTable();

        public Form_ShowUsers()
        {
            InitializeComponent();
        }

        
        private void LoadData_ListUsers()
        {
            string sql = "SELECT * FROM dba_users WHERE ACCOUNT_STATUS = 'OPEN' ORDER BY CREATED DESC";
            dtTableName = Functions.GetDataToTable(sql);
            dataGridView_ListUsers.DataSource = dtTableName;
            // set Font cho tên cột
            dataGridView_ListUsers.Font = new Font("Time New Roman", 13);
            dataGridView_ListUsers.Columns[0].HeaderText = "USERNAME";
            dataGridView_ListUsers.Columns[1].HeaderText = "USER_ID";
            dataGridView_ListUsers.Columns[2].HeaderText = "PASSWORD";
            dataGridView_ListUsers.Columns[3].HeaderText = "ACOUNT STATUS";
            dataGridView_ListUsers.Columns[4].HeaderText = "CREATED";

            // set Font cho dữ liệu hiển thị trong cột
            dataGridView_ListUsers.DefaultCellStyle.Font = new Font("Time New Roman", 12);

            // set kích thước cột
            dataGridView_ListUsers.Columns[0].Width = 140;
            dataGridView_ListUsers.Columns[1].Width = 140;
            dataGridView_ListUsers.Columns[2].Width = 140;
            dataGridView_ListUsers.Columns[3].Width = 140;
            dataGridView_ListUsers.Columns[4].Width = 160;

            //Không cho người dùng thêm dữ liệu trực tiếp
            dataGridView_ListUsers.AllowUserToAddRows = false;
            dataGridView_ListUsers.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void Form_ShowUsers_Load(object sender, EventArgs e)
        {
            LoadData_ListUsers();
        }
    }
}
