using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class KorisnikManager : IKorisnikManager
    {
        public bool dodajKorisnika(Korisnik user)
        {
            using (var db = new GameShopDbContext())
            {
                db.Korisnici.Add(user);
            }
            return true;
        }
        public bool obrisiKorisnika(Korisnik user)
        {
            using (var db = new GameShopDbContext())
            {
                db.Entry(user).State = EntityState.Deleted;
                db.SaveChanges();
            }

            return true;
        }
        public Korisnik dajKorisnika(int id)
        {
            using (var db = new GameShopDbContext())
            {
                var dbEntry = db.Korisnici.FirstOrDefault(acc => acc.bazaID == id);
                return dbEntry;
            }
        }
        public String findID(Korisnik user)
        {
            using (var db = new GameShopDbContext())
            {
                var dbEntry = db.Korisnici.FirstOrDefault(acc => acc.bazaID == user.bazaID);
                return dbEntry.bazaID;
            }
        }
    }
}
