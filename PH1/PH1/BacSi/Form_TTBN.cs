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
    public partial class Form_TTBN : Form
    {
        String username = "";
        String dbname ="";
        public Form_TTBN(String username, String dbname)
        {
            this.username = username;
            this.dbname = dbname;
            InitializeComponent();
        }

        public void load_Data()
        {
            string sql1 = "select * from U_AD.View_YBacSi_Select_BenhNhan where mabn = " + Int32.Parse(tb_TimKiem.Text.ToString()) + " or cmnd = '" +tb_TimKiem.Text.ToString()+"' ";
            DataTable dt = Functions.GetDataToTable(sql1);
            if (dt.Rows.Count > 0)
            {
                tb_Hoten.Text = dt.Rows[0]["TENBN"].ToString();
                tb_NgaySinh.Text = dt.Rows[0]["NGAYSINH"].ToString();
                tb_CMND.Text = dt.Rows[0]["CMND"].ToString();
                tb_SoNha.Text = dt.Rows[0]["SONHA"].ToString();
                tb_TenDuong.Text = dt.Rows[0]["TENDUONG"].ToString();
                tb_QH.Text = dt.Rows[0]["QUANHUYEN"].ToString();
                tb_TTP.Text = dt.Rows[0]["TINHTP"].ToString();
                tb_TSB.Text = dt.Rows[0]["TIENSUBENH"].ToString();
                tb_TSBGD.Text = dt.Rows[0]["TIENSUBENHGD"].ToString();
                tb_DUT.Text = dt.Rows[0]["DIUNGTHUOC"].ToString();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
