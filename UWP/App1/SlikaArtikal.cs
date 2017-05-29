using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace App1
{
    class SlikaArtikal
    {
        public Image slika;
        public SlikaArtikal(Image slika)
        {
            const int maxWidth = 200;
            const int maxHeight = 200;
            if (slika.Width > maxWidth) throw new ArgumentException("Presiroka slika");
            if (slika.Height > maxHeight) throw new ArgumentException("Previsoka slika");
            this.slika = slika;
        }
    }
}
