using DnDMobile.Classes;
using DnDMobile.Classes.ItemsFolder;
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
            Items items = new Items();
            InitializeItems(items.SimpleMeleeWeapons);
            InitializeItems(items.SimpleRangedWeapons);
            InitializeItems(items.MartialMeleeWeapons);
            InitializeItems(items.MartialRangedWeapons);
            weaponList.Sort((x, y) => x.Description.CompareTo(y.Description));
            ListViewItems.ItemsSource = weaponList;

            // Update type picker options.
            ItemFilterPicker.ItemsSource = StaticVariables.meleeTypes;
        }


        private void InitializeItems(List<Weapon> weapons)
        {
            foreach (Weapon weapon in weapons)
            {
                weaponList.Add(weapon);
            }
        }


        private void ItemFilterPickerSelected(object sender, EventArgs e)
        {
            int selectedIndex = ItemFilterPicker.SelectedIndex;
            if (selectedIndex != -1)
            {
                Object itemType = ItemFilterPicker.ItemsSource[selectedIndex];
                if (object.Equals(itemType, StaticVariables.simpleMelee))
                {
                    FilterItemList(StaticVariables.simpleMelee);
                }
                else if (object.Equals(itemType, StaticVariables.simpleRanged))
                {
                    FilterItemList(StaticVariables.simpleRanged);
                }
                else if (object.Equals(itemType, StaticVariables.martialMelee))
                {
                    FilterItemList(StaticVariables.martialMelee);
                }
                else if (object.Equals(itemType, StaticVariables.martialRanged))
                {
                    FilterItemList(StaticVariables.martialRanged);
                }
                else
                {
                    ListViewItems.ItemsSource = weaponList;
                    ItemFilterPicker.SelectedIndex = -1;
                }
            }
        }


        private void FilterItemList(string type)
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
