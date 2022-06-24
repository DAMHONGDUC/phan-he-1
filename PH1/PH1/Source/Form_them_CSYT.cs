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
    public partial class Form_them_CSYT : Form
    {
        public Form_them_CSYT()
        {
            InitializeComponent();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            String sql = "INSERT INTO " +
                "CSYT(TENCSYT, DCCSYT, SDTCSYT) " +
                "VALUES (" +
                "N'"+ txt_ten .Text+ "', " +
                "N'" + txt_dc.Text + "', " +
                "'" + txt_SDT.Text + "')";
            Functions.RunSQL(sql);
            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
