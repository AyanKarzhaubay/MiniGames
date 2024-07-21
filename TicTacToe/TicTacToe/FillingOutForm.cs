using System;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class FillingOutForm : Form
    {
        public FillingOutForm()
        {
            InitializeComponent();
        }

        private void playButton_Click(object sender, EventArgs e) //Set names and close the dialog window
        {
            if (player1NameTextBox.Text != "" && player2NameTextBox.Text != "")
            {
                TicTacToe.SetPlayerNames(player1NameTextBox.Text, player2NameTextBox.Text);
            }
            this.Hide();

        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e) //if press the enter on TextBox, press the button playButton
        {
            if (e.KeyChar.ToString() == "\r")
            {
                playButton.PerformClick();
            }
        }

        private void FillingOutForm_Load(object sender, EventArgs e)
        {
        }
    }
}