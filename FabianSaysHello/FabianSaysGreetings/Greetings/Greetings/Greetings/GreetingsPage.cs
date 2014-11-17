using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;


namespace Greetings
{
    class GreetingsPage : ContentPage
    {
        public GreetingsPage()
        {
            FormattedString formattedString = new FormattedString();
            //Label label = new Label // taking this away in second step to make it this.Content
            this.Content = new Label
            {
                Text = "Hi from Fabian Williams Xamarin Forms",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.StartAndExpand,
                BackgroundColor = Color.Purple,
                TextColor = Color.Yellow
            };

            //this.Padding = new Thickness (0, 20, 0, 0); //this way makes it happen on all devices
            this.Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0); //iOS only device

        }
    }
}
