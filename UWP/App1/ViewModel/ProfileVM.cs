using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.ViewModel
{
    class ProfileVM
    {
        #region atributi
        private Korisnik curUser; //trenutni loginani user
        private String searchString; //uneseni string u searchu
        #endregion

        #region komande
        public RelayCommand csearch { get; set; }
        public RelayCommand cfilter { get; set; }
        public RelayCommand csettings { get; set; }
        public RelayCommand cpremium { get; set; }
        public RelayCommand ckolekcija { get; set; }
        public RelayCommand chome { get; set; }
        #endregion

        #region konstruktor
        /// <summary>
        /// daje listu stringova iz regexpanog stringa odvojenog sa ';'
        /// </summary>
        /// <param name="regexp"></param>
        /// <returns></returns>
        private List<String> getList(String regexp)
        {
            List<String> lista = new List<String>;
            String cur = "";
            foreach (char letter in regexp)
            {
                if (letter == ";")
                {
                    lista.Add(cur);
                }
                else
                {
                    cur += letter;
                }
            }
            return lista;
        }

        /// <summary>
        /// inicijalizuje login page sa datim korisnikom
        /// </summary>
        public LoginVM(Korisnik user)
        {
            this.curUser = user;
            this.chome = new RelayCommand(backHome);
            this.csearch = new RelayCommand(pretraga);
            this.cfilter = new RelayCommand(filtriraj);
            this.csettings new RelayCommand(opcije);
            this.cpremium = new RelayCommand(premium);
            this.ckolekcija = new RelayCommand(kolekcija);
        }
        #endregion

        #region implementacija interfejsa
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion

        #region osobine
        public Korisnik CurUser
        {
            get
            {
                return curUser;
            }
            set
            {
                curUser = value;
                OnPropertyChanged("CurUser");
            }
        }
        public String SearchString
        {
            get
            {
                return searchString;
            }
            set
            {
                searchString = value;
                OnPropertyChanged("SearchString");
            }
        }
        #endregion

        #region metode
        public void backHome()
        {
            var frame = (Frame)Window.Current.Content;
            HomepageVM neuVM = new HomepageVM(this.curUser);
            frame.Navigate(typeof(MainPage), neuVM);
        }

        public void pretraga()
        {
            var frame = (Frame)Window.Current.Content;
            ShopSearchVM neuVM = new ShopSearchVM(this.curUser, this.searchString);
            frame.Navigate(typeof(ShopSearchView), neuVM);
        }

        public void filtriraj()
        {
            var frame = (Frame)Window.Current.Content;
            FilterVM neuVM = new FilterVM(this.curUser);
            frame.Navigate(typeof(FilterView), neuVM);
        }

        public void opcije()
        {
            var frame = (Frame)Windows.Current.Content;
            SettingsVM neuVM = new SettingsVM(this.curUser);
            frame.Navigate(typeof(SettingsView), neuVM);
        }

        public void premium()
        {
            var frame = (Frame)Windows.Current.Content;
            Artikal premiumMembership = null;
            using (var db = new GameShopDbContext())
            {
                foreach (DataRow row in db.Rows)
                {
                    if (row["ime"] == "Premium Membership")
                    {
                        premiumMembership = new Artikal(row["info"], row["ime"], (float)row["cijena"] / 100, 
                            getList(row["listaKategorija"]), artType(row["tipArtikla"]), row["slika"]);
                        break;
                    }
                }
            }
            ArtikalVM neuVM = new ArtikalVM(this.curUser, premiumMembership);
            frame.Navigate(typeof(ArtikalView), neuVM);
        }

        public void kolekcija()
        {
            var frame = (Frame)Windows.Current.Content;
            KolekcijaVM neuVM = new KolekcijaVM(this.curUser);
            frame.Navigate(typeof(KolekcijaView), neuVM);
        }

        #endregion

    }
}
