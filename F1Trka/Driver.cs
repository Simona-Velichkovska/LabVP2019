using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1Trka
{
    public class Driver
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool First { get; set; }
        public List<Round> Rounds;

        public Driver(string name,int age, bool first)
        {
            Name = name;
            Age = age;
            First = first;
            Rounds = new List<Round>();
        }

        public void addRound(Round round)
        {
            Rounds.Add(round);
        }
        public override string ToString()
        {
            return string.Format("{0}({1})-{2}", Name, Age, First ? "F" : "S");
        }
    }
}
