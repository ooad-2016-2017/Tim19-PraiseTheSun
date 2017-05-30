using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class Kritika
    {
        public String komentar { get; set; }
        public int ocjena { get; set; }
        public Korisnik user { get; set; }
        public int bazaID { get; set; }
        public Kritika() { }
        public Kritika(String komentar, int ocjena, Korisnik user)
        {
            this.komentar = komentar;
            this.ocjena = ocjena;
            this.user = user;
        }
        public bool operator <(Kritika A, Kritika B) //poredi Kritike po datim ocjenama
        {
            return A.ocjena < B.ocjena;
        }
    }
}
