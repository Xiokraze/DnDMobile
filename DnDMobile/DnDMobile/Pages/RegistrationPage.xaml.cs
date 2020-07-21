using DnDMobile.Classes;
using Newtonsoft.Json;
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


        private void ButtonSaveUserProcedure(object sender, EventArgs e)
        {
            ButtonSaveUser.IsEnabled = false;
            User user = new User()
            {
                Username = EntryUsername.Text,
                Password = EntryPassword.Text,
                VerificationPassword = EntryConfirmPassword.Text
            };

            if (EnteredData(user) && PasswordsMatch(user))
            {
                AttemptSaveUser(user);
            }
            ButtonSaveUser.IsEnabled = true;
        }


        private void AttemptSaveUser(User user)
        {
            Hashing hashing = new Hashing();
            user.VerificationPassword = "";
            user.Password = hashing.RegistrationHash(user.Password);
            SaveUser(user);
        }


        private void SaveUser(User user)
        {
            try
            {
                string userObject = JsonConvert.SerializeObject(user);
                // TODO
            }
            catch
            {
                // TODO
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
                DependencyService.Get<IToast>().Show("Passwords do not match!");
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