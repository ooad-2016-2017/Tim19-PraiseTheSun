using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class MockCreditCardService : ICreditCardService
    {
        public bool zahtjevProdaja(Cart korpa, KreditnaKartica card)
        {
            Random rnd = new Random((int)DateTime.Now.Ticks);
            int roll = rnd.Next(1, 10);
            return roll != 10;
        }
    }
}
