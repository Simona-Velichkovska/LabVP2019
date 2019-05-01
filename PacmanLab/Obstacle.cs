using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacmanLab
{
    public class Obstacle
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Brush obsBrush = new SolidBrush(Color.Blue);


        public Obstacle(int x,int y)
        {
            X = x;
            Y = y;
        }
        public void Draw(Graphics g)
        {
            g.FillRectangle(obsBrush, X*40, Y*40, 40,120);
        }
    }
}
