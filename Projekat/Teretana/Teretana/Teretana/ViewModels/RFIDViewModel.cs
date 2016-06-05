using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Teretana.Teretana.Helper;
using Teretana.Teretana.Views;
using Teretana.TeretanaBaza.Models;
using Windows.UI.Popups;

namespace Teretana.Teretana.ViewModels
{
    class RFIDViewModel : INotifyPropertyChanged
    {
        public Korisnik Korisnik { get; set; }
        public string RFID { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        public INavigationService NavigationService { get; set; }
        public ICommand OK { get; set; }
        public RFIDViewModel()
        {
            Korisnik korisnik = new Korisnik();
            NavigationService = new NavigationService();
            OK = new RelayCommand<object>(dodaj, mozeLi);
        }
        bool mozeLi(object param) { return true; }

        public async void dodaj(object param) { 
        bool ima = false;
        NasaBazaDbContext db = new NasaBazaDbContext();
            foreach(Korisnik k in db.Korisnici)
                if(RFID.Equals(k.RFID))
                {
                    ima = true;
                    Korisnik = k;
                    break;
                }
            if(ima)
            {
                NavigationService.Navigate(typeof(DolazakKorisnikaPage), new RFIDViewModel());
            }
            else
            {
                var dialog = new MessageDialog("Ne postoji takav korisnik!");
                await dialog.ShowAsync();
            }
        }
    }
}
