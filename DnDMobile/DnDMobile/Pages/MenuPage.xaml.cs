using DnDMobile.Classes;
using DnDMobile.Classes.ItemsFolder;
using DnDMobile.Classes.ItemsFolder.ItemLists;
using DnDMobile.Pages.Generators;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DnDMobile.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
            LoadMenuListView();
        }


        private void LoadMenuListView()
        {
            Spells spells = new Spells();
            int itemCount = Weapons.Count + ArmorList.Count + GeneralItems.Count + Trinkets.Count + ArtList.Count + Gemstones.Count;
            List<MenuListViewItem> menuListViewItems = new List<MenuListViewItem>()
            {
                 new MenuListViewItem("Standard Items", itemCount, MenuOptions.StandardItems),
                 new MenuListViewItem("Random Generators", MenuOptions.RandomGenerators),
                 new MenuListViewItem("Spells", spells.GetSpellCount(), MenuOptions.Spells)
            };
            menuListView.ItemsSource = menuListViewItems;
            PageStack.FadeTo(1, 2000);
        }


        private async void MenuMaterialSelected(object sender, EventArgs e)
        {
            MenuListViewItem tappedMaterial = (MenuListViewItem)((ListView)sender).SelectedItem;

            switch (tappedMaterial.Type)
            {
                case MenuOptions.StandardItems:
                    await Navigation.PushAsync(new StandardEquipmentPage());
                    break;
                case MenuOptions.Spells:
                    await Navigation.PushAsync(new SpellsPage());
                    break;
                case MenuOptions.RandomGenerators:
                    await Navigation.PushAsync(new GeneratorPage());
                    break;
                default:
                    break;
            }
        }
    }
}
