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
        String thanhtra = "THANHTRA_";
        String nghiencuu = "NGHIENCUU_";
        Thread t;

        

        
       

        // xử lí đăng xuất + đăng nhập lại
        public void open_FormLogin(object obj)
        {
            Application.Run(new Form_Login());
        }

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

        private void button3_Click(object sender, EventArgs e)
        {
            if (username.Contains(thanhtra))
            {
                openChildForm(new PH1.NhanVien.Form_xemTT());
                ActivateButton(sender);
            }
            else
            {
                MessageBox.Show("Chỉ thanh tra mới được sử dụng chức năng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(open_FormLogin);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
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


        private void btn_hsba_Click(object sender, EventArgs e)
        {
            if (username.Contains(nghiencuu))
            {
                openChildForm(new PH1.NhanVien.HSBA(username, dbname));
                ActivateButton(sender);
            }
            else
            {
                MessageBox.Show("Chỉ Nghiên Cứu mới được sử dụng chức năng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }          

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
