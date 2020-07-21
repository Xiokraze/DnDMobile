using DnDMobile.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DnDMobile.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SpellsPage : ContentPage
    {
        private Spells spells = new Spells();

        public SpellsPage()
        {
            InitializeComponent();
            GetSpells();
            PageStack.FadeTo(1, 2000);
        }


        private async void GetSpells()
        {
            if (spells.GetSpellList().Count > 0)
            {
                ListViewSpells.ItemsSource = spells.GetSpellList();
            }
            else
            {
                await DisplayAlert("Error", "An error occured when populating spell data.", "OK");
                await Navigation.PopAsync();
            }
        }


        private void OnSpellSearchTextChanged(object sender, EventArgs e)
        {
            SearchBar searchBar = (SearchBar)sender;
            string searchText = searchBar.Text.ToLower();
            List<Spell> matchedSpells = new List<Spell>();
            foreach (Spell spell in spells.GetSpellList())
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


        private async void SpellSelected(object sender, EventArgs e)
        {
            Spell spell = ListViewSpells.SelectedItem as Spell;
            await Navigation.PushAsync(new SpellInfoPage(spell));
        }
    }
}