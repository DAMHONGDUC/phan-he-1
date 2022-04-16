namespace PH1
{
    partial class Form_EditUser
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Finish = new System.Windows.Forms.Button();
            this.chk_Unlock = new System.Windows.Forms.CheckBox();
            this.chk_Lock = new System.Windows.Forms.CheckBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Finish);
            this.panel1.Controls.Add(this.chk_Unlock);
            this.panel1.Controls.Add(this.chk_Lock);
            this.panel1.Controls.Add(this.txt_Password);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_login);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_UserName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 456);
            this.panel1.TabIndex = 3;
            // 
            // btn_Finish
            // 
            this.btn_Finish.BackColor = System.Drawing.Color.LightCyan;
            this.btn_Finish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Finish.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Finish.Location = new System.Drawing.Point(290, 379);
            this.btn_Finish.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Finish.Name = "btn_Finish";
            this.btn_Finish.Size = new System.Drawing.Size(108, 28);
            this.btn_Finish.TabIndex = 14;
            this.btn_Finish.Text = "Hoàn tất";
            this.btn_Finish.UseVisualStyleBackColor = false;
            this.btn_Finish.Click += new System.EventHandler(this.btn_Finish_Click);
            // 
            // chk_Unlock
            // 
            this.chk_Unlock.AutoSize = true;
            this.chk_Unlock.Location = new System.Drawing.Point(377, 334);
            this.chk_Unlock.Name = "chk_Unlock";
            this.chk_Unlock.Size = new System.Drawing.Size(63, 19);
            this.chk_Unlock.TabIndex = 13;
            this.chk_Unlock.Text = "Unlock";
            this.chk_Unlock.UseVisualStyleBackColor = true;
            // 
            // chk_Lock
            // 
            this.chk_Lock.AutoSize = true;
            this.chk_Lock.Location = new System.Drawing.Point(232, 334);
            this.chk_Lock.Name = "chk_Lock";
            this.chk_Lock.Size = new System.Drawing.Size(51, 19);
            this.chk_Lock.TabIndex = 12;
            this.chk_Lock.Text = "Lock";
            this.chk_Lock.UseVisualStyleBackColor = true;
            // 
            // txt_Password
            // 
            this.txt_Password.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Password.Location = new System.Drawing.Point(232, 275);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(228, 31);
            this.txt_Password.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(232, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nhập Password mới";
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(187)))), ((int)(((byte)(241)))));
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_login.Location = new System.Drawing.Point(475, 196);
            this.btn_login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(108, 28);
            this.btn_login.TabIndex = 9;
            this.btn_login.Text = "Kiểm tra";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(232, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập tên User cần sửa";
//            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_UserName
            // 
            this.txt_UserName.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_UserName.Location = new System.Drawing.Point(232, 194);
            this.txt_UserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(228, 31);
            this.txt_UserName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(232, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nhập Password mới";
            // 
           
            // Form_EditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form_EditUser";
            this.Text = "Form_EditUser";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btn_Finish;
        private CheckBox chk_Unlock;
        private CheckBox chk_Lock;
        private TextBox txt_Password;
        private Label label2;
        private Button btn_login;
        private Label label1;
        private TextBox txt_UserName;
    }
}