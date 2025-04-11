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

namespace practice_log_in_add_delete_view
{
    public partial class txtemailadd : Form
    {
        string connstr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Users\\VERLI ALCANTARA\\Downloads\\DB-ACT3.mdb\"";
        OleDbConnection conn;

        public txtemailadd()
        {
            InitializeComponent();
        }

        private void txtemailadd_Load(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {

            string query = "insert into [employee] (name, email,sex, address) values ('" + txtnameadd.Text + "','" + txtemaileadd.Text + "', '" + txtsexadd.Text + "' , '" + txtaddressadd.Text + "' )"; ;
            conn = new OleDbConnection(connstr);
            conn.Open();
            OleDbCommand cmd = new OleDbCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("successful");
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            txtaddressadd.Clear();
            txtsexadd.Clear();
            txtemaileadd.Clear();
            txtnameadd.Clear();
        }
    }
}
