using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using System.Drawing;
using System.ComponentModel;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using App1.View;

namespace App1.ViewModel
{
    class ShopSearchVM
    {
        #region atributi
        private Korisnik curUser; //trenutni loginani user
        private String searchString; //uneseni string u search
        private List<Artikal> results; //rezultati pretrage
        #endregion

        #region komande
        public RelayCommand csearch { get; set; }
        public RelayCommand cfilter { get; set; }
        public RelayCommand clogin { get; set; }
        public RelayCommand cregister { get; set; }
        public RelayCommand cprofile { get; set; }
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
        /// inicijalizuje search page sa loginanim userom
        /// </summary>
        public ShopSearchVM(Korisnik user, String searched)
        {
            this.curUser = user;
            this.searchString = searched;
            this.results = new List<Artikal>();
            using (var db = new GameShopDbContext())
            {
                foreach(DataRow row in db.Rows)
                {
                    if (row["ime"].contains(searched))
                    {
                        this.results.Add(new Artikal(row["info"], row["ime"], (float)row["cijena"] / 100,
                            List<String>(getList(row["ListaKategorija"])), row["tipArtikla"], row["slika"]));
                    }
                }
            }
            this.csearch = new RelayCommand(pretraga);
            this.cfilter = new RelayCommand(filtriraj);
            this.clogin = new RelayCommand(logiranje);
            this.cregister = new RelayCommand(registracija);
            this.cprofile = new RelayCommand(profil);
        }
        /// <summary>
        /// kreiranje ShopSearchVM sa datim korisnikom pretrazenim stringom i kategorijama
        /// </summary>
        /// <param name="user"></param>
        /// <param name="searched"></param>
        /// <param name="kategorije"></param>
        public ShopSearchVM(Korisnik user, String searched, List<String> kategorije)
        {
            this.curUser = user;
            this.searchString = searched;
            this.results = new List<Artikal>();
            using (var db = new GameShopDbContext())
            {
                foreach (DataRow row in db.Rows)
                {
                    if (List<String>(getList(row["ListaKategorija"])) == kategorije && row["ime"].contains(searched))
                    {
                        this.results.Add(new Artikal(row["info"], row["ime"], (float)row["cijena"] / 100,
                            List<String>(getList(row["ListaKategorija"])), row["tipArtikla"], row["slika"]));
                    }
                }
            }
            this.csearch = new RelayCommand(pretraga);
            this.cfilter = new RelayCommand(filtriraj);
            this.clogin = new RelayCommand(logiranje);
            this.cregister = new RelayCommand(registracija);
            this.cprofile = new RelayCommand(profil);
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
        public List<Artikal> Results
        {
            get
            {
                return results;
            }
            set
            {
                results = value;
                OnPropertyChanged("Results");
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

        public void logiranje()
        {
            var frame = (Frame)Window.Current.Content;
            LoginVM neuVM = new LoginVM(this.curUser);
            frame.Navigate(typeof(LoginView), neuVM);
        }

        public void registracija()
        {
            var frame = (Frame)Window.Current.Content;
            RegisterVM neuVM = new RegisterVM(this.curUser);
            frame.Navigate(typeof(RegisterView), neuVM);
        }

        public void profil()
        {
            var frame = (Frame)Window.Current.Content;
            ProfileVM neuVM = new ProfileVM(this.curUser);
            frame.Navigate(typeof(ProfileView), neuVM);
        }
        #endregion
    }
}
