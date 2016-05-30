using Teretana.Teretana.Helper;
using Teretana.Teretana.Models;
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
        public event PropertyChangedEventHandler PropertyChanged;
        public Uposlenik Uposlenik { get; set; }
        public INavigationService NavigationService { get; set; }
        public ICommand dodajUposlenika { get; set; }

        public DodavanjeUposlenikaViewModel()
        {
            Uposlenik = new Uposlenik();
            NavigationService = new NavigationService();
            dodajUposlenika = new RelayCommand<object>(dodavanjeUposlenika, mozeLiSeDodati);
        }
        public void dodavanjeUposlenika(object parametar)
        {
            //prebacuje na sljedeci view i proslijedjuje viewmodel za taj view, koji ima ovaj view (this) kao Parent
            NavigationService.Navigate(typeof(AdministratorPage), new Uposlenik());
        }
        public bool mozeLiSeDodati(object parametar)
        {
            return true;
        }
    }
}