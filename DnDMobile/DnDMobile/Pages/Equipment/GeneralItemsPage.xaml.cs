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
    public partial class GeneralItemsPage : ContentPage
    {
        public GeneralItemsPage()
        {
            InitializeComponent();
            PageStack.FadeTo(1, 2000);
            LoadGeneralItems();
        }


        private void LoadGeneralItems()
        {
            ListViewItems.ItemsSource = GeneralItems.All;
            ItemFilterPicker.ItemsSource = StaticVariables.generalTypes;
        }


        private void ItemFilterPickerSelected(object sender, EventArgs e)
        {
            int selectedIndex = ItemFilterPicker.SelectedIndex;
            if (selectedIndex != -1)
            {
                var itemType = ItemFilterPicker.ItemsSource[selectedIndex];
                if (object.Equals(itemType, ItemTypes.Ammunition))
                {
                    FilterItemList(ItemTypes.Ammunition);
                }
                else if (object.Equals(itemType, ItemTypes.ArcaneFocus))
                {
                    FilterItemList(ItemTypes.ArcaneFocus);
                }
                else if (object.Equals(itemType, ItemTypes.DruidicFocus))
                {
                    FilterItemList(ItemTypes.DruidicFocus);
                }
                else if (object.Equals(itemType, ItemTypes.GeneralGood))
                {
                    FilterItemList(ItemTypes.GeneralGood);
                }
                else if (object.Equals(itemType, ItemTypes.HolySymbol))
                {
                    FilterItemList(ItemTypes.HolySymbol);
                }
                else
                {
                    ListViewItems.ItemsSource = GeneralItems.All;
                    ItemFilterPicker.SelectedIndex = -1;
                }
            }
        }


        private void FilterItemList(ItemTypes type)
        {
            List<GeneralItem> filterMatches = new List<GeneralItem>();
            foreach (GeneralItem generalItem in GeneralItems.All)
            {
                if (object.Equals(type, generalItem.Type))
                {
                    filterMatches.Add(generalItem);
                }
            }
            ListViewItems.ItemsSource = filterMatches;
        }


        private async void ListItemTapped(object sender, EventArgs e)
        {
            ListView listView = (ListView)sender;
            GeneralItem generalItem = (GeneralItem)listView.SelectedItem;
            await Navigation.PushAsync(new GeneralItemInfoPage(generalItem));
        }


        private void OnItemsSearchTextChanged(object sender, EventArgs e)
        {
            SearchBar searchBar = (SearchBar)sender;
            string searchText = searchBar.Text.ToLower();
            if (string.IsNullOrEmpty(searchText))
            {
                ListViewItems.ItemsSource = GeneralItems.All;
            }
            else
            {
                FilterList(searchText);
            }
        }


        private void FilterList(string searchText = "")
        {
            List<GeneralItem> tempList = new List<GeneralItem>();
            foreach (GeneralItem item in GeneralItems.All)
            {
                if (item.Description.ToLower().Contains(searchText))
                {
                    tempList.Add(item);
                }
            }
            ListViewItems.ItemsSource = tempList;
        }
    }
}
