using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacmanLab
{
    public partial class Form1 : Form
    {
        Random random;
        Pacman pacman;
        static readonly int TIMER_INTERVAL = 250;
        static readonly int WORLD_WIDTH = 15;
        static readonly int WORLD_HEIGHT = 10;
        Obstacle[] obstacles = new Obstacle[8];
        Image foodImage;
        bool[][] foodWorld;
        public Form1()
        {
            InitializeComponent();
            foodImage = Properties.Resources.Carrot;
            DoubleBuffered = true;
            pbPercent.Maximum = 150;
            pbPercent.Value = 150;
            initiateObstacles();
            newGame();
            
        }

        public void newGame()
        {
            pacman = new Pacman();
            this.Width = Pacman.RADIUS * 2 * (WORLD_WIDTH + 1);
            this.Height = Pacman.RADIUS * 2 * (WORLD_HEIGHT + 1)+40;
            // овде кодот за иницијализација на матрицата foodWorld
            foodWorld = new bool[WORLD_WIDTH][];
            for (int i = 0; i < WORLD_WIDTH; i++)
            {
                foodWorld[i] = new bool[WORLD_HEIGHT];
                for (int j = 0; j < WORLD_HEIGHT; j++)
                    foodWorld[i][j] = true;
            }

            // овде кодот за иницијализација и стартување на тајмерот
            timer = new Timer();
            timer.Interval = TIMER_INTERVAL;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }
        public void initiateObstacles()
        {
            random = new Random();
            
            for (int i = 0; i < 8; i++)
            {
                int x = i*2;
                int y = random.Next(0, WORLD_HEIGHT - 3);
               
                obstacles[i] = new Obstacle(x, y);
            }
            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // овде вашиот код
            
            for (int i = 0; i < WORLD_WIDTH; i++)
            {
                for (int j = 0; j < WORLD_HEIGHT; j++)
                {
                    
                    foodWorld[pacman.X][pacman.Y] = false;
                   

                }
            
            }
            
            
            pacman.Move(WORLD_WIDTH, WORLD_HEIGHT);
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);
            int points =-150;
            int progress = 0;
            for (int i = 0; i < foodWorld.Length; i++)
            {
               
                for (int j = 0; j < foodWorld[i].Length; j++)
                {
                    if (foodWorld[i][j])
                    {
                        g.DrawImageUnscaled(foodImage, i * Pacman.RADIUS * 2 + (Pacman.RADIUS * 2 - foodImage.Height) / 2, j * Pacman.RADIUS * 2 + (Pacman.RADIUS * 2 - foodImage.Width) / 2);
                        points++;
                        progress++;
                        
                       
                    }
                    
                }
               
            }
            for (int i = 0; i < 8; i++)
            {
                obstacles[i].Draw(g);
            }
            pacman.Draw(g);
            pbPercent.Value = progress;
            tbPoints.Text = Math.Abs(points).ToString();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

            // не заборавајте да го додадете настанот на самата форма
            // вашиот код овде
            if (e.KeyCode == Keys.Up)
            {
                pacman.ChangeDirection(Pacman.DIRECTION.gore);
            }
            else if (e.KeyCode == Keys.Down)
            {
                pacman.ChangeDirection(Pacman.DIRECTION.dole);
            }
            else if (e.KeyCode == Keys.Right)
            {
                pacman.ChangeDirection(Pacman.DIRECTION.desno);
            }
            else if (e.KeyCode == Keys.Left)
            {
                pacman.ChangeDirection(Pacman.DIRECTION.levo);
            }
            Invalidate();
        }
    }
}
