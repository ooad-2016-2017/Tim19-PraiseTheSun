using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class DostavneInformacije
    {
        public Korisnik kupac { get; set; }
        public Lokacija prodajnoMjesto { get; set; }
        public Artikal prodajniArtikal { get; set; }
        public DostavneInformacije(Korisnik kupac, Lokacija prodajnoMjesto, Artikal prodajniArtikal)
        {
            this.kupac = kupac;
            this.prodajniArtikal = prodajniArtikal;
            this.prodajnoMjesto = prodajnoMjesto;
        }
    }
}
