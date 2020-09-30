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
        GUIHelper guiHelper = new GUIHelper();
        private static readonly Items items = new Items();
        bool pageLoad = true;

        public StandardArmorPage()
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
            InitializeArmor(searchText, items.GetStandardLightArmor(), LightArmorGrid);
            InitializeArmor(searchText, items.GetStandardMediumArmor(), MediumArmorGrid);
            InitializeArmor(searchText, items.GetStandardHeavyArmor(), HeavyArmorGrid);
            InitializeArmor(searchText, items.GetStandardShields(), ShieldsGrid);
        }


        private void ShowGrid(string gridID)
        {
            switch (gridID)
            {
                case "IDLightArmor":
                    ButtonShowLightArmorProcedure(null, null);
                    break;
                case "IDMediumArmor":
                    ButtonShowMediumArmorProcedure(null, null);
                    break;
                case "IDHeavyArmor":
                    ButtonShowHeavyArmorProcedure(null, null);
                    break;
                case "IDShields":
                    ButtonShowShieldsProcedure(null, null);
                    break;
                default:
                    break;
            }
        }


        private void HideGrid(string gridID)
        {
            switch (gridID)
            {
                case "IDLightArmor":
                    ButtonHideLightArmorProcedure(null, null);
                    break;
                case "IDMediumArmor":
                    ButtonHideMediumArmorProcedure(null, null);
                    break;
                case "IDHeavyArmor":
                    ButtonHideHeavyArmorProcedure(null, null);
                    break;
                case "IDShields":
                    ButtonHideShieldsProcedure(null, null);
                    break;
                default:
                    break;
            }
        }


        private void ButtonShowLightArmorProcedure(object sender, EventArgs e)
        {
            guiHelper.ShowElementsProcedure(ButtonShowLightArmor, ButtonHideLightArmor, LabelLightArmorHeader, ScrollviewLightArmor);
        }


        private void ButtonHideLightArmorProcedure(object sender, EventArgs e)
        {
            guiHelper.HideElementsProcedure(ButtonShowLightArmor, ButtonHideLightArmor, LabelLightArmorHeader, ScrollviewLightArmor);
        }


        private void ButtonShowMediumArmorProcedure(object sender, EventArgs e)
        {
            guiHelper.ShowElementsProcedure(ButtonShowMediumArmor, ButtonHideMediumArmor, LabelMediumArmorHeader, ScrollviewMediumArmor);
        }


        private void ButtonHideMediumArmorProcedure(object sender, EventArgs e)
        {
            guiHelper.HideElementsProcedure(ButtonShowMediumArmor, ButtonHideMediumArmor, LabelMediumArmorHeader, ScrollviewMediumArmor);
        }


        private void ButtonShowHeavyArmorProcedure(object sender, EventArgs e)
        {
            guiHelper.ShowElementsProcedure(ButtonShowHeavyArmor, ButtonHideHeavyArmor, LabelHeavyArmorHeader, ScrollviewHeavyArmor);
        }


        private void ButtonHideHeavyArmorProcedure(object sender, EventArgs e)
        {
            guiHelper.HideElementsProcedure(ButtonShowHeavyArmor, ButtonHideHeavyArmor, LabelHeavyArmorHeader, ScrollviewHeavyArmor);
        }


        private void ButtonShowShieldsProcedure(object sender, EventArgs e)
        {
            guiHelper.ShowElementsProcedure(ButtonShowShields, ButtonHideShields, LabelShieldsHeader, ScrollviewShields);
        }


        private void ButtonHideShieldsProcedure(object sender, EventArgs e)
        {
            guiHelper.HideElementsProcedure(ButtonShowShields, ButtonHideShields, LabelShieldsHeader, ScrollviewShields);
        }


        public void CreateWeaponGridLabel(string text, int row, int col, Grid grid, bool isHeader = false)
        {
            Label label = new Label()
            {
                Text = text,
                Style = (Style)Application.Current.Resources["labelGridDataStyle"],
                HorizontalOptions = LayoutOptions.Start
            };
            if (isHeader)
            {
                label.TextColor = Color.FromHex("#930C10");
            }
            Grid.SetRow(label, row);
            Grid.SetColumn(label, col);
            grid.Children.Add(label);
        }


        private void AddArmorGridHeaders(Grid grid)
        {
            RowDefinition rowDefinition = new RowDefinition();
            
            grid.RowDefinitions.Add(rowDefinition);
            CreateWeaponGridLabel("Description", 0, 0, grid, true);
            CreateWeaponGridLabel("Value", 0, 1, grid, true);
            CreateWeaponGridLabel("Armor Class", 0, 2, grid, true);
            CreateWeaponGridLabel("Required Strength", 0, 3, grid, true);
            CreateWeaponGridLabel("Weight", 0, 4, grid, true);
        }


        private void InitializeArmor(string searchDescription, List<Armor> armorList, Grid grid)
        {
            grid.RowDefinitions.Clear();
            grid.Children.Clear();
            AddArmorGridHeaders(grid);
            int rowNumber = 1;
            Boolean matchFound = false;

            foreach (Armor armor in armorList)
            {
                if (string.IsNullOrEmpty(searchDescription) || armor.Description.ToLower().Contains(searchDescription.ToLower()))
                {
                    matchFound = true;
                    RowDefinition rowDefinition = new RowDefinition();
                    grid.RowDefinitions.Add(rowDefinition);
                    CreateWeaponGridLabel(armor.Description, rowNumber, 0, grid);
                    CreateWeaponGridLabel(armor.Value, rowNumber, 1, grid);
                    CreateWeaponGridLabel(armor.ArmorClass, rowNumber, 2, grid);
                    CreateWeaponGridLabel(armor.RequiredStrength, rowNumber, 3, grid);
                    CreateWeaponGridLabel(armor.Weight, rowNumber, 4, grid);
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
