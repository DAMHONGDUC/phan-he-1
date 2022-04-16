namespace PH1
{
    partial class Form_AddRole
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
            this.btn_AddRole = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_AddRoleName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_AddRole);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_AddRoleName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 456);
            this.panel1.TabIndex = 5;
            // 
            // btn_AddRole
            // 
            this.btn_AddRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(187)))), ((int)(((byte)(241)))));
            this.btn_AddRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddRole.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_AddRole.Location = new System.Drawing.Point(475, 196);
            this.btn_AddRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AddRole.Name = "btn_AddRole";
            this.btn_AddRole.Size = new System.Drawing.Size(108, 28);
            this.btn_AddRole.TabIndex = 9;
            this.btn_AddRole.Text = "Thêm";
            this.btn_AddRole.UseVisualStyleBackColor = false;
            this.btn_AddRole.Click += new System.EventHandler(this.btn_AddRole_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(232, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập tên Role cần thêm";
            // 
            // txt_AddRoleName
            // 
            this.txt_AddRoleName.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_AddRoleName.Location = new System.Drawing.Point(232, 194);
            this.txt_AddRoleName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_AddRoleName.Name = "txt_AddRoleName";
            this.txt_AddRoleName.Size = new System.Drawing.Size(228, 31);
            this.txt_AddRoleName.TabIndex = 0;
            // 
            // Form_AddRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form_AddRole";
            this.Text = "Form_AddRole";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btn_AddRole;
        private Label label1;
        private TextBox txt_AddRoleName;
    }
}