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

    public partial class main : Form
    {
        string connstr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Users\\VERLI ALCANTARA\\Downloads\\DB-ACT3.mdb\"";
        OleDbConnection conn;

        string _username;
        public main(string username)

        {
            InitializeComponent();
            _username = username;
            this.Text = "Welcome" + _username;
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {


        }

        private void searchGenderSpecific()
        {
            DataTable dt = new DataTable();
            conn = new OleDbConnection(connstr);
            string query = " select * from [employee] where name like '" + txtkeyword.Text + "%' and sex='" + cbogender.Text + "';";
            conn.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
            adapter.Fill(dt);
            conn.Close();

            Gridview1.DataSource = dt;
        }

        private void txtkeyword_TextChanged(object sender, EventArgs e)
        {
            searchGenderSpecific();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            cbogender.SelectedIndex = -1;
            txtkeyword.Clear();
        }

        private void cbogender_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbogender.SelectedValue = 0;

            // if male or female and txtkeyword is empty
            if (cbogender.Text == "All" || cbogender.Text == "male" || cbogender.Text == "female" && string.IsNullOrEmpty(txtkeyword.Text))
            {
                DataTable dt = new DataTable();
                conn = new OleDbConnection(connstr);
                string query = " select * from [employee] where sex='" + cbogender.Text + "';";
                conn.Open();
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
                adapter.Fill(dt);
                conn.Close();
                Gridview1.DataSource = dt;
            }
            else if (cbogender.Text == "male" || cbogender.Text == "female" && !string.IsNullOrEmpty(txtkeyword.Text))
            {
                searchGenderSpecific();
            }

            else if (cbogender.Text == "all" && string.IsNullOrEmpty(txtkeyword.Text))
            {
                DataTable dt = new DataTable();
                conn = new OleDbConnection(connstr);
                string query = "select * from employee";
                conn.Open();
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
                adapter.Fill(dt);
                conn.Close();
                Gridview1.DataSource = dt;
             
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            txtemailadd frm = new txtemailadd();
            frm.ShowDialog();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            edit frm = new edit();
            frm.ShowDialog();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            delete frm = new delete();
            frm.ShowDialog();
        }
    }
}

