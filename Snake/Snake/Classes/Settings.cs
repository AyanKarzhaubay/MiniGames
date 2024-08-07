﻿using System.Drawing;

namespace Snake
{
    public enum Direction
    {
        Up,
        Down,
        Left,
        Right,
        Stop
    };

    public class Settings
    {
        public static int Width { get; set; }
        public static int Height { get; set; }
        public static int Speed { get; set; }
        public static int Score { get; set; }
        public static int Points { get; set; }
        public static int Lifes { get; set; }
        public static bool GameOver { get; set; }
        public static Direction direction { get; set; }
        public static Rectangle R { get; set; } 

        public Settings()
        {
            Width = 36;
            Height = 36;
            Speed = 10;
            Score = 0;
            Points = 100;
            Lifes = 3;
            GameOver = false;
            direction = Direction.Down;
        }
    }
}
