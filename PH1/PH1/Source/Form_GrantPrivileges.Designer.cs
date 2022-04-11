namespace PH1
{
    partial class Form_GrantPrivileges
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
            this.dgv_privileges = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_privileges)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_privileges
            // 
            this.dgv_privileges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_privileges.Location = new System.Drawing.Point(0, 199);
            this.dgv_privileges.Name = "dgv_privileges";
            this.dgv_privileges.RowHeadersWidth = 51;
            this.dgv_privileges.RowTemplate.Height = 29;
            this.dgv_privileges.Size = new System.Drawing.Size(997, 329);
            this.dgv_privileges.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_login);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(997, 133);
            this.panel1.TabIndex = 1;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(187)))), ((int)(((byte)(241)))));
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_login.Location = new System.Drawing.Point(550, 62);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(124, 37);
            this.btn_login.TabIndex = 9;
            this.btn_login.Text = "Kiểm tra";
            this.btn_login.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(265, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập tên Uses/Role";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(265, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 37);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(187)))), ((int)(((byte)(241)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(404, 607);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 55);
            this.button1.TabIndex = 9;
            this.button1.Text = "Xác nhận";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form_GrantPrivileges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(997, 853);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_privileges);
            this.Name = "Form_GrantPrivileges";
            this.Text = "Form_GrantPrivileges";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_privileges)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgv_privileges;
        private Panel panel1;
        private Label label1;
        private TextBox textBox1;
        private Button btn_login;
        private Button button1;
    }
}