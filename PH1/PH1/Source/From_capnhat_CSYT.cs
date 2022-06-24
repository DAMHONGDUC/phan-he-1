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
        String ten, diachi, sdt;
        public From_capnhat_CSYT(String ten, String diachi, String sdt)
        {
            InitializeComponent();
            this.ten = ten;
            this.diachi = diachi;
            this.sdt = sdt;
        }

        private void From_capnhat_CSYT_Load(object sender, EventArgs e)
        {
            txt_dc.Text = diachi;
            txt_SDT.Text = sdt;
            txt_ten.Text = ten;
        }
    }
}
