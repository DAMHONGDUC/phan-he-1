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
    public partial class Form_RevokeRolecs : Form
    {
        public Form_RevokeRolecs()
        {
            InitializeComponent();
            Fill_comboBox();
        }

        private void Fill_comboBox()
        {
            // lấy tất cả role của username này
            DataTable all_role = Functions.GetAllRoles();
            foreach (DataRow row in all_role.Rows)
            {
                cbBox_role.Items.Add(row["ROLE"].ToString());
            }

            //// lấy tất cả user của username này
            //DataTable all_user = Functions.GetAllUsers();
            //foreach (DataRow row in all_user.Rows)
            //{
            //    cbBox_userOrrole.Items.Add(row["USERNAME"].ToString());
            //}
        }

        private void Run_SP_Revoke_Privileges()
        {

        }

        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            if (cbBox_userOrrole.Text.Trim().Length == 0 | cbBox_role.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);           
                return;
            }
            Run_SP_Revoke_Privileges();
        }
    }
}
