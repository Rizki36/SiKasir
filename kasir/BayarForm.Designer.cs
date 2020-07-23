namespace kasir.Resources
{
    partial class formDialog
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
            this.btnCetak = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKembali = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCetak
            // 
            this.btnCetak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(181)))), ((int)(((byte)(169)))));
            this.btnCetak.FlatAppearance.BorderSize = 0;
            this.btnCetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCetak.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCetak.ForeColor = System.Drawing.Color.Black;
            this.btnCetak.Location = new System.Drawing.Point(129, 222);
            this.btnCetak.Name = "btnCetak";
            this.btnCetak.Size = new System.Drawing.Size(104, 47);
            this.btnCetak.TabIndex = 1;
            this.btnCetak.Text = "Cetak";
            this.btnCetak.UseVisualStyleBackColor = false;
            this.btnCetak.Click += new System.EventHandler(this.btnCetak_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pembayaran Berhasil";
            // 
            // btnKembali
            // 
            this.btnKembali.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(181)))), ((int)(((byte)(169)))));
            this.btnKembali.FlatAppearance.BorderSize = 0;
            this.btnKembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKembali.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKembali.ForeColor = System.Drawing.Color.Black;
            this.btnKembali.Location = new System.Drawing.Point(262, 222);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(104, 47);
            this.btnKembali.TabIndex = 2;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = false;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // formDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 357);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.btnCetak);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button btnCetak;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKembali;
    }
}