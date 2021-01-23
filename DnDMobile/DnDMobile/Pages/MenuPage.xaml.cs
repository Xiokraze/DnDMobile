using DnDMobile.Classes;
using DnDMobile.Classes.ItemsFolder;
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
            Items items = new Items();
            Spells spells = new Spells();
            List<MenuListViewItem> menuListViewItems = new List<MenuListViewItem>()
            {
                 new MenuListViewItem("Standard Items", items.GetEquipmentCount()),
                 new MenuListViewItem("Random Generators"),
                 new MenuListViewItem("Spells", spells.GetSpellCount())
            };
            menuListView.ItemsSource = menuListViewItems;
            PageStack.FadeTo(1, 2000);
        }


        private async void MenuMaterialSelected(object sender, EventArgs e)
        {
            MenuListViewItem tappedMaterial = (MenuListViewItem)((ListView)sender).SelectedItem;

            switch (tappedMaterial.Name)
            {
                case "Standard Items":
                    await Navigation.PushAsync(new StandardEquipmentPage());
                    break;
                case "Spells":
                    await Navigation.PushAsync(new SpellsPage());
                    break;
                case "Random Generators":
                    await Navigation.PushAsync(new GeneratorPage());
                    break;
                default:
                    break;
            }
        }
    }
}
