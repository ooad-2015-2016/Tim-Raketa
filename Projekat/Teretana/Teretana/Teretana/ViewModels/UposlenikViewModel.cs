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
    class UposlenikViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public List<Uposlenik> uposlenici { get; set; }
        public INavigationService NavigationService { get; set; }
        public ICommand dodajUposlenika { get; set; }
        public ICommand obrisiUposlenika { get; set; }
        public ICommand izmijeniUposlenika { get; set; }

        public UposlenikViewModel()
        {
            uposlenici = new List<Uposlenik>();
            NavigationService = new NavigationService();
            dodajUposlenika = new RelayCommand<object>(dodavanje, daLiMoze);
            izmijeniUposlenika = new RelayCommand<object>(mijenjanje, daLiMoze);
            obrisiUposlenika = new RelayCommand<object>(brisanje, daLiMoze);
        }
        public void dodavanje(object parametar)
        {
            NavigationService.Navigate(typeof(AdministratorPage), null);
        }
        public void mijenjanje(object parametar)
        {
            NavigationService.Navigate(typeof(AdministratorPage), null);
        }
        public void brisanje(object parametar)
        {
            NavigationService.Navigate(typeof(AdministratorPage), null);
        }
        public bool daLiMoze(object parametar)
        {
            return true;
        }
    }
}
