using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacmanLab
{
    public class Pacman
    {
        public int X{get;set;}
        public int Y { get; set; }
        public enum DIRECTION { levo,desno,gore,dole};
        public DIRECTION direction { get; set; }
        public static int RADIUS = 20;
        public int Speed { get; set; }
        public bool MouthOpen = false;
        public Brush pacBrush= new SolidBrush(Color.Yellow);

        //PACMAN

        public Pacman()
        {
            X = 7;
            Y = 5;
            Speed = RADIUS;
            direction = DIRECTION.desno;
        }

        public void ChangeDirection(DIRECTION dir) {
            direction = dir;
        }
        public void Move(int x,int y) {
            if (direction == DIRECTION.desno )
            {
                if (X == x - 1)
                {
                    X = 0;
                }
                else { X++; }
            }
            else if (direction == DIRECTION.levo )
            {
                if (X == 0)
                {
                    X = x - 1;
                }
                else { X--; }
            }
            else if (direction == DIRECTION.dole)
            {
                if (Y == y - 1)
                {
                    Y = 0;
                }else { Y++; }
            }
            else if (direction == DIRECTION.gore)
            {
                if (Y == 0)
                {
                    Y = y - 1;
                }
                else { Y--; }
            }

           

        }
        public void Draw(Graphics g)
        {
            if (MouthOpen && direction==DIRECTION.desno)
            {
                g.FillPie(pacBrush, X*40, Y*40, RADIUS * 2, RADIUS * 2, 45, 270);
                MouthOpen = false;
            }
            else if(MouthOpen && direction == DIRECTION.dole)
            {
                g.FillPie(pacBrush, X * 40, Y * 40, RADIUS * 2, RADIUS * 2, 45, -270);
                MouthOpen = false;

            }
            else if (MouthOpen && direction == DIRECTION.gore)
            {
                g.FillPie(pacBrush, X * 40, Y * 40, RADIUS * 2, RADIUS * 2, -45, 270);
                MouthOpen = false;

            }
            else if (MouthOpen && direction == DIRECTION.levo)
            {
                g.FillPie(pacBrush, X * 40, Y * 40, RADIUS * 2, RADIUS * 2, 225, 270);
                MouthOpen = false;

            }
            else
            {
                g.FillEllipse(pacBrush, X * 40, Y * 40, RADIUS * 2, RADIUS * 2);
                MouthOpen = true;
            }
           
        }
    }
}
