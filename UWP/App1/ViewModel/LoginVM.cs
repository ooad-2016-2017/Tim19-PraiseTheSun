using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.ViewModel
{
    class LoginVM
    {
        #region atributi
        private Korisnik curUser; //trenutni loginani user
        private String typedUser;
        private String typedPass;
        private String errMsg;
        #endregion

        #region komande
        public RelayCommand clogin { get; set; }
        public RelayCommand chome { get; set; }
        #endregion

        #region konstruktor
        /// <summary>
        /// inicijalizuje login page sa datim korisnikom
        /// </summary>
        public LoginVM(Korisnik user)
        {
            this.curUser = user;
            this.chome = new RelayCommand(backHome);
            this.clogin = new RelayCommand(logiranje);
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
        public String TypedUser
        {
            get
            {
                return typedUser;
            }
            set
            {
                typedUser = value;
                OnPropertyChanged("TypedUser");
            }
        }
        public String TypedPass
        {
            get
            {
                return typedPass;
            }
            set
            {
                typedPass = value;
                OnPropertyChanged("TypedPass");
            }
        }
        public String ErrMsg
        {
            get
            {
                return errMsg;
            }
            set
            {
                errMsg = value;
                OnPropertyChanged("ErrMsg");
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

        public void logiranje()
        {
            var frame = (Frame)Window.Current.Content;
            RegistrationManager rm = new RegistrationManager();
            Korisnik newUser = null; //novi user postavljen na null
            if (rm.postojiLi(typedUser, typedPass)) //ako postoji korisnik sa unesenim podacima
            {
                using (var db = new GameShopDbContext())
                {
                    foreach (DataRow row in db.Rows)
                    {
                        if (row["username"] == typedUser && Password(row["password"], 
                            row["salt"]).provjeriPass(typedPass))
                        {
                            newUser = new Korisnik(row["username"], Password(row["password"], row["salt"]),
                                Lokacija(row["adress"]), row["slika"], accType(row["tipAccounta"]));
                            break;
                        }
                    }
                }
            }
            if (newUser == null)
            {
                this.ErrMsg = "Neispravan username / password!";
            }
            else
            {
                HomepageVM neuVM = new HomepageVM(newUser);
                frame.Navigate(typeof(MainPage), neuVM);
            }
        }
        #endregion
    }
}
