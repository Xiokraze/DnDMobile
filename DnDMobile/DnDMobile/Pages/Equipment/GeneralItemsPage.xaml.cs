using DnDMobile.Classes;
using DnDMobile.Classes.ItemsFolder;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DnDMobile.Pages.Equipment
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GeneralItemsPage : ContentPage
    {
        private readonly List<GeneralItem> generalItemList = new List<GeneralItem>();


        public GeneralItemsPage()
        {
            InitializeComponent();
            PageStack.FadeTo(1, 2000);
            LoadGeneralItems();
        }


        private void LoadGeneralItems()
        {
            Items items = new Items();
            InitializeItems(items.GeneralItems);
            InitializeItems(items.GeneralItemsAmmunition);
            InitializeItems(items.GeneralItemsArcaneFocus);
            InitializeItems(items.GeneralItemsDruidicFocus);
            InitializeItems(items.GeneralItemsHolySymbol);
            generalItemList.Sort((x, y) => x.Description.CompareTo(y.Description));
            ListViewItems.ItemsSource = generalItemList;

            // Update type picker options.
            ItemFilterPicker.ItemsSource = StaticVariables.generalTypes;
        }


        private void InitializeItems(List<GeneralItem> generalItems)
        {
            foreach (GeneralItem generalItem in generalItems)
            {
                generalItemList.Add(generalItem);
            }
        }


        private void ItemFilterPickerSelected(object sender, EventArgs e)
        {
            int selectedIndex = ItemFilterPicker.SelectedIndex;
            if (selectedIndex != -1)
            {
                var itemType = ItemFilterPicker.ItemsSource[selectedIndex];
                if (object.Equals(itemType, StaticVariables.ammunition))
                {
                    FilterItemList(StaticVariables.ammunition);
                }
                else if (object.Equals(itemType, StaticVariables.arcaneFocus))
                {
                    FilterItemList(StaticVariables.arcaneFocus);
                }
                else if (object.Equals(itemType, StaticVariables.druidicFocus))
                {
                    FilterItemList(StaticVariables.druidicFocus);
                }
                else if (object.Equals(itemType, StaticVariables.generalGood))
                {
                    FilterItemList(StaticVariables.generalGood);
                }
                else if (object.Equals(itemType, StaticVariables.holySymbol))
                {
                    FilterItemList(StaticVariables.holySymbol);
                }
                else
                {
                    ListViewItems.ItemsSource = generalItemList;
                    ItemFilterPicker.SelectedIndex = -1;
                }
            }
        }


        private void FilterItemList(string type)
        {
            List<GeneralItem> filterMatches = new List<GeneralItem>();
            foreach (GeneralItem generalItem in generalItemList)
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
                FilterList();
            }
            else
            {
                FilterList(searchText);
            }
        }


        private void FilterList(string searchText = "")
        {
            if (string.IsNullOrEmpty(searchText))
            {
                ListViewItems.ItemsSource = generalItemList;
            }
            else
            {
                List<GeneralItem> tempList = new List<GeneralItem>();
                foreach (GeneralItem item in generalItemList)
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
}
