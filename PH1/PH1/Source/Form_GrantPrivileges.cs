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
        DataTable dtTableName = new DataTable();
        // add column to datatable  

        public Form_GrantPrivileges()
        {
            InitializeComponent();
            create_datagridview();
        }

        private void create_datagridview()
        {
            // set font 
            dgv_privileges.Font = new Font("Segoe UI", 12);

            // lấy tên bảng         
            dtTableName.Columns.Add("TableName", typeof(string));

            dtTableName.Rows.Add("Bang 1");
            dtTableName.Rows.Add("Bang 2");
            dtTableName.Rows.Add("Bang 3");
            dtTableName.Rows.Add("Bang 4");

            dgv_privileges.DataSource = dtTableName;

            // tạo các cột
            string[] columnName = new string[] { "Select", "Select (WITH GRANT OPTION)",
                "Insert", "Insert (WITH GRANT OPTION)"
            ,"Update", "Update (WITH GRANT OPTION)"
            ,"Delete", "Delete (WITH GRANT OPTION)" };

            for (int i = 0; i < columnName.Length; i++)
            {
                DataGridViewCheckBoxColumn dgvCmb = new DataGridViewCheckBoxColumn();
                dgvCmb.ValueType = typeof(bool);
                dgvCmb.Name = "Chk";
                dgvCmb.HeaderText = columnName[i];

                dgv_privileges.Columns.Add(dgvCmb);
            }

            //Không cho người dùng thêm dữ liệu trực tiếp
            dgv_privileges.AllowUserToAddRows = false;
        }
    }
}
