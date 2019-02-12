using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace koncniProjekt
{
    class Sestavina
    {
        public string Ime { set; get; }
        public string Kolicina { set; get; }
        public string Enota { set; get; }

        public Sestavina(string ime, string kolicina, string enota)
        {
            Ime = ime;
            Kolicina = kolicina;
            Enota = enota;
        }

        public string izpis()
        {
            return Ime + "," + Kolicina + " " + Enota;
        }
    }
}
