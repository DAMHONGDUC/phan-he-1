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
    public partial class Form1_capnhat_NhanViencs : Form
    {
        String hoten, phai, quequan, sdt, cmnd, csyt, chuyenkhoa,vaitro,ngaysinh;

        private void Form1_capnhat_NhanViencs_Load(object sender, EventArgs e)
        {
            txt_hoten.Text = hoten;
                txt_phai.Text = phai;
            dTP_ngaysinh.Text = ngaysinh;
            txt_cmnd.Text = cmnd;
            txt_quequan.Text = quequan;
            txt_sdt.Text = sdt;
            txt_csyt.Text = csyt;
            cbBox_vaitro.Text = hoten;
            txt_chuyenkhoa.Text = chuyenkhoa;
            cbBox_vaitro.Text = vaitro;
        }

        public Form1_capnhat_NhanViencs(String hoten, String phai, String quequan, String sdt, String cmnd
            ,String csyt, String chuyenkhoa,String vaitro, String ngaysinh)
        {
            InitializeComponent();
            this.hoten = hoten;
            this.phai = phai;
            this.quequan = quequan;
            this.sdt = sdt;
            this.cmnd = cmnd;
            this.csyt = csyt;
            this.chuyenkhoa = chuyenkhoa;
            this.vaitro = vaitro;
            this.ngaysinh = ngaysinh;
        }


        
    }
}
