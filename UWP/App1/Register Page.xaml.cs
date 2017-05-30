using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BlankPage2 : Page
    {
        using (GameShopEntities context = new GameShopEntities())
        {
                public BlankPage2()
            {
                this.InitializeComponent();
            }

            private void Register_Click(System.Object sender, RoutedEventArgs e)
            {
                Lokacija lokacija = new Lokacija()
                {
                    //??
                    adresa = textBox_Copy3.Text;       
                }


                Korisnik korisnik = new Korisnik()
                {
                    username = textBox.Text;
                    pass = textBox_Copy1.Text;
                    //treba staviti onu od iznad
                    tipAccounta= "Obični";
                };    
                context.Lokacija.Add(lokacija);
                context.Korisnik.Add(korisnik);           
            }
        }
    }
}
