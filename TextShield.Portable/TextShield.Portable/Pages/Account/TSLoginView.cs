using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextShield.Portable.Common;
using TextShield.Portable.Interface;
using Xamarin.Forms;

namespace TextShield.Portable.Pages
{
    public class Login : ContentPage
    {
        Entry txtUserName, txtPassword;
        Button btnLogin;
        Label lblForgot;
        ActivityIndicator _loadingIndicator;

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="Login Page"/> class.
        /// </summary>
        public Login()
        {
            LoginLayout();

            btnLogin.Clicked += LoginOnClick;

        }
        #endregion

        #region Override Methods
        protected override bool OnBackButtonPressed()
        {
            //if (DocMatrixContext.IsLogin)
            return base.OnBackButtonPressed();
            //else
            //    return true;

        }
        protected override void OnAppearing()
        {
            txtUserName.Focus();

            try
            {
                NavigationPage.SetHasNavigationBar(this, false);

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

        #region LoginLayout
        /// <summary>
        /// Login page Layout.
        /// </summary>
        private void LoginLayout()
        {
            txtPassword = new Entry();
            txtPassword.IsPassword = true;

            txtUserName = new Entry();
            txtUserName.Text = string.Empty;
            txtUserName.BackgroundColor = Color.White;
            txtUserName.TextColor = Color.Black;
            txtUserName.Placeholder = "Username";

            txtPassword.Text = string.Empty;
            txtPassword.BackgroundColor = Color.White;
            txtPassword.TextColor = Color.Black;
            txtPassword.Placeholder = "Password";


            var imageLogo = new Image { Source = "appstoreicon.png", WidthRequest = 300 };
            var cvTxtUserName = new ContentView
            {
                Padding = new Thickness(10, 10, 10, 5),
                Content = txtUserName
            };
            var cvTxtPassword = new ContentView
            {
                Padding = new Thickness(10, 5, 10, 10),
                Content = txtPassword
            };

            btnLogin = new Button();
            btnLogin.Text = "Login";
            btnLogin.TextColor = Color.White;
            btnLogin.BackgroundColor = LayoutHelper.ButtonColor;
            btnLogin.Clicked += LoginOnClick;

            var cvBtnLogin = new ContentView
            {
                Padding = new Thickness(10, 5, 10, 10),
                Content = btnLogin
            };

            Label lblForgot = new Label
            {
                Text = "Forgot Password?",
                TextColor = LayoutHelper.LinkColor,
                BackgroundColor = Color.Transparent,
                FontSize = 16,
                HeightRequest = 36,
                HorizontalOptions = LayoutOptions.End,
            };

            ContentView cvLblForgetPassword = new ContentView
            {
                Padding = new Thickness(8, 5, 8, 0),
                Content = lblForgot
            };


            Label lblCopyrights = new Label
            {
                Text = "Copyright © 2015. All rights reserved.",
                TextColor = Color.White,
                BackgroundColor = Color.Black,
                Font = Font.SystemFontOfSize(14),
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.Center,
                //HeightRequest = 35,

            };

            var barLower = new StackLayout
            {
                BackgroundColor = Color.Black,
                Spacing = 0,
                Padding = new Thickness(0, 0, 0, 0),
                VerticalOptions = LayoutOptions.EndAndExpand,
                HorizontalOptions = LayoutOptions.Fill,
                Children =
                {
                    lblCopyrights,
                },

            };

            _loadingIndicator = new ActivityIndicator();
            // loader = new ActivityIndicator()

            StackLayout loginLayout = new StackLayout
            {
                Children = {
                    imageLogo,
                    cvTxtUserName,
                    cvTxtPassword ,
                    cvBtnLogin,
                    cvLblForgetPassword,
                    _loadingIndicator,
                    barLower,
                    
                },
                BackgroundColor = Color.White,
            };

            loginLayout.Padding = LayoutHelper.IOSPadding(0, 20, 0, 0);

            ScrollView scrollCartNewLayout = new ScrollView
            {
                Content = loginLayout
            };

            Content = scrollCartNewLayout;
        }

        #endregion

        private void LoginOnClick(object sender, EventArgs eventArgs)
        {
            //if (string.IsNullOrEmpty(txtUserName.Text))
            //{
            //    DisplayAlert(string.Empty, Messages.Login.UsernameRquired, Messages.Ok);
            //}

            //else if (string.IsNullOrEmpty(txtPassword.Text))
            //{
            //    DisplayAlert(string.Empty, Messages.Login.PasswordRequired, Messages.Ok);
            //}

            //else if (!string.IsNullOrEmpty(txtUserName.Text) && !string.IsNullOrEmpty(txtPassword.Text))
            //{
            try
            {

                Device.BeginInvokeOnMainThread(async () =>
                {
                    _loadingIndicator.IsVisible = true;
                    _loadingIndicator.IsRunning = true;
                    btnLogin.IsVisible = false;

                    Navigation.PushModalAsync(App.HomePage());

                });

            }
            catch (Exception ex)
            {

            }
            //}
            //else
            //{
            //    indicator.IsVisible = false;
            //    indicator.IsRunning = false;
            //    btnLogin.IsVisible = true;

            //    DisplayAlert(string.Empty, Messages.Login.UsernamePasswordRequired, Messages.Ok);
            //}
        }
    }
}
