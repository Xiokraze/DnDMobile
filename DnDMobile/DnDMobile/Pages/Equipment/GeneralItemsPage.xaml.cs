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
        GUIHelper guiHelper = new GUIHelper();
        private static readonly Items items = new Items();
        private List<GeneralItem> generalItems = new List<GeneralItem>();
        List<GeneralItem> filteredGeneralItems = new List<GeneralItem>();


        public GeneralItemsPage()
        {
            InitializeComponent();
            LoadGeneralItems();
            PageStack.FadeTo(1, 2000);
        }


        private void LoadGeneralItems()
        {
            generalItems.AddRange(items.GetGeneralItems());
            generalItems.AddRange(items.GetGeneralItemsAmmunition());
            generalItems.AddRange(items.GetGeneralItemsArcaneFocusn());
            generalItems.AddRange(items.GetGeneralItemsDruidicFocus());
            generalItems.AddRange(items.GetGeneralItemsHolySymbol());
            generalItems.Sort((x, y) => x.Description.CompareTo(y.Description));
            FilterList();
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
                ListViewGeneralItems.ItemsSource = generalItems;
            }
            else
            {
                List<GeneralItem> tempList = new List<GeneralItem>();
                foreach (GeneralItem item in generalItems)
                {
                    if (item.Description.ToLower().Contains(searchText))
                    {
                        tempList.Add(item);
                    }
                }
                ListViewGeneralItems.ItemsSource = tempList;
            }
        }


        private void FilterItemsByType(string type)
        {
            filteredGeneralItems.Clear();

            if (!string.IsNullOrEmpty(type))
            {
                foreach (GeneralItem item in generalItems)
                {
                    if (item.Classification == type)
                    {
                        filteredGeneralItems.Add(item);
                    }
                }
            }
        }


        private void ItemFilterSelected(object sender, EventArgs e)
        {
            int selectedIndex = ItemTypePicker.SelectedIndex;
            if (selectedIndex != -1)
            {
                string itemType = (string)ItemTypePicker.ItemsSource[selectedIndex];
                switch (itemType)
                {
                    case "All Items":
                        FilterItemsByType("");
                        break;
                    case "Ammunition":
                        FilterItemsByType("Ammunition");
                        break;
                    case "Arcane Focus":
                        FilterItemsByType("Arcane Focus");
                        break;
                    case "Druidic Focus":
                        FilterItemsByType("Druidic Focus");
                        break;
                    case "General Good":
                        FilterItemsByType("General Good");
                        break;
                    case "Holy Symbol":
                        FilterItemsByType("Holy Symbol");
                        break;
                    default:
                        break;
                }
                if (filteredGeneralItems.Count > 0)
                {
                    ListViewGeneralItems.ItemsSource = null;
                    ListViewGeneralItems.ItemsSource = filteredGeneralItems;
                }
                else
                {
                    ListViewGeneralItems.ItemsSource = null;
                    ListViewGeneralItems.ItemsSource = generalItems;
                }
            }
        }


        //private void AddGeneralItemHeaders(Grid grid)
        //{
        //    RowDefinition rowDefinition = new RowDefinition();
        //    grid.RowDefinitions.Add(rowDefinition);
        //    CreateGeneralItemGridLabel("Description", 0, 0, grid, true);
        //    CreateGeneralItemGridLabel("Value", 0, 1, grid, true);
        //    CreateGeneralItemGridLabel("Weight", 0, 2, grid, true);
        //}


        //public void CreateGeneralItemGridLabel(string text, int row, int col, Grid grid, bool isHeader = false)
        //{
        //    Label label = new Label()
        //    {
        //        Text = text,
        //        Style = (Style)Application.Current.Resources["labelGridDataStyle"],
        //        HorizontalOptions = LayoutOptions.Start
        //    };
        //    if (isHeader)
        //    {
        //        label.TextColor = Color.FromHex("#930C10");
        //    }
        //    Grid.SetRow(label, row);
        //    Grid.SetColumn(label, col);
        //    grid.Children.Add(label);
        //}


        //public void CreateGeneralItemLabel(string text, int row, int col, Grid grid, bool isHeader = false)
        //{
        //    Label label = new Label()
        //    {
        //        Text = text,
        //        Style = (Style)Application.Current.Resources["labelGridDataStyle"],
        //        HorizontalOptions = LayoutOptions.Start,
        //        StyleId = "Item"
        //    };
        //    if (isHeader)
        //    {
        //        label.TextColor = Color.FromHex("#930C10");
        //    }
        //    Grid.SetRow(label, row);
        //    Grid.SetColumn(label, col);
        //    grid.Children.Add(label);
        //}


        //private void UpdateGeneralItemsGrid(List<GeneralItem> items, Grid grid)
        //{
        //    grid.RowDefinitions.Clear();
        //    grid.Children.Clear();
        //    AddGeneralItemHeaders(grid);
        //    int rowNumber = 1;

        //    foreach (GeneralItem item in items)
        //    {
        //        RowDefinition rowDefinition = new RowDefinition();
        //        grid.RowDefinitions.Add(rowDefinition);
        //        CreateGeneralItemGridLabel(item.Description, rowNumber, 0, grid);
        //        CreateGeneralItemGridLabel(item.Value, rowNumber, 1, grid);
        //        CreateGeneralItemGridLabel(item.Weight, rowNumber, 2, grid);
        //        rowNumber++;
        //    }
        //}
    }
}
