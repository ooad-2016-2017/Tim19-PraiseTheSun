using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class Kritika
    {
        public int id_korisnika { get; set; }
        public int id_artikla { get; set; }
        public String komentar { get; set; }
        public int ocjena { get; set; }
        public Boolean removed = false;
        public Kritika() { }
        public Kritika(String komentar, int ocjena, int user, int art)
        {
            this.komentar = komentar;
            this.ocjena = ocjena;
            this.id_korisnika = user;
            this.id_artikla = art;
        }
        public static  bool operator <(Kritika A, Kritika B) //poredi Kritike po datim ocjenama
            //Hey Jane, trebaš i za > napraviti!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        {
            return A.ocjena < B.ocjena;
        }
    }
}
