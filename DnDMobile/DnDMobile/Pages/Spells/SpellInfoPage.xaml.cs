using DnDMobile.Classes;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DnDMobile.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SpellInfoPage : ContentPage
    {
        public SpellInfoPage(Spell spell)
        {
            InitializeComponent();
            BindingContext = spell;
        }
    }
}