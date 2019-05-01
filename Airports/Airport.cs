using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airports
{
    public class Airport
    {
        public string Grad { get; set; }
        public string Ime { get; set; }
        public string Kratenka { get; set; }
        public List<Destination> Destinations;

        public Airport(string grad, string ime, string kratenka)
        {
            Grad = grad;
            Ime = ime;
            Kratenka = kratenka;
            Destinations = new List<Destination>();
        }

        public void addDestination(Destination destination)
        {
            Destinations.Add(destination);
        }

        public override string ToString()
        {
            return string.Format("{0}-{1}-{2}", Kratenka, Ime, Grad);
        }
    }
}
