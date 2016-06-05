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
    class UposlenikViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public INavigationService NavigationService { get; set; }
        public ICommand odjava { get; set; }
        public ICommand dodajKorisnika { get; set; }
        public ICommand raspored { get; set; }
        public ICommand dolazakClana { get; set; }
        public ICommand dolazakGosta { get; set; }
        public ICommand pregledPosjecenosti { get; set; }

        public ICommand pregledClanova { get; set; }

        public UposlenikViewModel()
        {
            NavigationService = new NavigationService();
            odjava = new RelayCommand<object>(Odjava, mozeLi);
            dodajKorisnika = new RelayCommand<object>(DodajKorisnika, mozeLi);
            raspored = new RelayCommand<object>(Raspored, mozeLi);
            dolazakClana =  new RelayCommand<object>(DolazakClana, mozeLi);
            dolazakGosta = new RelayCommand<object>(DolazakGosta, mozeLi);
            pregledPosjecenosti = new RelayCommand<object>(PregledPosjecenosti, mozeLi);
            pregledClanova = new RelayCommand<object>(PregledKorisnika, mozeLi);

        }
        public bool mozeLi(object parametar)
        {
            return true;
        }
        public void Odjava(object parametar)
        {
            NavigationService.Navigate(typeof(PocetniView), null);
        }
        public void DodajKorisnika(object parametar)
        {
            NavigationService.Navigate(typeof(DodavanjeClanaPage), null);
        }
        public void Raspored(object param)
        {
            NavigationService.Navigate(typeof(Raspored), null);
        }
        public void DolazakClana(object param)
        {
            NavigationService.Navigate(typeof(RFIDPage), null);
        }
        public void DolazakGosta(object param)
        {
            NavigationService.Navigate(typeof(PrijavaGostaPage), null);
        }
        public void PregledPosjecenosti(object param)
        {
            NavigationService.Navigate(typeof(PosjecenostView), null);
        }
        public void PregledKorisnika(object param)
        {
            NavigationService.Navigate(typeof(PregledClanovaPage), null);
        }
    }
}
