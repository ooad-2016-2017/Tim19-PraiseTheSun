using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class KorisnikValidator : IKorisnikValidator
    {
        public bool validnost { get; set; }
        public String upute { get; set; }
        public KorisnikValidator(Korisnik user)
        {
            upute = "";
            validnost = true;
            foreach (Artikal art in user.kolekcija)
            {
                var artval = new ArtikalValidator(art);
                if (!artval.jeValidno())
                {
                    upute += "Artikal)\n";
                    upute += artval.dajUpute();
                    validnost = false;
                }
            }
            var cardval = new ValidatorKartica(user.kreditna);
            if (!cardval.jeValidno())
            {
                upute += cardval.dajUpute();
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
