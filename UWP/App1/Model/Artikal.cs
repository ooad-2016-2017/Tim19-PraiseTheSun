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
    public enum artType { Fizicki, Elektronski }
    class Artikal
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //oznaci bazaID kao primarni kljuc za bazu
        public int bazaID { get; set; }
        public String ime { get; set; }
        public int cijena { get; set; } //cijena kao int koja je 100 puta veca od stvarne
        public artType tipArtikla { get; set; }
        public String info { get; set; } //opce informacije o artiklu
        public List<Kritika> listaKritika { get; set; }
        public List<String> listaKategorija { get; set; }
        public List<Artikal> listaPreporuka { get; set; }
        public SlikaArtikal slika { get; set; }
        public Boolean removed = false;
        public Artikal(String info, String ime, float cijena, List<String> listaKategorija, artType tipArtikla, Image slika)
        {
            this.info = info;
            this.ime = ime;
            this.cijena = (int)(cijena * 100 + 1e-6); //kako bi se izbjegao problem sa zaokruzivanjem
            this.listaKategorija = new List<String>(listaKategorija);
            this.tipArtikla = tipArtikla;
            this.slika = new SlikaArtikal(slika);
            const int maxWidth = 200;
            const int maxHeight = 200;
            if (slika.Width > maxWidth) throw new ArgumentException("Presiroka slika");
            if (slika.Height > maxHeight) throw new ArgumentException("Previsoka slika");
            this.listaKritika = new List<Kritika>();
            this.listaPreporuka = new List<Artikal>();
        }
        /*public void dodajKritiku(Kritika komentar)
        {
            listaKritika.Add(komentar);
        }
        public bool obrisiKritiku(Kritika komentar)
        {
            return listaKritika.Remove(komentar);
        }
        /*public void dodajPreporuku(Artikal preporuka)
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
        }*/
        public float dajCijenu() //vraca stvarnu cijenu artikla(float)
        {
            return (float)cijena / 100;
        }
    }
}

