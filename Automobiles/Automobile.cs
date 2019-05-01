using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobiles
{
    public class Automobile
    {
        public List<Marka> marki;
        public string Model { get; set; }
        public int Potroshuvacka { get; set; }
        public int Cena { get; set;}

        public Automobile(string model, int p, int c)
        {
            Model = model;
            Potroshuvacka = p;
            Cena = c;
            marki = new List<Marka>();
        }

        public void addMarka(Marka marka)
        {
            marki.Add(marka);
        }
        public override string ToString()
        {
            return string.Format("{0} {1} ({2:#.0}) : {3}", marki[0].Ime, Model, Potroshuvacka, Cena);
        }
    }
}
