using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PH1.BenhNhan
{
    public partial class Form_Profile : Form
    {
        DataTable dt;
        String username = "";
        String dbname="";
        int mabn = 0;
        public Form_Profile(String username, String dbname)
        {
            this.dbname = dbname;
            this.username = username;
            InitializeComponent();
        }

       private void load_data()
        {

            string sql1 = "select MABN, TENBN, CMND, NGAYSINH, SONHA, TENDUONG, QUANHUYEN," +
                " TINHTP, TIENSUBENH, TIENSUBENHGD, DIUNGTHUOC from U_AD.BENHNHAN";
            DataTable dt = Functions.GetDataToTable(sql1);
            if(dt.Rows.Count > 0)
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
                try
                {
                    mabn = Int32.Parse(dt.Rows[0]["MABN"].ToString());
                }
                catch (Exception)
                {
                    mabn = 0;
                }
                
            }
        }

        private void Form_Profile_Load(object sender, EventArgs e)
        {
            load_data();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if( tb_Hoten.Text == "" || tb_NgaySinh.Text == "" || tb_CMND.Text == "" || tb_SoNha.Text == "" ||tb_TenDuong.Text == ""||
                tb_QH.Text == "" || tb_TTP.Text == "" || tb_TSB.Text == "" ||  tb_TSBGD.Text == "" || tb_DUT.Text == "" ||
                tb_Hoten.Text == null || tb_NgaySinh.Text == null || tb_CMND.Text == null || tb_SoNha.Text == null || tb_TenDuong.Text == null ||
                tb_QH.Text == null || tb_TTP.Text == null || tb_TSB.Text == null || tb_TSBGD.Text == null || tb_DUT.Text == null
                )
            {
                MessageBox.Show("Vui lòng fill đầy đủ các trường dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {

                String sql = 
                "UPDATE U_AD.BENHNHAN SET " +
                "TENBN = N'" + tb_Hoten.Text + "', " +
                "CMND = '" + tb_CMND.Text + "', " +
                "SONHA = N'" + tb_SoNha.Text + "', " +
                "TENDUONG = N'" + tb_TenDuong.Text + "', " +
                "QUANHUYEN = N'" + tb_QH.Text + "', " +
                "TINHTP = N'" + tb_TTP.Text + "', " +
                "TIENSUBENH = N'" + tb_TSB.Text + "', " +
                "TIENSUBENHGD = N'" + tb_TSBGD.Text + "', " +
                "DIUNGTHUOC = N'" + tb_DUT.Text + "', " +
                "NGAYSINH = to_date('" + tb_NgaySinh.Text + "','dd/mm/yyyy') " +
                "WHERE MABN = " + mabn;
           
                Functions.RunSQL(sql);
                Functions.RunSQL("COMMIT");
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           

        }
    }
}
