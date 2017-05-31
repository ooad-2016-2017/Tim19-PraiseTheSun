using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class KolekcijaKorisnikaManager : IKolekcijaKorisnikaManager
    {
        bool dodajKolekciju(KolekcijaKorisnika kol)
        {
            using (var db = new GameShopDbContext())
            {
                db.Collection.Add(kol);
            }
            return true;
        }
        bool brisiKolekciju(KolekcijaKorisnika kol)
        {
            using (var db = new GameShopDbContext())
            {
                db.Entry(kol).State = EntityState.Deleted;
                db.SaveChanges();
            }

            return true;
        }
        List<KolekcijaKorisnika> dajKolekciju(int id)
        {
            using (var db = new GameShopDbContext())
            {
                IQueryable<KolekcijaKorisnika> collection = from p in db.Collection
                                               select p;
                KolekcijaKorisnika[] collectionArray = collection.ToArray();
                List<KolekcijaKorisnika> collectionList = new List<KolekcijaKorisnika>();
                foreach (var k in collectionArray)
                {
                    if (k.id_korisnika == id)
                    {
                        collectionList.Add(k);
                    }
                }

                return collectionList;
            }
        }
        //int findID(KolekcijaKorisnika art);
    }
}
