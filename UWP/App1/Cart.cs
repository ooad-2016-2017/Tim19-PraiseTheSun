using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class Cart
    {
        public List<Artikal> items { get; set; }
        public int ukupnaCijena { get; set; }
        public Cart()
        {
            items = new List<Artikal>();
            ukupnaCijena = 0;
        }
        public void dodajArtikal(Artikal art)
        {
            items.Add(art);
            ukupnaCijena += art.cijena;
        }
        public bool obrisiArtikal(Artikal art)
        {
            ukupnaCijena -= art.cijena;
            return items.Remove(art);
        }
        public void isprazniKorpu()
        {
            items.Clear();
            ukupnaCijena = 0;
        }
        public float dajCijenu()
        {
            return (float)ukupnaCijena / 100;
        }
    }
}
