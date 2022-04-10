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
        DataTable dtb;
        public Form_GrantPrivileges()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            String sql = "SELECT * FROM U_AD.DOCGIA";
            dtb = Functions.GetDataToTable(sql);
            dataGridView1.DataSource = dtb;
        }
    }
}
