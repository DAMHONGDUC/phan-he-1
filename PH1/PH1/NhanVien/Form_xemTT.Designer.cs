namespace PH1.NhanVien
{
    partial class Form_xemTT
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
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dGV_2 = new System.Windows.Forms.DataGridView();
            this.btn_xem1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dGV_1 = new System.Windows.Forms.DataGridView();
            this.cbox_bang1 = new System.Windows.Forms.ComboBox();
            this.cbox_bang2 = new System.Windows.Forms.ComboBox();
            this.btn_xem2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(-6, 378);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 29;
            this.dataGridView3.Size = new System.Drawing.Size(1014, 2);
            this.dataGridView3.TabIndex = 19;
            // 
            // dGV_2
            // 
            this.dGV_2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_2.Location = new System.Drawing.Point(33, 438);
            this.dGV_2.Name = "dGV_2";
            this.dGV_2.RowHeadersWidth = 51;
            this.dGV_2.RowTemplate.Height = 29;
            this.dGV_2.Size = new System.Drawing.Size(831, 297);
            this.dGV_2.TabIndex = 15;
            // 
            // btn_xem1
            // 
            this.btn_xem1.Location = new System.Drawing.Point(324, 20);
            this.btn_xem1.Name = "btn_xem1";
            this.btn_xem1.Size = new System.Drawing.Size(116, 36);
            this.btn_xem1.TabIndex = 13;
            this.btn_xem1.Text = "Xem";
            this.btn_xem1.UseVisualStyleBackColor = true;
            this.btn_xem1.Click += new System.EventHandler(this.btn_xem1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(43, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 28);
            this.label1.TabIndex = 12;
            this.label1.Text = "Chọn bảng";
            // 
            // dGV_1
            // 
            this.dGV_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_1.Location = new System.Drawing.Point(33, 62);
            this.dGV_1.Name = "dGV_1";
            this.dGV_1.RowHeadersWidth = 51;
            this.dGV_1.RowTemplate.Height = 29;
            this.dGV_1.Size = new System.Drawing.Size(831, 297);
            this.dGV_1.TabIndex = 11;
            // 
            // cbox_bang1
            // 
            this.cbox_bang1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbox_bang1.FormattingEnabled = true;
            this.cbox_bang1.Items.AddRange(new object[] {
            "HSBA_DV",
            "HSBA",
            "NHANVIEN",
            "BENHNHAN",
            "KHOA",
            "CSYT"});
            this.cbox_bang1.Location = new System.Drawing.Point(157, 20);
            this.cbox_bang1.Name = "cbox_bang1";
            this.cbox_bang1.Size = new System.Drawing.Size(151, 36);
            this.cbox_bang1.TabIndex = 21;
            // 
            // cbox_bang2
            // 
            this.cbox_bang2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbox_bang2.FormattingEnabled = true;
            this.cbox_bang2.Items.AddRange(new object[] {
            "HSBA_DV",
            "HSBA",
            "NHANVIEN",
            "BENHNHAN",
            "KHOA",
            "CSYT"});
            this.cbox_bang2.Location = new System.Drawing.Point(157, 396);
            this.cbox_bang2.Name = "cbox_bang2";
            this.cbox_bang2.Size = new System.Drawing.Size(151, 36);
            this.cbox_bang2.TabIndex = 24;
            // 
            // btn_xem2
            // 
            this.btn_xem2.Location = new System.Drawing.Point(324, 396);
            this.btn_xem2.Name = "btn_xem2";
            this.btn_xem2.Size = new System.Drawing.Size(116, 36);
            this.btn_xem2.TabIndex = 23;
            this.btn_xem2.Text = "Xem";
            this.btn_xem2.UseVisualStyleBackColor = true;
            this.btn_xem2.Click += new System.EventHandler(this.btn_xem2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(43, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 28);
            this.label2.TabIndex = 22;
            this.label2.Text = "Chọn bảng";
            // 
            // Form_xemTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(920, 776);
            this.Controls.Add(this.cbox_bang2);
            this.Controls.Add(this.btn_xem2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbox_bang1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dGV_2);
            this.Controls.Add(this.btn_xem1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dGV_1);
            this.Name = "Form_xemTT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_xemTT";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView3;
        private DataGridView dGV_2;
        private Button btn_xem1;
        private Label label1;
        private DataGridView dGV_1;
        private ComboBox cbox_bang1;
        private ComboBox cbox_bang2;
        private Button btn_xem2;
        private Label label2;
    }
}