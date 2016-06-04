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
    class DodavanjeUposlenikaViewModel : INotifyPropertyChanged
    {
        public Osoba Uposlenik { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;

        public INavigationService NavigationService { get; set; }
        public ICommand dodajUposlenika { get; set; }
        public UposlenikViewModel uvm { get; set; }
        NasaBazaDbContext db;

        public DodavanjeUposlenikaViewModel()
        {
            db = new NasaBazaDbContext();
            uvm = new UposlenikViewModel();
            Uposlenik = new Osoba();
            Uposlenik.Tip = "UPOSLENIK";
            NavigationService = new NavigationService();
            dodajUposlenika = new RelayCommand<object>(dodavanjeUposlenika, mozeLiSeDodati);
        }
        public void dodavanjeUposlenika(object parametar)
        {

            db.Osobe.AddRange(Uposlenik);
            db.SaveChanges();
            //Uposlenik.create(Uposlenik);
            //prebacuje na sljedeci view i proslijedjuje viewmodel za taj view, koji ima ovaj view (this) kao Parent
            NavigationService.Navigate(typeof(AdministratorView), null);
        }
        public bool mozeLiSeDodati(object parametar)
        {
            return true;
        }
    }
}