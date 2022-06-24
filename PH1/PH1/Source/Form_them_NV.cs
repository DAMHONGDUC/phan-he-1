using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PH1.Source
{
    public partial class Form_them_NV : Form
    {
        public Form_them_NV()
        {
            InitializeComponent();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {         
            String sql = "INSERT INTO NHANVIEN(HOTEN, PHAI, NGAYSINH, CMND, QUEQUAN, SODT, CSYT, VAITRO, CHUYENKHOA, USERNAME) " +
                "VALUES(" +
                "N'" + txt_hoten.Text + "', " +
                "N'" + cbo_phai.Text + "', " +
                "TO_DATE('" + dTP_ngaysinh.Text + "', 'dd/mm/yyyy'), " +
                "'" + txt_cmnd.Text + "', " +
                "N'" + txt_quequan.Text + "', " +
                "'" + txt_sdt.Text + "', " +
                "" + txt_csyt.Text + ", " +
                "" + (cbBox_vaitro.SelectedIndex + 1) + ", " +
                "N'" + txt_chuyenkhoa.Text + "', " +
                "'" + txt_un.Text + "')";
            Functions.RunSQL(sql);
            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void Form_them_NV_Load(object sender, EventArgs e)
        {
            dTP_ngaysinh.Text = DateTime.Now.ToString();
        }
    }
}
