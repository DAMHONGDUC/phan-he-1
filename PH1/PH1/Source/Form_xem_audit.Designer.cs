namespace PH1.Source
{
    partial class Form_xem_audit
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
            this.cbox_2 = new System.Windows.Forms.ComboBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_xem2 = new System.Windows.Forms.Button();
            this.btn_xem1 = new System.Windows.Forms.Button();
            this.cbox_1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // cbox_2
            // 
            this.cbox_2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbox_2.FormattingEnabled = true;
            this.cbox_2.Items.AddRange(new object[] {
            "HSBA_DV",
            "HSBA",
            "NHANVIEN",
            "BENHNHAN",
            "KHOA",
            "CSYT"});
            this.cbox_2.Location = new System.Drawing.Point(483, 97);
            this.cbox_2.Name = "cbox_2";
            this.cbox_2.Size = new System.Drawing.Size(186, 36);
            this.cbox_2.TabIndex = 0;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(41, 183);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 29;
            this.dgv.Size = new System.Drawing.Size(828, 620);
            this.dgv.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(119, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fine Grained Audit";
            // 
            // btn_xem2
            // 
            this.btn_xem2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_xem2.Location = new System.Drawing.Point(675, 97);
            this.btn_xem2.Name = "btn_xem2";
            this.btn_xem2.Size = new System.Drawing.Size(82, 35);
            this.btn_xem2.TabIndex = 3;
            this.btn_xem2.Text = "Xem";
            this.btn_xem2.UseVisualStyleBackColor = true;
            this.btn_xem2.Click += new System.EventHandler(this.btn_xem2_Click);
            // 
            // btn_xem1
            // 
            this.btn_xem1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_xem1.Location = new System.Drawing.Point(328, 98);
            this.btn_xem1.Name = "btn_xem1";
            this.btn_xem1.Size = new System.Drawing.Size(82, 35);
            this.btn_xem1.TabIndex = 5;
            this.btn_xem1.Text = "Xem";
            this.btn_xem1.UseVisualStyleBackColor = true;
            this.btn_xem1.Click += new System.EventHandler(this.btn_xem1_Click);
            // 
            // cbox_1
            // 
            this.cbox_1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbox_1.FormattingEnabled = true;
            this.cbox_1.Items.AddRange(new object[] {
            "HSBA (KETLUAN)",
            "HSBA_DV (KETQUA)",
            "NHANVIEN (CMND)"});
            this.cbox_1.Location = new System.Drawing.Point(119, 98);
            this.cbox_1.Name = "cbox_1";
            this.cbox_1.Size = new System.Drawing.Size(194, 36);
            this.cbox_1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(483, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Standard Audit";
            // 
            // Form_xem_audit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(917, 840);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_xem1);
            this.Controls.Add(this.cbox_1);
            this.Controls.Add(this.btn_xem2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.cbox_2);
            this.Name = "Form_xem_audit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_xem_audit";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbox_2;
        private DataGridView dgv;
        private Label label1;
        private Button btn_xem2;
        private Button btn_xem1;
        private ComboBox cbox_1;
        private Label label2;
    }
}