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
            this.btn_checkUserOrRole = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_userOrRoleName = new System.Windows.Forms.TextBox();
            this.btn_confirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_privileges)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_privileges
            // 
            this.dgv_privileges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_privileges.Location = new System.Drawing.Point(0, 249);
            this.dgv_privileges.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_privileges.Name = "dgv_privileges";
            this.dgv_privileges.RowHeadersWidth = 51;
            this.dgv_privileges.RowTemplate.Height = 29;
            this.dgv_privileges.Size = new System.Drawing.Size(1246, 528);
            this.dgv_privileges.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_checkUserOrRole);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tb_userOrRoleName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1246, 166);
            this.panel1.TabIndex = 1;
            // 
            // btn_checkUserOrRole
            // 
            this.btn_checkUserOrRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(187)))), ((int)(((byte)(241)))));
            this.btn_checkUserOrRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_checkUserOrRole.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_checkUserOrRole.Location = new System.Drawing.Point(688, 78);
            this.btn_checkUserOrRole.Margin = new System.Windows.Forms.Padding(4);
            this.btn_checkUserOrRole.Name = "btn_checkUserOrRole";
            this.btn_checkUserOrRole.Size = new System.Drawing.Size(155, 46);
            this.btn_checkUserOrRole.TabIndex = 9;
            this.btn_checkUserOrRole.Text = "Kiểm tra";
            this.btn_checkUserOrRole.UseVisualStyleBackColor = false;
            this.btn_checkUserOrRole.Click += new System.EventHandler(this.btn_checkUserOrRole_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(331, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập tên Uses/Role";
            // 
            // tb_userOrRoleName
            // 
            this.tb_userOrRoleName.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_userOrRoleName.Location = new System.Drawing.Point(331, 78);
            this.tb_userOrRoleName.Margin = new System.Windows.Forms.Padding(4);
            this.tb_userOrRoleName.Name = "tb_userOrRoleName";
            this.tb_userOrRoleName.Size = new System.Drawing.Size(324, 43);
            this.tb_userOrRoleName.TabIndex = 0;
            // 
            // btn_confirm
            // 
            this.btn_confirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(187)))), ((int)(((byte)(241)))));
            this.btn_confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_confirm.Location = new System.Drawing.Point(499, 824);
            this.btn_confirm.Margin = new System.Windows.Forms.Padding(4);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(189, 69);
            this.btn_confirm.TabIndex = 9;
            this.btn_confirm.Text = "Xác nhận";
            this.btn_confirm.UseVisualStyleBackColor = false;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // Form_GrantPrivileges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1246, 1050);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_privileges);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_GrantPrivileges";
            this.Text = "Form_GrantPrivileges";
            this.Load += new System.EventHandler(this.Form_GrantPrivileges_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_privileges)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgv_privileges;
        private Panel panel1;
        private Label label1;
        private TextBox tb_userOrRoleName;
        private Button btn_checkUserOrRole;
        private Button btn_confirm;
    }
}