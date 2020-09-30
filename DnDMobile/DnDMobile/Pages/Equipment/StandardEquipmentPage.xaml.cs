using DnDMobile.Classes.ItemsFolder;
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
            LoadMenuListView();
        }


        private void LoadMenuListView()
        {
            Items items = new Items();
            List<MenuListViewItem> menuListViewItems = new List<MenuListViewItem>()
            {
                new MenuListViewItem("Armor", items.GetNumberOfArmorCount()),
                new MenuListViewItem("General Items", items.GetGeneralItemsCount()),
                new MenuListViewItem("Trinkets", items.GetTrinketCount()),
                new MenuListViewItem("Weapons", items.GetNumberOfWeaponsCount())
            };
            menuListView.ItemsSource = menuListViewItems;
            PageStack.FadeTo(1, 2000);
        }


        private async void MenuMaterialSelected(object sender, EventArgs e)
        {
            MenuListViewItem tappedMaterial = (MenuListViewItem)((ListView)sender).SelectedItem;

            switch (tappedMaterial.Name)
            {
                case "Armor":
                    await Navigation.PushAsync(new StandardArmorPage());
                    break;
                case "General Items":
                    await Navigation.PushAsync(new GeneralItemsPage());
                    break;
                case "Trinkets":
                    await Navigation.PushAsync(new TrinketPage());
                    break;
                case "Weapons":
                    await Navigation.PushAsync(new StandardWeaponsPage());
                    break;
                default:
                    break;
            }
        }
    }
}
