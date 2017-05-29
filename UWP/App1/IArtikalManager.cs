using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    interface IArtikalManager
    {
        public bool dodajArtikal(Artikal art);
        public bool brisiArtikal(Artikal art);
        public Artikal dajArtikal(int id);
        public int findID(Artikal art);
    }
}
