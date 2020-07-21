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
    public partial class SpellInfoPage : ContentPage
    {
        public SpellInfoPage(Spell spell)
        {
            InitializeComponent();
            BindingContext = spell;
        }
    }
}