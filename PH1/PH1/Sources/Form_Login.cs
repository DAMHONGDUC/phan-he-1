using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace PH1
{
    public partial class Form_Login : Form
    {
        Thread t;
        public Form_Login()
        {
            InitializeComponent();
        }

        // xử lí mở form main
        public void open_FormMain(object obj)
        {
            Application.Run(new Form_Main());
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(open_FormMain);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }
    }
}
