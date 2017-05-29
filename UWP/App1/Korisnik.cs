using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace App1
{
    public enum accType{ Korisnik, Premium, Kriticar, Zaposlenik, Admin };
    class Korisnik
    {
        public KorisnikInfo info { get; set; }
        public List<Artikal> kolekcija { get; set; }
        public String bazaID { get; set; }
        public Lokacija adresa { get; set; }
        public KreditnaKartica kreditna { get; set; }
        public SlikaKorisnik slika { get; set; }
        public accType tipAccounta { get; set; }
        public Korisnik(String username, String password, String adress, KreditnaKartica kreditna, Image slika, accType tipAccounta)
        {
            this.info = new KorisnikInfo(username, password);
            this.kolekcija = new List<Artikal>();
            this.Lokacija = new Lokacija(adress, locType.CivilnaLokacija);
            this.kreditna = kreditna;
            this.slika = new SlikaKorisnik(slika);
            this.tipAccounta = tipAccounta;
        }
        public bool imaArtikal(Artikal item)
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
        }
    }
}
