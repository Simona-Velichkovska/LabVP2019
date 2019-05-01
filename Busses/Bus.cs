using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busses
{
    public class Bus
    {
        public string Registration { get; set; }
        public string Name { get; set; }
        public bool Local { get; set; }
        public List<Line> Lines;

        public Bus(string reg, string name, bool local)
        {
            Registration = reg;
            Name = name;
            Local = local;
            Lines = new List<Line>();
        }

        public void addLine(Line line)
        {
            Lines.Add(line);
        }

        public override string ToString()
        {
            return String.Format("{0}-{1}-{2}", Name, Registration, Local ? "L" : "M");
        }

    }
}
