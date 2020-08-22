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
        public static int PanelHeight { get; set; }
        public static int PanelWidth { get; set; }
        public static int SnakeSpeed { get; set; }
        public static int Score { get; set; }
        public static bool IsGameOver { get; set; }
        public static int Points { get; set; }
        public static Direction direction { get; set; }

        public Settings()
        {
            PanelHeight = 16;
            PanelWidth = 16;
            SnakeSpeed = 16;
            Score = 0;
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
