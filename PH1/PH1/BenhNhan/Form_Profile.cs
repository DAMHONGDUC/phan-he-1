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
        public Form_Profile()
        {
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
            }
        }

        private void Form_Profile_Load(object sender, EventArgs e)
        {
            load_data();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql1 = "select MABN, TENBN, CMND, NGAYSINH, SONHA, TENDUONG, QUANHUYEN," +
                " TINHTP, TIENSUBENH, TIENSUBENHGD, DIUNGTHUOC from U_AD.BENHNHAN";
            this.dt = Functions.GetDataToTable(sql1);
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
                string sql = "UPDATE BENHNHAN SET " +
               "TENBN = '" + tb_Hoten + "'," +
               "CMND = '" + tb_CMND + "', " +
               "SONHA = '" + tb_SoNha + "', " +
               "TENDUONG = '" + tb_TenDuong + "', " +
               "QUANHUYEN = '" + tb_QH + "', " +
               "TINHTP = '" + tb_TTP + "', " +
               "TIENSUBENH = '" + tb_TSB + "', " +
               "TIENSUBENHGD = '" + tb_TSBGD + "', " +
               "DIUNGTHUOC = '" + tb_DUT + "', " +
               "NGAYSINH = 'to_date('" + tb_NgaySinh + "','dd/mm/yyyy') " +
               "WHERE MABN = " + Int32.Parse(this.dt.Rows[0]["MABN"].ToString());

                Functions.RunSQL(sql);
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           

        }
    }
}
