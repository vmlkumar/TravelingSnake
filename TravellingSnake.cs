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
        // used to store body of the snake based on no of food items eating
        private List<Item> Snake = new List<Item>();
        private Item food = new Item();
        public frmMain()
        {
            InitializeComponent();

            //making the default settings
            new Settings();
            gameTimer.Interval = 1000 / Settings.SnakeSpeed;

            /* Adds the event and the event handler for the method that will 
			process the timer event to the timer. event bind code / event handling method linking with timer 
            (Method Reference). Event handler takes a delegate which matches the method's arguments*/
            gameTimer.Tick += RefreshScreen;
            gameTimer.Start();
            
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
            if (Settings.IsGameOver)
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
                else if (Input.KeyPressed(Keys.Left) && Settings.direction != Direction.Right)
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
            //gameWorld.Invalidate();   //update the picture box used as sanke game World

        }

        private void gameWorld_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            if (!Settings.IsGameOver)
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
                //Move the snake head as per directions
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
                    //Get maximum X and Y Pos
                    int maxXPos = gameWorld.Size.Width / Settings.PanelWidth;
                    int maxYPos = gameWorld.Size.Height / Settings.PanelHeight;

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
                            //Die();
                        }
                    }

                    //Detect collision with food piece
                    if (Snake[0].X == food.X && Snake[0].Y == food.Y)
                    {
                        //Eat();
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

        // Detect Key Pressed 
        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, true);
            Console.WriteLine("key pressed: "+ e.KeyCode);  //Debug
        }

        private void frmMain_KeyUp(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, false);
        }

        // Game over call 
        private void Die()
        {
            Settings.IsGameOver = true;
        }
    }
}
