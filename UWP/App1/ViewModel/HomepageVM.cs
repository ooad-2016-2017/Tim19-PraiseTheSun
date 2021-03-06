﻿using System;
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
    class HomepageVM : INotifyPropertyChanged
    {
        #region atributi
        private Korisnik curUser; //trenutni loginani user
        private Image naslovnaSlika; //promocijska slika
        private String searchString; //uneseni string u search
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
        /// <summary>
        /// inicijalizuje homepage bez loginanog usera i loada promocionu sliku
        /// </summary>
        public HomepageVM()
        {
            //inicijalizacija neloginanog usera
            this.curUser = null;
            //loadanje promocione slike
            BitmapImage src = new BitmapImage();
            src.BeginInit();
            src.UriSource = new Uri("naslovna.png", UriKind.Relative);
            src.CacheOption = BitmapCacheOption.OnLoad;
            src.EndInit();
            this.naslovnaSlika = new Image();
            this.naslovnaSlika.Source = src;
            this.csearch = new RelayCommand(pretraga);
            this.cfilter = new RelayCommand(filtriraj);
            this.clogin = new RelayCommand(logiranje);
            this.cregister = new RelayCommand(registracija);
            this.cmaps = new RelayCommand(mape);
            this.cprofile = new RelayCommand(profil);
        }

        /// <summary>
        /// inicijalizuje homepage sa definiranim userom
        /// </summary>
        /// <param name="user"></param>
        public HomepageVM(Korisnik user)
        {
            //inicijalizuje trenutnog usera
            this.curUser = user;
            BitmapImage src = new BitmapImage();
            src.BeginInit();
            src.UriSource = new Uri("naslovna.png", UriKind.Relative);
            src.CacheOption = BitmapCacheOption.OnLoad;
            src.EndInit();
            this.naslovnaSlika = new Image();
            this.naslovnaSlika.Source = src;
            this.csearch = new RelayCommand(pretraga);
            this.cfilter = new RelayCommand(filtriraj);
            this.clogin = new RelayCommand(logiranje);
            this.cregister = new RelayCommand(registracija);
            this.cmaps = new RelayCommand(mape);
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

        public void mape()
        {
            var frame = (Frame)Window.Current.Content;
            MapeVM neuVM = new MapeVM(this.curUser);
            frame.Navigate(typeof(MapeView), neuVM);
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
