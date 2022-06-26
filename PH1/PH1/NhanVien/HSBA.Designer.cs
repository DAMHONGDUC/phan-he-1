namespace PH1.NhanVien
{
    partial class HSBA
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
            this.dgv_hsba = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hsba)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_hsba
            // 
            this.dgv_hsba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hsba.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_hsba.Location = new System.Drawing.Point(0, 84);
            this.dgv_hsba.Name = "dgv_hsba";
            this.dgv_hsba.RowTemplate.Height = 25;
            this.dgv_hsba.Size = new System.Drawing.Size(800, 366);
            this.dgv_hsba.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(138, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(515, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH SÁCH HỒ SƠ BỆNH ÁN";
            // 
            // HSBA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_hsba);
            this.Name = "HSBA";
            this.Text = "HSBA";
            this.Load += new System.EventHandler(this.HSBA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hsba)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgv_hsba;
        private Label label1;
    }
}