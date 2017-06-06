using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.ViewModel
{
    class FilterVM
    {
        #region atributi
        private Korisnik curUser; //trenutni loginani user
        private String searchString; //uneseni string u search
        private List<String> kategorije; //selektovane kategorije
        #endregion

        #region komande
        public RelayCommand csearch { get; set; }
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
        /// inicijalizuje filter page sa loginanim userom
        /// </summary>
        public FilterVM(Korisnik user)
        {
            this.curUser = user;
            this.kategorije = new List<String>();
            this.csearch = new RelayCommand(pretraga);
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
        public List<String> Results
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
            ShopSearchVM neuVM = new ShopSearchVM(this.curUser, this.searchString, this.kategorije);
            frame.Navigate(typeof(ShopSearchView), neuVM);
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
