using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    interface IKritikaManager
    {
        void dodajKritiku(Kritika kom);
        void obrisiKritiku(Kritika kom);
        List<Kritika> dajKritiku(int id);
        //int findID(Kritika kom);
    }
}
