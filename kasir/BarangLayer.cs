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

namespace kasir
{
    public partial class BarangLayer : UserControl
    {
        public BarangLayer()
        {
            InitializeComponent();
        }

        private void BarangLayer_Load(object sender, EventArgs e)
        {
            load_data();
        }

        public void load_data()
        {
            CRUD.sql = "SELECT id,nama,harga_jual,stok FROM produk";
            CRUD.cmd = new OleDbCommand(CRUD.sql, CRUD.con);
            DataTable dt = CRUD.PerformCRUD(CRUD.cmd);
            DataGridView dgv = dgv_list_barang;
            dgv.DataSource = dt;
        }

        private void tambah_barang()
        {
            string id = tb_id.Text;
            string nama = tb_nama_barang.Text;
            string harga_jual_text = tb_harga_jual.Text;
            string stok_text = tb_stok.Text;
            string gudang_id = "gudang-1";
            int stok;
            double harga_jual;
            try
            {
                stok = int.Parse(stok_text);
                harga_jual = double.Parse(harga_jual_text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Masukkan sesuai format!");
                return;
            }

            try
            {
                CRUD.sql = "INSERT INTO produk (id, nama, harga_jual, stok, gudang_id) values(@id,@nama,@harga_jual,@stok,@gudang_id)";
                CRUD.cmd = new OleDbCommand(CRUD.sql, CRUD.con);
                CRUD.cmd.Parameters.AddWithValue("id", id);
                CRUD.cmd.Parameters.AddWithValue("nama", nama);
                CRUD.cmd.Parameters.AddWithValue("harga_jual", harga_jual);
                CRUD.cmd.Parameters.AddWithValue("stok", stok);
                CRUD.cmd.Parameters.AddWithValue("gudang_id", gudang_id);
                CRUD.PerformCRUD(CRUD.cmd);
                clear_input();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Terjadi Kesalahan: " + ex);
                return;
            }
        }

        private void clear_input()
        {
            tb_id.Clear();
            tb_id_lama.Clear();
            tb_nama_barang.Clear();
            tb_harga_jual.Clear();
            tb_stok.Clear();
        }

        private void dgv_list_barang_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete && dgv_list_barang.CurrentCell != null)
            {
                DialogResult result = MessageBox.Show(this,"Apakah anda yakin akan menghapus barang ini?","", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    delete_barang(dgv_list_barang.CurrentRow.Cells[0].Value.ToString());
                    load_data();
                }
            }
        }

        private void delete_barang(string id)
        {
            CRUD.sql = "DELETE FROM produk WHERE id = @id ";
            CRUD.cmd = new OleDbCommand(CRUD.sql, CRUD.con);
            CRUD.cmd.Parameters.AddWithValue("id", id);
            CRUD.PerformCRUD(CRUD.cmd);
        }

        private void btn_ubah_Click(object sender, EventArgs e)
        {
            ubah_barang();
        }

        private void ubah_barang()
        {
            string id_lama = tb_id_lama.Text;
            string id = tb_id.Text;
            string nama = tb_nama_barang.Text;
            string harga_jual_text = tb_harga_jual.Text;
            string stok_text = tb_stok.Text;
            int stok;
            double harga_jual;
            try
            {
                stok = int.Parse(stok_text);
                harga_jual = double.Parse(harga_jual_text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Masukkan Sesuai Format!");
                return;
            }
            CRUD.sql = "UPDATE produk SET id = @id, nama = @nama, harga_jual = @harga_jual, stok = @stok WHERE id = @id_lama";
            CRUD.cmd = new OleDbCommand(CRUD.sql, CRUD.con);
            CRUD.cmd.Parameters.AddWithValue("id", id);
            CRUD.cmd.Parameters.AddWithValue("nama", nama);
            CRUD.cmd.Parameters.AddWithValue("harga_jual", harga_jual);
            CRUD.cmd.Parameters.AddWithValue("stok", stok);
            CRUD.cmd.Parameters.AddWithValue("id_lama", id_lama);
            CRUD.PerformCRUD(CRUD.cmd);
            load_data();
            mode_update();
        }

        private void dgv_list_barang_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridView dgv = dgv_list_barang;
            DataGridViewRow dgv_row = dgv.Rows[e.RowIndex];

            string id = dgv_row.Cells["id"].Value.ToString();
            string nama_barang = dgv_row.Cells["nama"].Value.ToString();
            string harga_jual = dgv_row.Cells["harga_jual"].Value.ToString();
            string stok = dgv_row.Cells["stok"].Value.ToString();

            tb_id.Text = tb_id_lama.Text = id;
            tb_nama_barang.Text = nama_barang;
            tb_harga_jual.Text = harga_jual;
            tb_stok.Text = stok;

            dgv.Enabled = false;
            dgv.ClearSelection();
            btn_tambah.Visible = false;
            btn_ubah.Visible = btn_batal.Visible = true;
        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            tambah_barang();
            load_data();
        }

        private void btn_batal_Click(object sender, EventArgs e)
        {
            mode_update();
        }

        private void mode_update()
        {
            DataGridView dgv = dgv_list_barang;
            dgv.Enabled = true;
            clear_input();
            btn_tambah.Visible = true;
            btn_ubah.Visible = btn_batal.Visible = false;
            tb_id.Focus();
        }
 
    }
}
