using DnDMobile.Classes;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DnDMobile.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SpellsPage : ContentPage
    {
        private Spells spells = new Spells();
        private List<Spell> spellList = Spells.All;

        public SpellsPage()
        {
            InitializeComponent();
            ListViewSpells.ItemsSource = spellList;
            PageStack.FadeTo(1, 2000);
        }


        private async void SpellSelected(object sender, EventArgs e)
        {
            Spell spell = ListViewSpells.SelectedItem as Spell;
            await Navigation.PushAsync(new SpellInfoPage(spell));
        }


        private void ButtonShowFilterOptions(object sender, EventArgs e)
        {
            ButtonShowFilters.IsVisible = false;
            GridFilters.IsVisible = true;
        }


        private void ButtonHideFilterOptions(object sender, EventArgs e)
        {
            ButtonShowFilters.IsVisible = true;
            GridFilters.IsVisible = false;
        }


        /// <summary> Resets the filter selections to default, resetting the spell list. </summary>
        private void ButtonResetFilterOptions(object sender, EventArgs e)
        {
            SpellLevelPicker.SelectedIndex = -1;
            SpellSchoolPicker.SelectedIndex = -1;
            SpellRitualPicker.SelectedIndex = -1;
            SpellConcentrationPicker.SelectedIndex = -1;
            SpellCastableByPicker.SelectedIndex = -1;
            SpellSourcePicker.SelectedIndex = -1;
            spellList = Spells.All;
            ListViewSpells.ItemsSource = spellList;
        }


        /// <summary> 
        /// Entry point for all spell filters. Resets the spell list, then applies any active filter
        /// ensuring that no matter what filter is selected, a fresh list is displayed containing
        /// all selected filters.
        /// </summary>
        private void SpellFilterSelected(object sender, EventArgs e)
        {
            spellList = Spells.All;
            ApplySpellLevelFilter();
            ApplySpellSchoolFilter();
            ApplySpellRitualFilter();
            ApplySpellConcentrationFilter();
            ApplySpellCastableByFilter();
            ApplySpellSourceFilter();
            ListViewSpells.ItemsSource = spellList;
        }


        private void ApplySpellSourceFilter()
        {
            int selectedIndex = SpellSourcePicker.SelectedIndex;
            if (selectedIndex != -1)
            {
                string spellSchool = (string)SpellSourcePicker.ItemsSource[selectedIndex];
                switch (spellSchool)
                {
                    case "Elemental Evil Player's Companion":
                        spellList = spells.FilterSpellsBySource("EE", spellList);
                        break;
                    case "Player Handbook":
                        spellList = spells.FilterSpellsBySource("PHB", spellList);
                        break;
                    case "Sword Coast Adventurer's Guide":
                        spellList = spells.FilterSpellsBySource("SCAG", spellList);
                        break;
                    case "Xanathar's Guide to Everything":
                        spellList = spells.FilterSpellsBySource("XGE", spellList);
                        break;
                    default:
                        break;
                }
            }
        }


        private void ApplySpellCastableByFilter()
        {
            int selectedIndex = SpellCastableByPicker.SelectedIndex;
            if (selectedIndex != -1)
            {
                string spellSchool = (string)SpellCastableByPicker.ItemsSource[selectedIndex];
                switch (spellSchool)
                {
                    case "Bard":
                        spellList = spells.FilterSpellsByCastableBy("Bard", spellList);
                        break;
                    case "Cleric":
                        spellList = spells.FilterSpellsByCastableBy("Cleric", spellList);
                        break;
                    case "Druid":
                        spellList = spells.FilterSpellsByCastableBy("Druid", spellList);
                        break;
                    case "Paladin":
                        spellList = spells.FilterSpellsByCastableBy("Paladin", spellList);
                        break;
                    case "Ranger":
                        spellList = spells.FilterSpellsByCastableBy("Ranger", spellList);
                        break;
                    case "Sorcerer":
                        spellList = spells.FilterSpellsByCastableBy("Sorcerer", spellList);
                        break;
                    case "Warlock":
                        spellList = spells.FilterSpellsByCastableBy("Warlock", spellList);
                        break;
                    case "Wizard":
                        spellList = spells.FilterSpellsByCastableBy("Wizard", spellList);
                        break;
                    default:
                        break;
                }
            }
        }


        private void ApplySpellConcentrationFilter()
        {
            int selectedIndex = SpellConcentrationPicker.SelectedIndex;
            if (selectedIndex != -1)
            {
                string spellSchool = (string)SpellConcentrationPicker.ItemsSource[selectedIndex];
                switch (spellSchool)
                {
                    case "Yes":
                        spellList = spells.FilterSpellsByConcentration("Yes", spellList);
                        break;
                    case "No":
                        spellList = spells.FilterSpellsByConcentration("-", spellList);
                        break;
                    default:
                        break;
                }
            }
        }


        private void ApplySpellRitualFilter()
        {
            int selectedIndex = SpellRitualPicker.SelectedIndex;
            if (selectedIndex != -1)
            {
                string spellSchool = (string)SpellRitualPicker.ItemsSource[selectedIndex];
                switch (spellSchool)
                {
                    case "Yes":
                        spellList = spells.FilterSpellsByRitual("Ritual", spellList);
                        break;
                    case "No":
                        spellList = spells.FilterSpellsByRitual("-", spellList);
                        break;
                    default:
                        break;
                }
            }
        }


        /// <summary> Applies the spell school filter to the spell list. </summary>
        private void ApplySpellSchoolFilter()
        {
            int selectedIndex = SpellSchoolPicker.SelectedIndex;
            if (selectedIndex != -1)
            {
                string spellSchool = (string)SpellSchoolPicker.ItemsSource[selectedIndex];
                switch (spellSchool)
                {
                    case "Abjuration":
                        spellList = spells.FilterSpellsBySchool("Abjuration", spellList);
                        break;
                    case "Conjuration":
                        spellList = spells.FilterSpellsBySchool("Conjuration", spellList);
                        break;
                    case "Divination":
                        spellList = spells.FilterSpellsBySchool("Divination", spellList);
                        break;
                    case "Enchantment":
                        spellList = spells.FilterSpellsBySchool("Enchantment", spellList);
                        break;
                    case "Evocation":
                        spellList = spells.FilterSpellsBySchool("Evocation", spellList);
                        break;
                    case "Illusion":
                        spellList = spells.FilterSpellsBySchool("Illusion", spellList);
                        break;
                    case "Necromancy":
                        spellList = spells.FilterSpellsBySchool("Necromancy", spellList);
                        break;
                    case "Transmutation":
                        spellList = spells.FilterSpellsBySchool("Transmutation", spellList);
                        break;
                    default:
                        break;
                }
            }
        }


        /// <summary> Applies the spell level filter to the spell list. </summary>
        private void ApplySpellLevelFilter()
        {
            int selectedIndex = SpellLevelPicker.SelectedIndex;
            if (selectedIndex != -1)
            {
                string spellLevel = (string)SpellLevelPicker.ItemsSource[selectedIndex];
                switch (spellLevel)
                {
                    case "Show All":
                        spellList = Spells.All;
                        break;
                    case "Cantrip":
                        spellList = spells.FilterSpellsByLevel("0", spellList);
                        break;
                    case "1st":
                        spellList = spells.FilterSpellsByLevel("1", spellList);
                        break;
                    case "2nd":
                        spellList = spells.FilterSpellsByLevel("2", spellList);
                        break;
                    case "3rd":
                        spellList = spells.FilterSpellsByLevel("3", spellList);
                        break;
                    case "4th":
                        spellList = spells.FilterSpellsByLevel("4", spellList);
                        break;
                    case "5th":
                        spellList = spells.FilterSpellsByLevel("5", spellList);
                        break;
                    case "6th":
                        spellList = spells.FilterSpellsByLevel("6", spellList);
                        break;
                    case "7th":
                        spellList = spells.FilterSpellsByLevel("7", spellList);
                        break;
                    case "8th":
                        spellList = spells.FilterSpellsByLevel("8", spellList);
                        break;
                    case "9th":
                        spellList = spells.FilterSpellsByLevel("9", spellList);
                        break;
                    default:
                        break;
                }
            }
        }


        /// <summary> Text listener for the spell searchbar that displays spell names containing the search text. </summary>
        private void OnSpellSearchTextChanged(object sender, EventArgs e)
        {
            SearchBar searchBar = (SearchBar)sender;
            string searchText = searchBar.Text.ToLower();
            List<Spell> matchedSpells = new List<Spell>();
            foreach (Spell spell in Spells.All)
            {
                bool nameFound = false;

                if (!string.IsNullOrEmpty(spell.Name))
                {
                    nameFound = spell.Name.ToLower().Contains(searchText);
                }

                if (nameFound)
                {
                    matchedSpells.Add(spell);
                }
            }
            ListViewSpells.ItemsSource = matchedSpells;
        }
    }
}
