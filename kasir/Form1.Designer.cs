namespace kasir
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.sidePanel = new System.Windows.Forms.Panel();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.transaksiPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_bayar = new System.Windows.Forms.Button();
            this.dgv_keranjang = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rtbKeterangan = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_list_barang = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cari = new System.Windows.Forms.Button();
            this.tb_cari_nama = new System.Windows.Forms.TextBox();
            this.tb_cari_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mainTopPanel = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.totalPanel = new System.Windows.Forms.Panel();
            this.lbTotal_ = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.dtpTanggal = new System.Windows.Forms.DateTimePicker();
            this.tbKasir = new System.Windows.Forms.TextBox();
            this.tbNoTransaksi = new System.Windows.Forms.TextBox();
            this.lbTanggal_ = new System.Windows.Forms.Label();
            this.lbKasir_ = new System.Windows.Forms.Label();
            this.lbNoTransaksi_ = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.sidePanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.transaksiPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_keranjang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list_barang)).BeginInit();
            this.panel1.SuspendLayout();
            this.mainTopPanel.SuspendLayout();
            this.totalPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(181)))), ((int)(((byte)(169)))));
            this.sidePanel.Controls.Add(this.label7);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Margin = new System.Windows.Forms.Padding(0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(175, 702);
            this.sidePanel.TabIndex = 3;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.White;
            this.headerPanel.Controls.Add(this.btnMinimize);
            this.headerPanel.Controls.Add(this.btnClose);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.ForeColor = System.Drawing.Color.White;
            this.headerPanel.Location = new System.Drawing.Point(175, 0);
            this.headerPanel.Margin = new System.Windows.Forms.Padding(0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1023, 66);
            this.headerPanel.TabIndex = 4;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimize.BackgroundImage")));
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimize.InitialImage = null;
            this.btnMinimize.Location = new System.Drawing.Point(954, 15);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(15, 35);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.InitialImage = null;
            this.btnClose.Location = new System.Drawing.Point(988, 15);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(15, 35);
            this.btnClose.TabIndex = 2;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // transaksiPanel
            // 
            this.transaksiPanel.Controls.Add(this.panel2);
            this.transaksiPanel.Controls.Add(this.panel1);
            this.transaksiPanel.Controls.Add(this.mainTopPanel);
            this.transaksiPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transaksiPanel.Location = new System.Drawing.Point(175, 66);
            this.transaksiPanel.Margin = new System.Windows.Forms.Padding(0);
            this.transaksiPanel.Name = "transaksiPanel";
            this.transaksiPanel.Size = new System.Drawing.Size(1023, 636);
            this.transaksiPanel.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btn_bayar);
            this.panel2.Controls.Add(this.dgv_keranjang);
            this.panel2.Controls.Add(this.rtbKeterangan);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.dgv_list_barang);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(0, 194);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1023, 442);
            this.panel2.TabIndex = 3;
            // 
            // btn_bayar
            // 
            this.btn_bayar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_bayar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(181)))), ((int)(((byte)(169)))));
            this.btn_bayar.FlatAppearance.BorderSize = 0;
            this.btn_bayar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bayar.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bayar.ForeColor = System.Drawing.Color.White;
            this.btn_bayar.Location = new System.Drawing.Point(875, 390);
            this.btn_bayar.Name = "btn_bayar";
            this.btn_bayar.Size = new System.Drawing.Size(105, 40);
            this.btn_bayar.TabIndex = 3;
            this.btn_bayar.Text = "Bayar";
            this.btn_bayar.UseVisualStyleBackColor = false;
            this.btn_bayar.Click += new System.EventHandler(this.btn_bayar_Click);
            // 
            // dgv_keranjang
            // 
            this.dgv_keranjang.AllowUserToAddRows = false;
            this.dgv_keranjang.AllowUserToDeleteRows = false;
            this.dgv_keranjang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_keranjang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_keranjang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_keranjang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_keranjang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Nama,
            this.Harga,
            this.qty,
            this.subtotal});
            this.dgv_keranjang.Location = new System.Drawing.Point(381, 38);
            this.dgv_keranjang.MultiSelect = false;
            this.dgv_keranjang.Name = "dgv_keranjang";
            this.dgv_keranjang.ReadOnly = true;
            this.dgv_keranjang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_keranjang.Size = new System.Drawing.Size(599, 326);
            this.dgv_keranjang.TabIndex = 2;
            this.dgv_keranjang.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_keranjang_CellDoubleClick);
            this.dgv_keranjang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv_keranjang_KeyDown);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // Nama
            // 
            this.Nama.HeaderText = "Nama";
            this.Nama.Name = "Nama";
            this.Nama.ReadOnly = true;
            // 
            // Harga
            // 
            this.Harga.HeaderText = "Harga";
            this.Harga.Name = "Harga";
            this.Harga.ReadOnly = true;
            // 
            // qty
            // 
            this.qty.HeaderText = "qty";
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "Sub Total";
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            // 
            // rtbKeterangan
            // 
            this.rtbKeterangan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbKeterangan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbKeterangan.Location = new System.Drawing.Point(103, 370);
            this.rtbKeterangan.Name = "rtbKeterangan";
            this.rtbKeterangan.Size = new System.Drawing.Size(272, 60);
            this.rtbKeterangan.TabIndex = 1;
            this.rtbKeterangan.Text = "";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.label6.Location = new System.Drawing.Point(378, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Keranjang";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.label5.Location = new System.Drawing.Point(3, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "List Barang";
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
            this.dgv_list_barang.Location = new System.Drawing.Point(4, 38);
            this.dgv_list_barang.MultiSelect = false;
            this.dgv_list_barang.Name = "dgv_list_barang";
            this.dgv_list_barang.ReadOnly = true;
            this.dgv_list_barang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_list_barang.Size = new System.Drawing.Size(371, 326);
            this.dgv_list_barang.TabIndex = 0;
            this.dgv_list_barang.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_list_CellDoubleClick);
            this.dgv_list_barang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv_list_barang_KeyDown);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Keterangan";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_cari);
            this.panel1.Controls.Add(this.tb_cari_nama);
            this.panel1.Controls.Add(this.tb_cari_id);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 137);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1023, 57);
            this.panel1.TabIndex = 2;
            // 
            // btn_cari
            // 
            this.btn_cari.Location = new System.Drawing.Point(431, 19);
            this.btn_cari.Name = "btn_cari";
            this.btn_cari.Size = new System.Drawing.Size(75, 23);
            this.btn_cari.TabIndex = 3;
            this.btn_cari.Text = "Cari";
            this.btn_cari.UseVisualStyleBackColor = true;
            this.btn_cari.Click += new System.EventHandler(this.btn_cari_Click);
            // 
            // tb_cari_nama
            // 
            this.tb_cari_nama.Location = new System.Drawing.Point(238, 22);
            this.tb_cari_nama.Name = "tb_cari_nama";
            this.tb_cari_nama.Size = new System.Drawing.Size(157, 20);
            this.tb_cari_nama.TabIndex = 2;
            this.tb_cari_nama.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_cari_KeyDown);
            // 
            // tb_cari_id
            // 
            this.tb_cari_id.Location = new System.Drawing.Point(79, 22);
            this.tb_cari_id.Name = "tb_cari_id";
            this.tb_cari_id.Size = new System.Drawing.Size(153, 20);
            this.tb_cari_id.TabIndex = 1;
            this.tb_cari_id.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_cari_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.label1.Location = new System.Drawing.Point(19, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cari";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.label3.Location = new System.Drawing.Point(236, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.label2.Location = new System.Drawing.Point(76, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Barcode";
            // 
            // mainTopPanel
            // 
            this.mainTopPanel.Controls.Add(this.checkBox1);
            this.mainTopPanel.Controls.Add(this.totalPanel);
            this.mainTopPanel.Controls.Add(this.dtpTanggal);
            this.mainTopPanel.Controls.Add(this.tbKasir);
            this.mainTopPanel.Controls.Add(this.tbNoTransaksi);
            this.mainTopPanel.Controls.Add(this.lbTanggal_);
            this.mainTopPanel.Controls.Add(this.lbKasir_);
            this.mainTopPanel.Controls.Add(this.lbNoTransaksi_);
            this.mainTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainTopPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTopPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainTopPanel.Name = "mainTopPanel";
            this.mainTopPanel.Size = new System.Drawing.Size(1023, 137);
            this.mainTopPanel.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(116, 109);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(93, 18);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Isi Otomatis";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // totalPanel
            // 
            this.totalPanel.BackColor = System.Drawing.Color.Transparent;
            this.totalPanel.Controls.Add(this.lbTotal_);
            this.totalPanel.Controls.Add(this.lbTotal);
            this.totalPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.totalPanel.Location = new System.Drawing.Point(673, 0);
            this.totalPanel.Margin = new System.Windows.Forms.Padding(0);
            this.totalPanel.Name = "totalPanel";
            this.totalPanel.Size = new System.Drawing.Size(350, 137);
            this.totalPanel.TabIndex = 3;
            // 
            // lbTotal_
            // 
            this.lbTotal_.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTotal_.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal_.Location = new System.Drawing.Point(0, 0);
            this.lbTotal_.Name = "lbTotal_";
            this.lbTotal_.Size = new System.Drawing.Size(350, 57);
            this.lbTotal_.TabIndex = 1;
            this.lbTotal_.Text = "Total";
            this.lbTotal_.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTotal
            // 
            this.lbTotal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbTotal.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(0, 0);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(350, 137);
            this.lbTotal.TabIndex = 1;
            this.lbTotal.Text = "0,00";
            this.lbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpTanggal
            // 
            this.dtpTanggal.Enabled = false;
            this.dtpTanggal.Location = new System.Drawing.Point(116, 83);
            this.dtpTanggal.Name = "dtpTanggal";
            this.dtpTanggal.Size = new System.Drawing.Size(171, 20);
            this.dtpTanggal.TabIndex = 2;
            // 
            // tbKasir
            // 
            this.tbKasir.Enabled = false;
            this.tbKasir.Location = new System.Drawing.Point(116, 52);
            this.tbKasir.Name = "tbKasir";
            this.tbKasir.Size = new System.Drawing.Size(171, 20);
            this.tbKasir.TabIndex = 1;
            // 
            // tbNoTransaksi
            // 
            this.tbNoTransaksi.Enabled = false;
            this.tbNoTransaksi.Location = new System.Drawing.Point(116, 23);
            this.tbNoTransaksi.Name = "tbNoTransaksi";
            this.tbNoTransaksi.Size = new System.Drawing.Size(171, 20);
            this.tbNoTransaksi.TabIndex = 1;
            // 
            // lbTanggal_
            // 
            this.lbTanggal_.AutoSize = true;
            this.lbTanggal_.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTanggal_.Location = new System.Drawing.Point(16, 83);
            this.lbTanggal_.Name = "lbTanggal_";
            this.lbTanggal_.Size = new System.Drawing.Size(61, 16);
            this.lbTanggal_.TabIndex = 1;
            this.lbTanggal_.Text = "Tanggal";
            // 
            // lbKasir_
            // 
            this.lbKasir_.AutoSize = true;
            this.lbKasir_.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKasir_.Location = new System.Drawing.Point(16, 53);
            this.lbKasir_.Name = "lbKasir_";
            this.lbKasir_.Size = new System.Drawing.Size(41, 16);
            this.lbKasir_.TabIndex = 1;
            this.lbKasir_.Text = "Kasir";
            // 
            // lbNoTransaksi_
            // 
            this.lbNoTransaksi_.AutoSize = true;
            this.lbNoTransaksi_.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNoTransaksi_.Location = new System.Drawing.Point(16, 23);
            this.lbNoTransaksi_.Name = "lbNoTransaksi_";
            this.lbNoTransaksi_.Size = new System.Drawing.Size(94, 16);
            this.lbNoTransaksi_.TabIndex = 1;
            this.lbNoTransaksi_.Text = "No Transaksi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(43, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "SiKasir";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 702);
            this.ControlBox = false;
            this.Controls.Add(this.transaksiPanel);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.sidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "mainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.sidePanel.ResumeLayout(false);
            this.sidePanel.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.transaksiPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_keranjang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list_barang)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.mainTopPanel.ResumeLayout(false);
            this.mainTopPanel.PerformLayout();
            this.totalPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel transaksiPanel;
        private System.Windows.Forms.Panel mainTopPanel;
        private System.Windows.Forms.Panel totalPanel;
        private System.Windows.Forms.Label lbTotal_;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.DateTimePicker dtpTanggal;
        private System.Windows.Forms.TextBox tbKasir;
        private System.Windows.Forms.TextBox tbNoTransaksi;
        private System.Windows.Forms.Label lbTanggal_;
        private System.Windows.Forms.Label lbKasir_;
        private System.Windows.Forms.Label lbNoTransaksi_;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_cari_nama;
        private System.Windows.Forms.TextBox tb_cari_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv_list_barang;
        private System.Windows.Forms.RichTextBox rtbKeterangan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_cari;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargajualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgv_keranjang;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Harga;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.Button btn_bayar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
    }
}

