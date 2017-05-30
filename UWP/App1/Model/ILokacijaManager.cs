using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    interface ILokacijaManager
    {
        bool dodajLokaciju(Lokacija loc);
        bool obrisiLokaciju(Lokacija loc);
        Lokacija dajLokaciju(int id);
        int findID(Lokacija loc);
    }
}
