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
using System.ComponentModel.DataAnnotations;
using Windows.UI.Popups;

namespace Teretana.Teretana.ViewModels
{
    class DodavanjeUposlenikaViewModel : INotifyPropertyChanged
    {
        public Uposlenik Uposlenik { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;

        public INavigationService NavigationService { get; set; }
        public ICommand dodajUposlenika { get; set; }
        public UposlenikViewModel uvm { get; set; }
       NasaBazaDbContext db;

        public DodavanjeUposlenikaViewModel()
        {
            db = new NasaBazaDbContext();
            uvm = new UposlenikViewModel();
            Uposlenik = new Uposlenik();
            NavigationService = new NavigationService();
            dodajUposlenika = new RelayCommand<object>(dodavanjeUposlenika, mozeLiSeDodati);
        }
        public async void dodavanjeUposlenika(object parametar)
        {
            EmailAddressAttribute email = new EmailAddressAttribute();
            bool valid = email.IsValid(Uposlenik.Email);
            if (Uposlenik.Ime == null || Uposlenik.Prezime == null || Uposlenik.MjestoStanovanja == null || Uposlenik.Email == null || Uposlenik.DatumRodjenja == null || Uposlenik.Password ==null)
            {
                var d = new MessageDialog("Greška prilikom unosa podataka. Polja ne smiju ostati prazna!"," Greška");
                await d.ShowAsync();
            }
            else if (DateTime.Now.Year - Uposlenik.DatumRodjenja.Year <= 18)
            {
                var d1 = new MessageDialog("Greška prilikom unosa datuma rođenja. ", "Greška");
                await d1.ShowAsync();
            }
            else if (!valid)
            {
                var d2 = new MessageDialog("Greška prilikom unosa e-mail adrese. Email treba biti u formatu nesto@nesto.nesto", "Greška");
                await d2.ShowAsync();
            }
            else {
                db.Uposlenici.AddRange(Uposlenik);
                db.SaveChanges();
                //Uposlenik.create(Uposlenik);
                //prebacuje na sljedeci view i proslijedjuje viewmodel za taj view, koji ima ovaj view (this) kao Parent
                NavigationService.Navigate(typeof(AdministratorView), null);
            }
        }
        public bool mozeLiSeDodati(object parametar)
        {
            return true;
        }
    }
}