using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1Trka
{
    public class Round
    {
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public Round(int min, int sec)
        {
            Minutes = min;
            Seconds = sec;
        }

        public override string ToString()
        {
            return string.Format("{0}:{1:00}", Minutes, Seconds);
        }

        public int Time
        {
            get
            {
                return Minutes * 60 + Seconds;
            }
        }
    }
}
