using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Xamarin2
{
    public partial class GreetPagexaml : ContentPage
    {
        public string[] Quotes = new string[] {"String1", "String2", "String3", "String4", "String5", "String6"};  

        public int Index = 0;

        public GreetPagexaml()
        {
            InitializeComponent();
            Slider.Value = 16;
            QuoteLbl.Text = Quotes[Index];
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
            if (Index == Quotes.Length-1)
            {
                Index = 0;
            }
            else
            {
                Index++;
            }
            QuoteLbl.Text = Quotes[Index];
            
        }
    }
}
