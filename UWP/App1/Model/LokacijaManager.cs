using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class LokacijaManager : ILokacijaManager
    {
        public bool dodajLokaciju(Lokacija loc)
        {
            using (var db = new GameShopDbContext())
            {
                db.Lokacije.Add(loc);
            }
            return true;
        }
        public bool obrisiLokaciju(Lokacija loc)
        {
            using (var db = new GameShopDbContext())
            {
                db.Entry(loc).State = EntityState.Deleted;
                db.SaveChanges();
            }

            return true;
        }
        public Lokacija dajLokaciju(int id)
        {
            using (var db = new GameShopDbContext())
            {
                var dbEntry = db.Lokacije.FirstOrDefault(acc => acc.bazaID == id);
                return dbEntry;
            }
        }
        public int findID(Lokacija loc)
        {
            using (var db = new GameShopDbContext())
            {
                var dbEntry = db.Artikli.FirstOrDefault(acc => acc.bazaID == loc.bazaID);
                return dbEntry.bazaID;
            }
        }
    }
}
