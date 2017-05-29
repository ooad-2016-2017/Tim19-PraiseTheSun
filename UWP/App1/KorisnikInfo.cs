using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class KorisnikInfo
    {
        public String username { get; set; }
        public Password pass { get; set; }
        public KorisnikInfo(String username, String password)
        {
            this.username = username;
            this.password = Password(password);
        }
        public bool provjeriInfo(String username, String password) //provjerava da li su username i password jednaki username i passwordu ovog korisnika
        {
            return this.username == username && pass.provjeriPass(password);
        }
    }
}
