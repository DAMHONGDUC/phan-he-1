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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_privileges)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_privileges
            // 
            this.dgv_privileges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_privileges.Location = new System.Drawing.Point(41, 146);
            this.dgv_privileges.Name = "dgv_privileges";
            this.dgv_privileges.RowHeadersWidth = 51;
            this.dgv_privileges.RowTemplate.Height = 24;
            this.dgv_privileges.Size = new System.Drawing.Size(917, 272);
            this.dgv_privileges.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(997, 95);
            this.panel1.TabIndex = 1;
            // 
            // Form_GrantPrivileges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(997, 853);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_privileges);
            this.Name = "Form_GrantPrivileges";
            this.Text = "Form_GrantPrivileges";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_privileges)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_privileges;
        private System.Windows.Forms.Panel panel1;
    }
}