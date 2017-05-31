using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class ItemManager : IItemManager
    {
        public bool dodajItem(Item objekt)
        {
            using (var db = new GameShopDbContext())
            {
                db.Items.Add(objekt);
            }
            return true;
        }
        public bool obrisiItem(Item objekt)
        {
            using (var db = new GameShopDbContext())
            {
                db.Entry(objekt).State = EntityState.Deleted;
                db.SaveChanges();
            }

            return true;
        }
        public Item dajItem(int id)
        {
            using (var db = new GameShopDbContext())
            {
                var dbEntry = db.Items.FirstOrDefault(acc => acc.bazaID == id);
                return dbEntry;
            }
        }
        public int findID(Item objekt)
        {
            using (var db = new GameShopDbContext())
            {
                var dbEntry = db.Artikli.FirstOrDefault(acc => acc.bazaID == objekt.bazaID);
                return dbEntry.bazaID;
            }
        }
    }
}
