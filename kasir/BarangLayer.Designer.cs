namespace kasir
{
    partial class BarangLayer
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
            this.tb_id = new System.Windows.Forms.TextBox();
            this.lbNoTransaksi_ = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_nama_barang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_harga_jual = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_stok = new System.Windows.Forms.TextBox();
            this.dgv_list_barang = new System.Windows.Forms.DataGridView();
            this.btn_tambah = new System.Windows.Forms.Button();
            this.tb_id_lama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_ubah = new System.Windows.Forms.Button();
            this.btn_batal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list_barang)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(113, 29);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(171, 20);
            this.tb_id.TabIndex = 1;
            // 
            // lbNoTransaksi_
            // 
            this.lbNoTransaksi_.AutoSize = true;
            this.lbNoTransaksi_.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNoTransaksi_.Location = new System.Drawing.Point(13, 29);
            this.lbNoTransaksi_.Name = "lbNoTransaksi_";
            this.lbNoTransaksi_.Size = new System.Drawing.Size(73, 16);
            this.lbNoTransaksi_.TabIndex = 3;
            this.lbNoTransaksi_.Text = "ID Barang";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nama Barang";
            // 
            // tb_nama_barang
            // 
            this.tb_nama_barang.Location = new System.Drawing.Point(113, 55);
            this.tb_nama_barang.Name = "tb_nama_barang";
            this.tb_nama_barang.Size = new System.Drawing.Size(171, 20);
            this.tb_nama_barang.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Harga jual";
            // 
            // tb_harga_jual
            // 
            this.tb_harga_jual.Location = new System.Drawing.Point(113, 81);
            this.tb_harga_jual.Name = "tb_harga_jual";
            this.tb_harga_jual.Size = new System.Drawing.Size(171, 20);
            this.tb_harga_jual.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Stok";
            // 
            // tb_stok
            // 
            this.tb_stok.Location = new System.Drawing.Point(113, 107);
            this.tb_stok.Name = "tb_stok";
            this.tb_stok.Size = new System.Drawing.Size(171, 20);
            this.tb_stok.TabIndex = 4;
            // 
            // dgv_list_barang
            // 
            this.dgv_list_barang.AllowUserToAddRows = false;
            this.dgv_list_barang.AllowUserToDeleteRows = false;
            this.dgv_list_barang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_list_barang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_list_barang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_list_barang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_list_barang.Location = new System.Drawing.Point(16, 165);
            this.dgv_list_barang.MultiSelect = false;
            this.dgv_list_barang.Name = "dgv_list_barang";
            this.dgv_list_barang.ReadOnly = true;
            this.dgv_list_barang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_list_barang.Size = new System.Drawing.Size(989, 396);
            this.dgv_list_barang.TabIndex = 6;
            this.dgv_list_barang.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_list_barang_CellMouseDoubleClick);
            this.dgv_list_barang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv_list_barang_KeyDown);
            // 
            // btn_tambah
            // 
            this.btn_tambah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(181)))), ((int)(((byte)(169)))));
            this.btn_tambah.FlatAppearance.BorderSize = 0;
            this.btn_tambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tambah.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tambah.ForeColor = System.Drawing.Color.White;
            this.btn_tambah.Location = new System.Drawing.Point(302, 87);
            this.btn_tambah.Name = "btn_tambah";
            this.btn_tambah.Size = new System.Drawing.Size(105, 40);
            this.btn_tambah.TabIndex = 5;
            this.btn_tambah.Text = "Tambah";
            this.btn_tambah.UseVisualStyleBackColor = false;
            this.btn_tambah.Click += new System.EventHandler(this.btn_tambah_Click);
            // 
            // tb_id_lama
            // 
            this.tb_id_lama.Enabled = false;
            this.tb_id_lama.Location = new System.Drawing.Point(303, 29);
            this.tb_id_lama.Name = "tb_id_lama";
            this.tb_id_lama.Size = new System.Drawing.Size(157, 20);
            this.tb_id_lama.TabIndex = 0;
            this.tb_id_lama.TabStop = false;
            this.tb_id_lama.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(300, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "ID Barang Lama(Hiden)";
            this.label4.Visible = false;
            // 
            // btn_ubah
            // 
            this.btn_ubah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(181)))), ((int)(((byte)(169)))));
            this.btn_ubah.FlatAppearance.BorderSize = 0;
            this.btn_ubah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ubah.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ubah.ForeColor = System.Drawing.Color.White;
            this.btn_ubah.Location = new System.Drawing.Point(413, 87);
            this.btn_ubah.Name = "btn_ubah";
            this.btn_ubah.Size = new System.Drawing.Size(105, 40);
            this.btn_ubah.TabIndex = 5;
            this.btn_ubah.Text = "Ubah";
            this.btn_ubah.UseVisualStyleBackColor = false;
            this.btn_ubah.Visible = false;
            this.btn_ubah.Click += new System.EventHandler(this.btn_ubah_Click);
            // 
            // btn_batal
            // 
            this.btn_batal.BackColor = System.Drawing.Color.Silver;
            this.btn_batal.FlatAppearance.BorderSize = 0;
            this.btn_batal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_batal.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_batal.ForeColor = System.Drawing.Color.White;
            this.btn_batal.Location = new System.Drawing.Point(524, 87);
            this.btn_batal.Name = "btn_batal";
            this.btn_batal.Size = new System.Drawing.Size(105, 40);
            this.btn_batal.TabIndex = 5;
            this.btn_batal.Text = "Batal";
            this.btn_batal.UseVisualStyleBackColor = false;
            this.btn_batal.Visible = false;
            this.btn_batal.Click += new System.EventHandler(this.btn_batal_Click);
            // 
            // BarangLayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_batal);
            this.Controls.Add(this.btn_ubah);
            this.Controls.Add(this.btn_tambah);
            this.Controls.Add(this.dgv_list_barang);
            this.Controls.Add(this.tb_stok);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_harga_jual);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_nama_barang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_id_lama);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbNoTransaksi_);
            this.Name = "BarangLayer";
            this.Size = new System.Drawing.Size(1028, 588);
            this.Load += new System.EventHandler(this.BarangLayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list_barang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label lbNoTransaksi_;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nama_barang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_harga_jual;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_stok;
        private System.Windows.Forms.DataGridView dgv_list_barang;
        private System.Windows.Forms.Button btn_tambah;
        private System.Windows.Forms.TextBox tb_id_lama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_ubah;
        private System.Windows.Forms.Button btn_batal;
    }
}
