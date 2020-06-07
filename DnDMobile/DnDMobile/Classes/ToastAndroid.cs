using DnDMobile.Classes;
using Android.Widget;

[assembly: Xamarin.Forms.Dependency(typeof(ToastAndroid))]
namespace DnDMobile.Classes
{

    class ToastAndroid : IToast
    {
        public void Show(string message)
        {
            Android.Widget.Toast.MakeText(Android.App.Application.Context, message, ToastLength.Long).Show();
        }
    }
}
