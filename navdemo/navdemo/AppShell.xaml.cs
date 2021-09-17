using navdemo.ViewModels;
using navdemo.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace navdemo
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }

        private void MenuItem_Clicked(object sender, EventArgs e)
        {
            FlyoutIsPresented = false;
            DisplayAlert("Rate!", "You selected the Rate This App item.", "Ok");
        }
    }
}
