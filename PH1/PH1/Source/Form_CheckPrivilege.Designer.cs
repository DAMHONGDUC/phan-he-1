namespace PH1.Source
{
    partial class Form_CheckPrivilege
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.NameUserOrRole = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_CheckPrivilege = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CheckPrivilege)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.NameUserOrRole);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 157);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(448, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(275, 56);
            this.button2.TabIndex = 3;
            this.button2.Text = "Kiểm tra quyền theo mức cột";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_LoadDateCheckPrivilegeOnView);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(270, 56);
            this.button1.TabIndex = 2;
            this.button1.Text = "Kiểm tra quyền theo mức bảng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_LoadDataPrivilegeOntable);
            // 
            // NameUserOrRole
            // 
            this.NameUserOrRole.Location = new System.Drawing.Point(364, 22);
            this.NameUserOrRole.Name = "NameUserOrRole";
            this.NameUserOrRole.Size = new System.Drawing.Size(228, 31);
            this.NameUserOrRole.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập tên User/Role";
            // 
            // dataGridView_CheckPrivilege
            // 
            this.dataGridView_CheckPrivilege.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_CheckPrivilege.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_CheckPrivilege.Location = new System.Drawing.Point(0, 157);
            this.dataGridView_CheckPrivilege.Name = "dataGridView_CheckPrivilege";
            this.dataGridView_CheckPrivilege.RowHeadersWidth = 62;
            this.dataGridView_CheckPrivilege.RowTemplate.Height = 33;
            this.dataGridView_CheckPrivilege.Size = new System.Drawing.Size(800, 293);
            this.dataGridView_CheckPrivilege.TabIndex = 1;
            // 
            // Form_CheckPrivilege
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView_CheckPrivilege);
            this.Controls.Add(this.panel1);
            this.Name = "Form_CheckPrivilege";
            this.Text = "Form_ShowPrivilege";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CheckPrivilege)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Button button1;
        private TextBox NameUserOrRole;
        private Label label1;
        private DataGridView dataGridView_CheckPrivilege;
    }
}