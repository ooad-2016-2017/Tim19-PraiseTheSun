using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    interface IKorisnikManager
    {
        bool dodajKorisnika(Korisnik user);
        bool obrisiKorisnika(Korisnik user);
        Korisnik dajKorisnika(int id);
        String findID(Korisnik user);
    }
}
