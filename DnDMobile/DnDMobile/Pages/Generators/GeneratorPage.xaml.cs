using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DnDMobile.Pages.Generators
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GeneratorPage : ContentPage
    {
        public GeneratorPage()
        {
            InitializeComponent();
            List<string> options = GetGeneratorOptions();
            ListViewGenerators.ItemsSource = options;
        }


        private List<string> GetGeneratorOptions()
        {
            List<string> options = new List<string>()
            {
                "Individual Treasure",
                "Treasure Hoard"
            };
            return options;
        }


        private async void GeneratorSelected(object sender, EventArgs e)
        {
            string spell = ListViewGenerators.SelectedItem.ToString();
            switch (spell)
            {
                case "Individual Treasure":
                    //do this
                    break;
                case "Treasure Hoard":
                    // TODO
                    break;
                default:
                    break;
            }

            //await Navigation.PushAsync(new SpellInfoPage(spell));
        }
    }
}