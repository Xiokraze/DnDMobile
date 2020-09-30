using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace DnDMobile.Classes.ItemsFolder
{
    class GUIHelper
    {
        public void HideElementsProcedure(Button showButton, Button hideButton, Label headerLabel, ScrollView scrollview)
        {
            showButton.IsVisible = true;
            hideButton.IsVisible = false;
            headerLabel.IsVisible = false;
            scrollview.IsVisible = false;
            
        }


        public void ShowElementsProcedure(Button showButton, Button hideButton, Label headerLabel, ScrollView scrollview)
        {
            showButton.IsVisible = false;
            hideButton.IsVisible = true;
            headerLabel.IsVisible = true;
            scrollview.IsVisible = true;
            
        }
    }
}
