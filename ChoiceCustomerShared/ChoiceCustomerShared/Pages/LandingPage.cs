using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace ChoiceCustomerShared.Pages
{
    public class LandingPage : MasterDetailPage
    {
        public LandingPage()
        {
            this.Master = new ContentPage { BackgroundColor = Color.Red, Title = "My Master" };
            this.Detail = new NavigationPage(new ContentPage { BackgroundColor = Color.Blue, Title = "My Detail" });
        }
    }
}
