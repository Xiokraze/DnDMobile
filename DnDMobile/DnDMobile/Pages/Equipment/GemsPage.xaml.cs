using DnDMobile.Classes;
using DnDMobile.Classes.ItemsFolder;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DnDMobile.Pages.Equipment
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GemsPage : ContentPage
    {
        private readonly List<Gem> gemList = new List<Gem>();

        public GemsPage()
        {
            InitializeComponent();
            PageStack.FadeTo(1, 2000);
            InitializeItemLists();
        }


        private void InitializeItemLists()
        {
            Items items = new Items();
            InitializeItems(items.Gems10);
            InitializeItems(items.Gems50);
            InitializeItems(items.Gems100);
            InitializeItems(items.Gems500);
            InitializeItems(items.Gems1000);
            InitializeItems(items.Gems5000);
            gemList.Sort((x, y) => x.Name.CompareTo(y.Name));
            ListViewItems.ItemsSource = gemList;

            // Update type picker options.
            ItemFilterPicker.ItemsSource = StaticVariables.gemTypes;
        }


        private void InitializeItems(List<Gem> gems)
        {
            foreach (Gem gem in gems)
            {
                gemList.Add(gem);
            }
        }


        private void ItemFilterPickerSelected(object sender, EventArgs e)
        {
            int selectedIndex = ItemFilterPicker.SelectedIndex;
            if (selectedIndex != -1)
            {
                Object itemType = ItemFilterPicker.ItemsSource[selectedIndex];
                if (object.Equals(itemType, StaticVariables.gp10))
                {
                    FilterItemList(StaticVariables.gp10);
                }
                else if (object.Equals(itemType, StaticVariables.gp50))
                {
                    FilterItemList(StaticVariables.gp50);
                }
                else if (object.Equals(itemType, StaticVariables.gp100))
                {
                    FilterItemList(StaticVariables.gp100);
                }
                else if (object.Equals(itemType, StaticVariables.gp500))
                {
                    FilterItemList(StaticVariables.gp500);
                }
                else if (object.Equals(itemType, StaticVariables.gp1000))
                {
                    FilterItemList(StaticVariables.gp1000);
                }
                else if (object.Equals(itemType, StaticVariables.gp5000))
                {
                    FilterItemList(StaticVariables.gp5000);
                }
                else
                {
                    ListViewItems.ItemsSource = gemList;
                    ItemFilterPicker.SelectedIndex = -1;
                }
            }
        }


        private void FilterItemList(string type)
        {
            List<Gem> filterMatches = new List<Gem>();
            foreach (Gem gem in gemList)
            {
                if (object.Equals(type, gem.Value))
                {
                    filterMatches.Add(gem);
                }
            }
            ListViewItems.ItemsSource = filterMatches;
        }


        private async void ListItemTapped(object sender, EventArgs e)
        {
            ListView listView = (ListView)sender;
            Gem gem = (Gem)listView.SelectedItem;
            await Navigation.PushAsync(new GemInfoPage(gem));
        }
    }
}
