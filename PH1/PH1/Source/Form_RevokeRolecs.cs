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
