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
    class PrijavaGostaViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public Gost Gost { get; set; }
        public INavigationService NavigationService { get; set; }
        public ICommand dodajGosta { get; set; }
        NasaBazaDbContext db = new NasaBazaDbContext();
        public PrijavaGostaViewModel()
        {
            Gost = new Gost();
            NavigationService = new NavigationService();
            dodajGosta = new RelayCommand<object>(dodavanje, mozeLiSeDodati);
        }
        public async void dodavanje(object parametar)
        {
            db.Gosti.AddRange(Gost);
            db.SaveChanges();
            var dialog = new MessageDialog("Uspješno ste prijavili gosta!");
            await dialog.ShowAsync();
            //prebacuje na sljedeci view i proslijedjuje viewmodel za taj view, koji ima ovaj view (this) kao Parent
            NavigationService.Navigate(typeof(UposlenikView), null);
        }
        public bool mozeLiSeDodati(object parametar)
        {
            return true;
        }
    }
}