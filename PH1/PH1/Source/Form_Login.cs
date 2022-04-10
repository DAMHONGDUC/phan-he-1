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
        String username = "", password = "", dbname = "";
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
            // xử lí login
            username = txtbox_usename.Text.Trim();
            password = txtbox_password.Text.Trim();
            dbname = txtbox_dbname.Text.Trim();

            Login(username, password, dbname);

            // xử lí mở main
            this.Close();
            t = new Thread(open_FormMain);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }

        private void Login(String username, String password, String dbName)
        {
            try
            {            
                Functions.InitConnection(username, password, dbName);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
