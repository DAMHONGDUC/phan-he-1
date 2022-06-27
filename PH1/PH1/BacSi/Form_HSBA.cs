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
    public partial class Form_HSBA : Form
    {
        DataTable dt = new DataTable();
        private String username = "";
        private String dbname = "";
        public Form_HSBA(String username,String dbname)
        {
            this.username= username;
            this.dbname=dbname;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void load_Data()
        {
            string sql = "select * from U_AD.View_YBacSi_Select_HSBA";
            dt = Functions.GetDataToTable(sql);
            dgv_HSBA.DataSource = dt;



            // set Font cho tên cột
            dgv_HSBA.Font = new Font("Time New Roman", 13);
            dgv_HSBA.Columns[0].HeaderText = "Mã HSBA";
            dgv_HSBA.Columns[1].HeaderText = "Mã BN";
            dgv_HSBA.Columns[2].HeaderText = "Ngày";

            dgv_HSBA.Columns[3].HeaderText = "Chuẩn đoán";
            dgv_HSBA.Columns[4].HeaderText = "Mã bác sĩ";
            dgv_HSBA.Columns[5].HeaderText = "Mã khoa";

            dgv_HSBA.Columns[6].HeaderText = "Mã CSYT";
            dgv_HSBA.Columns[7].HeaderText = "Kết luận";

            // set Font cho dữ liệu hiển thị trong cột
            dgv_HSBA.DefaultCellStyle.Font = new Font("Time New Roman", 12);

            // set kích thước cột
            dgv_HSBA.Columns[0].Width = 200;
            dgv_HSBA.Columns[1].Width = 300;
            dgv_HSBA.Columns[2].Width = 300;
            dgv_HSBA.Columns[3].Width = 300;
            dgv_HSBA.Columns[4].Width = 250;
            dgv_HSBA.Columns[5].Width = 300;
            dgv_HSBA.Columns[6].Width = 300;
            dgv_HSBA.Columns[7].Width = 250;


            //Không cho người dùng thêm dữ liệu trực tiếp
            dgv_HSBA.AllowUserToAddRows = false;
            dgv_HSBA.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void Form_HSBA_Load(object sender, EventArgs e)
        {
            load_Data();
        }
    }
}
