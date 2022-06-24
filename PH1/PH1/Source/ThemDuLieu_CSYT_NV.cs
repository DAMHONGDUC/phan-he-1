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
    public partial class ThemDuLieu_CSYT_NV : Form
    {
        String manv = "";
        DataTable tbl_NV;
        DataTable tbl_CSYT;
        public ThemDuLieu_CSYT_NV()
        {
            InitializeComponent();
        }

        private void LoadData_NV()
        {             
            string sql = "SELECT * FROM NHANVIEN";
            tbl_NV = Functions.GetDataToTable(sql);

            

            dGV_NV.DataSource = tbl_NV;

            // set Font cho tên cột            
            dGV_NV.Columns[0].HeaderText = "MANV";
            dGV_NV.Columns[1].HeaderText = "HOTEN";
            dGV_NV.Columns[2].HeaderText = "PHAI";
            dGV_NV.Columns[3].HeaderText = "NGAYSINH";
            dGV_NV.Columns[4].HeaderText = "CMND";
            dGV_NV.Columns[5].HeaderText = "QUEQUAN";
            dGV_NV.Columns[6].HeaderText = "SODT";
            dGV_NV.Columns[7].HeaderText = "CSYT";           
            dGV_NV.Columns[8].HeaderText = "VAITRO";
            dGV_NV.Columns[9].HeaderText = "CHUYENKHOA";
            dGV_NV.Columns[10].HeaderText = "USERNAME";
            dGV_NV.Columns[11].HeaderText = "PASSWORD";
           
            // set kích thước cột
            dGV_NV.Columns[0].Width = 200;
            dGV_NV.Columns[1].Width = 200;
            dGV_NV.Columns[2].Width = 200;
            dGV_NV.Columns[3].Width = 200;
            dGV_NV.Columns[4].Width = 200;
            dGV_NV.Columns[5].Width = 200;
            dGV_NV.Columns[6].Width = 200;
            dGV_NV.Columns[7].Width = 200;
            dGV_NV.Columns[8].Width = 200;
            dGV_NV.Columns[9].Width = 200;
            dGV_NV.Columns[10].Width = 200;
            dGV_NV.Columns[11].Width = 200;


            //Không cho người dùng thêm dữ liệu trực tiếp
            dGV_NV.AllowUserToAddRows = false;
            dGV_NV.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void LoadData_CSYT()
        {
            string sql = "SELECT * FROM CSYT";
            tbl_CSYT = Functions.GetDataToTable(sql);
            dGV_CSYT.DataSource = tbl_CSYT;

            

            dGV_CSYT.Columns[0].HeaderText = "MACSYT";
            dGV_CSYT.Columns[1].HeaderText = "TENCSYT";
            dGV_CSYT.Columns[2].HeaderText = "DCCSYT";
            dGV_CSYT.Columns[3].HeaderText = "SDTCSYT";
        

            

            // set kích thước cột
            dGV_CSYT.Columns[0].Width = 200;
            dGV_CSYT.Columns[1].Width = 200;
            dGV_CSYT.Columns[2].Width = 200;
            dGV_CSYT.Columns[3].Width = 200;
      


            //Không cho người dùng thêm dữ liệu trực tiếp
            dGV_CSYT.AllowUserToAddRows = false;
            dGV_CSYT.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void ThemDuLieu_CSYT_NV_Load(object sender, EventArgs e)
        {
            LoadData_NV();
            LoadData_CSYT();
        }

        private void btn_capnhat_NV_Click(object sender, EventArgs e)
        {
            manv = dGV_NV.CurrentRow.Cells["MANV"].Value.ToString();
            if (manv.Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn hàng nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            PH1.Source.Form1_capnhat_NhanViencs capnhat_NhanVien = new Form1_capnhat_NhanViencs(
                dGV_NV.CurrentRow.Cells["HOTEN"].Value.ToString(),
                dGV_NV.CurrentRow.Cells["PHAI"].Value.ToString(),
                dGV_NV.CurrentRow.Cells["QUEQUAN"].Value.ToString(),
                dGV_NV.CurrentRow.Cells["SODT"].Value.ToString(),
                dGV_NV.CurrentRow.Cells["CMND"].Value.ToString(),
                dGV_NV.CurrentRow.Cells["CSYT"].Value.ToString(),
                dGV_NV.CurrentRow.Cells["CHUYENKHOA"].Value.ToString(),
                dGV_NV.CurrentRow.Cells["VAITRO"].Value.ToString(),
                dGV_NV.CurrentRow.Cells["NGAYSINH"].Value.ToString()
                );
            
            capnhat_NhanVien.Show();
        }

        private void dGV_NV_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_them_NV_Click(object sender, EventArgs e)
        {
            PH1.Source.Form_them_NV them_nv = new Form_them_NV();

            them_nv.Show();
        }

        private void btn_them_CSYT_Click(object sender, EventArgs e)
        {
            PH1.Source.Form_them_CSYT them_CSYT = new Form_them_CSYT();

            them_CSYT.Show();
        }

        private void btn_sua_CSYT_Click(object sender, EventArgs e)
        {
            PH1.Source.From_capnhat_CSYT capnhat_CSYT = new From_capnhat_CSYT(
                dGV_CSYT.CurrentRow.Cells["TENCSYT"].Value.ToString(),
                dGV_CSYT.CurrentRow.Cells["DCCSYT"].Value.ToString(),
                dGV_CSYT.CurrentRow.Cells["SDTCSYT"].Value.ToString()
                );

            capnhat_CSYT.Show();
        }
    }
}
