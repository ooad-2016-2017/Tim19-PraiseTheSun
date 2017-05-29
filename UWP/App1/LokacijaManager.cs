using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class LokacijaManager : ILokacijaManager
    {
        public bool dodajLokaciju(Lokacija loc);
        public bool obrisiLokaciju(Lokacija loc);
        public Lokacija dajLokaciju(int id);
        public int findID(Lokacija loc);
    }
}
