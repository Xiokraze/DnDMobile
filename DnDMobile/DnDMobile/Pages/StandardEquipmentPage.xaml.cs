using DnDMobile.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DnDMobile.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StandardEquipmentPage : ContentPage
    {
        private static readonly Items items = new Items();

        public StandardEquipmentPage()
        {
            InitializeComponent();
            InitializeItemLists();
        }


        private void OnItemsSearchTextChanged(object sender, EventArgs e)
        {
            SearchBar searchBar = (SearchBar)sender;
            string searchText = searchBar.Text.ToLower();
            InitializeItemLists(searchText);
        }


        private void ButtonShowWeaponsProcedure(object sender, EventArgs e)
        {
            ButtonShowWeapons.IsVisible = false;
            LabelSimpleMeleeHeader.IsVisible = true;
            ScrollviewSimpleMelee.IsVisible = true;
            ButtonHideWeapons.IsVisible = true;
        }


        private void ButtonHideWeaponsProcedure(object sender, EventArgs e)
        {
            ButtonShowWeapons.IsVisible = true;
            LabelSimpleMeleeHeader.IsVisible = false;
            ScrollviewSimpleMelee.IsVisible = false;
            ButtonHideWeapons.IsVisible = false;
        }


        private void ButtonShowArmorProcedure(object sender, EventArgs e)
        {
            
        }


        private void ButtonHideArmorProcedure(object sender, EventArgs e)
        {

        }


        private void InitializeItemLists(string searchText = "")
        {
            InitializeWeapons(searchText, items.GetSimpleMeleeWeapons(), SimpleMeleeWeaponsGrid);

        }


        public void CreateWeaponGridLabel(string text, int row, int col, Grid grid)
        {
            Label label = new Label()
            {
                Text = text,
                Style = (Style)Application.Current.Resources["labelGridDataStyle"],
                HorizontalOptions = LayoutOptions.Start
            };
            Grid.SetRow(label, row);
            Grid.SetColumn(label, col);
            grid.Children.Add(label);
        }


        private void AddWeaponGridHeaders(Grid grid)
        {
            RowDefinition rowDefinition = new RowDefinition();
            grid.RowDefinitions.Add(rowDefinition);
            CreateWeaponGridLabel("Description", 0, 0, grid);
            CreateWeaponGridLabel("Value", 0, 1, grid);
            CreateWeaponGridLabel("Damage", 0, 2, grid);
            CreateWeaponGridLabel("Weight", 0, 3, grid);
            CreateWeaponGridLabel("Properties", 0, 4, grid);
        }


        private void InitializeWeapons(string searchDescription, List<Weapon> weapons, Grid grid)
        {
            grid.RowDefinitions.Clear();
            grid.Children.Clear();
            AddWeaponGridHeaders(grid);
            int rowNumber = 1;

            foreach (Weapon weapon in weapons)
            {
                if (string.IsNullOrEmpty(searchDescription) || weapon.Description.ToLower().Contains(searchDescription.ToLower()))
                {
                    RowDefinition rowDefinition = new RowDefinition();
                    grid.RowDefinitions.Add(rowDefinition);
                    CreateWeaponGridLabel(weapon.Description, rowNumber, 0, grid);
                    CreateWeaponGridLabel(weapon.Value, rowNumber, 1, grid);
                    CreateWeaponGridLabel(weapon.Damage, rowNumber, 2, grid);
                    CreateWeaponGridLabel(weapon.Weight, rowNumber, 3, grid);
                    CreateWeaponGridLabel(weapon.Properties, rowNumber, 4, grid);
                    rowNumber++;
                }
            }
        }
    }
}
