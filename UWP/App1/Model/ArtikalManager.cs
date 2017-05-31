using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class ArtikalManager : IArtikalManager
    {
        public bool dodajArtikal(Artikal art)
        {
            using (var db = new GameShopDbContext())
            {              
                db.Artikli.Add(art);
            }
            return true;
        }
        public bool brisiArtikal(Artikal art)
        {
            using (var db = new GameShopDbContext())
            {
                db.Entry(art).State = EntityState.Deleted;
                db.SaveChanges();
            }

            return true;
        }
        public Artikal dajArtikal(int id)
        {
            using (var db = new GameShopDbContext())
            {
                var dbEntry = db.Artikli.FirstOrDefault(acc => acc.bazaID == id);
                return dbEntry;
            }
        }
        public int findID(Artikal art)
        {
            using (var db = new GameShopDbContext())
            {
                var dbEntry = db.Artikli.FirstOrDefault(acc => acc.bazaID == art.bazaID);
                return dbEntry.bazaID;
            }
        }
    }
}
