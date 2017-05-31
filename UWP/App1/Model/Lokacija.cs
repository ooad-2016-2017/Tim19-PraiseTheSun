using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    public enum locType { Skladiste, Prodavnica, Tvornica, Distributer, CivilnaLokacija };
    class Lokacija
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int bazaID { get; set; }
        public String adresa { get; set; }
        public locType tipLokacije { get; set; }
        public Boolean removed = false;
        public Lokacija() { }
        public Lokacija(String adresa, locType tipLokacije)
        {
            this.adresa = adresa;
            this.tipLokacije = tipLokacije;
        }
    }
}
