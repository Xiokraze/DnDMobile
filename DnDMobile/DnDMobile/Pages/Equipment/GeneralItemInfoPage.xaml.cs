using DnDMobile.Classes.ItemsFolder;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DnDMobile.Pages.Equipment
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GeneralItemInfoPage : ContentPage
    {
        public GeneralItemInfoPage(GeneralItem generalItem)
        {
            InitializeComponent();
            BindingContext = generalItem;
        }
    }
}
