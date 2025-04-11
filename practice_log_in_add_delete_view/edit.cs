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
    public partial class edit : Form
    {
        string connstr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Users\\VERLI ALCANTARA\\Downloads\\DB-ACT3.mdb\"";
        OleDbConnection conn;
        public edit()
        {
            InitializeComponent();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            string query = "UPDATE employee SET name = @name, email = @email, address = @address WHERE empid = @Id;";
            //string query = "update employee set name=@name, email=@email, address=@address where id = "+txtIDedit.Text+"';";
            conn = new OleDbConnection(connstr);
            conn.Open();
            OleDbCommand cmd = new OleDbCommand(query,conn);
            cmd.Parameters.AddWithValue("@name", txtnameedit.Text);
            cmd.Parameters.AddWithValue("@email", txtemailedit.Text); 
            cmd.Parameters.AddWithValue("@address", txtadressdedit.Text);
            cmd.Parameters.AddWithValue("@Id", txtIDedit.Text);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel; 
        }
    }
}
