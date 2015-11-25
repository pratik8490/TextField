using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TextShield.Portable.Pages;
using Xamarin.Forms;

namespace TextShield.Portable
{
    public class App : Application
    {
        static NavigationPage navPage;

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="App"/> class.
        /// </summary>
        public App()
        {
            MainPage = new Login();
        }
        #endregion

        public static Page HomePage()
        {
            navPage = new NavigationPage(new MasterPage(new CommonPage()));
            navPage.BarBackgroundColor = Color.FromHex("#428BCA");
            navPage.BarTextColor = Color.White;
            return navPage;
        }

        public static Page AcountBasicPage()
        {
            return new MasterPage(new AccountBasic());
        }

        public static Page SetUpCodePage()
        {
            return new MasterPage(new SetupCode());
        }
    }
}
