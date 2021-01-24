using DnDMobile.Classes;
using DnDMobile.Classes.ItemsFolder;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DnDMobile.Pages.Equipment
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StandardArmorPage : ContentPage
    {
        private readonly List<Armor> armorList = new List<Armor>();

        public StandardArmorPage()
        {
            InitializeComponent();
            PageStack.FadeTo(1, 2000);
            InitializeItemLists();
        }


        private void InitializeItemLists()
        {
            Items items = new Items();
            InitializeItems(items.StandardLightArmor);
            InitializeItems(items.StandardMediumArmor);
            InitializeItems(items.StandardHeavyArmor);
            InitializeItems(items.StandardShields);
            armorList.Sort((x, y) => x.Description.CompareTo(y.Description));
            ListViewItems.ItemsSource = armorList;

            // Update type picker options.
            ItemFilterPicker.ItemsSource = StaticVariables.armorTypes;
        }


        private void InitializeItems(List<Armor> weapons)
        {
            foreach (Armor weapon in weapons)
            {
                armorList.Add(weapon);
            }
        }


        private void ItemFilterPickerSelected(object sender, EventArgs e)
        {
            int selectedIndex = ItemFilterPicker.SelectedIndex;
            if (selectedIndex != -1)
            {
                Object itemType = ItemFilterPicker.ItemsSource[selectedIndex];
                if (object.Equals(itemType, StaticVariables.lightAmor))
                {
                    FilterItemList(StaticVariables.lightAmor);
                }
                else if (object.Equals(itemType, StaticVariables.mediumAmor))
                {
                    FilterItemList(StaticVariables.mediumAmor);
                }
                else if (object.Equals(itemType, StaticVariables.heavyAmor))
                {
                    FilterItemList(StaticVariables.heavyAmor);
                }
                else if (object.Equals(itemType, StaticVariables.shields))
                {
                    FilterItemList(StaticVariables.shields);
                }
                else
                {
                    ListViewItems.ItemsSource = armorList;
                    ItemFilterPicker.SelectedIndex = -1;
                }
            }
        }


        private void FilterItemList(string type)
        {
            List<Armor> filterMatches = new List<Armor>();
            foreach (Armor armor in armorList)
            {
                if (object.Equals(type, armor.Type))
                {
                    filterMatches.Add(armor);
                }
            }
            ListViewItems.ItemsSource = filterMatches;
        }


        private async void ListItemTapped(object sender, EventArgs e)
        {
            ListView listView = (ListView)sender;
            Armor armor = (Armor)listView.SelectedItem;
            await Navigation.PushAsync(new ArmorInfoPage(armor));
        }
    }
}
