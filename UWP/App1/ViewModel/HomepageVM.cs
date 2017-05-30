using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using System.Drawing;
using System.ComponentModel;

namespace App1.ViewModel
{
    class HomepageVM : INotifyPropertyChanged
    {
        #region atributi
        private Korisnik curUser;
        private Image naslovnaSlika;
        #endregion

        #region komande
        public RelayCommand csearch { get; set; }
        public RelayCommand cfilter { get; set; }
        public RelayCommand clogin { get; set; }
        public RelayCommand cregister { get; set; }
        public RelayCommand cmaps { get; set; }
        public RelayCommand cprofile { get; set; }
        #endregion

        #region konstruktor
        public HomepageVM()
        {
            curUser = null;
            BitmapImage src = new BitmapImage();
            src.BeginInit();
            src.UriSource = new Uri("naslovna.png", UriKind.Relative);
            src.CacheOption = BitmapCacheOption.OnLoad;
            src.EndInit();
            naslovnaSlika = new Image();
            naslovnaSlika.Source = src;
            csearch = new RelayCommand(pretraga);
            cfilter = new RelayCommand(filtriraj);
            clogin = new RelayCommand(logiranje);
            cregister = new RelayCommand(registracija);
            cmaps = new RelayCommand(mape);
            cprofile = new RelayCommand(profil);
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
        public Image NaslovnaSlika
        {
            get
            {
                return naslovnaSlika;
            }
        }
        #endregion

        #region metode
        public void pretraga()
        {

        }

        public void filtriraj()
        {

        }

        public void logiranje()
        {

        }

        public void registracija()
        {

        }

        public void mape()
        {

        }

        public void profil()
        {

        }
        #endregion
    }
}
