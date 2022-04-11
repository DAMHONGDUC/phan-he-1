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
    public partial class Form_Main : Form
    {
        Thread t;
        String username = "", password = "";
        public Form_Main(String un, String pw)
        {
            this.username = un;
            this.password = pw;

            InitializeComponent();

            label_username.Text = username;
        }

        // mở 1 form con
        private Form activeform = null;
        private void openChildForm(Form childForm)
        {
            if (activeform != null)
                activeform.Close();
            activeform = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm_KH.Controls.Add(childForm);
            panelChildForm_KH.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        // xử lí chuyển màu khi click vào button
        private Button currentButton;
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = ColorTranslator.FromHtml("#4169E1");
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(39, 39, 58);
                    previousBtn.ForeColor = Color.Gainsboro;
                }
            }
        }

        // xử lí đăng xuất + đăng nhập lại
        public void open_FormLogin(object obj)
        {
            Application.Run(new Form_Login());
        }

        private void Set_Center_Username()
        {
            int y = (panel_username.Height / 2) - (label_username.Height / 2);
            int x = (panel_username.Width / 2) - (label_username.Width / 2);
            label_username.Location = new Point(x, y-15);
           // label_welcome.Location = new Point(x,y-40);
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            Set_Center_Username();
        }

        private void btn_grantPrivileges_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_GrantPrivileges());
            ActivateButton(sender);
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(open_FormLogin);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }

        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Functions.Disconnect();
        }

        private void btn_revokePrivileges_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_RevokeRolecs());
            ActivateButton(sender);
        }

        private void btn_grantRole_toUser_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_GrantRoleToUser());
            ActivateButton(sender);
        }
    }
}
