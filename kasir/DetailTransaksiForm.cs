using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kasir.Resources
{
    public partial class DetailTransaksiForm : Form
    {
        private string penjualan_id;

        public DetailTransaksiForm(string idPenjualan)
        {
            InitializeComponent();
            penjualan_id = idPenjualan;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CRUD.sql = "SELECT * FROM detail_penjualan WHERE penjualan_id = @penjualan_id;";
            CRUD.cmd = new OleDbCommand(CRUD.sql, CRUD.con);
            CRUD.cmd.Parameters.AddWithValue("penjualan_id", penjualan_id);
            dgv_detail_penjualan.DataSource = CRUD.PerformCRUD(CRUD.cmd);
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
