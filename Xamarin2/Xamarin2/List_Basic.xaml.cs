using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin2.Models;

namespace Xamarin2
{
    public partial class List_Basic : ContentPage
    {
        public List_Basic()
        {
            InitializeComponent();
          

            ListView.ItemsSource = new List<Contact>
            {
                new Contact {Name = "Wilson", ImageUrl = "http://lorempixel.com/100/100/people/1"},
                new Contact {Name = "Ena", ImageUrl = "http://lorempixel.com/100/100/people/2", Status = "Let's Talk"},
                new Contact {Name = "Fei Mui~", ImageUrl = "http://lorempixel.com/100/100/people/3"}
            };

        }
    }
}
