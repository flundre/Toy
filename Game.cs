using System;
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
    public partial class Game : Form
    {
        int score = 0;
        uint ticks = 0;
        string name;
        int diff;
        public Game()
        {
            InitializeComponent();
        }
        public Game(string n, int d)
        {
            InitializeComponent();
            name = n;
            diff = d;
        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
        }

        private void BallTimer_Tick(object sender, EventArgs e)
        {
            ticks += 1;
            if (ticks == 3)
            {
                Close();
            }
            score -= 1;
            Score.Text = $"Score {score}";
            GenerateBall();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            BallTimer.Interval = diff;
        }

        private void Game_Click(object sender, EventArgs e)
        {
            ticks += 1;
            score -= 1;
            if (ticks == 3)
            {
                Close();
            }
            Score.Text = $"Score {score}";
            GenerateBall();
            BallTimer.Enabled = false;
            BallTimer.Enabled = true;
        }
        private void GenerateBall()
        {
            Random rand = new Random();
            switch (rand.Next(1, 5))
            {
                case 1:
                    GenerateRed();
                    break;
                case 2:
                    GenerateYellow();
                    break;
                case 3:
                    GenerateBlue();
                    break;
                case 4:
                    GenerateGreen();
                    break;
                default:
                    break;
            }
        }
        private void GenerateRed()
        {
            Random rand = new Random();
            RedBallBox.Top = rand.Next(50, 300);
            RedBallBox.Left = rand.Next(50, 650);
            RedBallBox.Visible = true;
            GreenBallBox.Visible = false;
            YellowBallBox.Visible = false;
            BlueBallBox.Visible = false;
        }
        private void GenerateYellow()
        {
            Random rand = new Random();
            YellowBallBox.Top = rand.Next(50, 300);
            YellowBallBox.Left = rand.Next(50, 650);
            RedBallBox.Visible = false;
            GreenBallBox.Visible = false;
            YellowBallBox.Visible = true;
            BlueBallBox.Visible = false;
        }
        private void GenerateBlue()
        {
            Random rand = new Random();
            BlueBallBox.Top = rand.Next(50, 300);
            BlueBallBox.Left = rand.Next(50, 650);
            RedBallBox.Visible = false;
            GreenBallBox.Visible = false;
            YellowBallBox.Visible = false;
            BlueBallBox.Visible = true;
        }
        private void GenerateGreen()
        {
            ticks -= 1;
            score += 1;
            Random rand = new Random();
            GreenBallBox.Top = rand.Next(50, 300);
            GreenBallBox.Left = rand.Next(50, 650);
            RedBallBox.Visible = false;
            GreenBallBox.Visible = true;
            YellowBallBox.Visible = false;
            BlueBallBox.Visible = false;
        }
        private void RedBallBox_Click(object sender, EventArgs e)
        {
            GenerateBall();
            score += 10;
            Score.Text = $"Score {score}";
            BallTimer.Enabled = false;
            BallTimer.Enabled = true;
        }

        private void GreenBallBox_Click(object sender, EventArgs e)
        {
            GenerateBall();
            score += -20;
            ticks += 2;
            Score.Text = $"Score {score}";
            BallTimer.Enabled = false;
            BallTimer.Enabled = true;
        }

        private void YellowBallBox_Click(object sender, EventArgs e)
        {
            GenerateBall();
            score += 5;
            Score.Text = $"Score {score}";
            BallTimer.Enabled = false;
            BallTimer.Enabled = true;
        }

        private void BlueBallBox_Click(object sender, EventArgs e)
        {
            GenerateBall();
            score += 0;
            Score.Text = $"Score {score}";
            BallTimer.Enabled = false;
            BallTimer.Enabled = true;

        }
    }
}
