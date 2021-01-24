using DnDMobile.Classes;
using DnDMobile.Classes.ItemsFolder;
using DnDMobile.Classes.ItemsFolder.ItemLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DnDMobile.Pages.Equipment
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ArtPage : ContentPage
    {
        private readonly List<Art> artList = new List<Art>();
        public ArtPage()
        {
            InitializeComponent();
            PageStack.FadeTo(1, 2000);
            InitializeItemLists();
        }


        private void InitializeItemLists()
        {
            ListViewItems.ItemsSource = ArtList.All;
            ItemFilterPicker.ItemsSource = StaticVariables.artTypes;
        }


        private void ItemFilterPickerSelected(object sender, EventArgs e)
        {
            int selectedIndex = ItemFilterPicker.SelectedIndex;
            if (selectedIndex != -1)
            {
                Object itemType = ItemFilterPicker.ItemsSource[selectedIndex];
                if (object.Equals(itemType, StaticVariables.gp25))
                {
                    FilterItemList(StaticVariables.gp25);
                }
                else if (object.Equals(itemType, StaticVariables.gp250))
                {
                    FilterItemList(StaticVariables.gp250);
                }
                else if (object.Equals(itemType, StaticVariables.gp750))
                {
                    FilterItemList(StaticVariables.gp750);
                }
                else if (object.Equals(itemType, StaticVariables.gp2500))
                {
                    FilterItemList(StaticVariables.gp2500);
                }
                else if (object.Equals(itemType, StaticVariables.gp7500))
                {
                    FilterItemList(StaticVariables.gp7500);
                }
                else
                {
                    ListViewItems.ItemsSource = artList;
                    ItemFilterPicker.SelectedIndex = -1;
                }
            }
        }


        private void FilterItemList(string type)
        {
            List<Art> filterMatches = new List<Art>();
            foreach (Art art in artList)
            {
                if (object.Equals(type, art.Value))
                {
                    filterMatches.Add(art);
                }
            }
            ListViewItems.ItemsSource = filterMatches;
        }


        private async void ListItemTapped(object sender, EventArgs e)
        {
            ListView listView = (ListView)sender;
            Art art = (Art)listView.SelectedItem;
            await Navigation.PushAsync(new ArtInfoPage(art));
        }
    }
}