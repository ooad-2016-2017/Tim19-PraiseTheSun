using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class KritikaManager : IKritikaManager
    {
        public void dodajKritiku(Kritika kom)
        {
            using (var db = new GameShopDbContext())
            {
                db.Kritike.Add(kom);
            }
            //return true;
        }
        public void obrisiKritiku(Kritika kom)
        {
            using (var db = new GameShopDbContext())
            {
                db.Entry(kom).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }
        public List<Kritika> dajKritiku(int id)
        {
            using (var db = new GameShopDbContext())
            {
                IQueryable<Kritika> kritike = from p in db.Kritike                                               
                                               select p;
                Kritika[] kritikaArray = kritike.ToArray();
                List<Kritika> kritikaList = new List<Kritika>();
                foreach(var k in kritikaArray)
                {
                    if (k.id_korisnika == id)
                    {
                        kritikaList.Add(k);
                    }
                }


                return kritikaList;
            }
        }
        //public int findID(Kritika kom);
    }
}
