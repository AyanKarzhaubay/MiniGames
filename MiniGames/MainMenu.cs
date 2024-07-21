using System;
using System.Windows.Forms;

namespace MiniGames
{
    public partial class MainMenu : Form
    {
        public static TicTacToe.TicTacToe ticTacToe;
        public static Snake.MainForm mainForm;
        public MainMenu()
        {
            InitializeComponent();
        }

        private void buttonTicTacToe_Click(object sender, EventArgs e)
        {
            this.Hide();
            ticTacToe.Show();
        }

        private void buttonSnake_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            ticTacToe = new TicTacToe.TicTacToe();
            mainForm = new Snake.MainForm();
        }
    }
}
