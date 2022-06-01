using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TripsTrapsTrull
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            Button Start = new Button()
            {
                Text = "Start",
                BackgroundColor = Color.LightGreen,
                HorizontalOptions = LayoutOptions.Center,
            };

            Button Exit = new Button()
            {
                Text = "Exit",
                BackgroundColor = Color.LightGreen,
                HorizontalOptions = LayoutOptions.Center,
            };
            StackLayout st = new StackLayout()
            {
                Children = { Start, Exit }
            };

            st.BackgroundColor = Color.AntiqueWhite;
            Content = st;
            Exit.Clicked += Exit_Clicked;
            Start.Clicked += Start_Clicked;
        }

        private async void Start_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Game());
        }

        private void Exit_Clicked(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
