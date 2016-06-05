using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Teretana.Teretana.Helper;
using Teretana.Teretana.Views;

namespace Teretana.Teretana.ViewModels
{
    class PocetniViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ICommand administrator { get; set; }
        public ICommand uposlenik { get; set; }
        public INavigationService NavigationService { get; set; }
        public PocetniViewModel()
        {
            NavigationService = new NavigationService();
            administrator = new RelayCommand<object>(otvoriAdministratorView, mozeLi);
            uposlenik = new RelayCommand<object>(otvoriUposlenikView, mozeLi);
        }
        public void otvoriAdministratorView(object parametar)
        {
            NavigationService.Navigate(typeof(LoginAdministrator), null);
        }
        public bool mozeLi(object parametar)
        {
            return true;
        }
        public void otvoriUposlenikView(object parametar)
        {
            NavigationService.Navigate(typeof(LoginUposlenik), null);
        }

    }
}
