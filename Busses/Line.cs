using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busses
{
    public class Line
    {
        public string Destination { get; set; }
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Price { get; set; }

        public Line(string dest, int h, int m, int price)
        {
            Destination = dest;
            Hour = h;
            Minute = m;
            Price = price;
        }

        public override string ToString()
        {
            return String.Format("{0}:{1}-{2}-{3} Ден.",Hour,Minute,Destination,Price);
        }
    }
}
