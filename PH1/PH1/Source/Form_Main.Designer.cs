﻿namespace PH1
{
    partial class Form_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btn_revokePrivileges = new System.Windows.Forms.Button();
            this.btn_grantRole_toUser = new System.Windows.Forms.Button();
            this.btn_grantPrivileges = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel_username = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.label_username = new System.Windows.Forms.Label();
            this.panelChildForm_KH = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panel_username.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelMenu.Controls.Add(this.btn_revokePrivileges);
            this.panelMenu.Controls.Add(this.btn_grantRole_toUser);
            this.panelMenu.Controls.Add(this.btn_grantPrivileges);
            this.panelMenu.Controls.Add(this.button7);
            this.panelMenu.Controls.Add(this.button6);
            this.panelMenu.Controls.Add(this.button5);
            this.panelMenu.Controls.Add(this.button4);
            this.panelMenu.Controls.Add(this.button3);
            this.panelMenu.Controls.Add(this.button2);
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.panel_username);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(181, 853);
            this.panelMenu.TabIndex = 0;
            // 
            // btn_revokePrivileges
            // 
            this.btn_revokePrivileges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btn_revokePrivileges.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_revokePrivileges.FlatAppearance.BorderSize = 0;
            this.btn_revokePrivileges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_revokePrivileges.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_revokePrivileges.ForeColor = System.Drawing.Color.White;
            this.btn_revokePrivileges.Location = new System.Drawing.Point(0, 729);
            this.btn_revokePrivileges.Name = "btn_revokePrivileges";
            this.btn_revokePrivileges.Size = new System.Drawing.Size(181, 99);
            this.btn_revokePrivileges.TabIndex = 33;
            this.btn_revokePrivileges.Text = "Revoke PrivilegesRole From User/Role";
            this.btn_revokePrivileges.UseVisualStyleBackColor = false;
            this.btn_revokePrivileges.Click += new System.EventHandler(this.btn_revokePrivileges_Click);
            // 
            // btn_grantRole_toUser
            // 
            this.btn_grantRole_toUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btn_grantRole_toUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_grantRole_toUser.FlatAppearance.BorderSize = 0;
            this.btn_grantRole_toUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_grantRole_toUser.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_grantRole_toUser.ForeColor = System.Drawing.Color.White;
            this.btn_grantRole_toUser.Location = new System.Drawing.Point(0, 654);
            this.btn_grantRole_toUser.Name = "btn_grantRole_toUser";
            this.btn_grantRole_toUser.Size = new System.Drawing.Size(181, 75);
            this.btn_grantRole_toUser.TabIndex = 32;
            this.btn_grantRole_toUser.Text = "Grant Role To User";
            this.btn_grantRole_toUser.UseVisualStyleBackColor = false;
            this.btn_grantRole_toUser.Click += new System.EventHandler(this.btn_grantRole_toUser_Click);
            // 
            // btn_grantPrivileges
            // 
            this.btn_grantPrivileges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btn_grantPrivileges.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_grantPrivileges.FlatAppearance.BorderSize = 0;
            this.btn_grantPrivileges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_grantPrivileges.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_grantPrivileges.ForeColor = System.Drawing.Color.White;
            this.btn_grantPrivileges.Location = new System.Drawing.Point(0, 579);
            this.btn_grantPrivileges.Name = "btn_grantPrivileges";
            this.btn_grantPrivileges.Size = new System.Drawing.Size(181, 75);
            this.btn_grantPrivileges.TabIndex = 31;
            this.btn_grantPrivileges.Text = "Grant Privileges To User/Role";
            this.btn_grantPrivileges.UseVisualStyleBackColor = false;
            this.btn_grantPrivileges.Click += new System.EventHandler(this.btn_grantPrivileges_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.button7.Dock = System.Windows.Forms.DockStyle.Top;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(0, 520);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(181, 59);
            this.button7.TabIndex = 30;
            this.button7.Text = "Delete Role";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(0, 461);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(181, 59);
            this.button6.TabIndex = 29;
            this.button6.Text = "Add Role";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(0, 402);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(181, 59);
            this.button5.TabIndex = 28;
            this.button5.Text = "Update User";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(0, 343);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(181, 59);
            this.button4.TabIndex = 27;
            this.button4.Text = "Delete User";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(0, 284);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(181, 59);
            this.button3.TabIndex = 26;
            this.button3.Text = "Add User";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 59);
            this.button2.TabIndex = 25;
            this.button2.Text = "Check Privileges ";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 59);
            this.button1.TabIndex = 24;
            this.button1.Text = "Users List";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel_username
            // 
            this.panel_username.BackColor = System.Drawing.Color.Gainsboro;
            this.panel_username.Controls.Add(this.btn_logout);
            this.panel_username.Controls.Add(this.label_username);
            this.panel_username.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_username.Location = new System.Drawing.Point(0, 0);
            this.panel_username.Name = "panel_username";
            this.panel_username.Size = new System.Drawing.Size(181, 166);
            this.panel_username.TabIndex = 2;
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(187)))), ((int)(((byte)(241)))));
            this.btn_logout.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_logout.Location = new System.Drawing.Point(31, 115);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(118, 37);
            this.btn_logout.TabIndex = 9;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // label_username
            // 
            this.label_username.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_username.Location = new System.Drawing.Point(12, 76);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(163, 28);
            this.label_username.TabIndex = 1;
            this.label_username.Text = "No User";
            this.label_username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelChildForm_KH
            // 
            this.panelChildForm_KH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm_KH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelChildForm_KH.Location = new System.Drawing.Point(181, 0);
            this.panelChildForm_KH.Name = "panelChildForm_KH";
            this.panelChildForm_KH.Size = new System.Drawing.Size(901, 853);
            this.panelChildForm_KH.TabIndex = 1;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1082, 853);
            this.Controls.Add(this.panelChildForm_KH);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_FormClosing);
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.panelMenu.ResumeLayout(false);
            this.panel_username.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelMenu;
        private Panel panel_username;
        private Label label_username;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button btn_revokePrivileges;
        private Button btn_grantRole_toUser;
        private Button btn_grantPrivileges;
        private Panel panelChildForm_KH;
        private Button btn_logout;
    }
}