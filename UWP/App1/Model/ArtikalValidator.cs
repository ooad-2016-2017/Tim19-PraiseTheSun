using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class ArtikalValidator : IArtikalValidator
    {
        public bool validnost { get; set; }
        public string upute { get; set; }
        public ArtikalValidator(Artikal roba)
        {
            validnost = true;
            upute = "";
            const int maxImeLen = 20;
            const int maxCijena = 100000000;
            const int maxInfoLen = 256;
            if(roba.ime.Length > maxImeLen)
            {
                validnost = false;
                upute = "Predugo ime artikla\n";
            }
            if(roba.cijena > maxCijena)
            {
                validnost = false;
                upute += "Prevelika cijena artikla\n";
            }
            if(roba.info.Length > maxInfoLen)
            {
                validnost = false;
                upute += "String koji sadrzi informacije o artiklu predug\n";
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
