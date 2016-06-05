using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Teretana.Teretana.ViewModels;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Teretana.Teretana.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AdministratorView : Page
    {
        public AdministratorView()
        {
            this.InitializeComponent();
            DataContext = new AdministratorViewModel();
            NavigationCacheMode = NavigationCacheMode.Required;

        }

        private void toggleButton_Copy3_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(DodavanjeClanaPage), null);
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var currentView = SystemNavigationManager.GetForCurrentView();
            currentView.AppViewBackButtonVisibility = AppViewBackButtonVisibility.Collapsed;
        }

        private void toggleButton_Checked(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(DodavanjeUposlenika), null);
        }

        private void toggleButton_Copy_Checked(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(PregledUposlenikaPage), null);
        }

        private void toggleButton_Copy2_Checked(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(PregledClanovaPage), null);
        }

        private void toggleButton_Copy1_Checked(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(PregledProgramaPage), null);
        }

        private void toggle(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(DodavanjeProgramaPage), null);
        }

        private void toggleButton_Copy5_Checked(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(PocetniView), null);
        }
    }
}
