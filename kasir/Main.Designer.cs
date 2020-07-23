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
            this.activePanel = new System.Windows.Forms.Panel();
            this.btn_riwayat = new System.Windows.Forms.Button();
            this.btn_penjualan = new System.Windows.Forms.Button();
            this.btn_barang = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.barangLayer1 = new kasir.BarangLayer();
            this.penjualanLayer1 = new kasir.PenjualanLayer();
            this.riwayatLayer1 = new kasir.RiwayatLayer();
            this.sidePanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(181)))), ((int)(((byte)(169)))));
            this.sidePanel.Controls.Add(this.activePanel);
            this.sidePanel.Controls.Add(this.btn_riwayat);
            this.sidePanel.Controls.Add(this.btn_penjualan);
            this.sidePanel.Controls.Add(this.btn_barang);
            this.sidePanel.Controls.Add(this.label8);
            this.sidePanel.Controls.Add(this.label7);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Margin = new System.Windows.Forms.Padding(0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(175, 702);
            this.sidePanel.TabIndex = 3;
            // 
            // activePanel
            // 
            this.activePanel.BackColor = System.Drawing.Color.White;
            this.activePanel.Location = new System.Drawing.Point(0, 106);
            this.activePanel.Margin = new System.Windows.Forms.Padding(0);
            this.activePanel.Name = "activePanel";
            this.activePanel.Size = new System.Drawing.Size(10, 37);
            this.activePanel.TabIndex = 0;
            // 
            // btn_riwayat
            // 
            this.btn_riwayat.FlatAppearance.BorderSize = 0;
            this.btn_riwayat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_riwayat.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_riwayat.ForeColor = System.Drawing.Color.White;
            this.btn_riwayat.Location = new System.Drawing.Point(3, 192);
            this.btn_riwayat.Name = "btn_riwayat";
            this.btn_riwayat.Size = new System.Drawing.Size(172, 37);
            this.btn_riwayat.TabIndex = 2;
            this.btn_riwayat.Text = "Riwayat";
            this.btn_riwayat.UseVisualStyleBackColor = true;
            this.btn_riwayat.Click += new System.EventHandler(this.btn_riwayat_Click);
            // 
            // btn_penjualan
            // 
            this.btn_penjualan.FlatAppearance.BorderSize = 0;
            this.btn_penjualan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_penjualan.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_penjualan.ForeColor = System.Drawing.Color.White;
            this.btn_penjualan.Location = new System.Drawing.Point(3, 149);
            this.btn_penjualan.Name = "btn_penjualan";
            this.btn_penjualan.Size = new System.Drawing.Size(172, 37);
            this.btn_penjualan.TabIndex = 2;
            this.btn_penjualan.Text = "Penjualan";
            this.btn_penjualan.UseVisualStyleBackColor = true;
            this.btn_penjualan.Click += new System.EventHandler(this.btnPenjualan_Click);
            // 
            // btn_barang
            // 
            this.btn_barang.FlatAppearance.BorderSize = 0;
            this.btn_barang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_barang.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_barang.ForeColor = System.Drawing.Color.White;
            this.btn_barang.Location = new System.Drawing.Point(3, 106);
            this.btn_barang.Margin = new System.Windows.Forms.Padding(0);
            this.btn_barang.Name = "btn_barang";
            this.btn_barang.Size = new System.Drawing.Size(172, 37);
            this.btn_barang.TabIndex = 2;
            this.btn_barang.Text = "Barang";
            this.btn_barang.UseVisualStyleBackColor = true;
            this.btn_barang.Click += new System.EventHandler(this.btnBarang_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(60, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Master";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(44, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "SiKasir";
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
            this.btnMinimize.Location = new System.Drawing.Point(930, 21);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(20, 20);
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
            this.btnClose.Location = new System.Drawing.Point(977, 21);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.TabIndex = 2;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.barangLayer1);
            this.mainPanel.Controls.Add(this.penjualanLayer1);
            this.mainPanel.Controls.Add(this.riwayatLayer1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(175, 66);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1023, 636);
            this.mainPanel.TabIndex = 5;
            // 
            // barangLayer1
            // 
            this.barangLayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.barangLayer1.Location = new System.Drawing.Point(0, 0);
            this.barangLayer1.Name = "barangLayer1";
            this.barangLayer1.Size = new System.Drawing.Size(1023, 636);
            this.barangLayer1.TabIndex = 1;
            // 
            // penjualanLayer1
            // 
            this.penjualanLayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.penjualanLayer1.Location = new System.Drawing.Point(0, 0);
            this.penjualanLayer1.Name = "penjualanLayer1";
            this.penjualanLayer1.Size = new System.Drawing.Size(1023, 636);
            this.penjualanLayer1.TabIndex = 0;
            // 
            // riwayatLayer1
            // 
            this.riwayatLayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.riwayatLayer1.Location = new System.Drawing.Point(0, 0);
            this.riwayatLayer1.Name = "riwayatLayer1";
            this.riwayatLayer1.Size = new System.Drawing.Size(1023, 636);
            this.riwayatLayer1.TabIndex = 2;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 702);
            this.ControlBox = false;
            this.Controls.Add(this.mainPanel);
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
            this.sidePanel.ResumeLayout(false);
            this.sidePanel.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargajualDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_penjualan;
        private System.Windows.Forms.Button btn_barang;
        private System.Windows.Forms.Panel activePanel;
        private PenjualanLayer penjualanLayer1;
        private BarangLayer barangLayer1;
        private System.Windows.Forms.Button btn_riwayat;
        private RiwayatLayer riwayatLayer1;
    }
}

