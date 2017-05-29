using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    interface IKritikaManager
    {
        public void dodajKritiku(Kritika kom);
        public void obrisiKritiku(Kritika kom);
        public Kritika dajKritiku(int id);
        public int findID(Kritika kom);
    }
}
