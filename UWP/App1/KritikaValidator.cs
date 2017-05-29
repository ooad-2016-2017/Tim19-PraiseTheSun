using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class KritikaValidator : IKritikaValidator
    {
        public bool validnost { get; set; }
        public String upute { get; set; }
        public KritikaValidator(Kritika K)
        {
            upute = "";
            validnost = true;
            const int minOcjena = 1;
            const int maxOcjena = 5;
            if(minOcjena > K.ocjena || maxOcjena < K.ocjena)
            {
                validnost = false;
                upute += "Ocjena nije unutar dozvoljenih ogranicenja\n";
            }
            const int maxKomLen = 256;
            if(K.komentar.Length > maxKomLen)
            {
                validnost = false;
                upute += "Komentar predug\n";
            }
        }
        public bool jeValidno()
        {
            return validnost;
        }
        public String dajUpute()
        {
            return upute;
        }
    }
}
