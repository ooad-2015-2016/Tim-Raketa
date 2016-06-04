using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Teretana.Teretana.ViewModels;
using Teretana.TeretanaBaza.Models;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Teretana.Teretana.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LoginUposlenik : Page
    {
        Osoba u;
        public LoginUposlenik()
        {
            this.InitializeComponent();
            var inicijalizacija = new DataSource();
            u = new Osoba();
        }
            /*var currentView = SystemNavigationManager.GetForCurrentView();
            currentView.AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
            SystemNavigationManager.GetForCurrentView().BackRequested += ThisPage_BackRequested;

        }
        /*NasaBazaDbContext db = new NasaBazaDbContext();*/
        public Osoba vrati(string username, string pass)
        {
            /*List<Osoba> osobe = new List<Osoba>();
            osobe.AddRange(db.Osobe);
            foreach (Osoba u in osobe)
            {
                if ((u.Ime + u.Prezime).Equals(username) && u.Password.Equals(pass) && u.Tip.Equals("UPOSLENIK"))
                    return u;
            }*/
            return null;
        }
        private async void button_Click(object sender, RoutedEventArgs e)
        {
            var username = textBox.Text;
            var password = passwordBox_Copy.Password;
            var uposlenik = vrati(username, password);
            if(uposlenik != null)
            {
                this.Frame.Navigate(typeof(UposlenikView), uposlenik);
            }
            else
            {
                var dialog = new MessageDialog("Pogrešna šifra/korisničko ime!", "Neuspješna prijava");

                await dialog.ShowAsync();
            }
        }
        private void ThisPage_BackRequested(object sender, BackRequestedEventArgs e)
        {
            if (Frame.CanGoBack)
            {
                Frame.GoBack();
                e.Handled = true;
            }
        }
    }
}
