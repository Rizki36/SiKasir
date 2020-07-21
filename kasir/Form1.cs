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
            OleDbCommand cmd = new OleDbCommand(CRUD.sql,CRUD.con);
            cmd.Parameters.AddWithValue("date", date);
            DataTable dt =  CRUD.PerformCRUD(cmd);
            if (dt.Rows[0][0].ToString() != string.Empty)
                id = int.Parse(dt.Rows[0][0].ToString()) + 1;
            else
                id = 1;
            id_jadi = date + id.ToString();
            tbNoTransaksi.Text = id_jadi;
        }

        public mainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            generateNoTransaksi();
            tbKasir.Text = "Kasir-1";
            loadData();
            tb_cari_id.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void AddParameters(string str)
        {
            string noTransaksi = tbNoTransaksi.Text;
            string kasir = tbKasir.Text;
            string tanggal = dtpTanggal.Value.ToString();
            CRUD.cmd.Parameters.AddWithValue("no",noTransaksi);
            CRUD.cmd.Parameters.AddWithValue("kasir", noTransaksi);
            CRUD.cmd.Parameters.AddWithValue("no", noTransaksi);
        }

        private void loadData(string id = "", string nama = "")
        {
            CRUD.sql = "SELECT * FROM produk WHERE id LIKE @id AND nama LIKE @nama;";
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

            //dgv.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            //dgv.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dgv.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            //dgv.Columns[0].Width = 100;
            //dgv.Columns[1].Width = 200;
            //dgv.Columns[2].Width = 100;

            //dgv.ReadOnly = true;
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
                string total_text = string.Format(culture,"{0:C}", Convert.ToDecimal(total_harga));
                lbTotal.Text = total_text;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Terjadi error: " + ex.Message);
            }
        }

        private void btn_cari_Click(object sender, EventArgs e)
        {
            string id = tb_cari_id.Text;
            string nama = tb_cari_nama.Text;
            loadData(id, nama);
        }

        

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode== Keys.F)
            {
                tb_cari_id.Focus();
            }

            if (e.Control && e.KeyCode == Keys.Enter)
            {
                btn_bayar_Click(sender,e);
            }

            if (e.Control && e.KeyCode == Keys.L)
            {
                dgv_list_barang.Focus();
            }

            if (e.Control && e.KeyCode == Keys.K)
            {
                dgv_keranjang.Focus();
            }

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        // cari data ketika user klik enter 
        private void tb_cari_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                string id = tb_cari_id.Text;
                string nama = tb_cari_nama.Text;
                loadData(id, nama);
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

                CRUD.sql = "INSERT INTO detail_penjualan (id,penjualan_id,produk_id,qty,harga,sub_total) values(@id,@penjualan_id,@produk_id,@qty,@harga,@sub_total)";
                CRUD.cmd = new OleDbCommand(CRUD.sql, CRUD.con);

                CRUD.cmd.Parameters.AddWithValue("id", id_detail_transaksi);
                CRUD.cmd.Parameters.AddWithValue("penjualan_id", noTransaksi);
                CRUD.cmd.Parameters.AddWithValue("produk_id", row.Cells["id"].Value);
                CRUD.cmd.Parameters.AddWithValue("qty", row.Cells["qty"].Value);
                CRUD.cmd.Parameters.AddWithValue("harga", row.Cells["harga"].Value);
                CRUD.cmd.Parameters.AddWithValue("sub_total", row.Cells["subtotal"].Value);
                CRUD.PerformCRUD(CRUD.cmd);
            }
        }

        private void btn_bayar_Click(object sender, EventArgs e)
        {
            insert_penjualan();
            insert_detail_penjualan();
            formDialog dialog = new formDialog();
            dialog.ShowDialog(this);
            generateNoTransaksi();
            tb_cari_id.Focus();
            dgv_keranjang.Rows.Clear();

        }

        private void dgv_list_barang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && dgv_list_barang.CurrentCell != null)
                dgv_list_CellDoubleClick(sender,new DataGridViewCellEventArgs(0,dgv_list_barang.CurrentCell.RowIndex));
        }

        private void dgv_keranjang_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter && dgv_keranjang.CurrentCell != null)
                dgv_keranjang_CellDoubleClick(sender, new DataGridViewCellEventArgs(0, dgv_keranjang.CurrentCell.RowIndex));
            
        }

    }
}
