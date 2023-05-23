using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toy
{
    public partial class Menu : Form
    {
        string diff = "";
        public Menu()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if(NameInputBox.Text == string.Empty)
            {
                MessageBox.Show("Input player's name!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Hide();
            if(diff == "Easy")
            {
                Game game = new Game(NameInputBox.Text, 2000, diff);
                game.Show();
            }
            else if(diff == "Medium")
            {
                Game game = new Game(NameInputBox.Text, 1000, diff);
                game.Show();
            }
            else if (diff == "Hard")
            {
                Game game = new Game(NameInputBox.Text, 800, diff);
                game.Show();
            }
            else
            { // secret difficulty PRO
                Game game = new Game(NameInputBox.Text, 600, "PRO");
                game.Show();
            }
            
        }
        private void DifficultyComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            diff = DifficultyComboBox.GetItemText(DifficultyComboBox.SelectedItem);
        }

        private void NameInputBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void StatsButton_Click(object sender, EventArgs e)
        {
            string text = File.ReadAllText("../../Resources/stats.txt");
            MessageBox.Show(text, "Stats", MessageBoxButtons.OK, MessageBoxIcon.None);
        }
    }
}
