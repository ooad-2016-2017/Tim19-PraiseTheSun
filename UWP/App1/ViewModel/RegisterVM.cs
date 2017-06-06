using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.ViewModel
{
    class RegisterVM
    {
        #region atributi
        private Korisnik curUser; //trenutni loginani user
        private String typedUser;
        private String typedPass;
        private String confirmPass;
        private String adress;
        private String errMsg;
        #endregion

        #region komande
        public RelayCommand cregister { get; set; }
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
            this.cregister = new RelayCommand(registracija);
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
        public String ConfirmPass
        {
            get
            {
                return confirmPass;
            }
            set
            {
                confirmPass = value;
                OnPropertyChanged("ConfirmPass");
            }
        }
        public String Adress
        {
            get
            {
                return adress;
            }
            set
            {
                adress = value;
                OnPropertyChanged("Adress");
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

        public void registracija()
        {
            var frame = (Frame)Window.Current.Content;
            RegistrationManager rm = new RegistrationManager();
            Korisnik newUser = this.curUser; //novi user postavljen na null
            if (!rm.postojiLi(typedUser, typedPass)) //ako postoji korisnik sa unesenim podacima
            {
                using (var db = new GameShopDbContext())
                {
                    rm.KreirajAccount(typedUser, typedPass);
                }
                newUser = null;
            }
            if(newUser == null)
            {
                HomepageVM neuVM = new HomepageVM(newUser);
                frame.Navigate(typeof(MainPage), neuVM);
            }
            else
            {
                errMsg = "Neispravno uneseni podaci za registraciju!";
            }
        }
        #endregion
    }
}
