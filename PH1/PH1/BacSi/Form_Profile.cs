using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PH1.BacSi
{
    public partial class Form_Profile : Form
    {
        DataTable dt;
        String username = ""; String dbname ="";
        public Form_Profile(String username, String dbname)
        {
            this.username = username;
            this.dbname = dbname;
            InitializeComponent();
        }

        private void load_data()
        {

            string sql1 = "select * from U_AD.NHANVIEN";
            dt = Functions.GetDataToTable(sql1);
            if (dt.Rows.Count > 0)
            {
                tb_Hoten.Text = dt.Rows[0]["HOTEN"].ToString();
                tb_NgaySinh.Text = dt.Rows[0]["NGAYSINH"].ToString();
                tb_CMND.Text = dt.Rows[0]["CMND"].ToString();
                tb_QQ.Text = dt.Rows[0]["QUEQUAN"].ToString();
                tb_SDT.Text = dt.Rows[0]["SODT"].ToString();
                tb_Phai.Text = dt.Rows[0]["PHAI"].ToString();             
            }
        }
        private void Form_Profile_Load(object sender, EventArgs e)
        {
            load_data();
        }
    }
}
