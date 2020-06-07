using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DnDMobile
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            PageStack.FadeTo(1, 2000);
        }


        private async void ButtonLoginProcedure(object sender, EventArgs e)
        {
            await DisplayAlert("Alert", "In Development", "Ok");
        }


        private async void ButtonRegisterProcedure(object sender, EventArgs e)
        {
            await DisplayAlert("Alert", "In Development", "Ok");
        }
    }
}
