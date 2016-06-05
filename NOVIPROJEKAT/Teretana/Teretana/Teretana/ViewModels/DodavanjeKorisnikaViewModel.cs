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
using Windows.UI.Popups;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Teretana.Teretana.ViewModels
{
    class DodavanjeKorisnikaViewModel : INotifyPropertyChanged
    { 
        public event PropertyChangedEventHandler PropertyChanged;
        public Korisnik Korisnik { get; set; }
        public TeretanaBaza.Models.Program OdabraniProgram { get; set; }
        public List<TeretanaBaza.Models.Program> Programi { get; set; }
        public INavigationService NavigationService { get; set; }
        public ICommand dodajKorisnika { get; set; }
       NasaBazaDbContext db { get; set; }
        Rfid rfid;
        public DodavanjeKorisnikaViewModel()
        {
           // rfid = new Rfid();
            //rfid.InitializeReader(RfidReadSomething);
            db = new NasaBazaDbContext();
            Korisnik = new Korisnik();
            OdabraniProgram = new TeretanaBaza.Models.Program();
            Programi = new List<TeretanaBaza.Models.Program>();
            foreach (TeretanaBaza.Models.Program k in db.Programi)
                Programi.Add(k);
            /*
             OdabraniProgram = Programi[0];*/
            // Programi = TeretanaBaza.Models.Program.getAll();
            NavigationService = new NavigationService();
            dodajKorisnika = new RelayCommand<object>(dodavanjeKorisnika, mozeLiSeDodati);
        }
            //callback na read rfid
        public void RfidReadSomething(string rfidKod)
        {
            string rfid1 = Regex.Replace(rfidKod, "[^0-9a-zA-Z]+", "");
            Korisnik.RFID = rfid1;
        }
        public async void dodavanjeKorisnika(object parametar)
        {

            EmailAddressAttribute email = new EmailAddressAttribute();
            bool valid = email.IsValid(Korisnik.Email);
            if (Korisnik.Ime == null || Korisnik.Prezime == null || Korisnik.MjestoStanovanja == null || Korisnik.Email == null || Korisnik.DatumRodjenja == null)
            {
                var d = new MessageDialog("Greška prilikom unosa podataka. Polja ne smiju ostati prazna!"," Greška");
                await d.ShowAsync();
            }
            else if (DateTime.Now.Year - Korisnik.DatumRodjenja.Year <= 7) 
            {
                var d1 = new MessageDialog("Greška prilikom unosa datuma rođenja.", "Greška");
                await d1.ShowAsync();
            }
            else if (!valid)
            {
                var d2 = new MessageDialog("Greška prilikom unosa e-mail adrese. Email treba biti u formatu nesto@nesto.nesto", "Greška");
                await d2.ShowAsync();
            }
            else {
                Korisnik.ProgramID = OdabraniProgram.ProgramId;
                db.Korisnici.AddRange(Korisnik);
                db.SaveChanges();
                var dialog = new MessageDialog("Uspješno ste dodali korisnika!");
                await dialog.ShowAsync();
                //prebacuje na sljedeci view i proslijedjuje viewmodel za taj view, koji ima ovaj view (this) kao Parent
                NavigationService.Navigate(typeof(UposlenikView), null);
            }
        }
        public bool mozeLiSeDodati(object parametar)
        {
            return true;
        }
    }
}
