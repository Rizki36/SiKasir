using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace kasir
{
    class CRUD
    {
        public static OleDbConnection con = new OleDbConnection(getConnectionString());
        public static OleDbCommand cmd = default(OleDbCommand);
        public static string sql = string.Empty;

        public static string getConnectionString()
        {
            string conString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=database.accdb";
            return conString;
        }

        public static DataTable PerformCRUD(OleDbCommand cmd)
        {
            OleDbDataAdapter da = default(OleDbDataAdapter);
            DataTable dt = new DataTable();
            try
            {
                da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("An error occured: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dt = null;
            }
            return dt;
        }
  
    }

}
