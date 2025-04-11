using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace practice_log_in_add_delete_view
{
    public partial class delete : Form
    {

        string connstr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Users\\VERLI ALCANTARA\\Downloads\\DB-ACT3.mdb\"";
        OleDbConnection conn;

        public delete()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btndelete_Click(object sender, EventArgs e)
        {

            string query = "DELETE FROM employee WHERE name = @Name AND email = @Email;";
            conn = new OleDbConnection(connstr);
            conn.Open();
            OleDbCommand cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("@Name", txtdeletename.Text);
            cmd.Parameters.AddWithValue("@Email", txtemaildelete.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("successfull");
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            
        }
    }
}
