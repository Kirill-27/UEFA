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
    public partial class EditForm : Form
    {
        private readonly int id;
        readonly bool edit;
        public EditForm()
        {
            InitializeComponent();
            teamsTableAdapter.Fill(footballDataSet1.teams);
            playersTableAdapter.Fill(footballDataSet1.players);
            player_id_label.Text=Convert.ToString 
                (Convert.ToInt32(playersTableAdapter.ScalarQuery())+1);
            edit = false;
        }

        public EditForm(int player_id, string name, string surname, int number, 
            int age, string nationality, int team_id )
        {
            InitializeComponent();
            teamsTableAdapter.Fill(footballDataSet1.teams);
            playersTableAdapter.Fill(footballDataSet1.players);
            //MessageBox.Show(Convert.ToString(team_id));
            Team_comboBox.SelectedValue = team_id;
            
            player_id_label.Text = Convert.ToString(player_id);
            
            //MessageBox.Show(Convert.ToString(Team_comboBox.Text));
            //MessageBox.Show(Convert.ToString(Team_comboBox.SelectedValue));
            edit = true;
            id = player_id;
            
            Name_textBox.Text = name;
            Surname_textBox.Text = surname;
            Number_numericUpDown.Value = number;
            Age_numericUpDown.Value = age;
            Nationality_textBox.Text = nationality;

        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "footballDataSet1.players". При необходимости она может быть перемещена или удалена.
            this.playersTableAdapter.Fill(this.footballDataSet1.players);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "footballDataSet1.teams". При необходимости она может быть перемещена или удалена.
            this.teamsTableAdapter.Fill(this.footballDataSet1.teams);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "footballDataSet1.teams". При необходимости она может быть перемещена или удалена.
            this.teamsTableAdapter.Fill(this.footballDataSet1.teams);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "footballDataSet1.teams". При необходимости она может быть перемещена или удалена.
            this.teamsTableAdapter.Fill(this.footballDataSet1.teams);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "footballDataSet1.players". При необходимости она может быть перемещена или удалена.
            this.playersTableAdapter.Fill(this.footballDataSet1.players);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "footballDataSet1.players". При необходимости она может быть перемещена или удалена.
            this.playersTableAdapter.Fill(this.footballDataSet1.players);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "footballDataSet1.teams". При необходимости она может быть перемещена или удалена.
            this.teamsTableAdapter.Fill(this.footballDataSet1.teams);
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OK_button_Click(object sender, EventArgs e)
        {
            if(edit)
            {
                playersTableAdapter.UpdateQuery(id,
                    Name_textBox.Text,
                Surname_textBox.Text,
                Convert.ToInt32(Number_numericUpDown.Value),
                Convert.ToInt32(Age_numericUpDown.Value),
                Nationality_textBox.Text,
                Convert.ToInt32(Team_comboBox.SelectedValue));
            }
            else
            {
                playersTableAdapter.Insert(
                Convert.ToInt32(playersTableAdapter.ScalarQuery())+1,
                Name_textBox.Text,
                Surname_textBox.Text,
                Convert.ToInt32(Number_numericUpDown.Value),
                Convert.ToInt32(Age_numericUpDown.Value),
                Nationality_textBox.Text,
                Convert.ToInt32(Team_comboBox.SelectedValue));
            }
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int y = Convert.ToInt32(Team_comboBox.SelectedValue);
            y = y % 4 + 1;
            Team_comboBox.SelectedValue = y;
        }
    }
}
