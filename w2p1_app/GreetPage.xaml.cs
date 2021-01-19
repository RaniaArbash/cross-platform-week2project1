using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace w2p1_app
{
    public partial class GreetPage : ContentPage
    {//MVVM
        int count = 0;
        public GreetPage()
        {
            InitializeComponent();
            //  mylabel.Text = "Hello Xamarin";
           // mylabel.Text = slider.Value.ToString();
        }

        private void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            count++;
            //((Button)sender).Text = $"{count}";
            // DisplayAlert("Hello Class", "Welcome to Xamarin", "OK");
            mylabel.Text = $"count = {count}";
        }

        
    }
}
