using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    public enum locType { Skladiste, Prodavnica, Tvornica, Distributer, CivilnaLokacija };
    class Lokacija
    {
        public String adresa { get; set; }
        public locType tipLokacije { get; set; }
        public int bazaID { get; set; }
        public Lokacija() { }
        public Lokacija(String adresa, locType tipLokacije)
        {
            this.adresa = adresa;
            this.tipLokacije = tipLokacije;
        }
    }
}
