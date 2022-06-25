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
    public partial class HSBA : Form
    {
        DataTable dtTableName = new DataTable();
        String username = "", dbname = "";
        public HSBA(String un, String dn)
        {
            InitializeComponent();
            this.username = un;
            this.dbname = dn;
        }
        private void LoadData()
        {
            string sql = "SELECT * FROM U_AD.Select_HSBA";
            dtTableName = Functions.GetDataToTable(sql);
            

            if (dtTableName.Rows.Count == 0)
            {
                MessageBox.Show("Không tồn tại hồ sơ nào!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dgv_hsba.DataSource = dtTableName;

            // set Font cho tên cột
            dgv_hsba.Font = new Font("Time New Roman", 13);
            dgv_hsba.Columns[0].HeaderText = "MÃ HSBA";
            dgv_hsba.Columns[1].HeaderText = "MÃBN";
            dgv_hsba.Columns[2].HeaderText = "NGÀY";
            dgv_hsba.Columns[3].HeaderText = "CHUẨN ĐOÁN";
            dgv_hsba.Columns[4].HeaderText = "MÃBS";
            dgv_hsba.Columns[5].HeaderText = "MÃKHOA";
            dgv_hsba.Columns[6].HeaderText = "MÃCSYT";
            dgv_hsba.Columns[7].HeaderText = "KẾT LUẬN";
            dgv_hsba.Columns[8].HeaderText = "MÃDV";
            dgv_hsba.Columns[9].HeaderText = "NGÀY DV";
            dgv_hsba.Columns[10].HeaderText = "MÃKTV";
            dgv_hsba.Columns[11].HeaderText = "KẾT QUẢ";

            // set Font cho dữ liệu hiển thị trong cột
            dgv_hsba.DefaultCellStyle.Font = new Font("Time New Roman", 12);

            // set kích thước cột
            dgv_hsba.Columns[0].Width = 100;
            dgv_hsba.Columns[1].Width = 100;
            dgv_hsba.Columns[2].Width = 100;
            dgv_hsba.Columns[3].Width = 250;
            dgv_hsba.Columns[4].Width = 100;
            dgv_hsba.Columns[5].Width = 100;
            dgv_hsba.Columns[6].Width = 100;
            dgv_hsba.Columns[7].Width = 250;
            dgv_hsba.Columns[8].Width = 100;
            dgv_hsba.Columns[9].Width = 100;
            dgv_hsba.Columns[10].Width = 100;
            dgv_hsba.Columns[11].Width = 250;

            //Không cho người dùng thêm dữ liệu trực tiếp
            dgv_hsba.AllowUserToAddRows = false;
            dgv_hsba.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void HSBA_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
