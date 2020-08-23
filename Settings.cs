using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelingSnake
{
    class Settings
    {
        // properties defined to access these variable globaly 
        public static int ItemHeight { get; set; }
        public static int ItemWidth { get; set; }
        public static int SnakeSpeed { get; set; }
        public static int Score { get; set; }
        public static bool IsGameOver { get; set; }
        public static int Points { get; set; }
        public static Direction direction { get; set; }

        public Settings()
        {
            ItemHeight = 16;
            ItemWidth = 16;
            SnakeSpeed = 10;
            Score = 0;
            Points = 10;
            IsGameOver = false;
            direction = Direction.Down;
        }
    }

    public enum Direction
    {
        Left,
        Right,
        Up,
        Down
    }
}
