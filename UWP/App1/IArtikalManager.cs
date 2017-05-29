using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    interface IArtikalManager
    {
        bool dodajArtikal(Artikal art);
        bool brisiArtikal(Artikal art);
        Artikal dajArtikal(int id);
        int findID(Artikal art);
    }
}
