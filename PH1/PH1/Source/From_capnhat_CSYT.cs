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
    public partial class From_capnhat_CSYT : Form
    {
        String ten, diachi, sdt, macsyt;

        private void btn_them_Click(object sender, EventArgs e)
        {
            String sql = "UPDATE CSYT " +
                "SET TENCSYT = '" + txt_ten.Text + "', " +
                "DCCSYT = '" + txt_dc.Text + "', " +
                "SDTCSYT = '" + txt_SDT.Text + "' " +
                "WHERE MACSYT = " + macsyt + "";
            Functions.RunSQL(sql);
            MessageBox.Show("Chỉnh sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        public From_capnhat_CSYT(String ten, String diachi, String sdt, String macsyt)
        {
            InitializeComponent();
            this.ten = ten;
            this.diachi = diachi;
            this.sdt = sdt;
            this.macsyt = macsyt;
        }

        private void From_capnhat_CSYT_Load(object sender, EventArgs e)
        {
            txt_dc.Text = diachi;
            txt_SDT.Text = sdt;
            txt_ten.Text = ten;
        }
    }
}
