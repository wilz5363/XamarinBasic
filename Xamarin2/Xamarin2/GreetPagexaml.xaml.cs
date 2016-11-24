using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Xamarin2
{
    public partial class GreetPagexaml : ContentPage
    {
        public List<String> Quotes = new List<string>(
            new string[] {"String1", "String2", "String3", "String4", "String5", "String6" }        
        );
        public static int Index = 0;

        public GreetPagexaml()
        {
            InitializeComponent();
            Slider.Value = 16;
            //Device.OnPlatform(
            //     iOS: () =>
            //     {
            //         Padding = new Thickness(0, 20, 0, 0);
            //     },
            //    Android: () =>
            //    {
            //        Padding = new Thickness(10, 20, 0, 0);
            //    }
            // );
        }

        private void NextQuoteBtn_OnClicked(object sender, EventArgs e)
        {

            QuoteLbl.Text = Quotes[Index++ == Quotes.Count ? 0 : Index];
        }
    }
}
