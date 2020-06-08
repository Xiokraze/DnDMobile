using DnDMobile.Classes;
using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
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


        private void ButtonRegisterProcedure(object sender, EventArgs e)
        {
            ButtonRegister.IsEnabled = false;
            User user = new User()
            {
                Username = EntryUsername.Text,
                Password = EntryPassword.Text,
                VerificationPassword = EntryConfirmPassword.Text
            };

            if (EnteredData(user) && PasswordsMatch(user))
            {
                AttemptRegistration(user);
            }
            ButtonRegister.IsEnabled = true;
        }


        private void AttemptRegistration(User user)
        {
            Hashing hashing = new Hashing();
            user.VerificationPassword = "";
            user.Password = hashing.RegistrationHash(user.Password);
            SaveUser(user);
        }


        private  SaveUser(User user)
        {
            try
            {
                if ()
                
            }
            catch
            {

            }
        }


        private bool PasswordsMatch(User user)
        {
            bool matchStatus = user.Password == user.VerificationPassword;
            if (matchStatus)
            {
                return true;
            }
            else
            {
                DependencyService.Get<IToast>().Show("Passwords did not match!");
                EntryPassword.Text = "";
                EntryConfirmPassword.Text = "";
                return false;
            }
        }


        private bool EnteredData(User user)
        {
            bool enteredUsername = !string.IsNullOrEmpty(user.Username);
            bool enteredPassword = !string.IsNullOrEmpty(user.Password);
            bool enteredConfirmPassword = !string.IsNullOrEmpty(user.VerificationPassword);
            if (enteredUsername && enteredPassword && enteredConfirmPassword)
            {
                return true;
            }
            else
            {
                DependencyService.Get<IToast>().Show("Complete form to continue!");
                return false;
            }
        }
    }
}