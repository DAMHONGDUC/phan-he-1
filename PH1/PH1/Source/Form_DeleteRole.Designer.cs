namespace PH1.Source
{
    partial class Form_DeleteRole
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
            this.btn_XoaUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_XoaUser);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_UserName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 456);
            this.panel1.TabIndex = 5;
            // 
            // btn_XoaUser
            // 
            this.btn_XoaUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(187)))), ((int)(((byte)(241)))));
            this.btn_XoaUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XoaUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_XoaUser.Location = new System.Drawing.Point(484, 196);
            this.btn_XoaUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_XoaUser.Name = "btn_XoaUser";
            this.btn_XoaUser.Size = new System.Drawing.Size(108, 28);
            this.btn_XoaUser.TabIndex = 9;
            this.btn_XoaUser.Text = "Xoá";
            this.btn_XoaUser.UseVisualStyleBackColor = false;
            this.btn_XoaUser.Click += new System.EventHandler(this.btn_XoaUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(232, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập tên Role cần xoá";
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
            // Form_DeleteRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form_DeleteRole";
            this.Text = "Form_DeleteRole";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btn_XoaUser;
        private Label label1;
        private TextBox txt_UserName;
    }
}