﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Phone.UI.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Pour en savoir plus sur le modèle d’élément Page vierge, consultez la page http://go.microsoft.com/fwlink/?LinkID=390556

namespace DevCWinPhone
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class SujetPage : Page
    {
        private ViewModelCategorie _ViewModelcategorie = null;
        public SujetPage()
        {
            this.InitializeComponent();
            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        /// <summary>
        /// Invoqué lorsque cette page est sur le point d'être affichée dans un frame.
        /// </summary>
        /// <param name="e">Données d'événement décrivant la manière dont l'utilisateur a accédé à cette page.
        /// Ce paramètre est généralement utilisé pour configurer la page.</param>
        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            // On récupère le ViewModel (ViewModelCategorie) ViewModelCategorie est la source de données

            _ViewModelcategorie = (ViewModelCategorie)e.Parameter;
            await _ViewModelcategorie.getSujetByCategorieID();
            // Binding de la source de données (ViewModelCategorie) avec le contexte de la page
            DataContext = _ViewModelcategorie;
            // On s'abonne à l'événement système 'HardwareButtons_BackPressed'          
            HardwareButtons.BackPressed += HardwareButtons_BackPressed;
        }

        private void HardwareButtons_BackPressed(object sender, BackPressedEventArgs e)
        {
            e.Handled = true;
            Frame.Navigate(typeof(MainPage));
        }

        protected override void OnNavigatingFrom(NavigatingCancelEventArgs e)
        {
            HardwareButtons.BackPressed -= HardwareButtons_BackPressed;
        }

        private void mnuFermer_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void ListView_Click(object sender, RoutedEventArgs e)
        {
            ViewModelSujet ViewModelsujet = (ViewModelSujet)((Button)sender).DataContext;
            Frame.Navigate(typeof(ReponsePage), ViewModelsujet);
        }

        private void mnuQuitter_Click(object sender, RoutedEventArgs e)
        {
            // Fermeture de l'application
            App.Current.Exit();
        }

        private async void mnuSynchro_Click(object sender, RoutedEventArgs e)
        {
            // On rafraichi la liste des sujet
            await _ViewModelcategorie.getSujetByCategorieID();
        }
    }
}
