using navdemo.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace navdemo.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}