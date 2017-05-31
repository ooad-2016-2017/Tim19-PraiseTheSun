using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    interface IKolekcijaKorisnikaManager
    {
        bool dodajKolekciju(KolekcijaKorisnika kol);
        bool brisiKolekciju(KolekcijaKorisnika kol);
        List<KolekcijaKorisnika> dajKolekciju(int id);
        //int findID(KolekcijaKorisnika art);
    }
}
