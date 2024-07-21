using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Snake
{
    public partial class MainForm : Form
    {
        private List<Circle> Snake = new List<Circle>();
        private Circle food = new Circle();
        public MainForm()
        {
            InitializeComponent();
            //Set settings to default
            new Settings();

            //Set game speed and start timer
            gameTimer.Interval = 1200 / Settings.Speed;
            gameTimer.Tick += UpdateScreen;
            gameTimer.Start();
            pictureBoxCanvas.BackColor = Color.Olive;
            labelGameResult.Location = new Point(this.Size.Width / 2, this.Size.Height / 2);
            labelScoreText.Location = new Point(this.Size.Width / 2 + labelScoreText.Width / 2, menuStrip.Height);
            labelScore.Location = new Point(this.Size.Width / 2 + labelScoreText.Width + labelScoreText.Width / 2, menuStrip.Height);
            //Start New game
            StartGame();
        }

        private void StartGame()
        {
            labelGameResult.Visible = false;
            labelEatYourself.Visible = false;

            Settings.GameOver = false;
            Settings.Score = 0;
            Settings.Lifes = 3;
            gameTimer.Interval = 1000 / Settings.Speed;

            //Create new player object
            Snake.Clear();
            Circle head = new Circle { X = 10, Y = 5 };
            Snake.Add(head);

            labelScore.Text = Settings.Score.ToString();
            labelGameResult.Text = Settings.Score.ToString();
            GenerateFood();

        }

        //Place random food object
        private void GenerateFood()
        {
            int maxXPos = pictureBoxCanvas.Size.Width / Settings.Width;
            int maxYPos = pictureBoxCanvas.Size.Height / Settings.Height;

            Random random = new Random();
            food = new Circle { X = random.Next(0, maxXPos), Y = random.Next(0, maxYPos) };

        }


        private void UpdateScreen(object sender, EventArgs e)
        {
            //Check for Game Over
            if (Settings.GameOver)
            {
                SaveResult();
                //Check if Enter is pressed
                if (Input.KeyPressed(Keys.F2))
                {
                    StartGame();
                }
            }
            else
            {
                if (Input.KeyPressed(Keys.Right) && Settings.direction != Direction.Left)
                    Settings.direction = Direction.Right;
                else if (Input.KeyPressed(Keys.Left) && Settings.direction != Direction.Right)
                    Settings.direction = Direction.Left;
                else if (Input.KeyPressed(Keys.Up) && Settings.direction != Direction.Down)
                    Settings.direction = Direction.Up;
                else if (Input.KeyPressed(Keys.Down) && Settings.direction != Direction.Up)
                    Settings.direction = Direction.Down;

                MovePlayer();
            }

            pictureBoxCanvas.Invalidate();

        }

        private void pictureBoxCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            pictureBoxCanvas.Location = new Point(pictureBoxBG.Location.X + 150, pictureBoxBG.Location.Y + 100);
            pictureBoxCanvas.Size = new Size(pictureBoxBG.Size.Width - 300, pictureBoxBG.Height - 190);
            Settings.R = new Rectangle(100, 60, pictureBoxBG.Width - 300, pictureBoxBG.Height - 130);


            if (!Settings.GameOver)
            {
                //Set colour of snake

                //Draw snake
                for (int i = 0; i < Snake.Count; i++)
                {
                    Brush snakeColour;
                    if (i == 0)
                        snakeColour = Brushes.Black;     //Draw head
                    else
                        snakeColour = Brushes.Green;    //Rest of body

                    //Draw snake
                    canvas.FillEllipse(snakeColour,
                        new Rectangle(Snake[i].X * Settings.Width,
                                      Snake[i].Y * Settings.Height,
                                      Settings.Width, Settings.Height));


                    //Draw Food
                    canvas.FillEllipse(Brushes.Red,
                        new Rectangle(food.X * Settings.Width,
                             food.Y * Settings.Height, Settings.Width, Settings.Height));
                }
            }
            else if (pictureBoxCanvas.Width * pictureBoxCanvas.Height == Snake.Count * Settings.Width * Settings.Height)
            {
                //pictureBoxChicken.Visible = false; 
                string gameResult = $"Unbelievable! You can win! My congratulations!";
                labelGameResult.Text = gameResult;
                labelGameResult.Visible = true;
            }
            else
            {
                //pictureBoxChicken.Visible = false;
                string gameOver = $"Game over \nYour final score is: {Settings.Score}\nPress F2 to try again";
                if (Settings.Score > 1000)
                {

                }
                labelGameResult.Text = gameOver;
                labelGameResult.Visible = true;
            }
        }

        private void MovePlayer()
        {
            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                //Move head
                if (i == 0)
                {
                    switch (Settings.direction)
                    {
                        case Direction.Right:
                            Snake[i].X++;
                            break;
                        case Direction.Left:
                            Snake[i].X--;
                            break;
                        case Direction.Up:
                            Snake[i].Y--;
                            break;
                        case Direction.Down:
                            Snake[i].Y++;
                            break;
                        case Direction.Stop:
                            break;
                    }


                    //Get maximum X and Y Pos
                    int maxXPos = Settings.R.Size.Width / Settings.Width;
                    int maxYPos = Settings.R.Size.Height / Settings.Height;

                    //Detect collission with game borders.
                    if (Snake[i].X < 0 || Snake[i].Y < 0
                        || Snake[i].X >= maxXPos || Snake[i].Y >= maxYPos)
                    {
                        Die();
                    }


                    //Detect collission with body
                    for (int j = 1; j < Snake.Count; j++)
                    {
                        if (Snake[i].X == Snake[j].X &&
                           Snake[i].Y == Snake[j].Y)
                        {
                            EatYourself(i);
                        }
                    }

                    //Detect collision with food piece
                    if (Snake[0].X == food.X && Snake[0].Y == food.Y)
                    {
                        Eat();
                    }
                }
                else
                {
                    //Move body
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, true);
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, false);
        }

        private void Eat()
        {
            //Add circle to body
            Circle circle = new Circle
            {
                X = Snake[Snake.Count - 1].X,
                Y = Snake[Snake.Count - 1].Y
            };
            Snake.Add(circle);

            //Update Score
            Settings.Score += Settings.Points;
            labelScore.Text = Settings.Score.ToString();
            labelEatYourself.Visible = false;
            GenerateFood();
        }

        private void EatYourself(int I)
        {
            Settings.Lifes--;
            for (int i = I; i < Snake.Count; i++)
            {
                Settings.Score -= 100;
                Snake.RemoveAt(i);
            }
            labelEatYourself.Location = new Point(Snake[0].X * Settings.Width + pictureBoxCanvas.Location.X, Snake[0].Y * Settings.Height + pictureBoxCanvas.Location.Y);

            if (Settings.Lifes == 1) { labelEatYourself.Text = "Oh next time I will not survive!"; }
            labelEatYourself.Visible = true;

            if (Settings.Lifes == 0) { Die(); }
        }
        private void Die()
        {
            labelEatYourself.Visible = false;
            Settings.GameOver = true;
        }
        //private void CollisionsWithTheWall()
        //{
        //    Settings.Lifes--;
        //    if (Snake[0].Y == pictureBoxCanvas.Location.Y)
        //    {
        //        for (int i = Snake.Count - 1; i >= 0; i--)
        //        {
        //            Snake[i].X = Snake[i + 1].X;
        //            Snake[i].Y = Snake[i + 1].Y;
        //        }
        //        Settings.direction = Direction.Left;
        //    }
        //    else if (Snake[0].Y == pictureBoxCanvas.Height + pictureBoxCanvas.Location.Y)
        //    {
        //        Snake[0].Y++;
        //        Settings.direction = Direction.Right;
        //    }
        //    else if (Snake[0].X == pictureBoxCanvas.Location.X)
        //    {
        //        Snake[0].X++;
        //        Settings.direction = Direction.Down;
        //    }
        //    else if (Snake[0].X == pictureBoxCanvas.Width + pictureBoxCanvas.Location.X)
        //    {
        //        Snake[0].X--;
        //        Settings.direction = Direction.Up;
        //    }

        //    if (Settings.Lifes > 1) { labelOuch.Visible = true; }
        //    if (Settings.Lifes == 0) { labelOh.Visible = true; }
        //    if (Settings.Lifes == 0) { Die(); }
        //}
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void highScoreTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HighScoreTableForm highScoreTableForm = new HighScoreTableForm();
            highScoreTableForm.ShowDialog();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Ayan Karzhaubay. All rights reserved.\nCopyright (C)", "About");
        }

        private void howToPlayItToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Move the snake and eat foods.\nBeware of boundaries and don't eat yourself along the way.", "How to play it?");
        }
        public void SaveResult()
        {
            var location = System.Reflection.Assembly.GetExecutingAssembly().Location;
            var path = Path.GetDirectoryName(location) + "TableResults";
            try
            {
                using (StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.Default))
                {
                    sw.WriteLine(labelScore.Text + "\t" + DateTime.Now.ToString());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
