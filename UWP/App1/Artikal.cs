using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace App1
{
    class Artikal
    {
        public enum artType{ Fizicki, Elektronski }
        public String ime { get; set; }
        public int cijena { get; set; }
        public artType tipArtikla { get; set; }
        public String info { get; set; }
        public int bazaID { get; set; }
        public List<Kritika> listaKritika { get; set; }
        public List<String> listaKategorija { get; set; }
        public List<Artikal> listaPreporuka { get; set; }
        public SlikaArtikal slika { get; set; }
        
        Artikal(artType tipArtikla)
        {
            this.tipArtikla = tipArtikla;
        }
        Artikal(String info, String ime, float cijena, List<String> listaKategorija, artType tipArtikla, Image slika, String sifra)
        {
            this.info = info;
            this.ime = ime;
            this.cijena = (int)(cijena * 100 + 1e-6);
            this.listaKategorija = listaKategorija;
            this.tipArtikla = tipArtikla;
            this.slika = new SlikaArtikal(slika);
        }
        public void dodajKritiku(Kritika komentar)
        {
            listaKritika.Add(komentar);
        }
        public bool obrisiKritiku(Kririka komentar)
        {
            return listaKritika.Remove(komentar);
        }
        public void dodajPreporuku(Artikal preporuka)
        {
            listaPreporuka.Add(preporuka);
        }
        public bool obrisiPreporuku(Artikal preporuka)
        {
            return listaPreporuka.Remove(preporuka);
        }
        public void dodajKategoriju(String kategorija)
        {
            listaKategorija.Add(kategorija);
        }
        public bool obrisiKategoriju(String kategorija)
        {
            return listaKategorija.Remove(kategorija);
        }
        public float dajCijenu()
        {
            return (float)cijena / 100;
        }
    }
}

