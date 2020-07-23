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

namespace kasir
{
    public partial class RiwayatLayer : UserControl
    {
        public RiwayatLayer()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            
        }

        public void load_data()
        {
            CRUD.sql = "SELECT id,total_harga,tanggal FROM penjualan";
            CRUD.cmd = new OleDbCommand(CRUD.sql, CRUD.con);
            DataTable dt = CRUD.PerformCRUD(CRUD.cmd);
            dgv_list_penjualan.DataSource = dt;
        }

        private void dgv_list_penjualan_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1) return;
            string id_penjualan = dgv_list_penjualan.Rows[e.RowIndex].Cells["id"].Value.ToString();
            DetailTransaksiForm detail_form = new DetailTransaksiForm(id_penjualan);
            detail_form.ShowDialog(this);
        }
    }
}
