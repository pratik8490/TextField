using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TextShield.Portable.Pages
{
    public class SetupCode : ContentPage
    {
        public SetupCode()
        {
            Button btn = new Button();
            btn.Text = "SetUpCode";
            btn.Clicked += (sender, e) =>
                {
                    //Navigation.PushModalAsync(App.HomePage());
                };

            this.Content = new StackLayout
            {
                Children = { btn },
            };
        }
    }
}
