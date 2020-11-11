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
    public partial class Teams : Form
    {
        bool cl = true;
        public Teams()
        {
            InitializeComponent();
        }

        private void teamsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.teamsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.footballDataSet1);

        }

        private void Teams_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "footballDataSet1.players". При необходимости она может быть перемещена или удалена.
            this.playersTableAdapter.Fill(this.footballDataSet1.players);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "footballDataSet1.teams". При необходимости она может быть перемещена или удалена.
            this.teamsTableAdapter.Fill(this.footballDataSet1.teams);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to save data and exit?",
                "Saving", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                teamsBindingSource.EndEdit();
                teamsTableAdapter.Update(footballDataSet1); 
                playersTableAdapter.Update(footballDataSet1);
                cl = false;
                Close();
            }
        }

        private void Teams_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cl)
            {
                var t = MessageBox.Show("Do you want to save data before exit?",
                    "Saving", MessageBoxButtons.YesNoCancel);
                if (t == DialogResult.Yes)
                {
                    teamsBindingSource.EndEdit();
                    teamsTableAdapter.Update(footballDataSet1);
                    playersTableAdapter.Update(footballDataSet1);
                }
                else
                {
                    if (t == DialogResult.Cancel) e.Cancel = true;
                }
            }
        }
    }
}
