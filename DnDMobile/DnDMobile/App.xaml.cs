﻿using DnDMobile.Pages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DnDMobile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MenuPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
