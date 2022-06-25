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
    public partial class Form_xem_audit : Form
    {
        DataTable dtAudit;
        public Form_xem_audit()
        {
            InitializeComponent();
        }

        private void Load(String sql, int column)
        {
            dtAudit = Functions.GetDataToTable(sql);

            dgv.DataSource = dtAudit;

            int width = 150;
            if (column == 3)
            {
                width = 250;
            }
            for (int i = 0; i < column; i++)
            {
                dgv.Columns[i].Width = width;

            }
        }

        private void btn_xem1_Click(object sender, EventArgs e)
        {
            if (cbox_1.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng chọn Fine Grained Audit", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            String s = cbox_1.Text.Trim();
            string[] words = s.Split('(');
            
            string[] words2 = words[1].Split(')');
            String s2 = words2[0];
            Load("SELECT DBUID, LSQLTEXT, NTIMESTAMP# FROM SYS.FGA_LOG$ WHERE LSQLTEXT LIKE '%"+ words2[0] + "%'", 3);
        }

        private void btn_xem2_Click(object sender, EventArgs e)
        {
            if (cbox_2.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng chọn Standard Audit", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Load("select username, EXTENDED_TIMESTAMP ,obj_name, action_name, sql_text " +
                "from dba_audit_trail " +
                "WHERE OBJ_NAME = '"+ cbox_2.Text.Trim() + "' ",5);
        }
    }
}
