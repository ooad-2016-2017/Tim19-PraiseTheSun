using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace App1
{
    public enum artType { Fizicki, Elektronski }
    class Artikal
    {
        public String ime { get; set; }
        public int cijena { get; set; } //cijena kao int koja je 100 puta veca od stvarne
        public artType tipArtikla { get; set; }
        public String info { get; set; } //opce informacije o artiklu
        public int bazaID { get; set; }
        public List<Kritika> listaKritika { get; set; }
        public List<String> listaKategorija { get; set; }
        public List<Artikal> listaPreporuka { get; set; }
        public SlikaArtikal slika { get; set; }
        public Artikal(String info, String ime, float cijena, List<String> listaKategorija, artType tipArtikla, Image slika, String sifra)
        {
            this.info = info;
            this.ime = ime;
            this.cijena = (int)(cijena * 100 + 1e-6); //kako bi se izbjegao problem sa zaokruzivanjem
            this.listaKategorija = new List<String>(listaKategorija);
            this.tipArtikla = tipArtikla;
            this.slika = slika;
            this.listaKritika = new List<Kritika>();
            this.listaPreporuka = new List<Artikal>();
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
        public float dajCijenu() //vraca stvarnu cijenu artikla(float)
        {
            return (float)cijena / 100;
        }
    }
}

