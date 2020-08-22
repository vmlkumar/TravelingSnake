using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelingSnake
{
    public partial class frmMain : Form
    {
        private List<Item> Snake = new List<Item>();
        private Item food = new Item();
        public frmMain()
        {
            InitializeComponent();

            //making the default settings
            new Settings();
            gameTimer.Interval = 1000;
            gameTimer.Tick += RefreshScreen;

            //Start the new game
            StartGame();

        }

        // Game will be started by this method
        private void StartGame()
        {
            lblGameOver.Visible = false;
            //making the default settings
            new Settings();

            Snake.Clear();
            Item head = new Item();
            head.X = 10;
            head.Y = 5;
            Snake.Add(head);

            lblScoreValue.Text = Settings.Score.ToString();
            AddFood();


        }

        //Add food to the playing canvas randomly
        private void AddFood()
        {
            int maxXPossition = gameWorld.Size.Height / Settings.PanelHeight;
            int maxYPossition = gameWorld.Size.Width / Settings.PanelWidth;

            Random random = new Random();
            food = new Item();
            food.X = random.Next(0, maxXPossition);
            food.Y = random.Next(0, maxYPossition);
        }


        private void RefreshScreen(object sender, EventArgs e)
        {
            // check for game over
            if (Settings.IsGameOver == true)
            {
                if (Input.KeyPressed(Keys.Enter))
                {
                    StartGame();
                }
            }
            else
            {
                if (Input.KeyPressed(Keys.Right) && Settings.direction != Direction.Left)
                {
                    Settings.direction = Direction.Right;
                }
                else if (Input.KeyPressed(Keys.Left) && Settings.direction != Direction.Left)
                {
                    Settings.direction = Direction.Left;
                }
                else if (Input.KeyPressed(Keys.Up) && Settings.direction != Direction.Down)
                {
                    Settings.direction = Direction.Up;
                }
                else if (Input.KeyPressed(Keys.Down) && Settings.direction != Direction.Up)
                {
                    Settings.direction = Direction.Down;
                }

                MoveSnake();
            }
            gameWorld.Invalidate();

        }

        private void gameWorld_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            if (Settings.IsGameOver == false)
            {
                Brush sankeColor;

                // Draw sanke
                for (int i = 0; i < Snake.Count; i++)
                {
                    if (i == 0)
                    {
                        sankeColor = Brushes.Black;
                    }
                    else
                    {
                        sankeColor = Brushes.Green;
                    }

                    // snake location coordinates with head and body
                    canvas.FillEllipse(sankeColor,
                        new Rectangle(Snake[i].X * Settings.PanelWidth,
                                      Snake[i].Y * Settings.PanelHeight,
                                      Settings.PanelWidth, Settings.PanelHeight));

                    // draw food
                    canvas.FillEllipse(Brushes.Red,
                       new Rectangle(food.X * Settings.PanelWidth,
                                     food.Y * Settings.PanelHeight, Settings.PanelWidth, Settings.PanelHeight));
                }
            }
            else
            {
                string gameOver = "Game Over \n Press Enter to try Again";
                lblGameOver.Text = gameOver;
                lblGameOver.Visible = true;
            }
        }
        private void MoveSnake()
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
                    }
                }
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, true);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, false);
        }
    }
}
