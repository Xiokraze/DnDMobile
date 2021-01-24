using DnDMobile.Classes;
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
    public partial class StandardWeaponsPage : ContentPage
    {
        private readonly List<Weapon> weaponList = new List<Weapon>();

        public StandardWeaponsPage()
        {
            InitializeComponent();
            PageStack.FadeTo(1, 2000);
            InitializeItemLists();
        }


        private void InitializeItemLists()
        {
            ListViewItems.ItemsSource = Weapons.All;
            ItemFilterPicker.ItemsSource = StaticVariables.meleeTypes;
        }


        private void ItemFilterPickerSelected(object sender, EventArgs e)
        {
            int selectedIndex = ItemFilterPicker.SelectedIndex;
            if (selectedIndex != -1)
            {
                Object itemType = ItemFilterPicker.ItemsSource[selectedIndex];
                if (object.Equals(itemType, ItemTypes.SimpleMelee))
                {
                    FilterItemList(ItemTypes.SimpleMelee);
                }
                else if (object.Equals(itemType, ItemTypes.SimpleRanged))
                {
                    FilterItemList(ItemTypes.SimpleRanged);
                }
                else if (object.Equals(itemType, ItemTypes.MartialMelee))
                {
                    FilterItemList(ItemTypes.MartialMelee);
                }
                else if (object.Equals(itemType, ItemTypes.MartialRanged))
                {
                    FilterItemList(ItemTypes.MartialRanged);
                }
                else
                {
                    ListViewItems.ItemsSource = weaponList;
                    ItemFilterPicker.SelectedIndex = -1;
                }
            }
        }


        private void FilterItemList(ItemTypes type)
        {
            List<Weapon> filterMatches = new List<Weapon>();
            foreach (Weapon weapon in weaponList)
            {
                if (object.Equals(type, weapon.Type))
                {
                    filterMatches.Add(weapon);
                }
            }
            ListViewItems.ItemsSource = filterMatches;
        }


        private async void ListItemTapped(object sender, EventArgs e)
        {
            ListView listView = (ListView)sender;
            Weapon weapon = (Weapon)listView.SelectedItem;
            await Navigation.PushAsync(new WeaponsInfoPage(weapon));
        }
    }
}
