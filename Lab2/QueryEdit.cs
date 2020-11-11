using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Lab2
{
    public partial class QueryEdit : Form
    {
        public QueryEdit()
        {
            InitializeComponent();
        }

        private void DoSQLbutton_Click(object sender, EventArgs e)
        {
                try 
                { 
                    SqlConnection sqlconn = new SqlConnection(ConnectionString);
                    sqlconn.Open(); 
                    SqlDataAdapter oda = new SqlDataAdapter(TestInput.Text, sqlconn); 
                    DataTable dt = new DataTable();
                    oda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    sqlconn.Close();
                } 
                catch (Exception ex) 
                { 
                    MessageBox.Show(@"Error: " + ex.Message); 
                }
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            TestInput.Clear(); 
            TestInput.Text = "SELECT";
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
