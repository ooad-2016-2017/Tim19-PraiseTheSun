using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    interface IItemManager
    {
        bool dodajItem(Item objekt);
        bool obrisiItem(Item objekt);
        Item dajItem(int id);
        int findID(Item objekt);
    }
}
