using Teretana.Teretana.Helper;
using Teretana.Teretana.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Teretana.TeretanaBaza.Models;

namespace Teretana.Teretana.ViewModels
{
    class KorisnikViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public Korisnik Korisnik { get; set; }
        public INavigationService NavigationService { get; set; }
        public ICommand dodajKorisnika { get; set; }

        public KorisnikViewModel()
        {
            Korisnik = new Korisnik();
            NavigationService = new NavigationService();
            dodajKorisnika = new RelayCommand<object>(dodavanjeKorisnika, mozeLiSeDodati);
        }
        public void dodavanjeKorisnika(object parametar)
        {
            //prebacuje na sljedeci view i proslijedjuje viewmodel za taj view, koji ima ovaj view (this) kao Parent
            NavigationService.Navigate(typeof(UposlenikView), new Korisnik());
        }
        public bool mozeLiSeDodati(object parametar)
        {
            return true;
        }
    }
}
