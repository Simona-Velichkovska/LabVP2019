using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Produkti
    {
        public string Ime { get; set; }
        public string Katerogija { get; set; }
        public double Cena { get; set; }

        public int Kolicina { get; set; }

        public int preostanataKolicina { get; set; }
        public Produkti(string ime,string kategorija,double cena,int kolicina, int preostanato)
        {
            Ime = ime;
            Katerogija = kategorija;
            Cena = cena;
            Kolicina = kolicina;
            preostanataKolicina = preostanato;
        }

        public void newKolicina(int kol)
        {
            this.Kolicina = kol;

        }
       

        public override string ToString()
        {
            return string.Format("{0}", Ime);
        }

    }
}
