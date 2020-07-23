using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using kasir.Resources;
using System.Globalization;
using Microsoft.VisualBasic;

namespace kasir
{
    public partial class PenjualanLayer : UserControl
    {
        
        string pembeli_id = "pembeli-1";
        double total_harga = 0;
        int length_string_pad = 8;

        public PenjualanLayer()
        {
            InitializeComponent();
        }

        /**
         * Mengenerate id dari tanggal sekarang + no transaksi
         * MenSet tbNoTransaksi dengan generated id
         **/
        public void generateNoTransaksi()
        {
            string id_jadi;
            string date = DateTime.Now.ToString("yyyyMMdd");
            int id;

            CRUD.sql = "SELECT MAX(Cint(Mid(id,9))) FROM penjualan WHERE(((Left([id], 8)) = @date));";
            OleDbCommand cmd = new OleDbCommand(CRUD.sql, CRUD.con);
            cmd.Parameters.AddWithValue("date", date);
            DataTable dt = CRUD.PerformCRUD(cmd);
            if (dt.Rows[0][0].ToString() != string.Empty)
                id = int.Parse(dt.Rows[0][0].ToString()) + 1;
            else
                id = 1;
            id_jadi = date + id.ToString().PadLeft(length_string_pad, '0');
            tbNoTransaksi.Text = id_jadi;
        }

        private void btn_cari_Click(object sender, EventArgs e)
        {
            string id = tb_cari_id.Text;
            string nama = tb_cari_nama.Text;
            load_data(id, nama);
        }

        private void mainLayer_Load(object sender, EventArgs e)
        {
            //load_data();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
                tbKasir.Enabled = tbNoTransaksi.Enabled = dtpTanggal.Enabled = true;
            else
                tbKasir.Enabled = tbNoTransaksi.Enabled = dtpTanggal.Enabled = false;
        }

        private void execute(string sql, string param)
        {
            CRUD.cmd = new OleDbCommand(sql, CRUD.con);
            CRUD.PerformCRUD(CRUD.cmd);
        }

        public void load_data(string id = "", string nama = "")
        {
            CRUD.sql = "SELECT id,nama,harga_jual,stok FROM produk WHERE id LIKE @id AND nama LIKE @nama;";
            CRUD.cmd = new OleDbCommand(CRUD.sql, CRUD.con);

            id = string.Format("%{0}%", id);
            nama = string.Format("%{0}%", nama);

            CRUD.cmd.Parameters.AddWithValue("id", id);
            CRUD.cmd.Parameters.AddWithValue("nama", nama);

            DataTable dt = CRUD.PerformCRUD(CRUD.cmd);

            DataGridView dgv = dgv_list_barang;

            dgv.DataSource = dt;

            //dgv.AutoGenerateColumns = true;

            dgv.Columns[0].HeaderText = "ID Barang";
            dgv.Columns[1].HeaderText = "Nama Barang";
            dgv.Columns[2].HeaderText = "Harga Jual";

            tbKasir.Text = "Kasir-1";
            generateNoTransaksi();
            tb_cari_id.Focus();
        }

        private void dgv_list_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            string id = dgv_list_barang.Rows[e.RowIndex].Cells[0].Value.ToString();
            string nama = dgv_list_barang.Rows[e.RowIndex].Cells[1].Value.ToString();
            double harga = Double.Parse(dgv_list_barang.Rows[e.RowIndex].Cells[2].Value.ToString());

            /** 
             * Tambah barang jika tidak ada di keranjang
             **/

            bool is_in_keranjang = false;
            foreach (DataGridViewRow row in dgv_keranjang.Rows)
            {
                if (row.Cells[0].Value == id)
                {
                    is_in_keranjang = true;
                    MessageBox.Show("Barang sudah ada di keranjang");
                    break;
                }
            }

        // Validasi input qty jika salah
        Pesan:
            if (!is_in_keranjang)
            {
                string message = Interaction.InputBox("Masukkan berapa banyak barang", "Input banyak barang", "1");
                try
                {
                    int qty;
                    qty = int.Parse(message);
                    double subTotal = harga * qty;
                    dgv_keranjang.Rows.Add(id, nama, harga, qty, subTotal);
                    hitung_total();
                }
                catch (Exception)
                {
                    //Jika messagebox klik no
                    if (message != "")
                    {
                        MessageBox.Show("Masukkan angka!");
                        goto Pesan;
                    }
                }

            }

        }

        private void dgv_keranjang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            dgv_keranjang.Rows.RemoveAt(e.RowIndex);
            hitung_total();
        }

        /**
         * Menghitung total harga dari dgv_keranjang
         * MenSet lbTotal.text dengan total harga
         **/
        private void hitung_total()
        {
            total_harga = 0;
            try
            {
                foreach (DataGridViewRow row in dgv_keranjang.Rows)
                {
                    total_harga += double.Parse(row.Cells["subtotal"].Value.ToString());
                }
                CultureInfo culture = CultureInfo.CreateSpecificCulture("id-ID");
                string total_text = string.Format(culture, "{0:C}", Convert.ToDecimal(total_harga));
                lbTotal.Text = total_text;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Terjadi error: " + ex.Message);
            }
        }
        
        public void tb_cari_id_focus()
        {
            tb_cari_id.Focus();
        }

        public void dgv_list_barang_focus()
        {
            dgv_list_barang.Focus();
        }

        public void dgv_keranjang_focus() 
        {
            dgv_keranjang.Focus();
        }


        // cari data ketika user klik enter 
        private void tb_cari_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string id = tb_cari_id.Text;
                string nama = tb_cari_nama.Text;
                load_data(id, nama);
            }
        }

        private void insert_penjualan()
        {
            try
            {
                string noTransaksi = tbNoTransaksi.Text;
                string kasir_id = tbKasir.Text;
                string keterangan = rtbKeterangan.Text;

                CRUD.sql = "INSERT INTO penjualan (id,pembeli_id,kasir_id,total_harga,keterangan,tanggal) values(@id,@pembeli_id,@kasir_id,@total_harga,@keterangan,@tanggal)";
                CRUD.cmd = new OleDbCommand(CRUD.sql, CRUD.con);

                CRUD.cmd.Parameters.AddWithValue("id", noTransaksi);
                CRUD.cmd.Parameters.AddWithValue("pembeli_id", pembeli_id);
                CRUD.cmd.Parameters.AddWithValue("kasir_id", kasir_id);
                CRUD.cmd.Parameters.AddWithValue("total_harga", total_harga);
                CRUD.cmd.Parameters.AddWithValue("keterangan", keterangan);
                CRUD.cmd.Parameters.AddWithValue("tanggal", dtpTanggal.Value);
                CRUD.PerformCRUD(CRUD.cmd);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Terjadi Error: " + ex.Message);
            }
        }

        private void insert_detail_penjualan()
        {
            string noTransaksi = tbNoTransaksi.Text;
            int counter = 0;
            foreach (DataGridViewRow row in dgv_keranjang.Rows)
            {
                counter += 1;
                string id_detail_transaksi = noTransaksi + counter;

                // Insert ke table detail_pembelian
                CRUD.sql = "INSERT INTO detail_penjualan (id,penjualan_id,produk_id,qty,harga,sub_total) values(@id,@penjualan_id,@produk_id,@qty,@harga,@sub_total)";
                CRUD.cmd = new OleDbCommand(CRUD.sql, CRUD.con);
                CRUD.cmd.Parameters.AddWithValue("id", id_detail_transaksi);
                CRUD.cmd.Parameters.AddWithValue("penjualan_id", noTransaksi);
                CRUD.cmd.Parameters.AddWithValue("produk_id", row.Cells["id"].Value);
                CRUD.cmd.Parameters.AddWithValue("qty", row.Cells["qty"].Value);
                CRUD.cmd.Parameters.AddWithValue("harga", row.Cells["harga"].Value);
                CRUD.cmd.Parameters.AddWithValue("sub_total", row.Cells["subtotal"].Value);
                CRUD.PerformCRUD(CRUD.cmd);

                // Update stok di table
                CRUD.sql = "UPDATE produk SET stok = stok - @qty WHERE id = @id";
                CRUD.cmd = new OleDbCommand(CRUD.sql, CRUD.con);
                CRUD.cmd.Parameters.AddWithValue("qty", row.Cells["qty"].Value);
                CRUD.cmd.Parameters.AddWithValue("id", row.Cells["id"].Value);
                CRUD.PerformCRUD(CRUD.cmd);
            }
        }

        private void btn_bayar_Click(object sender, EventArgs e)
        {
            bayar();
        }
        public void bayar()
        {
            tb_cari_id.Focus(); 
            insert_penjualan();
            insert_detail_penjualan();
            formDialog dialog = new formDialog();
            dialog.ShowDialog(this);
            generateNoTransaksi();
            dgv_keranjang.Rows.Clear();
            lbTotal.Text = "0,00";
            total_harga = 0;
            load_data();
        }

        private void dgv_list_barang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && dgv_list_barang.CurrentCell != null)
                dgv_list_CellDoubleClick(sender, new DataGridViewCellEventArgs(0, dgv_list_barang.CurrentCell.RowIndex));
        }

        private void dgv_keranjang_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter && dgv_keranjang.CurrentCell != null)
                dgv_keranjang_CellDoubleClick(sender, new DataGridViewCellEventArgs(0, dgv_keranjang.CurrentCell.RowIndex));

        }
    }
}
