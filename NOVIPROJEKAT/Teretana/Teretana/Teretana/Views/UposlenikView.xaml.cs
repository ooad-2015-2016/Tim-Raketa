﻿using System;
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
    public sealed partial class UposlenikView : Page
    {
        public UposlenikView()
        {
            this.InitializeComponent();
            DataContext = new UposlenikViewModel();
            NavigationCacheMode = NavigationCacheMode.Required;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var currentView = SystemNavigationManager.GetForCurrentView();
            currentView.AppViewBackButtonVisibility = AppViewBackButtonVisibility.Collapsed;
        }

        private void toggleButton_Checked(object sender, RoutedEventArgs e)
        {
        }

        private void toggleButton_Copy2_Checked(object sender, RoutedEventArgs e)
        {
        }

        private void toggleButton_Copy4_Checked(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(PrijavaGostaPage), null);
        }

        private void toggleButton_Copy1_Checked(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(DolazakKorisnikaPage), null);
        }

        private void textBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
    }
}
