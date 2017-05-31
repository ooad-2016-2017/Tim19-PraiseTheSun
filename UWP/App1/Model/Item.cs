using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class Item
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int bazaID { get; set; }
        public DateTime datumProdaje { get; set; }
        public int trenutnaLokacija { get; set; }
        public Boolean removed = false;
        public Item(int art, int lokacija)
        {
            this.bazaID = art;
            this.trenutnaLokacija = lokacija;
            this.datumProdaje = new DateTime(1, 1, 1);
        }
        public void oznaciProdano()
        {
            this.datumProdaje = DateTime.Now;
        }
    }
}
