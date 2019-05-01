using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobiles
{
    public class Marka
    {
        public string Ime { get; set; }
        public string Sifra { get; set; }
        
        public Marka(string ime, string sifra)
        {
            Ime = ime;
            Sifra = sifra;
        }

        public override string ToString()
        {
            return string.Format("{0} ({1})",Ime, Sifra);
        }
    }
}
