using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dataGridView2.AutoGenerateColumns = true;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "footballDataSet1.stadiums". При необходимости она может быть перемещена или удалена.
            this.stadiumsTableAdapter.Fill(this.footballDataSet1.stadiums);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "footballDataSet1.teams". При необходимости она может быть перемещена или удалена.
            this.teamsTableAdapter.Fill(this.footballDataSet1.teams);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "footballDataSet1.players". При необходимости она может быть перемещена или удалена.
            this.playersTableAdapter.Fill(this.footballDataSet1.players);
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            playersTableAdapter.Update(footballDataSet1);
            teamsTableAdapter.Update(footballDataSet1);
            stadiumsTableAdapter.Update(footballDataSet1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            playersTableAdapter.Update(footballDataSet1);
            teamsTableAdapter.Update(footballDataSet1);
            stadiumsTableAdapter.Update(footballDataSet1);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            playersTableAdapter.Update(footballDataSet1);
            teamsTableAdapter.Update(footballDataSet1);
            stadiumsTableAdapter.Update(footballDataSet1);
        }

        private void teamsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator2.BindingSource = teamsBindingSource;
            dataGridView2.DataSource = teamsBindingSource;
            label1.Text = "Teams";
        }

        private void playersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator2.BindingSource = playersBindingSource;
            dataGridView2.DataSource = playersBindingSource;
            label1.Text = "Players";
        }

        private void stadiumsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator2.BindingSource = stadiumsBindingSource;
            dataGridView2.DataSource = stadiumsBindingSource;
            label1.Text = "Stadiums";
        }

        private void distributionteamsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rs = new Teams(); 
            rs.ShowDialog();
            teamsTableAdapter.Fill(footballDataSet1.teams);
            playersTableAdapter.Fill(footballDataSet1.players);
            stadiumsTableAdapter.Fill(footballDataSet1.stadiums);
            footballDataSet1.AcceptChanges();
        }

        private void queryEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var qe = new QueryEdit();
            qe.ShowDialog();
            teamsTableAdapter.Fill(footballDataSet1.teams);
            playersTableAdapter.Fill(footballDataSet1.players);
            stadiumsTableAdapter.Fill(footballDataSet1.stadiums);
            footballDataSet1.AcceptChanges();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ed = new EditForm();
            ed.ShowDialog();
            playersTableAdapter.Fill(footballDataSet1.players);
            teamsTableAdapter.Fill(footballDataSet1.teams);
            footballDataSet1.AcceptChanges();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pl = new FootballDataSet1.playersDataTable(); 
            playersTableAdapter.FillBy(pl, Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value));
            object[] row = pl.Rows[0].ItemArray;
            //MessageBox.Show(Convert.ToString(Convert.ToInt32(row[6])));
            var fo = new EditForm(Convert.ToInt32(row[0]),
                row[1].ToString(),
                row[2].ToString(),
                Convert.ToInt32(row[3]),
                Convert.ToInt32(row[4]),
                row[5].ToString(),
                Convert.ToInt32(row[6]));
            MessageBox.Show(fo.Team_comboBox.Text);
            fo.ShowDialog();
            
            playersTableAdapter.Fill(footballDataSet1.players);
            footballDataSet1.AcceptChanges();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for(int i=0; i<dataGridView2.SelectedRows.Count; ++i) 
            {
                playersTableAdapter.DeleteQuery(Convert.ToInt32(dataGridView2.SelectedRows[i].Cells[0].Value));
            }
            playersTableAdapter.Fill(footballDataSet1.players);
            footballDataSet1.AcceptChanges();
        }
    }
}
