using DnDMobile.Classes.ItemsFolder;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DnDMobile.Pages.Equipment
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TrinketPage : ContentPage
    {
        public TrinketPage()
        {
            InitializeComponent();
            Items items = new Items();
            ListViewTrinkets.ItemsSource = items.GeneralItemsTrinkets;
            PageStack.FadeTo(1, 2000);
        }
    }
}