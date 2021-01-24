using DnDMobile.Classes;
using DnDMobile.Classes.ItemsFolder;
using DnDMobile.Classes.ItemsFolder.ItemLists;
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
            ListViewItems.ItemsSource = ArmorList.All;
            ItemFilterPicker.ItemsSource = StaticVariables.armorTypes;
        }


        private void ItemFilterPickerSelected(object sender, EventArgs e)
        {
            int selectedIndex = ItemFilterPicker.SelectedIndex;
            if (selectedIndex != -1)
            {
                Object itemType = ItemFilterPicker.ItemsSource[selectedIndex];
                if (object.Equals(itemType, ItemTypes.LightArmor))
                {
                    FilterItemList(ItemTypes.LightArmor);
                }
                else if (object.Equals(itemType, ItemTypes.MediumArmor))
                {
                    FilterItemList(ItemTypes.MediumArmor);
                }
                else if (object.Equals(itemType, ItemTypes.HeavyArmor))
                {
                    FilterItemList(ItemTypes.HeavyArmor);
                }
                else if (object.Equals(itemType, ItemTypes.Shield))
                {
                    FilterItemList(ItemTypes.Shield);
                }
                else
                {
                    ListViewItems.ItemsSource = armorList;
                    ItemFilterPicker.SelectedIndex = -1;
                }
            }
        }


        private void FilterItemList(ItemTypes type)
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
