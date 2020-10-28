using DnDMobile.Classes.ItemsFolder;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DnDMobile.Pages.Equipment
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ArtInfoPage : ContentPage
    {
        public ArtInfoPage(Art art)
        {
            InitializeComponent();
            BindingContext = art;
        }
    }
}
