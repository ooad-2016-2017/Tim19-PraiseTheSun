using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{//cini mi se da sam trebao ovu klau napraviti umjesto koristenja liste artikala zbog baze
    class KolekcijaKorisnika
    {
        public int id_korisnika { get; set; }
        public int id_artikal { get; set; }
        public Boolean removed = false;

        public KolekcijaKorisnika(int id_k, int id_a)
        {
            this.id_korisnika = id_k;
            this.id_artikal = id_a;
        }
    }
}
