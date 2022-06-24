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
        String username = "", password = "";
        
        public Form_Login()
        {
            InitializeComponent();          
        }

        // xử lí mở form main
        public void open_FormMain(object obj)
        {
            String dbname = "U_AD";
            Application.Run(new Form_Main(username, password, dbname));
        }

        public void open_FormMainNV(object obj)
        {
            String dbname = "U_AD";
            Application.Run(new PH1.NhanVien.FormMain_NV(username, dbname));
        }

        public void open_FormMainBN(object obj)
        {
            String dbname = "U_AD";
            Application.Run(new PH1.BenhNhan.FormMain_BN(username,dbname));
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            // xử lí login
            username = txtbox_usename.Text.Trim();
            password = txtbox_password.Text.Trim();
            

            Login(username, password);

            // U_AD thì xử lí mở main
            if (username.Contains("U_AD"))
            {
                this.Close();
                t = new Thread(open_FormMain);
                t.SetApartmentState(ApartmentState.STA);
                t.Start();
            }

            // NV 
            else if (username.Contains("NV_"))
            {
                this.Close();
                t = new Thread(open_FormMainNV);
                t.SetApartmentState(ApartmentState.STA);
                t.Start();
            }

            // BN
            else if (username.Contains("BN_"))
            {
                this.Close();
                t = new Thread(open_FormMainBN);
                t.SetApartmentState(ApartmentState.STA);
                t.Start();
            }
        }


        private void Login(String username, String password)
        {
            try
            {            
                Functions.InitConnection(username, password);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
