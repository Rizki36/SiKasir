namespace kasir
{
    partial class RiwayatLayer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbNoTransaksi_ = new System.Windows.Forms.Label();
            this.dgv_list_penjualan = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list_penjualan)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNoTransaksi_
            // 
            this.lbNoTransaksi_.AutoSize = true;
            this.lbNoTransaksi_.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNoTransaksi_.Location = new System.Drawing.Point(5, 19);
            this.lbNoTransaksi_.Name = "lbNoTransaksi_";
            this.lbNoTransaksi_.Size = new System.Drawing.Size(239, 29);
            this.lbNoTransaksi_.TabIndex = 4;
            this.lbNoTransaksi_.Text = "Riwayat Penjualan";
            // 
            // dgv_list_penjualan
            // 
            this.dgv_list_penjualan.AllowUserToAddRows = false;
            this.dgv_list_penjualan.AllowUserToDeleteRows = false;
            this.dgv_list_penjualan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_list_penjualan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_list_penjualan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_list_penjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_list_penjualan.Location = new System.Drawing.Point(10, 67);
            this.dgv_list_penjualan.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.dgv_list_penjualan.MultiSelect = false;
            this.dgv_list_penjualan.Name = "dgv_list_penjualan";
            this.dgv_list_penjualan.ReadOnly = true;
            this.dgv_list_penjualan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_list_penjualan.Size = new System.Drawing.Size(1008, 477);
            this.dgv_list_penjualan.TabIndex = 7;
            this.dgv_list_penjualan.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_list_penjualan_CellMouseDoubleClick);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.label7.Location = new System.Drawing.Point(7, 547);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(301, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "*Double click untuk melihat detail Penjualan";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RiwayatLayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgv_list_penjualan);
            this.Controls.Add(this.lbNoTransaksi_);
            this.Name = "RiwayatLayer";
            this.Size = new System.Drawing.Size(1028, 588);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list_penjualan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNoTransaksi_;
        private System.Windows.Forms.DataGridView dgv_list_penjualan;
        private System.Windows.Forms.Label label7;
    }
}
