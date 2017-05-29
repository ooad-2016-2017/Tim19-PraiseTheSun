using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class ItemValidator : IItemValidator
    {
        public bool validnost { get; set; }
        public String upute { get; set; }
        public ItemValidator(Item objekt)
        {
            validnost = true;
            upute = "";
            var artval = new ArtikalValidator(objekt.art);
            if (!artval.jeValidno())
            {
                upute += artval.dajUpute();
                validnost = false;
            }
            if(objekt.datumProdaje > DateTime.Now) //kupovina se morala desiti prije trenutnog trenutka
            {
                upute += "Kupovina se desila u buducnosti.\n";
                validnost = false;
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
