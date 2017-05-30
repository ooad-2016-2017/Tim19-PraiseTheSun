using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class ValidatorKartica : IValidatorKartica
    {
        public bool validnost { get; set; }
        public String upute { get; set; }
        public ValidatorKartica(KreditnaKartica card)
        {
            validnost = true;
            upute = "";
            DateTime istek = new DateTime(card.godinaIsteka, card.mjesecIsteka, 1);
            if(istek < DateTime.Now) //ispitivanje isteka kartice
            {
                upute += "Isteklo vrijeme vazenja kartice\n";
                validnost = false;
            }
            if(card.tipKartice != "American Express" && card.tipKartice != "Discover" && card.tipKartice != "MasterCard" && card.tipKartice != "Visa") 
            //tip mora biti medju 4 predvidjena
            {
                upute += "Nije validan tip kartice\n";
                validnost = false;
            }
            if(card.brojKartice.Length != 16) //duzina mora biti 16
            {
                upute += "Nije validna duzina broja kreditne kartice(treba biti 16)\n";
                validnost = false;
            }
            foreach(char letter in card.brojKartice) //svi karakteri moraju biti cifre
            {
                if(!Char.IsDigit(letter))
                {
                    upute += "Broj kreditne kartice se mora sastojati iskljucivo od cifri\n";
                    validnost = false;
                    break;
                }
            }
            if (card.zastitniKod.Length - Convert.ToInt32((card.tipKartice == "American Express")) != 3) //duzina mora biti 3 ili 4
            {
                upute += "Nije validna duzina zastitnog koda(treba biti 4 za American Express i 3 za ostale)\n";
                validnost = false;
            }
            foreach(char letter in card.zastitniKod)
            {
                if (!Char.IsDigit(letter))
                {
                    upute += "Zastitni kod se mora sastojati iskljucivo od cifri\n";
                    validnost = false;
                    break;
                }
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
