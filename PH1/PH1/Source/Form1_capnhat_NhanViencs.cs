﻿using System;
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
        String hoten, phai, quequan, sdt, cmnd, csyt, chuyenkhoa,vaitro,ngaysinh,manv, username;

        private void btn_chinhsua_Click(object sender, EventArgs e)
        {           
            String sql = "UPDATE NHANVIEN " +
                "SET HOTEN = N'" + txt_hoten.Text + "', " +
                "PHAI = N'" + txt_phai.Text + "', " +
                "NGAYSINH = TO_DATE('"+ dTP_ngaysinh.Text + "', 'dd/mm/yyyy'), " +
                "CMND = N'" + txt_cmnd.Text + "', " +
                "QUEQUAN = N'" + txt_quequan.Text + "', " +
                "SODT = '" + txt_sdt.Text + "', " +
                "CSYT = '" + txt_csyt.Text + "', " +
                "VAITRO = '" + cbBox_vaitro.Text + "', " +
                "CHUYENKHOA = N'" + txt_chuyenkhoa.Text + "', " +
                "USERNAME = N'" + txt_un.Text + "'" +
                "WHERE MANV = " + manv + " ";
            Functions.RunSQL(sql);
            MessageBox.Show("Chỉnh sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

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
            txt_un.Text = username;
            dTP_ngaysinh.Text = DateTime.Now.ToString();
        }

        public Form1_capnhat_NhanViencs(String hoten, String phai, String quequan, String sdt, String cmnd
            ,String csyt, String chuyenkhoa,String vaitro, String ngaysinh, String manv,String username)
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
            this.manv = manv;
            this.username = username;
        }


        
    }
}
