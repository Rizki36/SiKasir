using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Microsoft.VisualBasic;
using System.Globalization;
using kasir.Resources;

namespace kasir
{
    public partial class mainForm : Form
    {

        string pembeli_id = "pembeli-1";
        double total_harga = 0;

        public mainForm()
        {
            InitializeComponent();
        }

        /**
         * Mengenerate id dari tanggal sekarang + no transaksi
         * MenSet tbNoTransaksi dengan generated id
         **/
        

        private void Form1_Load(object sender, EventArgs e)
        {
            barangLayer1.Enabled = true;
            penjualanLayer1.Enabled = false;
            barangLayer1.BringToFront();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            bool penjualan = penjualanLayer1.Enabled;

            if (penjualan && e.Control && e.KeyCode == Keys.F)
            {
                penjualanLayer1.tb_cari_id_focus();
            }

            if (penjualan && e.Control && e.KeyCode == Keys.Enter)
            {
                penjualanLayer1.bayar();
            }

            if (penjualan && e.Control && e.KeyCode == Keys.L)
            {
                penjualanLayer1.dgv_list_barang_focus();
            }

            if (penjualan && e.Control && e.KeyCode == Keys.K)
            {
                penjualanLayer1.dgv_keranjang_focus();
            }

        }

        private void btnBarang_Click(object sender, EventArgs e)
        {
            activePanel.Top = btn_barang.Top;
            activePanel.Height = btn_barang.Height;
            barangLayer1.load_data();
            barangLayer1.BringToFront();
            barangLayer1.Enabled = true;
            penjualanLayer1.Enabled = riwayatLayer1.Enabled = false;
        }

        private void btnPenjualan_Click(object sender, EventArgs e)
        {
            activePanel.Top = btn_penjualan.Top;
            activePanel.Height = btn_penjualan.Height;
            penjualanLayer1.load_data();
            penjualanLayer1.BringToFront();
            penjualanLayer1.Enabled = true;
            barangLayer1.Enabled = riwayatLayer1.Enabled = false;
        }

        private void btn_riwayat_Click(object sender, EventArgs e)
        {
            activePanel.Top = btn_riwayat.Top;
            activePanel.Height = btn_riwayat.Height;
            riwayatLayer1.load_data();
            riwayatLayer1.BringToFront();
            riwayatLayer1.Enabled = true;
            barangLayer1.Enabled = penjualanLayer1.Enabled = false;
        }
    }
}
