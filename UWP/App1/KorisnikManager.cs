using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class KorisnikManager : IKorisnikManager
    {
        public bool dodajKorisnika(Korisnik user);
        public bool obrisiKorisnika(Korisnik user);
        public Korisnik dajKorisnika(String id);
        public String findID(Korisnik user);
    }
}
