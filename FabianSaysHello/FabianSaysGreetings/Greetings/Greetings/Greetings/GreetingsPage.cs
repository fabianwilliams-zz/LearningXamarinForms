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
            //Label label = new Label // taking this away in second step to make it this.Content
            this.Content = new Label
            {
                Text = "Hello from Fabian Williams Xamarin Forms"
            };

            this.Padding = new Thickness (0, 20, 0, 0); //this way makes it happen on all devices
            //this.Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0); //iOS only device

        }
    }
}
