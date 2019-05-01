using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Series
{
    public class Series
    {
        public Production production;
        public string Name { get; set; }
        public decimal Rating { get; set; }
        public int Seasons { get; set; }

        public Series(string name,decimal rating, int seasons, Production prod)
        {
            Name = name;
            Rating = rating;
            Seasons = seasons;
            production = prod;
        }



        public override string ToString()
        {
            return string.Format("{0} {1} ({2}) S:{3}", production.Name, Name, Rating, Seasons);
        }
    }
}
