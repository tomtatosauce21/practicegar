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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
namespace AppdevFinals
{
    public partial class Form1 : Form
    {
        String connstr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Yves\\Downloads\\dpPirates.accdb";
        OleDbConnection conn;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = "select * from pirates where givenname=@name and pirategroup=@group";
            DataTable dt = new DataTable();
            conn = new OleDbConnection(connstr);
            conn.Open();
            OleDbCommand cmd = new OleDbCommand(query,conn);
            cmd.Parameters.AddWithValue("@name",txtSearch.Text);
            cmd.Parameters.AddWithValue("@group", cboSearch.Text);
            OleDbDataAdapter adapter = new OleDbDataAdapter(query,conn);  
            adapter.SelectCommand = cmd;
            adapter.Fill(dt); 
            conn.Close();
            dataGridView1.DataSource = dt;


            dataGridView1.Columns["ID"].Visible = false;


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedrow = dataGridView1.SelectedRows[0];

                txtAlias.Text = selectedrow.Cells["Alias"].Value.ToString();
                txtName.Text = selectedrow.Cells["name"].Value.ToString();
                txtAge.Text = selectedrow.Cells["Age"].Value.ToString();
                cboPirateGroup.SelectedItem = selectedrow.Cells["PirateGroup"].Value.ToString();
                txtBounty.Text = selectedrow.Cells["Bounty"].Value.ToString();

                txtAlias.Enabled = true;
                txtName.Enabled = true;
                cboPirateGroup.Enabled = true;
                txtBounty.Enabled = true;

              
              btnNew.Enabled = false;


            }
            else
            {
                MessageBox.Show("Please select a row to view details.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string query = "SELECT ID as id, piratename as Alias, givenname as name, age as Age, pirategroup as Pirategroup, bounty as Bounty FROM pirates";
            conn = new OleDbConnection(connstr);
            conn.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
            dataGridView1.Columns["Age"].Visible = false;
            dataGridView1.Columns["id"].Visible = false;

        }

        private void btnsave_Click(object sender, EventArgs e)
        {


            int selectedrows = dataGridView1.SelectedCells[0].RowIndex;
            string selectedvalue = dataGridView1.Rows[selectedrows].Cells["ID"].Value.ToString();
            //string cellValue = dataGridView1.SelectedCells[0].ToString();
            //string query = "UPDATE pirates set piratename =@alias, givenname =@name, age =@age, pirategroup = '" + cboPirateGroup.Text + "', bounty =@bounty where ID " + dataGridView1.SelectedCells[0].Value.ToString() +"";
            string query = "update pirates set piratename=@alias, givenname =@name, age=@age, pirategroup=@pirategroup, bounty=@bounty where ID = "+ selectedvalue+"";
            conn = new OleDbConnection(connstr);
            OleDbCommand cmd = new OleDbCommand(query, conn);
            conn.Open();


            cmd.Parameters.AddWithValue("@alias", txtAlias.Text);
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@age", txtAge.Text);
            cmd.Parameters.AddWithValue("@pirategroup", cboPirateGroup.Text);
            cmd.Parameters.AddWithValue("@bounty", txtBounty.Text);
            //cmd.Parameters.AddWithValue("@id", selectedvalue);  
            cmd.ExecuteNonQuery();
            conn.Close();

            btnsave.Enabled = false;
            cboPirateGroup.Enabled = false;
            txtAlias.ReadOnly = true;
            txtName.ReadOnly = true;
            txtAge.ReadOnly = true;
            txtBounty.ReadOnly = true;
            

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            string query = "insert into pirates (piratename, givenname, age, pirategroup, bounty) values(@alias,@name,@age,@pirategroup,@bounty) ";
            conn = new OleDbConnection( connstr );  
            conn.Open();
            OleDbCommand cmd = new OleDbCommand(query,conn);
            cmd.Parameters.AddWithValue("@alias", txtAlias.Text);
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@age", txtAge.Text);
            cmd.Parameters.AddWithValue("@pirategroup", cboPirateGroup.Text);
            cmd.Parameters.AddWithValue("@bounty", txtBounty.Text);

            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
