﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DnDMobile.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
            PageStack.FadeTo(1, 2000);
        }


        private async void ButtonViewSpellsProcedure(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SpellsPage());
        }
    }
}