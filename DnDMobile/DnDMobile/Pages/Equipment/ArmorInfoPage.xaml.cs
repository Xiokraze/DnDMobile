using DnDMobile.Classes.ItemsFolder;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DnDMobile.Pages.Equipment
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ArmorInfoPage : ContentPage
    {
        public ArmorInfoPage(Armor armor)
        {
            InitializeComponent();
            BindingContext = armor;
        }
    }
}
