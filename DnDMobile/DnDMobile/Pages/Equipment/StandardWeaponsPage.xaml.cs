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
    public partial class StandardWeaponsPage : ContentPage
    {
        private static readonly Items items = new Items();
        bool pageLoad = true;

        public StandardWeaponsPage()
        {
            InitializeComponent();
            PageStack.FadeTo(1, 2000);
            InitializeItemLists();
            pageLoad = false;
        }


        private void OnItemsSearchTextChanged(object sender, EventArgs e)
        {
            SearchBar searchBar = (SearchBar)sender;
            string searchText = searchBar.Text.ToLower();
            if (string.IsNullOrEmpty(searchText))
            {
                pageLoad = true;
            }
            else
            {
                pageLoad = false;
            }
            InitializeItemLists(searchText);
        }


        private void InitializeItemLists(string searchText = "")
        {
            InitializeWeapons(searchText, items.GetSimpleMeleeWeapons(), SimpleMeleeWeaponsGrid);
            InitializeWeapons(searchText, items.GetSimpleRangedWeapons(), SimpleRangedWeaponsGrid);
            InitializeWeapons(searchText, items.GetMartialMeleeWeapons(), MartialMeleeWeaponsGrid);
            InitializeWeapons(searchText, items.GetMartialRangedWeapons(), MartialRangedWeaponsGrid);

        }


        private void ShowGrid(string gridID)
        {
            switch (gridID)
            {
                case "IDSimpleMelee":
                    ButtonShowSimpleMeleeWeaponsProcedure(null, null);
                    break;
                case "IDSimpleRanged":
                    ButtonShowSimpleRangedWeaponsProcedure(null, null);
                    break;
                case "IDMartialMelee":
                    ButtonShowMartialMeleeWeaponsProcedure(null, null);
                    break;
                case "IDMartialRanged":
                    ButtonShowMartialRangedWeaponsProcedure(null, null);
                    break;
                default:
                    break;
            }
        }


        private void HideGrid(string gridID)
        {
            switch (gridID)
            {
                case "IDSimpleMelee":
                    ButtonHideSimpleMeleeWeaponsProcedure(null, null);
                    break;
                case "IDSimpleRanged":
                    ButtonHideSimpleRangedWeaponsProcedure(null, null);
                    break;
                case "IDMartialMelee":
                    ButtonHideMartialMeleeWeaponsProcedure(null, null);
                    break;
                case "IDMartialRanged":
                    ButtonHideMartialRangedWeaponsProcedure(null, null);
                    break;
                default:
                    break;
            }
        }


        private void ButtonShowSimpleMeleeWeaponsProcedure(object sender, EventArgs e)
        {
            ButtonShowSimpleMeleeWeapons.IsVisible = false;
            LabelSimpleMeleeHeader.IsVisible = true;
            ScrollviewSimpleMelee.IsVisible = true;
            ButtonHideSimpleMeleeWeapons.IsVisible = true;
        }


        private void ButtonHideSimpleMeleeWeaponsProcedure(object sender, EventArgs e)
        {
            ButtonShowSimpleMeleeWeapons.IsVisible = true;
            LabelSimpleMeleeHeader.IsVisible = false;
            ScrollviewSimpleMelee.IsVisible = false;
            ButtonHideSimpleMeleeWeapons.IsVisible = false;
        }


        private void ButtonShowSimpleRangedWeaponsProcedure(object sender, EventArgs e)
        {
            ButtonShowSimpleRangedWeapons.IsVisible = false;
            LabelSimpleRangedHeader.IsVisible = true;
            ScrollviewSimpleRanged.IsVisible = true;
            ButtonHideSimpleRangedWeapons.IsVisible = true;
        }


        private void ButtonHideSimpleRangedWeaponsProcedure(object sender, EventArgs e)
        {
            ButtonShowSimpleRangedWeapons.IsVisible = true;
            LabelSimpleRangedHeader.IsVisible = false;
            ScrollviewSimpleRanged.IsVisible = false;
            ButtonHideSimpleRangedWeapons.IsVisible = false;
        }


        private void ButtonShowMartialMeleeWeaponsProcedure(object sender, EventArgs e)
        {
            ButtonShowMartialMeleeWeapons.IsVisible = false;
            LabelMartialMeleeHeader.IsVisible = true;
            ScrollviewMartialMelee.IsVisible = true;
            ButtonHideMartialMeleeWeapons.IsVisible = true;
        }


        private void ButtonHideMartialMeleeWeaponsProcedure(object sender, EventArgs e)
        {
            ButtonShowMartialMeleeWeapons.IsVisible = true;
            LabelMartialMeleeHeader.IsVisible = false;
            ScrollviewMartialMelee.IsVisible = false;
            ButtonHideMartialMeleeWeapons.IsVisible = false;
        }

        private void ButtonShowMartialRangedWeaponsProcedure(object sender, EventArgs e)
        {
            ButtonShowMartialRangedWeapons.IsVisible = false;
            LabelMartialRangedHeader.IsVisible = true;
            ScrollviewMartialRanged.IsVisible = true;
            ButtonHideMartialRangedWeapons.IsVisible = true;
        }


        private void ButtonHideMartialRangedWeaponsProcedure(object sender, EventArgs e)
        {
            ButtonShowMartialRangedWeapons.IsVisible = true;
            LabelMartialRangedHeader.IsVisible = false;
            ScrollviewMartialRanged.IsVisible = false;
            ButtonHideMartialRangedWeapons.IsVisible = false;
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
            Boolean matchFound = false;

            foreach (Weapon weapon in weapons)
            {
                if (string.IsNullOrEmpty(searchDescription) || weapon.Description.ToLower().Contains(searchDescription.ToLower()))
                {
                    matchFound = true;
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
            if (matchFound && pageLoad != true)
            {
                ShowGrid(grid.StyleId);
            }
            else
            {
                HideGrid(grid.StyleId);
            }
        }
    }
}
