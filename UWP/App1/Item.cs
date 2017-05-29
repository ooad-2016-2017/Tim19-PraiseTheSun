using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class Item
    {
        public Artikal art { get; set; }
        public DateTime datumProdaje { get; set; }
        public Lokacija trenutnaLokacija { get; set; }
        public int bazaID { get; set; }
        public Item(Artikal art, Lokacija lokacija)
        {
            this.art = art;
            this.trenutnaLokacija = lokacija;
            this.datumProdaje = new DateTime(1, 1, 1);
        }
        public void oznaciProdano()
        {
            this.datumProdaje = DateTime.Now;
        }
    }
}
