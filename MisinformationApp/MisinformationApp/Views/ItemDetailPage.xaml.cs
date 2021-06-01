using MisinformationApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace MisinformationApp.Views
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