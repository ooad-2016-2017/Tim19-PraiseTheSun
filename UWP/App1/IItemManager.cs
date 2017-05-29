using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    interface IItemManager
    {
        public bool dodajItem(Item objekt);
        public bool obrisiItem(Item objekt);
        public Item dajItem(int id);
        public int findID(Item objekt);
    }
}
