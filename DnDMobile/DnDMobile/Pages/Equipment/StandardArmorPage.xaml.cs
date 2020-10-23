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
        int rowNumber = 0;
        Grid grid;


        public StandardArmorPage()
        {
            InitializeComponent();
            PageStack.FadeTo(1, 2000);
            InitializeItemLists();
        }


        private void InitializeItemLists(string searchText = "")
        {
            grid = StandardArmorGrid;
            Items items = new Items();
            InitializeArmor(items.GetStandardLightArmor(), "Light Armor");
            InitializeArmor(items.GetStandardMediumArmor(), "Medium Armor");
            InitializeArmor(items.GetStandardHeavyArmor(), "Heavy Armor");
            InitializeArmor(items.GetStandardShields(), "Shields");
        }


        public void CreateWeaponGridLabel(string text, int column, bool isHeader = false)
        {
            Label label = new Label()
            {
                Text = text,
                Style = (Style)Application.Current.Resources["labelGridDataStyle"],
                HorizontalOptions = LayoutOptions.Center
            };
            if (isHeader)
            {
                label.TextColor = Color.FromHex("#930C10");
            }
            Grid.SetRow(label, rowNumber);
            Grid.SetColumn(label, column);
            grid.Children.Add(label);
        }


        private void AddArmorGridHeaders()
        {
            RowDefinition rowDefinition = new RowDefinition();
            grid.RowDefinitions.Add(rowDefinition);
            CreateWeaponGridLabel("Description", 0, true);
            CreateWeaponGridLabel("Value", 1, true);
            CreateWeaponGridLabel("Armor Class", 2, true);
            CreateWeaponGridLabel("Required Strength", 3, true);
            CreateWeaponGridLabel("Weight", 4, true);
            rowNumber++;
        }


        private void AddLabel(string labelText)
        {
            rowNumber++;
            RowDefinition rowDefinition = new RowDefinition();
            grid.RowDefinitions.Add(rowDefinition);
            Label label = new Label()
            { 
                Text = labelText,
                FontSize = 22,
                Style = (Style)Application.Current.Resources["labelHeaderStyle"]
        };
            Grid.SetRow(label, rowNumber);
            Grid.SetColumnSpan(label, 5);
            grid.Children.Add(label);
            rowNumber++;
        }


        private void InitializeArmor(List<Armor> armorList, string labelText)
        {
            
            AddLabel(labelText);
            AddArmorGridHeaders();

            foreach (Armor armor in armorList)
            {
                RowDefinition rowDefinition = new RowDefinition();
                grid.RowDefinitions.Add(rowDefinition);
                CreateWeaponGridLabel(armor.Description, 0);
                CreateWeaponGridLabel(armor.Value, 1);
                CreateWeaponGridLabel(armor.ArmorClass, 2);
                CreateWeaponGridLabel(armor.RequiredStrength, 3);
                CreateWeaponGridLabel(armor.Weight, 4);
                rowNumber++;
            }
        }
    }
}
