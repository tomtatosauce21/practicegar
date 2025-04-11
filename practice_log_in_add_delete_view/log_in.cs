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
using System.Data.OleDb;

namespace practice_log_in_add_delete_view
{
    
    public partial class log_in : Form
    {
        string connstr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Users\\VERLI ALCANTARA\\Downloads\\DB-ACT3.mdb\"";
        OleDbConnection conn;
        public log_in()
        {
            InitializeComponent();
           
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string query = "select username,password from account where username=@username and password=@pass";
            conn = new OleDbConnection(connstr);
            conn.Open();
            OleDbCommand cmd = new OleDbCommand(query,conn);
            cmd.Parameters.AddWithValue("@username", txtusername.Text);
            cmd.Parameters.AddWithValue("@pass", txtpass.Text);
            OleDbDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                rdr.Read();
                main frm = new main(rdr["username"].ToString());
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Credentials are incorrect", "Credentials");
            }
            conn.Close();
           


        }

        private void log_in_Load(object sender, EventArgs e)
        {

        }
    }
}
