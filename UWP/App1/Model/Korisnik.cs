using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel.DataAnnotations.Schema;
using Windows.UI.Xaml.Controls;

namespace App1
{
    public enum accType{ Korisnik, Premium, Kriticar, Zaposlenik, Admin };
    class Korisnik
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int bazaID { get; set; }
        public KorisnikInfo info { get; set; }
        public List<Artikal> kolekcija { get; set; }
        public Lokacija adresa { get; set; }
        public SlikaKorisnik slika { get; set; }
        public accType tipAccounta { get; set; }
        public Boolean removed = false;
        public Korisnik(String username, String password, string adress, Image slika, accType tipAccounta)
        {
            this.info = new KorisnikInfo(username, password);
            this.kolekcija = new List<Artikal>();
            this.adresa = new Lokacija(adress, locType.CivilnaLokacija);
            this.slika = new SlikaKorisnik(slika);
            const int maxWidth = 200;
            const int maxHeight = 200;
            if (slika.Width > maxWidth) throw new ArgumentException("Presiroka slika");
            if (slika.Height > maxHeight) throw new ArgumentException("Previsoka slika");
            this.tipAccounta = tipAccounta;
        }
        /*public bool imaArtikal(Artikal item)
        {
            return kolekcija.Contains(item);
        }
        public void dodajArtikal(Artikal item)
        {
            kolekcija.Add(item);
        }
        public bool obrisiArtikal(Artikal item)
        {
            return kolekcija.Remove(item);
        }*/
    }
}
