using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextShield.Portable.Interface;
using TextShield.Portable.Models;
using Xamarin.Forms;

namespace TextShield.Portable.Pages
{
    public class MasterPage : MasterDetailPage
    {
        MenuPage menuPage;

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="Master Page"/> class.
        /// </summary>
        public MasterPage(ContentPage detailPage)
        {
            MasterLayout(detailPage);
        }
        #endregion

        #region MasterLayout
        /// <summary>
        /// Master page Layout.
        /// </summary>
        private void MasterLayout(ContentPage detailPage)
        {
            try
            {
                this.Master = new MenuPage { Icon = "left_menu.png" };
                this.Detail = detailPage;
            }
            catch (Exception ex)
            {

            }
        }
        #endregion

        #region Override Method
        protected override void OnAppearing()
        {
            base.OnAppearing();
            ToolbarItems.Clear();

            try
            {
                bool isNetworkAvailable = DependencyService.Get<INetworkOperation>().IsInternetConnectionAvailable();

                if (!isNetworkAvailable)
                {
                    DisplayAlert("Connection", "Please check your internet connection.", "Ok");
                }
            }
            catch (Exception ex)
            {
            }
        }
        protected override void OnDisappearing()
        {
            GC.Collect();
        }
        #endregion
    }
}
