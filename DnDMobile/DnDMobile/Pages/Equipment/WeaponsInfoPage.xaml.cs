using DnDMobile.Classes.ItemsFolder;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DnDMobile.Pages.Equipment
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WeaponsInfoPage : ContentPage
    {
        public WeaponsInfoPage(Weapon weapon)
        {
            InitializeComponent();
            BindingContext = weapon;
        }
    }
}
