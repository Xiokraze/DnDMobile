using DnDMobile.Classes.ItemsFolder;
using DnDMobile.Classes.ItemsFolder.ItemLists;
using DnDMobile.Pages.Equipment;
using System;
using System.Collections.Generic;
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
            List<MenuListViewItem> menuListViewItems = new List<MenuListViewItem>()
            {
                new MenuListViewItem("Armor", ArmorList.Count),
                new MenuListViewItem("Art", ArtList.Count),
                new MenuListViewItem("Gems", Gemstones.Count),
                new MenuListViewItem("General Items", GeneralItems.Count),
                new MenuListViewItem("Trinkets", Trinkets.Count),
                new MenuListViewItem("Weapons", Weapons.Count)
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
                case "Art":
                    await Navigation.PushAsync(new ArtPage());
                    break;
                case "Gems":
                    await Navigation.PushAsync(new GemsPage());
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
