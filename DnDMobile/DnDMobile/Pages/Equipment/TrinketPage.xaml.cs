using DnDMobile.Classes.ItemsFolder.ItemLists;
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
            ListViewTrinkets.ItemsSource = Trinkets.All;
            PageStack.FadeTo(1, 2000);
        }
    }
}