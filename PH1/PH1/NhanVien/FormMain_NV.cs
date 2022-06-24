using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PH1.NhanVien
{
    public partial class FormMain_NV : Form
    {
        String username = "", dbname = "";

        private void FormMain_NV_Load(object sender, EventArgs e)
        {
            Set_Center_Username();
        }
        private void Set_Center_Username()
        {
            int y = (panel_username.Height / 2) - (label_username.Height / 2);
            int x = (panel_username.Width / 2) - (label_username.Width / 2);
            label_username.Location = new Point(x, y - 15);
            // label_welcome.Location = new Point(x,y-40);
        }
        public FormMain_NV(String un, String dn)
        {
            InitializeComponent();
            this.username = un;
            this.dbname = dn;
            label_username.Text = username;
        }
    }
}
