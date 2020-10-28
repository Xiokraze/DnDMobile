using DnDMobile.Classes.ItemsFolder;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DnDMobile.Pages.Equipment
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GemInfoPage : ContentPage
    {
        public GemInfoPage(Gem gem)
        {
            InitializeComponent();
            BindingContext = gem;
        }
    }
}