namespace PH1.BacSi
{
    partial class Form_HSBA_DV
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_HSBA = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HSBA)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(360, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(618, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "HỒ SƠ BỆNH ÁN DỊCH VỤ";
            // 
            // dgv_HSBA
            // 
            this.dgv_HSBA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HSBA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_HSBA.Location = new System.Drawing.Point(0, 181);
            this.dgv_HSBA.Name = "dgv_HSBA";
            this.dgv_HSBA.RowHeadersWidth = 62;
            this.dgv_HSBA.RowTemplate.Height = 33;
            this.dgv_HSBA.Size = new System.Drawing.Size(1353, 756);
            this.dgv_HSBA.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1353, 181);
            this.panel1.TabIndex = 2;
            // 
            // Form_HSBA_DV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 937);
            this.Controls.Add(this.dgv_HSBA);
            this.Controls.Add(this.panel1);
            this.Name = "Form_HSBA_DV";
            this.Text = "Form_HSBA_DV";
            this.Load += new System.EventHandler(this.Form_HSBA_DV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HSBA)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private DataGridView dgv_HSBA;
        private Panel panel1;
    }
}