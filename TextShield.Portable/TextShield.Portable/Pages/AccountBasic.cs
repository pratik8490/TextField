using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TextShield.Portable.Pages
{
    public class AccountBasic : BasePage
    {
        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="Menu Page"/> class.
        /// </summary>
        public AccountBasic()
        {
            AccountBasicLayout();
        }
        #endregion

        #region Account Basic Layout
        /// <summary>
        /// Account Basic Layout.
        /// </summary>
        public void AccountBasicLayout()
        {
            BoxView bvDGA = new BoxView { HeightRequest = 1, HorizontalOptions = LayoutOptions.FillAndExpand, BackgroundColor = Color.Black };

            BoxView bvPA = new BoxView { HeightRequest = 1, HorizontalOptions = LayoutOptions.FillAndExpand, BackgroundColor = Color.Black };

            BoxView bvPD = new BoxView { HeightRequest = 1, HorizontalOptions = LayoutOptions.FillAndExpand, BackgroundColor = Color.Black };

            BoxView bvDN = new BoxView { HeightRequest = 1, HorizontalOptions = LayoutOptions.FillAndExpand, BackgroundColor = Color.Black };

            BoxView bvState = new BoxView { HeightRequest = 1, HorizontalOptions = LayoutOptions.FillAndExpand, BackgroundColor = Color.Black };

            BoxView bvPostalCode = new BoxView { HeightRequest = 1, HorizontalOptions = LayoutOptions.FillAndExpand, BackgroundColor = Color.Black };

            Label lblDGA = new Label { Text = "Dealer Group Association", TextColor = Color.Black };

            Label lblPA = new Label { Text = "Partner Association", TextColor = Color.Black };

            Label lblPD = new Label { Text = "Parent Designation", TextColor = Color.Black };

            Label lblDN = new Label { Text = "Dealership Name", TextColor = Color.Black };

            Label lblSA = new Label { Text = "Street Address", TextColor = Color.Black };

            Label lblCity = new Label { Text = "City", TextColor = Color.Black };

            Label lblState = new Label { Text = "State", TextColor = Color.Black };

            Label lblPostalCode = new Label { Text = "Postal Code", TextColor = Color.Black };

            Label lblblue1 = new Label { Text = "McPherson Ford", TextColor = Color.Blue };

            Label lblblue2 = new Label { Text = "McPherson Ford", TextColor = Color.Blue };

            Label lblblue3 = new Label { Text = "McPherson Ford", TextColor = Color.Blue };

            Label lblblue4 = new Label { Text = "Alabama", TextColor = Color.Blue };

            Entry txtDN = new Entry { TextColor = Color.Black, BackgroundColor = Color.FromHex("#d3d3d3") };

            Entry txtAddress1 = new Entry { TextColor = Color.Black, BackgroundColor = Color.FromHex("#d3d3d3") };

            Entry txtAddress2 = new Entry { TextColor = Color.Black, BackgroundColor = Color.FromHex("#d3d3d3") };

            Entry txtCity = new Entry { TextColor = Color.Black, BackgroundColor = Color.FromHex("#d3d3d3") };

            Entry txtPostalCode = new Entry { TextColor = Color.Black, BackgroundColor = Color.FromHex("#d3d3d3") };

            StackLayout slTest = new StackLayout { Children = { bvDGA, lblDGA, lblblue1, bvPA, lblPA, lblblue2, bvPD, lblPD, lblblue3, bvDN, lblDN, txtDN, lblSA, txtAddress1, txtAddress2, lblCity, txtCity, lblState, lblblue4, bvPostalCode, lblPostalCode, txtPostalCode, bvPostalCode }, Padding = new Thickness(10, 10, 10, 10), BackgroundColor = Color.White };

            Content = new ScrollView
            {
                Content = slTest
            };
        }
        #endregion
    }
}
