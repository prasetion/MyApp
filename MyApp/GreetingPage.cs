using System;
using Xamarin.Forms;

namespace MyApp
{
    public class GreetingPage : ContentPage
    {
        public GreetingPage()
        {
            Content = new Label()
            {
                Text = "Hello World!!",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            //Padding = new Thickness(0, 20, 0, 0);


        }
    }
}

