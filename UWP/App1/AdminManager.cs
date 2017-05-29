using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class AdminManager
    {
        Korisnik admin;
        AdminManager(Korisnik admin) //provjerava se da li je korisnik admin
        {
            if (admin.tipAccounta != accType.Admin) throw new ArgumentException("Korisnik nije admin");
            this.admin = admin;
        }
        public bool banKorisnik(Korisnik user)
        {

        }
        public bool ukloniKritiku(Kritika kom)
        {

        }
    }
}
