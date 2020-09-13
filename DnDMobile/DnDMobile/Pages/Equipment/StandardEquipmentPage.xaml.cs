using DnDMobile.Pages.Equipment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DnDMobile.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StandardEquipmentPage : ContentPage
    {
        public StandardEquipmentPage()
        {
            InitializeComponent();
            PageStack.FadeTo(1, 2000);
        }


        private async void ButtonViewGeneralItemsProcedure(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GeneralItemsPage());
        }


        private async void ButtonViewStandardArmorProcedure(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StandardArmorPage());
        }


        private async void ButtonViewStandardWeaponsProcedure(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StandardWeaponsPage());
        }


        
    }
}