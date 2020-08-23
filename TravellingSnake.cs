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
        private int sec = 0;
        private int min = 0;
        private int hours = 0;
        public frmMain()
        {
            InitializeComponent();
            lblScoreValue.Visible = true;

            //making the default settings
            new Settings();
            gameTimer.Interval = 1000 / Settings.SnakeSpeed;
            playingTimeTimer.Interval = 1000 / Settings.SnakeSpeed;

            /* Adds the event and the event handler for the method that will 
			process the timer event to the timer. event bind code / event handling method linking with timer 
            (Method Reference). Event handler takes a delegate which matches the method's arguments*/
            

            gameTimer.Tick += RefreshScreen;
            playingTimeTimer.Tick += TimePlayed;

            gameTimer.Start();
            playingTimeTimer.Start();

            //Start the new game
            StartGame();

        }
        private void TimePlayed(object sender, EventArgs e)
        {

            if (Settings.IsGameOver == false)
            {
                playingTimeTimer.Start();
                sec++;
                if (sec > 59)
                {
                    sec = 0;
                    min++;
                }
                if(min>59)
                {
                    min = 0;
                    hours++;
                }    
                if (sec <= 9)
                    txtSeconds.Text = "0" + sec;
                else
                    txtSeconds.Text = "" + sec;
                if (min <= 9)
                    txtMinutes.Text = "0" + min;
                else
                    txtMinutes.Text = "" + min;
                if (hours <= 9)
                    txtMinutes.Text = "0" + hours;
                else
                    txtMinutes.Text = "" + hours;
            }
            if(Settings.IsGameOver == true)
            {
                playingTimeTimer.Stop();
                sec = 0;
                min = 0;
                hours = 0;
            }
            
            //Console.WriteLine("reached here ");
            //MessageBox.Show("Reached here");
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
            int maxXPossition = gameWorld.Size.Height / Settings.ItemHeight;
            int maxYPossition = gameWorld.Size.Width / Settings.ItemWidth;

            //int maxXPossition = gameWorld.Size.Height;
            //int maxYPossition = gameWorld.Size.Width;

            Random random = new Random();
            food = new Item();
            food.X = random.Next(0, maxXPossition);
            food.Y = random.Next(0, maxXPossition);

            Console.WriteLine("GameWorld Coordinates X= " + gameWorld.Size.Height.ToString() + ", Y= " + gameWorld.Size.Width.ToString() + "");
            Console.WriteLine("Max Possitions Coordinates for X= " + maxXPossition + ", and Y= " + maxYPossition + "");
            Console.WriteLine("food placed at X= " + food.X.ToString() + ", Y= " + food.Y.ToString() + "");
        }

        // It will update the pb (GameWorld) every time interval set in timer and detect for the key pressed and snake movements
        private void RefreshScreen(object sender, EventArgs e)
        {
            // check for game over
            if (Settings.IsGameOver)
            {
                if (Input.KeyPressed(Keys.Enter))
                {
                    StartGame();
                    TimePlayed(sender,e);
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
                //MessageBox.Show("Reached here");
                MoveSnake();   //funcation call

            }
            gameWorld.Invalidate();   //update the picture box used as sanke game World
        }

        // will create the snake and food
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
                        sankeColor = Brushes.Brown;
                    }
                    else
                    {
                        sankeColor = Brushes.RosyBrown;
                    }

                    // snake location coordinates with head and body
                    canvas.FillEllipse(sankeColor,
                        new Rectangle(Snake[i].X * Settings.ItemWidth,
                                      Snake[i].Y * Settings.ItemHeight,
                                      Settings.ItemWidth, Settings.ItemHeight));

                    //draw food
                    canvas.FillEllipse(Brushes.Green,
                       new Rectangle(food.X * Settings.ItemWidth,
                                     food.Y * Settings.ItemHeight, Settings.ItemWidth, Settings.ItemHeight));

                    //Console.WriteLine("value of food.x = " + food.X + " abd food.Y = " + food.Y);
                    //Console.WriteLine("value of Item w and H = " + Settings.ItemWidth + " abd food.Y = "+Settings.ItemHeight);
                    //Console.WriteLine("value of multiplication food.x = " + food.X * Settings.ItemWidth + " abd food.Y = " + food.Y * Settings.ItemHeight);
                }
            }
            else
            {
                string gameOver = "Game Over \n Press Enter to try Again";
                lblGameOver.Text = gameOver;
                lblGameOver.Visible = true;
            }
        }

        // method used to move the snake to eat food wtih conditions applied
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
                    //Get maximum X and Y Pos
                    int maxXPossition = gameWorld.Size.Width / Settings.ItemWidth;
                    int maxYPossition = gameWorld.Size.Height / Settings.ItemHeight;

                    //Detect collission with game borders.
                    if (Snake[i].X < 0 || Snake[i].Y < 0
                        || Snake[i].X >= maxXPossition || Snake[i].Y >= maxYPossition)
                    {
                        Die();
                    }


                    //Detect collission with body
                    for (int j = 1; j < Snake.Count; j++)
                    {
                        if (Snake[i].X == Snake[j].X &&
                           Snake[i].Y == Snake[j].Y)
                        {
                            Die();
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

        // method for eat opration of the snake
        private void Eat()
        {
            //Add item as a circle to increase snake body
            Item bodyPart= new Item();
            bodyPart.X = Snake[Snake.Count - 1].X;
            bodyPart.Y = Snake[Snake.Count - 1].Y;
            Snake.Add(bodyPart);

            //Update Score
            Settings.Score += Settings.Points;
            lblScoreValue.Text = Settings.Score.ToString();
            
            //Settings.SnakeSpeed++;
            //Console.WriteLine("speed check : " + Settings.SnakeSpeed);
            AddFood();
        }

        // Game over call 
        private void Die()
        {
            Settings.IsGameOver = true;
        }


        // To Test Coordinated
        private void gameWorld_MouseClick(object sender, MouseEventArgs e)
        {
            lblXYCoordinateInfo.Text = "X: " + e.X + " / Y: " + e.Y;
        }
    }
}
