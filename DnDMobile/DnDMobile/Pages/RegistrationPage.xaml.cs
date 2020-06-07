using DnDMobile.Classes;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DnDMobile.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrationPage : ContentPage
    {
        public RegistrationPage()
        {
            InitializeComponent();
            PageStack.FadeTo(1, 2000);
        }


        private async void LogoutClicked(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }


        private async void ButtonRegisterProcedure(object sender, EventArgs e)
        {
            ButtonRegister.IsEnabled = false;
            User user = new User()
            {
                Username = EntryUsername.Text,
                Password = EntryPassword.Text,
                VerificationPassword = EntryConfirmPassword.Text
            };

            if (EnteredData(user))
            {

            }
            else
            {
                await DisplayAlert("Alert", "Enter all data.", "OK");
            }

            ButtonRegister.IsEnabled = true;
        }


        private bool EnteredData(User user)
        {
            bool enteredUsername = !string.IsNullOrEmpty(user.Username);
            bool enteredPassword = !string.IsNullOrEmpty(user.Password);
            bool enteredConfirmPassword = !string.IsNullOrEmpty(user.VerificationPassword);
            return enteredUsername && enteredPassword && enteredConfirmPassword;
        }
    }
}