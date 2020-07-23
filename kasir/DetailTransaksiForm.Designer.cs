namespace kasir.Resources
{
    partial class DetailTransaksiForm
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
            this.dgv_detail_penjualan = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_id_transaksi = new System.Windows.Forms.Label();
            this.btnKembali = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detail_penjualan)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_detail_penjualan
            // 
            this.dgv_detail_penjualan.AllowUserToAddRows = false;
            this.dgv_detail_penjualan.AllowUserToDeleteRows = false;
            this.dgv_detail_penjualan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_detail_penjualan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_detail_penjualan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_detail_penjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_detail_penjualan.Location = new System.Drawing.Point(12, 100);
            this.dgv_detail_penjualan.MultiSelect = false;
            this.dgv_detail_penjualan.Name = "dgv_detail_penjualan";
            this.dgv_detail_penjualan.ReadOnly = true;
            this.dgv_detail_penjualan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_detail_penjualan.Size = new System.Drawing.Size(895, 417);
            this.dgv_detail_penjualan.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Detail Transaksi";
            // 
            // lb_id_transaksi
            // 
            this.lb_id_transaksi.AutoSize = true;
            this.lb_id_transaksi.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_id_transaksi.Location = new System.Drawing.Point(13, 52);
            this.lb_id_transaksi.Name = "lb_id_transaksi";
            this.lb_id_transaksi.Size = new System.Drawing.Size(88, 23);
            this.lb_id_transaksi.TabIndex = 8;
            this.lb_id_transaksi.Text = "000000";
            // 
            // btnKembali
            // 
            this.btnKembali.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKembali.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(181)))), ((int)(((byte)(169)))));
            this.btnKembali.FlatAppearance.BorderSize = 0;
            this.btnKembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKembali.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKembali.ForeColor = System.Drawing.Color.White;
            this.btnKembali.Location = new System.Drawing.Point(803, 28);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(104, 47);
            this.btnKembali.TabIndex = 9;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = false;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // DetailTransaksiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(919, 529);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.lb_id_transaksi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_detail_penjualan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DetailTransaksiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detail_penjualan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridView dgv_detail_penjualan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_id_transaksi;
        private System.Windows.Forms.Button btnKembali;
    }
}