using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class KreditnaKartica
    {
        public String brojKartice { get; set; }
        public String tipKartice { get; set; }
        public String zastitniKod { get; set; }
        public int mjesecIsteka { get; set; }
        public int godinaIsteka { get; set; }
        public KreditnaKartica(String brojKartice, String tipKartice, String zastitniKod, int mjesecIsteka, int godinaIsteka)
        {
            if (mjesecIsteka < 1 || mjesecIsteka > 12) throw new ArgumentException("Mjesec nije u dozvoljenim granicama");
            if (godinaIsteka < 0) throw new ArgumentException("Godina nije u dozvoljenim granicama");
            this.brojKartice = brojKartice;
            this.tipKartice = tipKartice;
            this.zastitniKod = zastitniKod;
            this.mjesecIsteka = mjesecIsteka;
            this.godinaIsteka = godinaIsteka;
        }
        public bool josVazi() //ispitivanje da li kartica vazi u odnosu na trenutni datum
        {
            var deadline = new DateTime(godinaIsteka, mjesecIsteka, 1);
            return DateTime.Now < deadline;
        }
    }
}
