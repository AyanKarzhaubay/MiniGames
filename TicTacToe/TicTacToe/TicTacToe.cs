using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

namespace TicTacToe
{
    public partial class TicTacToe : Form
    {
        bool turn = true; //true - X, false - O
        int turnAmount = 0; //How many buttons turn in
        static string player1 = "X", player2 = "O";
        public TicTacToe()
        {
            InitializeComponent();
        }

        public static void SetPlayerNames(string n1, string n2)
        {
            player1 = n1;
            player2 = n2;
        }
        private void Button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (player2=="Computer")
            {
                if (turn)
                    b.Text = "X";
                ComputerMove();
            }
            else
            {                
                if (turn)
                    b.Text = "X";
                else
                    b.Text = "O";
                turn = !turn;
            }
            b.Enabled = false;
            turnAmount++;
            CheckWinner();
        } //enter X or O on buttons
        private void CheckWinner()
        {
            bool thereIsAWinner = false;

            //horizontal
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                thereIsAWinner = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                thereIsAWinner = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                thereIsAWinner = true;

            //vertical
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                thereIsAWinner = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                thereIsAWinner = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                thereIsAWinner = true;

            //diagonal
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                thereIsAWinner = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!A3.Enabled))
                thereIsAWinner = true;

            if (thereIsAWinner)
            {
                DisableButtons();
                string winner = "";
                if (turn)
                {
                    winner = player2;
                    oWinCounterLabel.Text = (Int32.Parse(oWinCounterLabel.Text) + 1).ToString();
                }
                else
                {
                    winner = player1;
                    xWinCounterLabel.Text = (Int32.Parse(xWinCounterLabel.Text) + 1).ToString();
                }

                MessageBox.Show(winner + " wins!", "We have a winner!");
            }
            else
            {
                if (turnAmount == 9)
                {
                    MessageBox.Show("Draw!");
                    drawCounterLabel.Text = (Int32.Parse(drawCounterLabel.Text) + 1).ToString();
                }
            }
        } //Method for check winner after each move
        private void DisableButtons()
        {
            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
                catch { }
            }
        } //Disable buttons when the winner appears

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }   //exit from application

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turnAmount = 0;
            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
                catch { }
            }
        } //Starts the new game

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This game created by Ayan Karzhaubay. All rights reserved. Copyright (C).", "About");
        } //Display message box about a game

        private void howToPlayItToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You must put your sign in one line before your opponent does it. Players moves alternately starting with X", "How to play it?");
        } //Display message box about how to play this game

        private void button_MouseEnter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                if (turn)
                    b.Text = "X";
                else
                    b.Text = "O";
            }
        } //this methods helps to understand whose move is now

        private void button_MouseLeave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                b.Text = "";
            }
        }

        private void resetWinCountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawCounterLabel.Text = "0";
            xWinCounterLabel.Text = "0";
            oWinCounterLabel.Text = "0";
        }  //reset win counters

        private void saveGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var location = System.Reflection.Assembly.GetExecutingAssembly().Location;
            //Для выделения пути к каталогу, воспользуйтесь `System.IO.Path`:
            var path = Path.GetDirectoryName(location) + "Save";
            try
            {
                using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine(
                        turn + "\n" +
                        turnAmount + "\n" +
                        xWinCountLabel.Text + "\n" +
                        oWinCountLabel.Text + "\n" +

                        xWinCounterLabel.Text + "\n" +
                        drawCounterLabel.Text + "\n" +
                        oWinCounterLabel.Text + "\n" +

                        A1.Text + "\n" +
                        A2.Text + "\n" +
                        A3.Text + "\n" +

                        B1.Text + "\n" +
                        B2.Text + "\n" +
                        B3.Text + "\n" +

                        C1.Text + "\n" +
                        C2.Text + "\n" +
                        C3.Text + "\n" +

                        A1.Enabled + "\n" +
                        A2.Enabled + "\n" +
                        A3.Enabled + "\n" +

                        B1.Enabled + "\n" +
                        B2.Enabled + "\n" +
                        B3.Enabled + "\n" +

                        C1.Enabled + "\n" +
                        C2.Enabled + "\n" +
                        C3.Enabled);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } //save the current game

        private void loadGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var location = System.Reflection.Assembly.GetExecutingAssembly().Location;
            var path = Path.GetDirectoryName(location) + "Save";
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    turn = Convert.ToBoolean(sr.ReadLine());
                    turnAmount = Convert.ToInt32(sr.ReadLine());

                    player1 = sr.ReadLine();
                    player2 = sr.ReadLine();
                    xWinCountLabel.Text = player1;
                    oWinCountLabel.Text = player2;

                    xWinCounterLabel.Text = sr.ReadLine();
                    drawCounterLabel.Text = sr.ReadLine();
                    oWinCounterLabel.Text = sr.ReadLine();

                    A1.Text = sr.ReadLine();
                    A2.Text = sr.ReadLine();
                    A3.Text = sr.ReadLine();

                    B1.Text = sr.ReadLine();
                    B2.Text = sr.ReadLine();
                    B3.Text = sr.ReadLine();

                    C1.Text = sr.ReadLine();
                    C2.Text = sr.ReadLine();
                    C3.Text = sr.ReadLine();

                    A1.Enabled = Convert.ToBoolean(sr.ReadLine());
                    A2.Enabled = Convert.ToBoolean(sr.ReadLine());
                    A3.Enabled = Convert.ToBoolean(sr.ReadLine());

                    B1.Enabled = Convert.ToBoolean(sr.ReadLine());
                    B2.Enabled = Convert.ToBoolean(sr.ReadLine());
                    B3.Enabled = Convert.ToBoolean(sr.ReadLine());

                    C1.Enabled = Convert.ToBoolean(sr.ReadLine());
                    C2.Enabled = Convert.ToBoolean(sr.ReadLine());
                    C3.Enabled = Convert.ToBoolean(sr.ReadLine());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } //load the last saved game

        private void TicTacToe_Load(object sender, EventArgs e)
        {
            FillingOutForm f = new FillingOutForm();
            f.ShowDialog();
            xWinCountLabel.Text = player1;
            oWinCountLabel.Text = player2;
        } //display the dialog window for the enter the name of players, when application start

        private void changePlayersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        } //restart the application

        private void TicTacToe_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ComputerMove()
        {
            Random rand = new Random();
            List<Button> availableButtons = new List<Button>();

            foreach (Control control in this.Controls)
            {
                if (control is Button && control.Enabled)
                {
                    availableButtons.Add(control as Button);
                }
            }

            if (availableButtons.Count > 0)
            {
                Button move = availableButtons[rand.Next(availableButtons.Count)];
                move.Text = "O"; // или "X", в зависимости от хода компьютера
                move.Enabled = false;
            } //AI
        }
    }
}
