using ComicListXam.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace ComicListXam.Views
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