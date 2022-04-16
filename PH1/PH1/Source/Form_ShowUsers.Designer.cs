namespace PH1.Source
{
    partial class Form_ShowUsers
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_ListUsers = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 102);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(211, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách người dùng";
            // 
            // dataGridView_ListUsers
            // 
            this.dataGridView_ListUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ListUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_ListUsers.Location = new System.Drawing.Point(0, 102);
            this.dataGridView_ListUsers.Name = "dataGridView_ListUsers";
            this.dataGridView_ListUsers.RowHeadersWidth = 62;
            this.dataGridView_ListUsers.RowTemplate.Height = 33;
            this.dataGridView_ListUsers.Size = new System.Drawing.Size(800, 348);
            this.dataGridView_ListUsers.TabIndex = 1;
            // 
            // Form_ShowUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView_ListUsers);
            this.Controls.Add(this.panel1);
            this.Name = "Form_ShowUsers";
            this.Text = "Form_ShowUsers";
            this.Load += new System.EventHandler(this.Form_ShowUsers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dataGridView_ListUsers;
    }
}